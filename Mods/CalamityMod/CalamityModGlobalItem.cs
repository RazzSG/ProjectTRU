using System.Collections.Generic;
using CalamityMod;
using CalamityMod.Items;
using CalamityMod.Items.SummonItems;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod;

public partial class CalamityModGlobalItem : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.Calamity != null && TRuConfig.Instance.CalamityModLocalization && TranslationHelper.IsRussianLanguage;
    }
    
    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        VanillaItemsTranslation(item, tooltips);
        VanillaWingsTranslation(item, tooltips);
        ModifyDamageTypes(item, tooltips);
        
        if (item.type == ModContent.ItemType<SandstormsCore>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip0", _ =>
            {
                tooltips.ReplaceText("Пустыня", "пустыне");
                tooltips.ReplaceText("Астральная пустыня", "астральной пустыне");
            });
        }
        
        CalamityGlobalItem calamityGlobalItem = item.GetGlobalItem<CalamityGlobalItem>();
        
        if (calamityGlobalItem.canFirePointBlankShots)
        {
            int pointBlankShotIndex = tooltips.FindLastIndex(x => x.Mod.Equals("CalamityMod") && x.Name.Equals("PointBlankShot"));
            int tooltipIndex = tooltips.FindLastIndex(x => x.Mod.Equals("Terraria") && x.Name.StartsWith("Tooltip"));
            int knockbackIndex = tooltips.FindLastIndex(x => x.Mod.Equals("Terraria") && x.Name.StartsWith("Knockback"));
            if (pointBlankShotIndex != -1)
            {
                tooltips.RemoveAt(pointBlankShotIndex);
            }
            
            TooltipLine pointBlankShot = new TooltipLine(ModInstances.Calamity, "PointBlankShot", "Выстрелы в упор наносят дополнительный урон врагам");
            
            tooltips.Insert(tooltipIndex != -1 ? ++tooltipIndex : ++knockbackIndex, pointBlankShot);
        }
         
        ItemHelper.TranslateTooltip(tooltips, l => l.FullName == "CalamityMod/SchematicKnowledge1", tooltip =>
        {
            tooltip.Text = "У вас недостаточно знаний для создания этого предмета";
        });
         
        ItemHelper.TranslateTooltip(tooltips, l => l.FullName == "CalamityMod/SchematicKnowledge2", _ =>
        {
            tooltips.ReplaceText("A specific schematic must be deciphered first", "Сначала необходимо расшифровать конкретную схему");
            tooltips.ReplaceText("The Sunken Sea schematic must be deciphered first", "Сначала необходимо расшифровать схему затерянного моря");
            tooltips.ReplaceText("The Planetoid schematic must be deciphered first", "Сначала необходимо расшифровать схему планетоида");
            tooltips.ReplaceText("The Jungle schematic must be deciphered first", "Сначала необходимо расшифровать схему джунглей");
            tooltips.ReplaceText("The Underworld schematic must be deciphered first", "Сначала необходимо расшифровать схему преисподней");
            tooltips.ReplaceText("The Ice biome schematic must be deciphered first", "Сначала необходимо расшифровать схему льдов");
        });
        
        ItemHelper.TranslateTooltip(tooltips, l => l.FullName == "CalamityMod/CalamityCharge", _ =>
        {
            tooltips.ReplaceText("Current Charge", "Текущий заряд");
        });
         
        ItemHelper.TranslateTooltip(tooltips, l => l.FullName == "CalamityMod/CalamityDonor", _ =>
        {
            tooltips.ReplaceText("Donor Item", "Предмет покровителя");
        });
         
        ItemHelper.TranslateTooltip(tooltips, l => l.FullName == "CalamityMod/CalamityDev", _ =>
        {
            tooltips.ReplaceText("Developer Item", "Предмет разработчика");
        });
         
        if (item.type is ItemID.AncientBattleArmorHat or ItemID.AncientBattleArmorShirt or ItemID.AncientBattleArmorPants && !Main.player[Main.myPlayer].Calamity().forbiddenCirclet)
        {
            ItemHelper.TranslateTooltip(tooltips, "SetBonus", _ =>
            {
                tooltips.ReplaceText("Minions no longer deal less damage while wielding magic weapons", "Миньоны больше не наносят сниженный урон, пока вы держите магическое оружие");
            });
        }
    }
}
