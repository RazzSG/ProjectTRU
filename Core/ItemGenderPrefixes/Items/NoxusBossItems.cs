using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;

namespace CalamityRuTranslate.Core.ItemGenderPrefixes.Items;

public class NoxusBossItems : IItemGender
{
    public List<int> Feminine => new();

    public List<int> Neuter
    {
        get
        {
            string[] items = {
                "DeificTouch"
            };
    
            if (ModInstances.NoxusBoss != null)
            {
                return TranslationHelper.GetItemTypesFromMod(items, "NoxusBoss");
            }
            return new List<int>();
        }
    }

    public List<int> Plural
    {
        get
        {
            string[] items = {
                "DivineWings"
            };
    
            if (ModInstances.NoxusBoss != null)
            {
                return TranslationHelper.GetItemTypesFromMod(items, "NoxusBoss");
            }
            return new List<int>();
        }
    }
}