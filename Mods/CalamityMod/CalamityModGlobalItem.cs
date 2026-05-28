using System.Collections.Generic;
using CalamityMod.Items;
using CalamityMod.Items.Accessories;
using CalamityMod.Items.Armor.GemTech;
using CalamityMod.Items.SummonItems;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using Terraria;
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
        
        if (calamityGlobalItem.donorItem)
        {
            if (item.type == ModContent.ItemType<GemTechHeadgear>() ||
                item.type == ModContent.ItemType<GemTechBodyArmor>() ||
                item.type == ModContent.ItemType<GemTechSchynbaulds>())
            {
                int donorIndex = tooltips.FindIndex(x => x.Name == "CalamityMod:DonorItem");
                
                if (donorIndex != -1)
                {
                    TooltipLine donorLine = tooltips[donorIndex];
                    tooltips.RemoveAt(donorIndex);
                    
                    int lastSetBonusIndex = tooltips.FindLastIndex(x => x.Name.Contains("SetBonus") || x.Name == "CalamityMod:HoldShiftExtensionIndicator");
                    
                    if (lastSetBonusIndex != -1)
                        tooltips.Insert(++lastSetBonusIndex, donorLine);
                    else
                        tooltips.Add(donorLine);
                }
            }
        }
        
        if (item.type == ModContent.ItemType<ScionsCurio>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip4", _ =>
            {
                tooltips.ReplaceText("DPS", "ед. урона в секунду");
            });
        }
        
        int kbIndex = tooltips.FindIndex(x => x.FullName == "Terraria/Knockback");
        string[] tagsToMove = ["CalamityMod:FlatSummonTag", "CalamityMod:MultiplicativeSummonTag", "CalamityMod:CritSummonTag"];

        if (item.DamageType == DamageClass.Summon || item.DamageType == DamageClass.SummonMeleeSpeed)
        {
            foreach (string tagName in tagsToMove)
            {
                int currentIndex = tooltips.FindIndex(x => x.Name == tagName);
                if (currentIndex != -1)
                {
                    TooltipLine line = tooltips[currentIndex];
                    tooltips.RemoveAt(currentIndex);
                    tooltips.Insert(++kbIndex, line);
                }
            }
        }
    }
}
