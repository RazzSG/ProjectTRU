using CalamityRuTranslate.Core.ItemGenderPrefixes.Items;

namespace CalamityRuTranslate.Core.ItemGenderPrefixes.Creators;

public class ThoriumModItemsCreator : IItemGenderCreator
{
    public string ModName => "ThoriumMod";

    public IItemGender Create()
    {
        return new ThoriumModItems();
    }
}