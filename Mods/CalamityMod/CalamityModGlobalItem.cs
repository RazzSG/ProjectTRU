using System.Collections.Generic;
using CalamityMod;
using CalamityMod.Items.SummonItems;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod;

public partial class CalamityModGlobalItem : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.Calamity != null && TranslationHelper.IsRussianLanguage;
    }

    public override void SetDefaults(Item item)
    {
        if (item.ModItem?.Mod == ModInstances.Calamity)
        {
            //item.ClearNameOverride();
        }
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
                tooltips.ReplaceText("Пустыня", "Пустыне");
                tooltips.ReplaceText("Астральная пустыня", "Астральной пустыне");
            });
        }
        global::CalamityMod.Items.CalamityGlobalItem calamityGlobalItem = item.GetGlobalItem<global::CalamityMod.Items.CalamityGlobalItem>();
        
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
            
            if (tooltipIndex != -1)
            {
                tooltips.Insert(++tooltipIndex, pointBlankShot);
            }
            else
            {
                tooltips.Insert(++knockbackIndex, pointBlankShot);
            }
        }
         
        ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "CalamityMod" && l.Name == "SchematicKnowledge1", tooltip =>
        {
            tooltip.Text = "У вас недостаточно знаний для создания этого предмета";
        });
         
        ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "CalamityMod" && l.Name == "SchematicKnowledge2", _ =>
        {
            tooltips.ReplaceText("A specific schematic must be deciphered first","Сначала необходимо расшифровать конкретную схему");
            tooltips.ReplaceText("The Sunken Sea schematic must be deciphered first","Сначала необходимо расшифровать схему затерянного моря");
            tooltips.ReplaceText("The Planetoid schematic must be deciphered first","Сначала необходимо расшифровать схему планетоида");
            tooltips.ReplaceText("The Jungle schematic must be deciphered first","Сначала необходимо расшифровать схему джунглей");
            tooltips.ReplaceText("The Underworld schematic must be deciphered first","Сначала необходимо расшифровать схему преисподней");
            tooltips.ReplaceText("The Ice biome schematic must be deciphered first", "Сначала необходимо расшифровать схему льдов");
        });
        
        ItemHelper.TranslateTooltip(tooltips, "CalamityCharge", tooltip =>
        {
            tooltip.Text = $"Текущий заряд: {tooltip.Text.Split(' ')[2]}";
        });
         
        ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "CalamityMod" && l.Name == "CalamityDonor", tooltip =>
        {
            tooltip.Text = "- Предмет покровителя -";
            tooltip.OverrideColor = new Color(196, 35, 44);
        });
         
        ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "CalamityMod" && l.Name == "CalamityDev", tooltip =>
        {
            tooltip.Text = "- Предмет разработчика -";
            tooltip.OverrideColor = new Color(255, 0, 255);
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
