using System;

namespace CalamityRuTranslate.Core.ArmorSetBonusPreview;

public sealed class ArmorSetBonusData(int itemID, Func<string> setBonusText)
{
    public int ItemID { get; } = itemID;
    private Func<string> SetBonusText { get; } = setBonusText;

    public string GetSetBonusText() => SetBonusText.Invoke();
}