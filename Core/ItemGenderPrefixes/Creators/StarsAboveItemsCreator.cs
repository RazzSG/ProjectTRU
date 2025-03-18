using CalamityRuTranslate.Core.ItemGenderPrefixes.Items;

namespace CalamityRuTranslate.Core.ItemGenderPrefixes.Creators;

public class StarsAboveItemsCreator : IItemGenderCreator
{
    public string ModName => "StarsAbove";

    public IItemGender Create()
    {
        return new StarsAboveItems();
    }
}