using CalamityRuTranslate.Core.ItemGenderPrefixes.Items;

namespace CalamityRuTranslate.Core.ItemGenderPrefixes.Creators;

public class InfernumModeItemsCreator : IItemGenderCreator
{
    public string ModName => "InfernumMode";

    public IItemGender Create()
    {
        return new InfernumModeItems();
    }
}