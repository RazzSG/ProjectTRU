using System.Collections.Generic;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameInput;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Core.ArmorSetBonusPreview;

public class ArmorSetBonusPreviewGlobalItem : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }
    
    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        if (!TRuConfig.Instance.ArmorSetBonusPreview || !ArmorSetBonusPreviewSystem.ArmorSetBonuses.TryGetValue(item.type, out string setBonus))
            return;

        List<string> keys = PlayerInput.CurrentProfile.InputModes[InputMode.Keyboard].KeyStatus[TriggerNames.SmartSelect];
        string key = keys.Count > 0 ? keys[0] : null;
        bool showDesc = key == null || PlayerInput.Triggers.Current.SmartSelect;
        int index = tooltips.FindLastIndex(x => x.Text == Language.GetTextValue("CommonItemTooltip.WizardHatDuringAnniversary") || (x.Mod.Equals("Terraria") && x.Name.StartsWith("Tooltip")));

        TooltipLine tooltipLine = new TooltipLine(Mod, "ForMoreInfo", $"Зажмите клавишу ({key}) без автоматической паузы для предосмотра бонуса комплекта")
        {
            OverrideColor = Color.Gray
        };

        if (!showDesc && !item.wornArmor)
        {
            if (index != -1)
                tooltips.Insert(++index, tooltipLine);
            else
                tooltips.Add(tooltipLine);
        }
        else if (showDesc && !item.wornArmor)
        {
            tooltips.Add(new TooltipLine(Mod, "ArmorSetBonusInfo", setBonus)
            {
                OverrideColor = Color.Gray
            });
        }
    }
}