using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;

namespace CalamityRuTranslate.Core.ItemGenderPrefixes.Items;

public class CatalystItems : IItemGender
{
    public List<int> Feminine
    {
        get
        {
            string[] items = {
                "AstralsEnd",
                "RookOfVengeance",
                "SandstoneReigns",
                "UnrelentingTorment",
            };
        
            if (ModInstances.Catalyst != null)
            {
                return TranslationHelper.GetItemTypesFromMod(items, "CatalystMod");
            }
            return new List<int>();
        }
    }

    public List<int> Neuter
    {
        get
        {
            string[] items = {
                "BreathofGlacies",
                "Repentance",
                "BlossomsBlessing",
            };
        
            if (ModInstances.Catalyst != null)
            {
                return TranslationHelper.GetItemTypesFromMod(items, "CatalystMod");
            }
            return new List<int>();
        }
    }

    public List<int> Plural { get; } = new();
}