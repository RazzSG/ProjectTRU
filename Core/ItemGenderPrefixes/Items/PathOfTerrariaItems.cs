using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;

namespace CalamityRuTranslate.Core.ItemGenderPrefixes.Items;

public class PathOfTerrariaItems : IItemGender
{
    public List<int> Feminine
    {
        get
        {
            string[] items =
            [
                "Bloodclotter",
                "LeadDangpa",
                "MoltenDangpa",
                "PlatinumGlaive",
                "Rottenbone",
                "SharpenedStick",
                "BloodOath",
                "Katana",
                "Spellbook",
                "PrismaticOrb",
                "TinyHat",
                "WoodPlank",
                "BloatingLeech",
                "Breastplate",
                "Crown",
                "FirelordsWill",
                "CoralCrown",
                "StoneStar",
                "BatteredMail",
                "IronboundCuirass",
                "HallowforgedCuirass",
                "AstralforgedAegis",
                "EternalforgedAegis",
                "ApprenticeCap",
                "SpectralVeil",
                "EtherealDiadem",
                "ApprenticeRobe",
                "EtherealMantle",
            ];
    
            if (ModInstances.PathOfTerraria != null)
            {
                return TranslationHelper.GetItemTypesFromMod(items, "PathOfTerraria");
            }
            return new List<int>();
        }
    }

    public List<int> Neuter
    {
        get
        {
            string[] items =
            [
                "PyralisHeart",
                "Visor",
                "FallenKingsLegacy",
                "GreenCore",
                "YellowCore",
                "Faeflame",
                "StoneRing",
                "BerylRing",
                "FireDiamondRing",
                "RubyRing",
                "AquamarineRing",
                "LapisLazuliRing",
                "SapphireRing",
                "ProlifRing",
                "AcolyteVestment",
                "MysticGarb",
            ];
    
            if (ModInstances.PathOfTerraria != null)
            {
                return TranslationHelper.GetItemTypesFromMod(items, "PathOfTerraria");
            }
            return new List<int>();
        }
    }

    public List<int> Plural
    {
        get
        {
            string[] items =
            [
                "BodyArmor",
                "CrystalVisors",
                "Greaves",
                "Tassets",
                "Treads",
                "Boots",
                "BatteredGreaves",
                "IronboundGreaves",
                "HallowforgedGreaves",
                "AstralforgedSabatons",
                "EternalforgedSabatons",
                "ApprenticeSlippers",
                "AcolyteSandals",
                "MysticBoots",
                "SpectralStriders",
                "EtherealGreaves",
            ];
    
            if (ModInstances.PathOfTerraria != null)
            {
                return TranslationHelper.GetItemTypesFromMod(items, "PathOfTerraria");
            }
            return new List<int>();
        }
    }
}