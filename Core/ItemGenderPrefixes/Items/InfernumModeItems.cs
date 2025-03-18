using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;

namespace CalamityRuTranslate.Core.ItemGenderPrefixes.Items;

public class InfernumModeItems : IItemGender
{
    public List<int> Feminine
    {
        get
        {
            string[] items = {
                "WanderersShell",
                "Purity",
                "IllusionersReverie",
            };
        
            if (ModInstances.Calamity != null && ModInstances.Infernum != null)
            {
                return TranslationHelper.GetItemTypesFromMod(items, "InfernumMode");
            }
            return new List<int>();
        }
    }

    public List<int> Neuter
    {
        get
        {
            string[] items = {
                "StormMaidensRetribution",
                "EyeOfMadness",
            };
        
            if (ModInstances.Calamity != null && ModInstances.Infernum != null)
            {
                return TranslationHelper.GetItemTypesFromMod(items, "InfernumMode");
            }
            return new List<int>();
        }
    }
    
    public List<int> Plural { get; } = new();
}