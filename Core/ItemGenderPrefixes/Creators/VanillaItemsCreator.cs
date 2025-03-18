using CalamityRuTranslate.Core.ItemGenderPrefixes.Items;

namespace CalamityRuTranslate.Core.ItemGenderPrefixes.Creators;

public class VanillaItemsCreator : IItemGenderCreator
{
    public string ModName => "Vanilla";

    public IItemGender Create()
    {
        return new VanillaItems();
    }
}