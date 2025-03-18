using CalamityRuTranslate.Core.ItemGenderPrefixes.Items;

namespace CalamityRuTranslate.Core.ItemGenderPrefixes.Creators;

public class FargoSoulsItemsCreator : IItemGenderCreator
{
    public string ModName => "FargowiltasSouls";

    public IItemGender Create()
    {
        return new FargoSoulsItems();
    }
}