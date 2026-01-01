using System.Text.RegularExpressions;
using CalamityRuTranslate.Common.Utilities;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace CalamityRuTranslate.Mods.Vanilla;

public class DynamicArgumentProcessor : ModSystem
{
    private readonly Regex _argumentRegex = new(@"\{\$([\w\.]+)\(([^}]*)\)\}", RegexOptions.Compiled);

    public override bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }
    
    public override void OnLocalizationsLoaded()
    {
        ItemTooltip.AddGlobalProcessor(ProcessArguments);
    }

    public override void OnModUnload()
    {
        ItemTooltip.RemoveGlobalProcessor(ProcessArguments);
    }
    
    private string ProcessArguments(string inputText)
    {
        if (!inputText.Contains("(") || !inputText.Contains(")"))
            return inputText;

        string newText = _argumentRegex.Replace(inputText, match =>
        {
            string targetKey = match.Groups[1].Value;
            string argsRaw = match.Groups[2].Value;

            if (Language.Exists(targetKey))
            {
                string targetValue = Language.GetTextValue(targetKey);
                object[] args = ParseArguments(argsRaw);
                
                return string.Format(targetValue, args);
            }

            return match.Value; 
        });
        
        return newText;
    }
    
    private object[] ParseArguments(string argsRaw)
    {
        if (string.IsNullOrWhiteSpace(argsRaw))
            return [];

        string[] parts = argsRaw.Split(',');
        object[] args = new object[parts.Length];

        for (int i = 0; i < parts.Length; i++)
        {
            string value = parts[i].Trim();

            if (int.TryParse(value, out int intVal))
                args[i] = intVal;
            else if (float.TryParse(value, out float floatVal))
                args[i] = floatVal;
            else
                args[i] = value;
        }

        return args;
    }
}