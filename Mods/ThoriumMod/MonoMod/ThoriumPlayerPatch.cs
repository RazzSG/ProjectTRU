using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using Microsoft.Xna.Framework;
using ReLogic.OS;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using ThoriumMod;

namespace CalamityRuTranslate.Mods.ThoriumMod.MonoMod;

public class ThoriumPlayerPatch : OnPatcher
{
    public override bool AutoLoad => ModInstances.Thorium != null && TRuConfig.Instance.ThoriumModLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(ThoriumPlayer).FindMethod(nameof(ThoriumPlayer.AddCoinTooltip));

    public override Delegate Delegate => Translation;

    private void Translation(Action<ThoriumPlayer, List<TooltipLine>, int, Color, bool> _, ThoriumPlayer self, List<TooltipLine> list, int amount, Color color = default, bool noCopper = false)
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
                int[] coins = Utils.CoinsSplit(amount);
                color = coins[3] > 0 ? Colors.CoinPlatinum :
                    coins[2] > 0 ? Colors.CoinGold :
                    coins[1] > 0 ? Colors.CoinSilver :
                    Colors.CoinCopper;
            }
            
            string hex = Colors.AlphaDarken(color).Hex3();
            text = $"[c/{hex}:{moneyText}]";
        }

        list.Insert(++index, new TooltipLine(self.Mod, "MoneyAmount", $"Дополнительно монет получено: {text}"));
    }
    
    private string GetMoneyText(int amount)
    {
        int[] coins = Utils.CoinsSplit(amount);
        int platinum = coins[3];
        int gold = coins[2];
        int silver = coins[1];
        int copper = coins[0];

        string moneyText = "";
        int lastCoinValue = 0;

        if (platinum > 0)
        {
            moneyText += Language.GetTextValue("Currency.Platinum", platinum);
            lastCoinValue = platinum;
        }

        if (gold > 0)
        {
            moneyText += Language.GetTextValue("Currency.Gold", gold);
            lastCoinValue = gold;
        }
        
        if (silver > 0)
        {
            moneyText += Language.GetTextValue("Currency.Silver", silver);
            lastCoinValue = silver;
        }
        
        if (copper > 0)
        {
            moneyText += Language.GetTextValue("Currency.Copper", copper);
            lastCoinValue = copper;
        }
        
        if (amount <= 0)
        {
            moneyText += "0 монет";
            return moneyText;
        }
        
        string coinText = LocalizedText.ApplyPluralization(" {^0:монета;монеты;монет}", lastCoinValue);
        
        if (moneyText.Length > 1)
            moneyText = moneyText[..^1] + coinText;
        
        return moneyText;
    }
}