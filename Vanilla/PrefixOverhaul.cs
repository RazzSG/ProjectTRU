﻿using System.Collections.Generic;
using System.Linq;
using CalamityRuTranslate.Common;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Vanilla;

public class VanillaItems : IItemGender
{
    public List<int> Feminine { get; } = new()
    {
        ItemID.LuckyHorseshoe,
        ItemID.GuideVoodooDoll,
        ItemID.ObsidianHorseshoe,
        ItemID.SorcererEmblem,
        ItemID.WarriorEmblem,
        ItemID.RangerEmblem,
        ItemID.NeptunesShell,
        ItemID.TitanGlove,
        ItemID.DiscountCard,
        ItemID.LuckyCoin,
        ItemID.SandstorminaBottle,
        ItemID.MoonShell,
        ItemID.StarVeil,
        ItemID.Blindfold,
        ItemID.TrifoldMap,
        ItemID.PowerGlove,
        ItemID.CountercurseMantra,
        ItemID.AvengerEmblem,
        ItemID.MechanicalGlove,
        ItemID.SandstorminaBalloon,
        ItemID.BlizzardinaBottle,
        ItemID.BlizzardinaBalloon,
        ItemID.BundleofBalloons,
        ItemID.BlueHorseshoeBalloon,
        ItemID.WhiteHorseshoeBalloon,
        ItemID.YellowHorseshoeBalloon,
        ItemID.DestroyerEmblem,
        ItemID.ClothierVoodooDoll,
        ItemID.ObsidianRose,
        ItemID.FireGauntlet,
        ItemID.PortableCementMixer,
        ItemID.CelestialEmblem,
        ItemID.MysteriousCape,
        ItemID.RedCape,
        ItemID.WinterCape,
        ItemID.HighTestFishingLine,
        ItemID.AnglerEarring,
        ItemID.GingerBeard,
        ItemID.LaserRuler,
        ItemID.SummonerEmblem,
        ItemID.CelestialShell,
        ItemID.GoblinTech,
        ItemID.BejeweledValkyrieWing,
        ItemID.BoneGlove,
        ItemID.BalloonHorseshoeFart,
        ItemID.BalloonHorseshoeHoney,
        ItemID.BalloonHorseshoeSharkron,
        ItemID.RedString,
        ItemID.OrangeString,
        ItemID.YellowString,
        ItemID.LimeString,
        ItemID.GreenString,
        ItemID.TealString,
        ItemID.CyanString,
        ItemID.SkyBlueString,
        ItemID.BlueString,
        ItemID.PurpleString,
        ItemID.VioletString,
        ItemID.PinkString,
        ItemID.BrownString,
        ItemID.WhiteString,
        ItemID.RainbowString,
        ItemID.BlackString,
        ItemID.YoyoBag,
        ItemID.WingsNebula,
        ItemID.Yoraiz0rDarkness,
        ItemID.PartyBundleOfBalloonsAccessory,
        ItemID.BerserkerGlove,
        ItemID.AncientChisel,
        ItemID.PortableStool,
        ItemID.GhostarsWings,
        ItemID.LongRainbowTrailWings,
        ItemID.EmpressFlightBooster,
        ItemID.WilsonBeardShort,
        ItemID.WilsonBeardLong,
        ItemID.WilsonBeardMagnificent,
        ItemID.IronPickaxe,
        ItemID.Vilethorn,
        ItemID.Starfury,
        ItemID.Minishark,
        ItemID.NightmarePickaxe,
        ItemID.MagicMissile,
        ItemID.MoltenFury,
        ItemID.MoltenPickaxe,
        ItemID.SpaceGun,
        ItemID.Muramasa,
        ItemID.BreathingReed,
        ItemID.Flamelash,
        ItemID.Sandgun,
        ItemID.DemonScythe,
        ItemID.NightsEdge,
        ItemID.Blowpipe,
        ItemID.ClockworkAssaultRifle,
        ItemID.MagicalHarp,
        ItemID.LaserRifle,
        ItemID.Megashark,
        ItemID.Cutlass,
        ItemID.TrueNightsEdge,
        ItemID.Frostbrand,
        ItemID.CobaltPickaxe,
        ItemID.MythrilPickaxe,
        ItemID.AdamantitePickaxe,
        ItemID.DeathbringerPickaxe,
        ItemID.BloodLustCluster,
        ItemID.CactusPickaxe,
        ItemID.PiranhaGun,
        ItemID.PalladiumPickaxe,
        ItemID.OrichalcumPickaxe,
        ItemID.TitaniumPickaxe,
        ItemID.ChlorophyteSaber,
        ItemID.ChlorophytePickaxe,
        ItemID.SniperRifle,
        ItemID.RainbowGun,
        ItemID.MagnetSphere,
        ItemID.ZombieArm,
        ItemID.IceSickle,
        ItemID.BookofSkulls,
        ItemID.SnowballCannon,
        ItemID.BonePickaxe,
        ItemID.DeathSickle,
        ItemID.SpectrePickaxe,
        ItemID.CandyCornRifle,
        ItemID.BladedGlove,
        ItemID.CnadyCanePickaxe,
        ItemID.ChainGun,
        ItemID.Razorpine,
        ItemID.SnowmanCannon,
        ItemID.Katana,
        ItemID.Rockfish,
        ItemID.PurpleClubberfish,
        ItemID.ReaverShark,
        ItemID.BubbleGun,
        ItemID.VortexPickaxe,
        ItemID.NebulaPickaxe,
        ItemID.SolarFlarePickaxe,
        ItemID.ChargedBlasterCannon,
        ItemID.ShadowFlameHexDoll,
        ItemID.WandofSparking,
        ItemID.MedusaHead,
        ItemID.TaxCollectorsStickOfDoom,
        ItemID.StardustPickaxe,
        ItemID.PlatinumPickaxe,
        ItemID.TungstenPickaxe,
        ItemID.LeadPickaxe,
        ItemID.TinPickaxe,
        ItemID.CopperPickaxe,
        ItemID.SilverPickaxe,
        ItemID.GoldPickaxe,
        ItemID.LastPrism,
        ItemID.NebulaBlaze,
        ItemID.LunarFlareBook,
        ItemID.BluePhasesaber,
        ItemID.RedPhasesaber,
        ItemID.GreenPhasesaber,
        ItemID.PurplePhasesaber,
        ItemID.WhitePhasesaber,
        ItemID.YellowPhasesaber,
        ItemID.DD2FlameburstTowerT2Popper,
        ItemID.DD2BallistraTowerT2Popper,
        ItemID.DD2LightningAuraT2Popper,
        ItemID.DD2ExplosiveTrapT2Popper,
        ItemID.DD2BetsyBow,
        ItemID.FossilPickaxe,
        ItemID.OrangePhasesaber,
        ItemID.SharpTears,
        ItemID.GravediggerShovel,
        ItemID.FairyQueenRangedItem,
        ItemID.EmpressBlade,
        ItemID.LucyTheAxe,
        ItemID.HamBat,
        ItemID.BatBat,
        ItemID.ScytheWhip,
        ItemID.MaceWhip,
        ItemID.Mace,
        ItemID.TheMeatball,
        ItemID.ObsidianSwordfish,
        ItemID.WandofFrosting,
        ItemID.WaffleIron,
        ItemID.HandOfCreation,
        ItemID.HorseshoeBundle,
        ItemID.FlowerPow,
    };

    public List<int> Neuter { get; } = new()
    {
        ItemID.CloudinaBottle,
        ItemID.DivingGear,
        ItemID.CloudinaBalloon,
        ItemID.ArmorBracing,
        ItemID.TigerClimbingGear,
        ItemID.Tabi,
        ItemID.MasterNinjaGear,
        ItemID.PygmyNecklace,
        ItemID.PanicNecklace,
        ItemID.JellyfishNecklace,
        ItemID.SweetheartNecklace,
        ItemID.JellyfishDivingGear,
        ItemID.ArcticDivingGear,
        ItemID.DiamondRing,
        ItemID.GoldRing,
        ItemID.CoinRing,
        ItemID.GreedyRing,
        ItemID.WeatherRadio,
        ItemID.CordageGuide,
        ItemID.TsunamiInABottle,
        ItemID.SharkToothNecklace,
        ItemID.PocketMirror,
        ItemID.FrogGear,
        ItemID.StingerNecklace,
        ItemID.DontStarveShaderItem,
        ItemID.Blowgun,
        ItemID.Uzi,
        ItemID.Tsunami,
        ItemID.PainterPaintballGun,
        ItemID.FireworksLauncher,
        ItemID.SpiritFlame,
        ItemID.DD2SquireDemonSword,
        ItemID.FairyQueenMagicItem,
        ItemID.TentacleSpike,
        ItemID.DarkLance,
        ItemID.Spear,
        ItemID.Celeb2,
    };

    public List<int> Plural { get; } = new()
    {
        ItemID.CopperWatch,
        ItemID.SilverWatch,
        ItemID.GoldWatch,
        ItemID.HermesBoots,
        ItemID.RocketBoots,
        ItemID.Flipper,
        ItemID.FeralClaws,
        ItemID.Shackle,
        ItemID.SpectreBoots,
        ItemID.DemonWings,
        ItemID.AngelWings,
        ItemID.TinWatch,
        ItemID.TungstenWatch,
        ItemID.PlatinumWatch,
        ItemID.ButterflyWings,
        ItemID.FairyWings,
        ItemID.HarpyWings,
        ItemID.BoneWings,
        ItemID.FlameWings,
        ItemID.FrozenWings,
        ItemID.GhostWings,
        ItemID.WaterWalkingBoots,
        ItemID.Vitamins,
        ItemID.LightningBoots,
        ItemID.ObsidianWaterWalkingBoots,
        ItemID.LavaWaders,
        ItemID.SteampunkWings,
        ItemID.IceSkates,
        ItemID.ClimbingClaws,
        ItemID.ShoeSpikes,
        ItemID.HoneyComb,
        ItemID.LeafWings,
        ItemID.BatWings,
        ItemID.BeeWings,
        ItemID.FlurryBoots,
        ItemID.DTownsWings,
        ItemID.WillsWings,
        ItemID.CrownosWings,
        ItemID.CenxsWings,
        ItemID.MagicCuffs,
        ItemID.TatteredFairyWings,
        ItemID.SpookyWings,
        ItemID.FrostsparkBoots,
        ItemID.FestiveWings,
        ItemID.HandWarmer,
        ItemID.CelestialCuffs,
        ItemID.BeetleWings,
        ItemID.FrogLeg,
        ItemID.FinWings,
        ItemID.FishronWings,
        ItemID.MothronWings,
        ItemID.PutridScent,
        ItemID.FleshKnuckles,
        ItemID.FlowerBoots,
        ItemID.SailfishBoots,
        ItemID.YoYoGlove,
        ItemID.WingsSolar,
        ItemID.WingsStardust,
        ItemID.Yoraiz0rWings,
        ItemID.JimsWings,
        ItemID.SkiphsWings,
        ItemID.LokisWings,
        ItemID.AnglerTackleBag,
        ItemID.BetsyWings,
        ItemID.ArkhalisWings,
        ItemID.AmphibianBoots,
        ItemID.FairyBoots,
        ItemID.FrogFlipper,
        ItemID.FrogWebbing,
        ItemID.SandBoots,
        ItemID.SpectreGoggles,
        ItemID.FoodBarbarianWings,
        ItemID.GroxTheGreatWings,
        ItemID.FlameWakerBoots,
        ItemID.RainbowWings,
        ItemID.HellfireTreads,
        ItemID.CreativeWings,
        ItemID.TerrasparkBoots,
        ItemID.LavaproofTackleBag,
        ItemID.GlassSlipper,
        ItemID.CursedFlames,
        ItemID.ShroomiteDiggingClaw,
        ItemID.StylistKilLaKillScissorsIWish,
        ItemID.RedsWings,
        ItemID.ReflectiveShades,
        ItemID.JimsDroneVisor,
    };
}

public class VanillaItemsCreator : IItemGenderCreator
{
    public IItemGender Create()
    {
        return new VanillaItems();
    }
}

public class CalamityItems : IItemGender
{
    public List<int> Feminine
    {
        get
        {
            string[] items =
            {
                "Affliction",
                "AlchemicalFlask",
                "AlluringBait",
                "AmbrosialAmpoule",
                "AmidiasSpark",
                "AquaticEmblem",
                "AsgardianAegis",
                "AsgardsValor",
                "BloodstainedGlove",
                "VoidofCalamity",
                "CelestialJewel",
                "CoinofDeceit",
                "CorruptFlask",
                "CrawCarapace",
                "CrimsonFlask",
                "CrownJewel",
                "DeadshotBrooch",
                "DragonScales",
                "ElectriciansGlove",
                "ElementalGauntlet",
                "ElysianAegis",
                "EnchantedPearl",
                "FeatherCrown",
                "FilthyGlove",
                "FrostFlare",
                "Gehenna",
                "GiantPearl",
                "GloveOfPrecision",
                "GloveOfRecklessness",
                "HallowedRune",
                "HideofAstrumDeus",
                "HoneyDew",
                "InkBomb",
                "Laudanum",
                "LeviathanAmbergris",
                "LivingDew",
                "MoonstoneCrown",
                "Nanotech",
                "OldDie",
                "RadiantOoze",
                "RogueEmblem",
                "SandCloak",
                "ScuttlersJewel",
                "SigilofCalamitas",
                "SpectralVeil",
                "TheSponge",
                "VoidofExtinction",
                "HadalMantle",
                "SoulofCryogen",
                "PolarisParrotfish",
                "Spadefish",
                "SparklingEmpress",
                "AstralPickaxe",
                "BeastialPickaxe",
                "BlossomPickaxe",
                "FlamebeakHampick",
                "GallantPickaxe",
                "GreatbayPickaxe",
                "ShardlightPickaxe",
                "SkyfringePickaxe",
                "GalvanizingGlaive",
                "HeavyLaserRifle",
                "PlasmaCaster",
                "PulseRifle",
                "SystemBane",
                "TeslaCannon",
                "AcidGun",
                "ApoctosisArray",
                "ArcticBearPaw",
                "Atlantis",
                "BloodBath",
                "LashesofChaos",
                "CoralSpout",
                "CosmicRainbow",
                "Cryophobia",
                "DarkSpark",
                "Eternity",
                "FlareBolt",
                "FrigidflashBolt",
                "FrostBolt",
                "GleamingMagnolia",
                "HeliumFlash",
                "Hematemesis",
                "MadAlchemistsCocktailGlove",
                "MagnaCannon",
                "ManaRose",
                "NuclearFury",
                "PhantasmalFury",
                "PlasmaRifle",
                "PrimordialAncient",
                "PrimordialEarth",
                "NanoPurge",
                "RecitationoftheBeast",
                "RelicofRuin",
                "SanguineFlare",
                "SkyGlaze",
                "TheWand",
                "Thunderstorm",
                "Vehemence",
                "VitriolicViper",
                "VividClarity",
                "WintersFury",
                "Aorta",
                "AstralPike",
                "AstralScythe",
                "Ataraxia",
                "Avalanche",
                "Basher",
                "Brimlash",
                "BurntSienna",
                "Carnage",
                "CausticEdge",
                "CosmicShiv",
                "DiseasedPike",
                "DragonRage",
                "Earth",
                "EarthenPike",
                "EssenceFlayer",
                "EutrophicScimitar",
                "ForsakenSaber",
                "FourSeasonsGalaxia",
                "LifefruitScythe",
                "Lucrecia",
                "Mourningstar",
                "Murasama",
                "PerfectDark",
                "Quagmire",
                "Shimmerspark",
                "SolarFlare",
                "SoulEdge",
                "StormSaber",
                "TheMicrowave",
                "Pandemic",
                "TitanArm",
                "TrueCausticEdge",
                "TyphonsGreed",
                "UrchinFlail",
                "UrchinMace",
                "Virulence",
                "AntiMaterielRifle",
                "Animosity",
                "BarracudaGun",
                "BrimstoneFury",
                "ChickenCannon",
                "ClamorRifle",
                "ClaretCannon",
                "Contagion",
                "CoralCannon",
                "DodusHandcannon",
                "EternalBlizzard",
                "FetidEmesis",
                "FirestormCannon",
                "FlakToxicannon",
                "FlurrystormCannon",
                "Galeforce",
                "HalibutCannon",
                "Infinity",
                "Karasawa",
                "MagnomalyCannon",
                "MineralMortar",
                "Onyxia",
                "PristineFury",
                "SandstormGun",
                "SpectralstormCannon",
                "Starmada",
                "StellarCannon",
                "StormSurge",
                "SulphuricAcidCannon",
                "TheBallista",
                "ThePack",
                "Ultima",
                "AcidicRainBarrel",
                "BallisticPoisonBomb",
                "BlastBarrel",
                "BrackishFlask",
                "Cinquedea",
                "ConsecratedWater",
                "ContaminatedBile",
                "CrushsawCrasher",
                "DeepSeaDumbbell",
                "DesecratedWater",
                "DuststormInABottle",
                "FrostcrushValari",
                "Hypothermia",
                "Kylie",
                "Lionfish",
                "Penumbra",
                "RadiantStar",
                "ScarletDevil",
                "SeafoamBomb",
                "SealedSingularity",
                "SlickCane",
                "StarofDestruction",
                "StormfrontRazor",
                "Supernova",
                "TimeBolt",
                "Turbulance",
                "AncientIceChunk",
                "CadaverousCarrion",
                "Cosmilamp",
                "ResurrectionButterfly",
                "SarosPossession",
                "Heresy",
                "RainbowPartyCannon",
                "Rancor",
                "AetherfluxCannon",
                "PhosphorescentGauntlet",
                "Violence",
                "FleshOfInfidelity",
                "Perdition",
                "WaveSkipper",
                "SearedPan",
                "OccultSkullCrown",
                "GloriousEnd",
                "ArtAttack",
                "ScorchedEarth",
                "UrchinMace",
                "FaultLine",
                "GenesisPickaxe",
                "ReedBlowgun",
                "HadalUrn",
                "WulfrumScrewdriver",
                "Effervescence",
                "TheAnomalysNanogun",
                "EnchantedConch",
                "SmokingComet",
                "Hydra",
                "FreedomStar",
                "SanctifiedSpark",
                "PermafrostsConcoction",
                "Sacrifice",
                "GodsParanoia",
                "Malevolence",
            };
            List<int> types = new List<int>();
            
            if (ModsCall.Calamity != null)
            {
                types.AddRange(items.Select(itemName => ModContent.Find<ModItem>("CalamityMod", itemName).Type));
            }

            return types;
        }
        
    }

    public List<int> Neuter
    {
        get
        {
            string[] items =
            {
                "AbyssalDivingGear",
                "AbyssalMirror",
                "AncientFossil",
                "AnechoicPlating",
                "BlazingCore",
                "BloodflareCore",
                "CoreOfTheBloodGod",
                "DarkSunRing",
                "DraedonsHeart",
                "EclipseMirror",
                "EyeoftheStorm",
                "HarpyRing",
                "HeartofDarkness",
                "HowlsHeart",
                "LifeJelly",
                "ManaJelly",
                "MirageMirror",
                "NebulousCore",
                "NecklaceofVexation",
                "ReaperToothNecklace",
                "AquaticHeart",
                "StarbusterCore",
                "StatisBlessing",
                "StatisCurse",
                "TheAmalgam",
                "TheCommunity",
                "ToxicHeart",
                "VitalJelly",
                "VoltaicJelly",
                "BurningSea",
                "DivineRetribution",
                "EyeofMagnus",
                "FatesReveal",
                "ForbiddenSun",
                "Keelhaul",
                "LightGodsBrilliance",
                "MagneticMeltdown",
                "AnahitasArpeggio",
                "UndinesRetribution",
                "Brimlance",
                "Devastation",
                "DevilsDevastation",
                "DraconicDestruction",
                "VulcaniteLance",
                "GoldplumeSpear",
                "LionHeart",
                "MarniteSpear",
                "RedSun",
                "ElementalLance",
                "StarnightLance",
                "StellarContempt",
                "TerraLance",
                "Oblivion",
                "Tumbleweed",
                "RedtideSpear",
                "Riptide",
                "AcesHigh",
                "Alluvion",
                "AstrealDefeat",
                "HavocsBreath",
                "CleansingBlaze",
                "DaemonsFlame",
                "DragonsBreath",
                "ElementalEruption",
                "PlanetaryAnnihilation",
                "SeasSearing",
                "BouncingEyeball",
                "EclipsesFall",
                "Equanimity",
                "IchorSpear",
                "Wrathwing",
                "ShatteredSun",
                "SpearofDestiny",
                "SpearofPaleolith",
                "Valediction",
                "GammaHeart",
                "IgneousExaltation",
                "FlamsteedRing",
                "WarbanneroftheSun",
                "SandSharkToothNecklace",
                "ShatteredCommunity",
                "RemsRevenge",
                "Calamity",
                "UnstableGraniteCore",
                "UniversalGenesis",
                "RedtideSpear",
                "HeartoftheElements",
                "DeathsAscension",
                "Vigilance",
                "HellionFlowerSpear",
            };
            List<int> types = new List<int>();
            
            if (ModsCall.Calamity != null)
            {
                types.AddRange(items.Select(itemName => ModContent.Find<ModItem>("CalamityMod", itemName).Type));
            }

            return types;
        }
    }

    public List<int> Plural
    {
        get
        {
            string[] items =
            {
                "AngelTreads",
                "DarkGodsSheath",
                "IronBoots",
                "SilencingSheath",
                "StressPills",
                "Popo",
                "CelestialTracers",
                "DrewsWings",
                "ElysianTracers",
                "ElysianWings",
                "HadarianWings",
                "SeraphTracers",
                "SilvaWings",
                "SkylineWings",
                "StarlightWings",
                "TarragonWings",
                "SnakeEyes",
                "Miasma",
                "ShiftingSands",
                "SlitheringEels",
                "TearsofHeaven",
                "Tradewinds",
                "Viscera",
                "EmpyreanKnives",
                "MantisClaws",
                "MonstrousKnives",
                "MycelialClaws",
                "IllustriousKnives",
                "TenebreusTides",
                "TheBurningSky",
                "JawsOfOblivion",
                "LeviathanTeeth",
                "SkyfinBombers",
                "TerrorTalons",
                "TotalityBreakers",
                "FleshOfInfidelity",
                "FlowersOfMortality",
                "GlacialEmbrace",
            };
            List<int> types = new List<int>();
            
            if (ModsCall.Calamity != null)
            {
                types.AddRange(items.Select(itemName => ModContent.Find<ModItem>("CalamityMod", itemName).Type));
            }

            return types;
        }
    }
}

public class CalamityItemsCreator : IItemGenderCreator
{
    public IItemGender Create()
    {
        return new CalamityItems();
    }
}

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
            };
        
            List<int> types = new List<int>();
            if (ModsCall.FargoSouls != null)
            {
                types.AddRange(items.Select(itemName => ModContent.Find<ModItem>("FargowiltasSouls", itemName).Type));
            }
            return types;
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
        };
        
        List<int> types = new List<int>();
        if (ModsCall.FargoSouls != null)
        {
            types.AddRange(items.Select(itemName => ModContent.Find<ModItem>("FargowiltasSouls", itemName).Type));
        }
        return types;
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
            };
        
            List<int> types = new List<int>();
            if (ModsCall.FargoSouls != null)
            {
                types.AddRange(items.Select(itemName => ModContent.Find<ModItem>("FargowiltasSouls", itemName).Type));
            }
            return types;
        }
    }
}

public class FargoSoulsItemsCreator : IItemGenderCreator
{
    public IItemGender Create()
    {
        return new FargoSoulsItems();
    }
}

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
        
            List<int> types = new List<int>();
            if (ModsCall.Calamity != null && ModsCall.Infernum != null)
            {
                types.AddRange(items.Select(itemName => ModContent.Find<ModItem>("InfernumMode", itemName).Type));
            }
            return types;
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
        
            List<int> types = new List<int>();
            if (ModsCall.Calamity != null && ModsCall.Infernum != null)
            {
                types.AddRange(items.Select(itemName => ModContent.Find<ModItem>("InfernumMode", itemName).Type));
            }
            return types;
        }
    }
    
    public List<int> Plural { get; } = new();
}

public class InfernumModeItemsCreator : IItemGenderCreator
{
    public IItemGender Create()
    {
        return new InfernumModeItems();
    }
}

public class PrefixOverhaul
{
    private List<int> _feminine = new();
    private List<int> _neuter = new();
    private List<int> _plural = new();

    //Мужской, Женский, Средний, Множественный
    public readonly string[][] Prefixes =
    {
        new [] {"Тупой", "Тупая", "Тупое", "Тупые"},
        new [] {"Несчастный", "Несчастная", "Несчастное", "Несчастные"},
        new [] {"Громоздкий", "Громоздкая", "Громоздкое", "Громоздкие"},
        new [] {"Позорный", "Позорная", "Позорное", "Позорные"},
        new [] {"Тяжёлый", "Тяжёлая", "Тяжёлое", "Тяжёлые"},
        new [] {"Лёгкий", "Лёгкая", "Лёгкое", "Лёгкие"},
        new [] {"Прицельный", "Прицельная", "Прицельное", "Прицельные"},
        new [] {"Скоростной", "Скоростная", "Скоростное", "Скоростные"},
        new [] {"Стремительный", "Стремительная", "Стремительное", "Стремительные"},
        new [] {"Пугающий", "Пугающая", "Пугающее", "Пугающие"},
        new [] {"Смертоносный", "Смертоносная", "Смертоносное", "Смертоносные"},
        new [] {"Стойкий", "Стойкая", "Стойкое", "Стойкие"},
        new [] {"Отвратительный", "Отвратительная", "Отвратительное", "Отвратительные"},
        new [] {"Замедленный", "Замедленная", "Замедленное", "Замедленные"},
        new [] {"Неуклюжий", "Неуклюжая", "Неуклюжее", "Неуклюжие"},
        new [] {"Мощный", "Мощная", "Мощное", "Мощные"},
        new [] {"Мистический", "Мистическая", "Мистическое", "Мистические"},
        new [] {"Искусный", "Искусная", "Искусное", "Искусные"},
        new [] {"Мастерский", "Мастерская", "Мастерское", "Мастерские"},
        new [] {"Неумелый", "Неумелая", "Неумелое", "Неумелые"},
        new [] {"Массивный", "Массивная", "Массивное", "Массивные"},
        new [] {"Неотёсанный", "Неотёсанная", "Неотёсанное", "Неотёсанные"},
        new [] {"Сумасшедший", "Сумасшедшая", "Сумасшедшее", "Сумасшедшие"},
        new [] {"Интенсивный", "Интенсивная", "Интенсивное", "Интенсивные"},
        new [] {"Запретный", "Запретная", "Запретное", "Запретные"},
        new [] {"Неземной", "Неземная", "Неземное", "Неземные"},
        new [] {"Яростный", "Яростная", "Яростное", "Яростные"},
        new [] {"Заточенный", "Заточенная", "Заточенное", "Заточенные"},
        new [] {"Превосходный", "Превосходная", "Превосходное", "Превосходные"},
        new [] {"Сильный", "Сильная", "Сильное", "Сильные"},
        new [] {"Сломанный", "Сломанная", "Сломанное", "Сломанные"},
        new [] {"Опасный", "Опасная", "Опасное", "Опасные"},
        new [] {"Повреждённый", "Повреждённая", "Повреждённое", "Повреждённые"},
        new [] {"Дрянной", "Дрянная", "Дрянное", "Дрянные"},
        new [] {"Быстрый", "Быстрая", "Быстрое", "Быстрые"},
        new [] {"Проворный", "Проворная", "Проворное", "Проворные"},
        new [] {"Шустрый", "Шустрая", "Шустрое", "Шустрые"},
        new [] {"Убийственный", "Убийственная", "Убийственное", "Убийственные"},
        new [] {"Медленный", "Медленная", "Медленное", "Медленные"},
        new [] {"Вялый", "Вялая", "Вялое", "Вялые"},
        new [] {"Ленивый", "Ленивая", "Ленивое", "Ленивые"},
        new [] {"Свирепый", "Свирепая", "Свирепое", "Свирепые"},
        new [] {"Досаждающий", "Досаждающая", "Досаждающее", "Досаждающие"},
        new [] {"Мерзкий", "Мерзкая", "Мерзкое", "Мерзкие"},
        new [] {"Маниакальный", "Маниакальная", "Маниакальное", "Маниакальные"},
        new [] {"Пагубный", "Пагубная", "Пагубное", "Пагубные"},
        new [] {"Крепкий", "Крепкая", "Крепкое", "Крепкие"},
        new [] {"Неприятный", "Неприятная", "Неприятное", "Неприятные"},
        new [] {"Слабый", "Слабая", "Слабое", "Слабые"},
        new [] {"Безжалостный", "Безжалостная", "Безжалостное", "Безжалостные"},
        new [] {"Бешеный", "Бешеная", "Бешеное", "Бешеные"},
        new [] {"Божественный", "Божественная", "Божественное", "Божественные"},
        new [] {"Острый", "Острая", "Острое", "Острые"},
        new [] {"Демонический", "Демоническая", "Демоническое", "Демонические"},
        new [] {"Страстный", "Страстная", "Страстное", "Страстные"},
        new [] {"Жёсткий", "Жёсткая", "Жёсткое", "Жёсткие"},
        new [] {"Защитный", "Защитная", "Защитное", "Защитные"},
        new [] {"Бронированный", "Бронированная", "Бронированное", "Бронированные"},
        new [] {"Охранный", "Охранная", "Охранное", "Охранные"},
        new [] {"Загадочный", "Загадочная", "Загадочное", "Загадочные"},
        new [] {"Точный", "Точная", "Точное", "Точные"},
        new [] {"Везучий", "Везучая", "Везучее", "Везучие"},
        new [] {"Зазубренный", "Зазубренная", "Зазубренное", "Зазубренные"},
        new [] {"Заострённый", "Заострённая", "Заострённое", "Заострённые"},
        new [] {"Шипованный", "Шипованная", "Шипованное", "Шипованные"},
        new [] {"Злящий", "Злящая", "Злящее", "Злящие"},
        new [] {"Грозный", "Грозная", "Грозное", "Грозные"},
        new [] {"Юркий", "Юркая", "Юркое", "Юркие"},
        new [] {"Порывистый", "Порывистая", "Порывистое", "Порывистые"},
        new [] {"Дикий", "Дикая", "Дикое", "Дикие"},
        new [] {"Опрометчивый", "Опрометчивая", "Опрометчивое", "Опрометчивые"},
        new [] {"Бесстрашный", "Бесстрашная", "Бесстрашное", "Бесстрашные"},
        new [] {"Крохотный", "Крохотная", "Крохотное", "Крохотные"},
        new [] {"Жестокий", "Жестокая", "Жестокое", "Жестокие"},
        new [] {"Легендарный", "Легендарная", "Легендарное", "Легендарные"},
        new [] {"Нереальный", "Нереальная", "Нереальное", "Нереальные"},
        new [] {"Мифический", "Мифическая", "Мифическое", "Мифические"},
        new [] {"Ужасный", "Ужасная", "Ужасное", "Ужасные"},
        new [] {"Маленький", "Маленькая", "Маленькое", "Маленькие"},
        new [] {"Стабилизированный", "Стабилизированная", "Стабилизированное", "Стабилизированные"},
        new [] {"Обтекаемый", "Обтекаемая", "Обтекаемое", "Обтекаемые"},
        new [] {"Увесистый", "Увесистая", "Увесистое", "Увесистые"},
        new [] {"Могучий", "Могучая", "Могучее", "Могучие"},
        new [] {"Выдающийся", "Выдающаяся", "Выдающееся", "Выдающиеся"},
        new [] {"Зубчатый", "Зубчатая", "Зубчатое", "Зубчатые"},
        new [] {"Убойный", "Убойная", "Убойное", "Убойные"},
        new [] {"Безупречный", "Безупречная", "Безупречное", "Безупречные"},
        new [] {"Радикальный", "Радикальная", "Радикальное", "Радикальные"},
        new [] {"Грубый", "Грубая", "Грубое", "Грубые"},
        new [] {"Хрупкий", "Хрупкая", "Хрупкое", "Хрупкие"},
        new [] {"Несбалансированный", "Несбалансированная", "Несбалансированное", "Несбалансированные"},
        new [] {"Кошмарный", "Кошмарная", "Кошмарное", "Кошмарные"},
        new [] {"Тихий", "Тихая", "Тихое", "Тихие"},
        new [] {"Скрытый", "Скрытая", "Скрытое", "Скрытые"},
        new [] {"Замаскированный", "Замаскированная", "Замаскированное", "Замаскированные"},
        new [] {"Безмолвный", "Безмолвная", "Безмолвное", "Безмолвные"},
        new [] {"Негодующий", "Негодующая", "Негодующее", "Негодующие"},
        new [] {"Горящий", "Горящая", "Горящее", "Горящие"},
        new [] {"Жертвенный", "Жертвенная", "Жертвенное", "Жертвенные"},
        new [] {"Злопамятный", "Злопамятная", "Злопамятное", "Злопамятные"},
        new [] {"Жаждущий", "Жаждущая", "Жаждущее", "Жаждущие"},
        new [] {"Эфемерный", "Эфемерная", "Эфемерное", "Эфемерные"},
        new [] {"Адский", "Адская", "Адское", "Адские"},
        new [] {"Порченный", "Порченная", "Порченное", "Порченные"},
        new [] {"Предательский", "Предательская", "Предательское", "Предательские"},
        new [] {"Иссушающий", "Иссушающая", "Иссушающее", "Иссушающие"},
        new [] {"Гонимый", "Гонимая", "Гонимое", "Гонимые"},
        new [] {"Блудливый", "Блудливая", "Блудливое", "Блудливые"}
    };

    public string GetGenderedPrefix(string[] prefix, int item)
    {
        Load();
        
        if (_feminine.Contains(item))
            return prefix[1];

        if (_neuter.Contains(item))
            return prefix[2];

        if (_plural.Contains(item))
            return prefix[3];

        return prefix[0];
    }
    
    private void Load()
    {

        VanillaItemsCreator vanilla = new VanillaItemsCreator();
        IItemGender vanillaItems = vanilla.Create();

        _feminine.AddRange(vanillaItems.Feminine);
        _neuter.AddRange(vanillaItems.Neuter);
        _plural.AddRange(vanillaItems.Plural);

        if (ModsCall.Calamity != null)
        {
            CalamityItemsCreator calamity = new CalamityItemsCreator();
            IItemGender calamityItems = calamity.Create();
            
            _feminine.AddRange(calamityItems.Feminine);
            _neuter.AddRange(calamityItems.Neuter);
            _plural.AddRange(calamityItems.Plural);

            if (ModsCall.Infernum != null)
            {
                InfernumModeItemsCreator infernum = new InfernumModeItemsCreator();
                IItemGender infernumItems = infernum.Create();
                
                _feminine.AddRange(infernumItems.Feminine);
                _neuter.AddRange(infernumItems.Neuter);
                _plural.AddRange(infernumItems.Plural);
            }
        }

        if (ModsCall.FargoSouls != null)
        {
            FargoSoulsItemsCreator fargoSouls = new FargoSoulsItemsCreator();
            IItemGender fargoSoulsItems = fargoSouls.Create();
            
            _feminine.AddRange(fargoSoulsItems.Feminine);
            _neuter.AddRange(fargoSoulsItems.Neuter);
            _plural.AddRange(fargoSoulsItems.Plural);
        }
    }
}
