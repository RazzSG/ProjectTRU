using CalamityRuTranslate.Core.ItemGenderPrefixes.Items;

namespace CalamityRuTranslate.Core.ItemGenderPrefixes.Creators;

public class RedemptionItemsCreator : IItemGenderCreator
{
    public string ModName => "Redemption";

    public IItemGender Create()
    {
        return new RedemptionItems();
    }
}