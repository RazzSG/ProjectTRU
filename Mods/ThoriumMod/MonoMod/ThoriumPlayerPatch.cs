using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Microsoft.Xna.Framework;
using ReLogic.OS;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using ThoriumMod;

namespace CalamityRuTranslate.Mods.ThoriumMod.MonoMod;

public class ThoriumPlayerPatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Thorium != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(ThoriumPlayer).GetCachedMethod(nameof(ThoriumPlayer.AddCoinTooltip));

    private delegate void AddCoinTooltipDelegate(ThoriumPlayer self, List<TooltipLine> list, int amount, Color color = default, bool noCopper = false);

    public override Delegate Delegate => Translation;

    private void Translation(AddCoinTooltipDelegate orig, ThoriumPlayer self, List<TooltipLine> list, int amount, Color color = default, bool noCopper = false)
    {
        int index = list.FindLastIndex(line => line.Mod.Equals("Terraria") && line.Name.StartsWith("Tooltip"));
        if (index == -1)
            return;

        string moneyText = GetMoneyText(amount);
        string text = "";
        
        if (!Platform.IsOSX)
        {
            if (color == default)
            {
                color = new Color(250, 210, 45);
            }
            float num2 = Main.mouseTextColor / 255f;
            string hex = (color * num2).Hex3();
            text = $"[c/{hex}:{moneyText}]";
        }

        list.Insert(++index, new TooltipLine(self.Mod, "MoneyAmount", $"Дополнительно монет получено: {text}"));
    }
    
    private string GetMoneyText(int amount)
    {
        int gold = amount / 10000;
        int silver = amount % 10000 / 100;
        int copper = amount % 100;

        string moneyText = "";
        string coinText = "";

        if (gold > 0)
        {
            moneyText += Language.GetTextValue("Currency.Gold", gold);
            coinText = LocalizedText.ApplyPluralization(" {^0:монета;монеты;монет}", gold);
        }
        
        if (silver > 0)
        {
            moneyText += Language.GetTextValue("Currency.Silver", silver);
            coinText = LocalizedText.ApplyPluralization(" {^0:монета;монеты;монет}", silver);
        }
        
        if (copper > 0)
        {
            moneyText += Language.GetTextValue("Currency.Copper", copper);
            coinText = LocalizedText.ApplyPluralization(" {^0:монета;монеты;монет}", copper);
        }
        
        if (amount <= 0)
        {
            moneyText += "0 монет";
            return moneyText;
        }
        
        if (moneyText.Length > 1)
            moneyText = moneyText[..^1] + coinText;
        
        return moneyText;
    }
}