using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas;

public class FargowiltasGlobalItem : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "Fargowiltas" && l.Name == "TooltipSquirrel", _ =>
        {
            tooltips.ReplaceText("Sold By Squirrel", "Продаётся белкой");
            tooltips.ReplaceText("Some Materials Sold", "Продаются некоторые материалы");
            tooltips.ReplaceText("Craftable Materials Sold", "Продаются материалы для изготовления");
            tooltips.ReplaceText("Sold At Thirty Stack", "Продаётся от тридцати штук");
            tooltips.ReplaceText("None", "Нет");
        });
        
        ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "Fargowiltas" && l.Name == "TooltipNPCSold", _ =>
        {
            tooltips.ReplaceText("Finish 5 angler quests", "Завершить 5 заданий рыбака");
            tooltips.ReplaceText("Finish 10 angler quests", "Завершить 10 заданий рыбака");
            tooltips.ReplaceText("Finish 15 angler quests", "Завершить 15 заданий рыбака");
            tooltips.ReplaceText("Finish 25 angler quests", "Завершить 25 заданий рыбака");
            tooltips.ReplaceText("Finish 30 angler quests", "Завершить 30 заданий рыбака");
            tooltips.ReplaceText("While underground", "Находясь под землёй");
            tooltips.ReplaceText("Have a weapon that uses Brittle Bones as ammunition in your inventory", "В вашем инвентаре есть оружие, которое использует хрупкие кости в качестве боеприпасов");
            tooltips.ReplaceText("Have a weapon that uses seeds as ammunition in your inventory", "В вашем инвентаре есть оружие, которое использует семена в качестве боеприпасов");
            tooltips.ReplaceText("After having picked up a Red Husk", "После того, как вы подобрали красный хитин");
            tooltips.ReplaceText("After having picked up an Orange Bloodroot", "После того, как вы подобрали лранжевую лапчатку");
            tooltips.ReplaceText("After having picked up a Yellow Marigold", "После того, как вы подобрали жёлтый бархатец");
            tooltips.ReplaceText("After having picked up a Lime Kelp", "После того, как вы подобрали лаймовую ламинарию");
            tooltips.ReplaceText("After having picked up a Green Mushroom", "После того, как вы подобрали зелёный гриб");
            tooltips.ReplaceText("After having picked up a Teal Mushroom", "После того, как вы подобрали бирюзовый гриб");
            tooltips.ReplaceText("After having picked up a Cyan Husk", "После того, как вы подобрали циановый хитин");
            tooltips.ReplaceText("After having picked up a Sky Blue Flower", "После того, как вы подобрали голубой цветок");
            tooltips.ReplaceText("After having picked up Blueberries", "После того, как вы подобрали синие ягоды");
            tooltips.ReplaceText("After having picked up Purple Mucos", "После того, как вы подобрали пурпурную слизь");
            tooltips.ReplaceText("After having picked up a Violet Husk", "После того, как вы подобрали фиолетовый хитин");
            tooltips.ReplaceText("After having picked up a Pink Prickly Pear", "После того, как вы подобрали розовую опунцию");
            tooltips.ReplaceText("After having picked up Black Ink", "После того, как вы подобрали чернила");
        });

        if (item.type == ItemID.PureWaterFountain)
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "Fargowiltas" && l.Name == "Tooltip0", tooltip =>
            {
                tooltip.Text = "[i:909] [c/AAAAAA:Ваше окружение меняется на океан при активации]";
            });
        }

        if (item.type is ItemID.OasisFountain or ItemID.DesertWaterFountain)
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "Fargowiltas" && l.Name == "Tooltip0", tooltip =>
            {
                tooltip.Text = "[i:909] [c/AAAAAA:Ваше окружение меняется на пустыню при активации]";
            });
        }

        if (item.type == ItemID.JungleWaterFountain)
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "Fargowiltas" && l.Name == "Tooltip0", tooltip =>
            {
                tooltip.Text = "[i:909] [c/AAAAAA:Ваше окружение меняется на джунгли при активации]";
            });
        }
        
        if (item.type == ItemID.IcyWaterFountain)
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "Fargowiltas" && l.Name == "Tooltip0", tooltip =>
            {
                tooltip.Text = "[i:909] [c/AAAAAA:Ваше окружение меняется на снега при активации]";
            });
        }
        
        if (item.type == ItemID.CorruptWaterFountain)
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "Fargowiltas" && l.Name == "Tooltip0", tooltip =>
            {
                tooltip.Text = "[i:909] [c/AAAAAA:Ваше окружение меняется на искажение при активации]";
            });
        }
        
        if (item.type == ItemID.CrimsonWaterFountain)
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "Fargowiltas" && l.Name == "Tooltip0", tooltip =>
            {
                tooltip.Text = "[i:909] [c/AAAAAA:Ваше окружение меняется на багрянец при активации]";
            });
        }
        
        if (item.type == ItemID.HallowedWaterFountain)
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "Fargowiltas" && l.Name == "Tooltip0", tooltip =>
            {
                tooltip.Text = "[i:909] [c/AAAAAA:Ваше окружение меняется на осящение (только в хардмоде) при активации]";
            });
        }
    }
}