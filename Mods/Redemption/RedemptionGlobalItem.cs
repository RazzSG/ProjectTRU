using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using Redemption.Items.Accessories.HM;
using Redemption.Items.Armor.Vanity.SkySquire;
using Redemption.Items.Placeable.Furniture.Misc;
using Redemption.Items.Weapons.HM.Melee;
using Redemption.Items.Weapons.PostML.Magic;
using Redemption.Items.Weapons.PreHM.Ammo;
using Redemption.Items.Weapons.PreHM.Melee;
using Redemption.Items.Weapons.PreHM.Ranged;
using Redemption.Items.Weapons.PreHM.Summon;
using Redemption.Rarities;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Redemption;

public partial class RedemptionGlobalItem : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage && TRuConfig.Instance.RedemptionLocalization && ModInstances.Redemption != null;
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        ModifyDamageTypes(item, tooltips);
        
        if (item.type == ModContent.ItemType<GeigerMuller>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Geiger1", _ =>
            {
                tooltips.ReplaceText("No doses of radiation detected on self, nothing to note.", "На вас не обнаружено радиации. Всё в норме");
                tooltips.ReplaceText("Low doses of radiation detected on self, nothing to note.", "Обнаружена низкая доза радиации. Всё в норме");
                tooltips.ReplaceText("Medium doses of radiation detected on self, have TeoChrome-issued pills on hand just in case.", "Обнаружена средняя доза радиации. Держите при себе таблетки, разработанные ТеоХромом, на всякий случай");
                tooltips.ReplaceText("High doses of radiation detected on self, have TeoChrome-issued pills on hand just in case.", "Обнаружена высокая доза радиации. Держите при себе таблетки, разработанные ТеоХромом, на всякий случай");
                tooltips.ReplaceText("Very high doses of radiation detected on self, high chance of irradiation and suffering ARS.", "Обнаружена очень высокая доза радиации. Высокий риск облучения и развития ОЛБ");
                tooltips.ReplaceText("Extreme doses of radiation detected on self, Acute Radiation Syndrome detected.", "Обнаружена экстремальная доза радиации. Диагностирована ОЛБ");
            });
            
            ItemHelper.TranslateTooltip(tooltips, "Geiger2", tooltip =>
            {
                tooltip.Text = $"Уровень облучения {tooltip.Text.Split(' ')[0]}";
            });
        }

        if (item.type == ModContent.ItemType<SkySquiresHelm>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Lore", tooltip =>
            {
                tooltip.Text = "'Шлем-салад, выкованный из канита, который носят Небесные оруженосцы Итона\nЭтот металл имеет синеватый оттенок и холодный на ощупь, служит достойной заменой железу, столь редкому в южном Итоне\nНебесные оруженосцы - это подразделение южного Итона, под чьей защитой пребывают королевства Ильн, Кликуб и Норапасс\nИх доспехи отличаются повышенной гибкостью, что позволяет им быстро выдвигаться на помощь'";
            });
        }
        
        if (item.type == ModContent.ItemType<SkySquiresGreaves>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Lore", tooltip =>
            {
                tooltip.Text = "'Поножи, выкованные из канита, которые носят Небесные оруженосцы Итона\nЭтот металл имеет синеватый оттенок и холодный на ощупь, служит достойной заменой железу, столь редкому в южном Итоне\nНебесные оруженосцы - это подразделение южного Итона, под чьей защитой пребывают королевства Ильн, Кликуб и Норапасс\nИх доспехи отличаются повышенной гибкостью, что позволяет им быстро выдвигаться на помощь'";
            });
        }
        
        if (item.type == ModContent.ItemType<SkySquiresTabard>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Lore", tooltip =>
            {
                tooltip.Text = "'Табард, сотканный из канита и ткани в клетчатом узоре, который носят Небесные оруженосцы Итона\nЭтот металл имеет синеватый оттенок и холодный на ощупь, служит достойной заменой железу, столь редкому в южном Итоне\nНебесные оруженосцы - это подразделение южного Итона, под чьей защитой пребывают королевства Ильн, Кликуб и Норапасс\nИх доспехи отличаются повышенной гибкостью, что позволяет им быстро выдвигаться на помощь'";
            });
        }
        
        if (item.type == ModContent.ItemType<SunkenCaptainPainting>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Lore", tooltip =>
            {
                tooltip.Text = "'Некогда великий капитан, для некоторых ставший легендой, даже после смерти продолжал бороздить моря, ведя свою призрачную команду к неизведанным землям\nЛишь при ярчайшем свете луны могли они ступить на берег\nДо тех пор они были обречены вечно преследовать волны, а самый густой туман оставался их единственным спутником'";
            });
        }
        
        if (item.type == ModContent.ItemType<MoonflareArrow>() || item.type == ModContent.ItemType<LunarShot>() || item.type == ModContent.ItemType<MoonflareStaff>())
        {
            ItemHelper.TranslateTooltip(tooltips, "text", tooltip =>
            {
                tooltip.Text = "Отсутствует лунный свет для отражения...";
            });
        }
        
        if (item.type == ModContent.ItemType<ForestNymphsSickle>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Damage", _ =>
            {
                tooltips.ReplaceText("melee урона", "ед. урона ближнего боя");
                tooltips.ReplaceText("magic урона", "ед. магического урона");
            });
        }
        
        if (item.type == ModContent.ItemType<CruxCardAnglonSkeletons>())
        {
            ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
            {
                tooltip.Text = "120/92/144 ед. базового здоровья";
            });
            
            ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
            {
                tooltip.Text = "11/9/15 ед. защиты";
            });
        }
        
        if (item.type == ModContent.ItemType<CruxCardCalavia>())
        {
            ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
            {
                tooltip.Text = "3000 ед. базового здоровья";
            });
            
            ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
            {
                tooltip.Text = "17 ед. защиты";
            });
        }
        
        if (item.type == ModContent.ItemType<CruxCardForestNymph>())
        {
            ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
            {
                tooltip.Text = "500 ед. базового здоровья";
            });
            
            ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
            {
                tooltip.Text = "5 ед. защиты";
            });
        }
        
        if (item.type == ModContent.ItemType<CruxCardGathicSkeletons>())
        {
            ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
            {
                tooltip.Text = "116/124 ед. базового здоровья";
            });
            
            ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
            {
                tooltip.Text = "8 ед. защиты";
            });
        }
        
        if (item.type == ModContent.ItemType<CruxCardGladestone>())
        {
            ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
            {
                tooltip.Text = "250 ед. базового здоровья";
            });
            
            ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
            {
                tooltip.Text = "20 ед. защиты";
            });
        }
        
        if (item.type == ModContent.ItemType<CruxCardMossyGoliath>())
        {
            ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
            {
                tooltip.Text = "2000 ед. базового здоровья";
            });
            
            ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
            {
                tooltip.Text = "14 ед. защиты";
            });
        }
        
        if (item.type == ModContent.ItemType<CruxCardSkeleton>())
        {
            ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
            {
                tooltip.Text = "108 ед. базового здоровья";
            });
            
            ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
            {
                tooltip.Text = "7 ед. защиты";
            });
        }
        
        if (item.type == ModContent.ItemType<CruxCardSkeletonAssassin>())
        {
            ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
            {
                tooltip.Text = "116 ед. базового здоровья";
            });
            
            ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
            {
                tooltip.Text = "8 ед. защиты";
            });
        }
        
        if (item.type == ModContent.ItemType<CruxCardSkullDigger>())
        {
            ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
            {
                tooltip.Text = "2400 ед. базового здоровья";
            });
            
            ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
            {
                tooltip.Text = "0 ед. защиты";
            });
        }
        
        if (item.type == ModContent.ItemType<CruxCardTied>())
        {
            ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
            {
                tooltip.Text = "418 ед. базового здоровья";
            });
            
            ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
            {
                tooltip.Text = "10 ед. защиты";
            });
        }
        
        if (item.rare == ModContent.RarityType<DonatorRarity>())
        {
            ItemHelper.TranslateTooltip(tooltips, "DonatorLine", tooltip =>
            {
                tooltip.Text = "-Предмет покровителя-";
            });
        }
        
        if (item.type == ModContent.ItemType<HammerOfProving>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip1", _ =>
            {
                tooltips.ReplaceText("Школы святости", "святых");
            });
        }
        
        if (item.type == ModContent.ItemType<NoblesHalberd>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip0", _ =>
            {
                tooltips.ReplaceText("Колющий", "копьём");
            });
        }
        
        ItemHelper.TranslateTooltip(tooltips, "SpecialPrice", tooltip =>
        {
            if (tooltip.Text.Contains("antique doruls"))
            {
                string[] parts = tooltip.Text.Split(' ');
                string priceValue = parts[2];
                if (int.TryParse(priceValue, out int value))
                {
                    string valueSuffix = LocalizedText.ApplyPluralization("{^0:античный дорул;античных дорула;античных дорулав}", value);
                    tooltip.Text = tooltip.Text.Replace("antique doruls", valueSuffix);
                }
            }
        });
        
        ItemHelper.TranslateTooltip(tooltips, "RitLine", tooltip =>
        {
            tooltip.Text = "ВНИМАНИЕ: Этот класс находится в разработке";
        });
    }
}