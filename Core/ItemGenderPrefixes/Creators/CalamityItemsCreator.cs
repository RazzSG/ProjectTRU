using CalamityRuTranslate.Core.ItemGenderPrefixes.Items;

namespace CalamityRuTranslate.Core.ItemGenderPrefixes.Creators;

public class CalamityItemsCreator : IItemGenderCreator
{
    public string ModName => "CalamityMod";

    public IItemGender Create()
    {
        return new CalamityItems();
    }
}