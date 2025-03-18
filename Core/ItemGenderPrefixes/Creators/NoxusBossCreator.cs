using CalamityRuTranslate.Core.ItemGenderPrefixes.Items;

namespace CalamityRuTranslate.Core.ItemGenderPrefixes.Creators;

public class NoxusBossCreator : IItemGenderCreator
{
    public string ModName => "NoxusBoss";

    public IItemGender Create()
    {
        return new NoxusBossItems();
    }
}