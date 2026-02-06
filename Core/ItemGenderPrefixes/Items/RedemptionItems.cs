using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;

namespace CalamityRuTranslate.Core.ItemGenderPrefixes.Items;

public class RedemptionItems : IItemGender
{
    public List<int> Feminine
    {
        get
        {
            string[] items = {
                "VasaraPendant",
                "OmegaPickaxe",
                "NanoAxe2",
                "GraveSteelPickaxe",
                "PureIronPickaxe",
                "Divinity",
                "Dusksong",
                "Dusksong2",
                "HydrasMaw",
                "Taikasauva",
                "BloodstainedPike",
                "CrystalGlaive",
                "InfectiousGlaive",
                "Midnight",
                "OversizedScrewdriver",
                "TidalWake",
                "BileLauncher",
                "CorruptedDoubleRifle",
                "DoubleRifle",
                "FlakCannon",
                "PrototypeAtomRifle",
                "AndroidHologram",
                "Constellations",
                "EmpyreanBlind",
                "PoemOfIlmatar",
                "TeslaCoil",
                "Hacksaw",
                "PiercingNebulaWeapon",
                "Electronade",
                "SwarmerCannon",
                "Twinklestar",
                "XeniumDrone",
                "CalciteWand",
                "ChickendWand",
                "EaglecrestGlove",
                "ErhanMagnifyingGlass",
                "Halbirdhouse",
                "NoblesHalberd",
                "SilverRapier",
                "EaglecrestSling",
                "HallowedHandGrenade",
                "CruxCardAnglonSkeletons",
                "CruxCardCalavia",
                "CruxCardForestNymph",
                "CruxCardGathicSkeletons",
                "CruxCardGladestone",
                "CruxCardMossyGoliath",
                "CruxCardSkeleton",
                "CruxCardSkeletonAssassin",
                "CruxCardSkullDigger",
                "CruxCardTied",
                "CystlingSummon",
                "HolyBible",
                "RitualistEmblem",
                "BeelzebubConcoction",
                "DevilishResin",
                "DurableBowString",
                "GildedSeaEmblem",
                "SpiderSerum",
                "TrappedSoulBauble",
                "NanoPickaxe",
                "ForestNymphsSickle",
                "PZGauntlet",
            };
        
            if (ModInstances.Redemption != null)
            {
                return TranslationHelper.GetItemTypesFromMod(items, "Redemption");
            }
            return new List<int>();
        }
    }

    public List<int> Neuter
    {
        get
        {
            string[] items = {
                "BlindJustice",
                "InfectedTentacle",
                "MythrilsBane",
                "SunInThePalm",
                "UkonRuno",
                "EaglecrestJavelin",
                "XenoXyston",
                "GracesGuidance",
                "MicroshieldCore",
                "HeartOfInfection",
                "WaterfowlEgg",
                "ForestCore",
                "HeartInsignia",
                "NecklaceOfPerception",
                "NecklaceOfSight",
                "ShellNecklace",
                "Wardbreaker",
                "FlintAndSteel",
            };
        
            if (ModInstances.Redemption != null)
            {
                return TranslationHelper.GetItemTypesFromMod(items, "Redemption");
            }
            return new List<int>();
        }
    }

    public List<int> Plural
    {
        get
        {
            string[] items = {
                "CrystallizedKnowledge",
                "HyperTechRevolvers",
                "CosmosChains",
                "ChompingChains",
                "KeepersClaw",
                "MechanicalSheath",
                "NebWings",
                "LeatherSheath",
                "NebWings2",
            };
    
            if (ModInstances.Redemption != null)
            {
                return TranslationHelper.GetItemTypesFromMod(items, "Redemption");
            }
            return new List<int>();
        }
    }
}