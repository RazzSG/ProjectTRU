using CalamityRuTranslate.Core.ItemGenderPrefixes.Items;

namespace CalamityRuTranslate.Core.ItemGenderPrefixes.Creators;

public class PathOfTerrariaCreator : IItemGenderCreator
{
    public string ModName => "PathOfTerraria";

    public IItemGender Create()
    {
        return new PathOfTerrariaItems();
    }
}