using System.Collections.Generic;
using System.Text.RegularExpressions;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Vanilla;

public class CurrencyTooltipModifier : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "Terraria" && l.Name == "Price", tooltip =>
        {
            Regex currencyRegex = new Regex(@"(\d+)\s*(платин\.|зол\.|сереб\.|медн\.)");
            MatchCollection matches = currencyRegex.Matches(tooltip.Text);
            
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            
            foreach (Match match in matches)
            {
                int value = int.Parse(match.Groups[1].Value);
                string currency = match.Groups[2].Value;

                switch (currency)
                {
                    case "платин.":
                        num = value;
                        break;
                    case "зол.":
                        num2 = value;
                        break;
                    case "сереб.":
                        num3 = value;
                        break;
                    case "медн.":
                        num4 = value;
                        break;
                }
            }
            
            string text = tooltip.Text;
            string coinText = "";
            
            if (num > 0)
            {
                text = text.Replace("платин.", LocalizedText.ApplyPluralization("{^0:платиновая;платиновые;платиновых}", num));
                coinText = LocalizedText.ApplyPluralization(" {^0:монета;монеты;монет}", num);
            }
            
            if (num2 > 0)
            {
                text = text.Replace("зол.", LocalizedText.ApplyPluralization("{^0:золотая;золотые;золотых}", num2));
                coinText = LocalizedText.ApplyPluralization(" {^0:монета;монеты;монет}", num2);
            }
            
            if (num3 > 0)
            {
                text = text.Replace("сереб.", LocalizedText.ApplyPluralization("{^0:серебряная;серебряные;серебряных}", num3));
                coinText = LocalizedText.ApplyPluralization(" {^0:монета;монеты;монет}", num3);
            }
            
            if (num4 > 0)
            {
                text = text.Replace("медн.", LocalizedText.ApplyPluralization("{^0:медная;медные;медных}", num4));
                coinText = LocalizedText.ApplyPluralization(" {^0:монета;монеты;монет}", num4);
            }

            if (num > 0 || num2 > 0 || num3 > 0 || num4 > 0)
                tooltip.Text = text.Substring(0, text.Length - 1) + coinText;
        });
    }
}