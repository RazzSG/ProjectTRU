using System;
using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Terraria;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;

public class ValueToNameLong : OnPatcher
{
    public override bool AutoLoad => TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(PopupText).GetMethod("ValueToName", BindingFlags.Public | BindingFlags.Static, new []{typeof(long)});
    
    private delegate string ValueToNameDelegate(long coinValue);

    public override Delegate Delegate => Translation;

    private string Translation(ValueToNameDelegate orig, long coinValue)
    {
        int num = 0;
        int num2 = 0;
        int num3 = 0;
        int num4 = 0;
        long num5 = coinValue;
        while (num5 > 0) {
            if (num5 >= 1000000) {
                num5 -= 1000000;
                num++;
            }
            else if (num5 >= 10000) {
                num5 -= 10000;
                num2++;
            }
            else if (num5 >= 100) {
                num5 -= 100;
                num3++;
            }
            else if (num5 >= 1) {
                num5--;
                num4++;
            }
        }

        string text = "";
        string coinText = "";
        
        if (num > 0)
        {
            text += Language.GetTextValue("Currency.Platinum", num);
            coinText = LocalizedText.ApplyPluralization(" {^0:монета;монеты;монет}", num);
        }

        if (num2 > 0)
        {
            text += Language.GetTextValue("Currency.Gold", num2);
            coinText = LocalizedText.ApplyPluralization(" {^0:монета;монеты;монет}", num2);
        }
        
        if (num3 > 0)
        {
            text += Language.GetTextValue("Currency.Silver", num3);
            coinText = LocalizedText.ApplyPluralization(" {^0:монета;монеты;монет}", num3);
        }
        
        if (num4 > 0)
        {
            text += Language.GetTextValue("Currency.Copper", num4);
            coinText = LocalizedText.ApplyPluralization(" {^0:монета;монеты;монет}", num4);
        }
        
        if (text.Length > 1)
            text = text.Substring(0, text.Length - 1) + coinText;

        return text;
    }
}

public class ValueToName : OnPatcher
{
    public override bool AutoLoad => TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(PopupText).GetMethod("ValueToName", BindingFlags.NonPublic | BindingFlags.Instance);
    
    private delegate void ValueToNameDelegate(PopupText self);

    public override Delegate Delegate => Translation;

    private void Translation(ValueToNameDelegate orig, PopupText self)
    {
        int num = 0;
        int num2 = 0;
        int num3 = 0;
        int num4 = 0;
        long num5 = self.coinValue;
        while (num5 > 0) {
            if (num5 >= 1000000) {
                num5 -= 1000000;
                num++;
            }
            else if (num5 >= 10000) {
                num5 -= 10000;
                num2++;
            }
            else if (num5 >= 100) {
                num5 -= 100;
                num3++;
            }
            else if (num5 >= 1) {
                num5--;
                num4++;
            }
        }

        self.name = "";
        string coinText = "";
        
        if (num > 0)
        {
            self.name += Language.GetTextValue("Currency.Platinum", num);
            coinText = LocalizedText.ApplyPluralization(" {^0:монета;монеты;монет}", num);
        }
        
        if (num2 > 0)
        {
            self.name += Language.GetTextValue("Currency.Gold", num2);
            coinText = LocalizedText.ApplyPluralization(" {^0:монета;монеты;монет}", num2);
        }
        
        if (num3 > 0)
        {
            self.name += Language.GetTextValue("Currency.Silver", num3);
            coinText = LocalizedText.ApplyPluralization(" {^0:монета;монеты;монет}", num3);
        }
        
        if (num4 > 0)
        {
            self.name += Language.GetTextValue("Currency.Copper", num4);
            coinText = LocalizedText.ApplyPluralization(" {^0:монета;монеты;монет}", num4);
        }
        
        if (self.name.Length > 1)
            self.name = self.name.Substring(0, self.name.Length - 1) + coinText;
    }
}

public class ValueToCoins : OnPatcher
{
    public override bool AutoLoad => TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(Main).GetCachedMethod(nameof(Main.ValueToCoins));
    
    private delegate string ValueToCoinsDelegate(long value);

    public override Delegate Delegate => Translation;

    private string Translation(ValueToCoinsDelegate orig, long value)
    {
        long num = value;
        long num2 = 0L;
        long num3 = 0L;
        long num4 = 0L;
        while (num >= 1000000) {
            num -= 1000000;
            num2++;
        }

        while (num >= 10000) {
            num -= 10000;
            num3++;
        }

        while (num >= 100) {
            num -= 100;
            num4++;
        }

        long num5 = num;
        string text = "";
        string coinText = "";
        
        if (num2 > 0)
        {
            text += Language.GetTextValue("Currency.Platinum", (int)num2);
            coinText = LocalizedText.ApplyPluralization(" {^0:монета;монеты;монет}", (int)num2);
        }
        
        if (num3 > 0)
        {
            text += Language.GetTextValue("Currency.Gold", (int)num3);
            coinText = LocalizedText.ApplyPluralization(" {^0:монета;монеты;монет}", (int)num3);
        }
        
        if (num4 > 0)
        {
            text += Language.GetTextValue("Currency.Silver", (int)num4);
            coinText = LocalizedText.ApplyPluralization(" {^0:монета;монеты;монет}", (int)num4);
        }
        
        if (num5 > 0)
        {
            text += Language.GetTextValue("Currency.Copper", (int)num5);
            coinText = LocalizedText.ApplyPluralization(" {^0:монета;монеты;монет}", (int)num5);
        }

        if (text.Length > 0)
            text = text.Substring(0, text.Length - 1) + coinText;

        return text;
    }
}