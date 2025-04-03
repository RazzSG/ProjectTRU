using System;
using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.ItemGenderPrefixes.Creators;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Core.ItemGenderPrefixes;

public class PrefixOverhaulModSystem : ModSystem
{
    private List<IItemGenderCreator> _genderCreators;
    
    public override bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public override void Load()
    {
        PrefixOverhaul prefixSystem = new PrefixOverhaul();
        _genderCreators = [];
        
        VanillaItemsCreator vanilla = new VanillaItemsCreator();
        prefixSystem.LoadGenderData(vanilla.Create());

        IEnumerable<Type> creatorTypes = CalamityRuTranslate.Instance.Code.GetTypes().Where(t => !t.IsAbstract && typeof(IItemGenderCreator).IsAssignableFrom(t));
        
        foreach (Type type in creatorTypes)
        {
            if (Activator.CreateInstance(type) is IItemGenderCreator creator && ModLoader.TryGetMod(creator.ModName, out Mod _))
            {
                _genderCreators.Add(creator);
                prefixSystem.LoadGenderData(creator.Create());
            }
        }
    }
    
    public override void Unload()
    {
        PrefixOverhaul.Instance?.Clear();
        _genderCreators?.Clear();
    }
    
    internal static void AddFeminineItems(Mod mod, string[] items) => AddGenderedItems(mod, items, PrefixOverhaul.ItemGenderType.Feminine);
    
    internal static void AddNeuterItems(Mod mod, string[] items) => AddGenderedItems(mod, items, PrefixOverhaul.ItemGenderType.Neuter);
    
    internal static void AddPluralItems(Mod mod, string[] items) => AddGenderedItems(mod, items, PrefixOverhaul.ItemGenderType.Plural);
    
    private static void AddGenderedItems(Mod mod, string[] items, PrefixOverhaul.ItemGenderType genderType)
    {
        if (mod != null)
        {
            List<int> itemIDs = TranslationHelper.GetItemTypesFromMod(items, mod.Name);
            PrefixOverhaul.Instance.AddItems(genderType, itemIDs);
        }
    }
}