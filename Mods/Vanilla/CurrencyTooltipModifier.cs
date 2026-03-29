using System.Collections.Generic;
using System.Text.RegularExpressions;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Vanilla;

public class CurrencyTooltipModifier : GlobalItem
{
    private static readonly Regex CurrencyRegex = new(@"(\d+)\s*(платин\.|зол\.|сереб\.|медн\.)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
    
    public override bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        ItemHelper.TranslateTooltip(tooltips, l => l.FullName == "Terraria/Price", tooltip =>
        {
            int lastValue = 0;
            
            string newText = CurrencyRegex.Replace(tooltip.Text, m =>
            {
                int value = int.Parse(m.Groups[1].Value);
                string suffix = m.Groups[2].Value.ToLower();
                lastValue = value;

                string replacement = suffix switch
                {
                    "платин." => "{^0:платиновая;платиновые;платиновых}",
                    "зол." => "{^0:золотая;золотые;золотых}",
                    "сереб." => "{^0:серебряная;серебряные;серебряных}",
                    "медн." => "{^0:медная;медные;медных}",
                    _ => suffix
                };

                return LocalizedText.ApplyPluralization(replacement, value);
            });
            
            if (lastValue > 0)
            {
                string coinSuffix = LocalizedText.ApplyPluralization(" {^0:монета;монеты;монет}", lastValue);
                tooltip.Text = newText.TrimEnd('.') + coinSuffix;
            }
        });
    }
}