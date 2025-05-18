using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;

namespace CalamityRuTranslate.Core.ItemGenderPrefixes.Items;

public class SpiritReforgedItems : IItemGender
{
    public List<int> Feminine
    {
        get
        {
            string[] items = {
                "PearlString",
                "BambooHalberd",
                "PoolNoodle",
                "ClawCannon",
                "WoodenClub",
            };
        
            if (ModInstances.SpiritReforged != null)
            {
                return TranslationHelper.GetItemTypesFromMod(items, "SpiritReforged");
            }
            return new List<int>();
        }
    }

    public List<int> Neuter
    {
        get
        {
            string[] items = {
                "ArcaneNecklaceGold",
                "ArcaneNecklacePlatinum",
                "CraneFeather",
                "SafekeeperRing",
                "OceanPendant",
                "HuntingRifle",
                "FrostbiteItem",
            };
        
            if (ModInstances.SpiritReforged != null)
            {
                return TranslationHelper.GetItemTypesFromMod(items, "SpiritReforged");
            }
            return new List<int>();
        }
    }

    public List<int> Plural
    {
        get
        {
            string[] items = {
                "ExplorerTreadsItem",
            };
    
            if (ModInstances.SpiritReforged != null)
            {
                return TranslationHelper.GetItemTypesFromMod(items, "SpiritReforged");
            }
            return new List<int>();
        }
    }
}