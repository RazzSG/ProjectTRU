using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;

namespace CalamityRuTranslate.Core.ItemGenderPrefixes.Items;

public class StarsAboveItems : IItemGender
{
    public List<int> Feminine
    {
        get
        {
            string[] items = {
                "Luciferium",
                "Persephone",
                "Glitterglue",
                "ChartTheCosmosMusicBox",
                "ElpisMusicBox",
                "EvenStarsMustFallMusicBox",
                "FleetingMomentMusicBox",
                "LegendsYetUnspunMusicBox",
                "MageOfVioletMusicBox",
                "MightOfTheHellbladeMusicBox",
                "SecondWarningMusicBox",
                "ShadowsCastByTheMightyMusicBox",
                "SunsetStardustMusicBox",
                "ToTheEdgeMusicBox",
                "UnmatchingPiecesMusicBox",
                "VoyageMusicBox",
                "EverlastingPickaxe",
                "IgnitionAstra",
                "UltimaThule",
                "VirtuesEdge",
                "CarianDarkMoon",
                "DreamersInkwell",
                "EternalStar",
                "HunterSymphony",
                "Ozma",
                "RadGun",
                "StygianNymph",
                "SupremeAuthority",
                "AshenAmbition",
                "BurningDesire",
                "CrimsonSakuraAlpha",
                "InugamiRipsaw",
                "LiberationBlazing",
                "Mercy",
                "MiserysCompany",
                "PenthesileaMuse",
                "SakuraVengeance",
                "ShadowlessCerulean",
                "Umbra",
                "ArchitectLuminance",
                "GoldenKatana",
                "GossamerNeedle",
                "Manifestation",
                "CrimsonOutbreak",
                "DeathInFourActs",
                "ForceOfNature",
                "IzanagiEdge",
                "SaltwaterScourge",
                "Tartaglia",
                "CaesuraOfDespair",
                "DragaliaFound",
                "KonpakuKatana",
                "LuminaryWand",
                "MorningStar",
            };
        
            if (ModInstances.StarsAbove != null)
            {
                return TranslationHelper.GetItemTypesFromMod(items, "StarsAbove");
            }
            return new List<int>();
        }
    }

    public List<int> Neuter
    {
        get
        {
            string[] items = {
                "CrystallizedAbsence",
                "GaleflameFeather",
                "EveryMomentMatters",
                "CatalystMemory",
                "TheOnlyThingIKnowForReal",
                "RedMage",
                "SanguineDespair",
                "VenerationOfButterflies",
                "KarlanTruesilver",
                "ManiacalJustice",
                "ElCapitansHardware",
                "RideTheBull",
                "AdornmentOfTheChaoticGod",
                "HollowheartAlbion",
                "KroniicAccelerator",
            };
        
            if (ModInstances.StarsAbove != null)
            {
                return TranslationHelper.GetItemTypesFromMod(items, "StarsAbove");
            }
            return new List<int>();
        }
    }

    public List<int> Plural
    {
        get
        {
            string[] items = {
                "BlackSilenceWeapon",
                "BuryTheLight",
                "TwinStars",
                "Chronoclock",
                "RupturedHeaven",
            };
    
            if (ModInstances.StarsAbove != null)
            {
                return TranslationHelper.GetItemTypesFromMod(items, "StarsAbove");
            }
            return new List<int>();
        }
    }
}