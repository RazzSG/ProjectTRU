using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;

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
            value = LocalizedText.ApplyPluralization(value, args);
        
        try {
            return string.Format(value, args);
        }
        catch (FormatException e) {
            throw new Exception($"The localization key:\n  \"{self.Key}\"\nwith a value of:\n  \"{value}\"\nfailed to be formatted with the inputs:\n  [{string.Join(", ", args)}]", e);
        }
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