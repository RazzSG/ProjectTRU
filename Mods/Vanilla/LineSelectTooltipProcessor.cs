using System.Text.RegularExpressions;
using CalamityRuTranslate.Common.Utilities;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace CalamityRuTranslate.Mods.Vanilla;

public class LineSelectTooltipProcessor : ModSystem
{
    private readonly Regex _regex = new(@"\{\$([\w\.]+)::(\d+)\}", RegexOptions.Compiled);
    
    public override bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }
    
    public override void OnLocalizationsLoaded()
    {
        ItemTooltip.AddGlobalProcessor(ProcessTooltipReferences);
    }

    public override void OnModUnload()
    {
        ItemTooltip.RemoveGlobalProcessor(ProcessTooltipReferences);
    }
    
    private string ProcessTooltipReferences(string inputText)
    {
        if (!inputText.Contains("::"))
            return inputText;

        string newText = _regex.Replace(inputText, match =>
        {
            string targetKey = match.Groups[1].Value;
            int lineIndex = int.Parse(match.Groups[2].Value);

            if (Language.Exists(targetKey))
            {
                string targetValue = Language.GetTextValue(targetKey);
                string[] lines = targetValue.Split('\n');

                if (lineIndex >= 0 && lineIndex < lines.Length)
                {
                    return lines[lineIndex].Trim();
                }
            }

            return match.Value; 
        });

        return newText;
    }
}