using CalamityRuTranslate.Core.ItemGenderPrefixes.Items;

namespace CalamityRuTranslate.Core.ItemGenderPrefixes.Creators;

public class CatalystItemsCreator : IItemGenderCreator
{
    public string ModName => "CatalystMod";

    public IItemGender Create()
    {
        return new CatalystItems();
    }
}