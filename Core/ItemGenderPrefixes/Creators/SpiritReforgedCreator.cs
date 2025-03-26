using CalamityRuTranslate.Core.ItemGenderPrefixes.Items;

namespace CalamityRuTranslate.Core.ItemGenderPrefixes.Creators;

public class SpiritReforgedCreator : IItemGenderCreator
{
    public string ModName => "SpiritReforged";

    public IItemGender Create()
    {
        return new SpiritReforgedItems();
    }
}