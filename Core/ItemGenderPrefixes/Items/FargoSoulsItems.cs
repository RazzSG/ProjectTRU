using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;

namespace CalamityRuTranslate.Core.ItemGenderPrefixes.Items;

public class FargoSoulsItems : IItemGender
{
    public List<int> Feminine
    {
        get
        {
            string[] items = {
                "ApprenticesEssence",
                "BarbariansEssence",
                "OccultistsEssence",
                "SharpshootersEssence",
                "CosmoForce",
                "EarthForce",
                "LifeForce",
                "NatureForce",
                "ShadowForce",
                "SpiritForce",
                "TerraForce",
                "TimberForce",
                "WillForce",
                "AbominableWand",
                "AgitatingLens",
                "CelestialRune",
                "ChaliceoftheMoon",
                "ConcentratedRainbowMatter",
                "DreadShell",
                "DubiousCircuitry",
                "IceQueensCrown",
                "PrecisionSeal",
                "PumpkingsCape",
                "ReinforcedPlating",
                "SaucerControlConsole",
                "SinisterIcon",
                "SqueakyToy",
                "SupremeDeathbringerFairy",
                "TimsConcoction",
                "ArchWizardsSoul",
                "BerserkerSoul",
                "ColossusSoul",
                "ConjuristsSoul",
                "DimensionSoul",
                "EternitySoul",
                "FlightMasterySoul",
                "MasochistSoul",
                "SnipersSoul",
                "SupersonicSoul",
                "TerrariaSoul",
                "TrawlerSoul",
                "UniverseSoul",
                "WorldShaperSoul",
                "BoneZone",
                "DestroyerGun",
                "FishStick",
                "FleshHand",
                "MountedAcornGun",
                "SparklingLove",
                "Mahoguny",
                "TophatSquirrelWeapon",
                "DestroyerGun2",
                "DragonBreath2",
                "HellZone",
                "ComputationOrb",
                "ParadoxWolfSoul",
                "MissDrakovisFishingPole",
                "BoxofGizmos",
                "PrismaRegalia",
                "NavalRustrifle",
                "EgyptianFlail",
                "SisypheanFist",
                "UmbraRegalia",
                "ElectricWhip",
                "GalacticGlobe",
                "TouhouStaff",
            };
        
            if (ModInstances.FargowiltasSouls != null)
            {
                return TranslationHelper.GetItemTypesFromMod(items, "FargowiltasSouls");
            }
            return new List<int>();
        }
    }

    public List<int> Neuter
    {
        get
        {
            string[] items = {
                "AdamantiteEnchant",
                "AncientCobaltEnchant",
                "AncientHallowEnchant",
                "AncientShadowEnchant",
                "AnglerEnchant",
                "ApprenticeEnchant",
                "BeeEnchant",
                "BeetleEnchant",
                "BorealWoodEnchant",
                "CactusEnchant",
                "ChlorophyteEnchant",
                "CobaltEnchant",
                "CopperEnchant",
                "CrimsonEnchant",
                "CrystalAssassinEnchant",
                "DarkArtistEnchant",
                "EbonwoodEnchant",
                "ForbiddenEnchant",
                "FossilEnchant",
                "FrostEnchant",
                "GladiatorEnchant",
                "GoldEnchant",
                "HallowEnchant",
                "HuntressEnchant",
                "IronEnchant",
                "JungleEnchant",
                "LeadEnchant",
                "MeteorEnchant",
                "MinerEnchant",
                "MoltenEnchant",
                "MonkEnchant",
                "MythrilEnchant",
                "NebulaEnchant",
                "NecroEnchant",
                "NinjaEnchant",
                "ObsidianEnchant",
                "OrichalcumEnchant",
                "PalladiumEnchant",
                "PalmWoodEnchant",
                "PearlwoodEnchant",
                "PlatinumEnchant",
                "PumpkinEnchant",
                "RainEnchant",
                "RedRidingEnchant",
                "RichMahoganyEnchant",
                "ShadewoodEnchant",
                "ShadowEnchant",
                "ShinobiEnchant",
                "ShroomiteEnchant",
                "SilverEnchant",
                "SnowEnchant",
                "SolarEnchant",
                "SpectreEnchant",
                "SpiderEnchant",
                "SpookyEnchant",
                "SquireEnchant",
                "StardustEnchant",
                "TikiEnchant",
                "TinEnchant",
                "TitaniumEnchant",
                "TungstenEnchant",
                "TurtleEnchant",
                "ValhallaKnightEnchant",
                "VortexEnchant",
                "WizardEnchant",
                "WoodEnchant",
                "UniverseCore",
                "BetsysHeart",
                "DarkenedHeart",
                "GuttedHeart",
                "HeartoftheMasochist",
                "NecromanticBrew",
                "PungentEyeball",
                "PureHeart",
                "QueenStinger",
                "SparklingAdoration",
                "WyvernFeather",
                "DragonBreath",
                "TheSmallSting",
                "TheBigSting",
                "AshWoodEnchant",
                "TheBiggestSting",
            };
        
            if (ModInstances.FargowiltasSouls != null)
            {
                return TranslationHelper.GetItemTypesFromMod(items, "FargowiltasSouls");
            }
            return new List<int>();
        }
    }

    public List<int> Plural
    {
        get
        {
            string[] items = {
                "AeolusBoots",
                "EurusSock",
                "FusedLens",
                "GelicWings",
                "MutantAntibodies",
                "SandsofTime",
                "ZephyrBoots",
                "TwinRangs",
                "GeminiGlaives",
                "Deerclawps",
                "FrigidGemstone",
            };
            
            if (ModInstances.FargowiltasSouls != null)
            {
                return TranslationHelper.GetItemTypesFromMod(items, "FargowiltasSouls");
            }
            return new List<int>();
        }
    }
}