using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;

[EarlyPatcher]
public class LocalizedTextPatch : OnPatcher
{
    private readonly Regex _replacePatternRegex = new(@"{r(\d+):([^\r\n]+?)}", RegexOptions.Compiled);
    private readonly Regex _argPatternRegex = new (@"{(\d+)}", RegexOptions.Compiled);
    
    public override bool AutoLoad => TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(LocalizedText).FindMethod(nameof(LocalizedText.Format));

    public override Delegate Delegate => Translation;

    private string Translation(Func<LocalizedText, object[], string> orig, LocalizedText self, params object[] args)
    {
        string value = self.Value;
    
        if (_replacePatternRegex.IsMatch(value))
            value = ApplyReplaceValue(value, args);
        
        if (LocalizedText.PluralizationPatternRegex.IsMatch(value))
            value = LocalizedText.ApplyPluralization(value, NormalizePluralizationArgs(value, args));
        
        try {
            return string.Format(value, args);
        }
        catch (FormatException e) {
            throw new Exception($"The localization key:\n  \"{self.Key}\"\nwith a value of:\n  \"{value}\"\nfailed to be formatted with the inputs:\n  [{string.Join(", ", args)}]", e);
        }
    }
    
    
    private static object[] NormalizePluralizationArgs(string value, object[] args)
    {
        object[] normalizedArgs = null;
        CultureInfo culture = Language.ActiveCulture.CultureInfo;

        foreach (Match match in LocalizedText.PluralizationPatternRegex.Matches(value))
        {
            if (!int.TryParse(match.Groups[1].Value, out int index) || (uint)index >= (uint)args.Length || args[index] is not string text || int.TryParse(text, NumberStyles.Integer, culture, out _))
                continue;

            NumberStyles decimalStyles = NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint;

            if (!decimal.TryParse(text, decimalStyles, culture, out decimal number))
                continue;

            decimal rounded = Math.Round(number, MidpointRounding.ToEven);
            if (rounded is < int.MinValue or > int.MaxValue)
                continue;

            (normalizedArgs ??= (object[])args.Clone())[index] = (int)rounded;
        }

        return normalizedArgs ?? args;
    }

    private string ApplyReplaceValue(string value, params object[] args)
    {
        HashSet<int> replacedIndices = [];
        
        string result = _replacePatternRegex.Replace(value, match =>
        {
            int argIndex = int.Parse(match.Groups[1].Value);
            replacedIndices.Add(argIndex);
 
            string inputValue = args[argIndex].ToString();
            string[] replacements = match.Groups[2].Value.Split(';');
            
            foreach (string replacement in replacements)
            {
                string[] pair = replacement.Split('=', 2);
                if (pair.Length == 2 && inputValue != null && inputValue.Contains(pair[0])) 
                    return inputValue.Replace(pair[0], pair[1]); 
            }

            return inputValue;
        });
        
        result = _argPatternRegex.Replace(result, match =>
        {
            int argIndex = int.Parse(match.Groups[1].Value);
            return replacedIndices.Contains(argIndex) ? "" : args[argIndex].ToString();
        });

        return result;
    }
}