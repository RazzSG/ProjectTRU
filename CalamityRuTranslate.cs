using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate;

public class CalamityRuTranslate : Mod
{
    public static CalamityRuTranslate Instance;

    public CalamityRuTranslate()
    {
        Instance = this;
        PreJITFilter = new DisableJIT();
    }

    public override void Unload()
    {
        Instance = null;
        TRuConfig.Instance = null;
    }

    public override void PostSetupContent()
    {
        if (TRuConfig.Instance.WikithisInfo && ModInstances.Wikithis != null && !Main.dedServ)
        {
            if (ModInstances.Calamity != null)
            {
                ModInstances.Wikithis.Call("AddModURL", ModInstances.Calamity, "https://calamitymod.wiki.gg/ru/wiki/{}", GameCulture.CultureName.Russian);
                TranslationHelper.WikithisRedirectItem("BloodOrange", "Кровавый апельсин (calamity)");
                TranslationHelper.WikithisRedirectItem("Elderberry", "Бузина (calamity)");
                TranslationHelper.WikithisRedirectItem("PineapplePet", "Ананас (calamity)");
                TranslationHelper.WikithisRedirectItem("TrashmanTrashcan", "Урна (питомец)");
                TranslationHelper.WikithisRedirectItem("Butcher", "Мясник (оружие)");
                TranslationHelper.WikithisRedirectItem("SandstormGun", "Песчаная буря (оружие)");
                TranslationHelper.WikithisRedirectItem("Thunderstorm", "Гроза (оружие)");
                TranslationHelper.WikithisRedirectItem("AtlasMunitionsBeacon", "Маячок установки Атлас");
                TranslationHelper.WikithisRedirectItem(new []
                {
                    "LoreAstralInfection", "LoreAbyss", "LoreAquaticScourge", "LoreArchmage", "LoreAstrumAureus",
                    "LoreAstrumDeus", "LoreAwakening", "LoreAzafure", "LoreBloodMoon", "LoreBrainofCthulhu",
                    "LoreBrimstoneElemental", "LoreCalamitas", "LoreCalamitasClone", "LoreCeaselessVoid",
                    "LoreCorruption", "LoreCrabulon", "LoreCrimson", "LoreCynosure", "LoreDesertScourge",
                    "LoreDestroyer", "LoreDevourerofGods", "LoreDragonfolly", "LoreDukeFishron", "LoreEaterofWorlds",
                    "LoreEmpressofLight", "LoreExoMechs", "LoreEyeofCthulhu", "LoreGolem", "LoreHiveMind",
                    "LoreKingSlime", "LoreLeviathanAnahita", "LoreMechs", "LoreOldDuke", "LorePerforators",
                    "LorePlaguebringerGoliath", "LorePlantera", "LorePolterghast", "LorePrelude", "LoreProfanedGuardians",
                    "LoreProvidence", "LoreQueenBee", "LoreQueenSlime", "LoreRavager", "LoreRequiem",
                    "LoreSignus", "LoreSkeletron", "LoreSkeletronPrime", "LoreSlimeGod", "LoreStormWeaver",
                    "LoreSulphurSea", "LoreTwins", "LoreUnderworld", "LoreWallofFlesh", "LoreYharon"
                }, "История#Предметы_истории");
                TranslationHelper.WikithisRedirectNPC("HiveEnemy", "Улей (враг)");
                TranslationHelper.WikithisRedirectNPC("KingSlimeJewelRuby", "Королевские драгоценности");
                TranslationHelper.WikithisRedirectNPC("KingSlimeJewelSapphire", "Королевские драгоценности");
                TranslationHelper.WikithisRedirectNPC("KingSlimeJewelEmerald", "Королевские драгоценности");
                TranslationHelper.WikithisRedirectNPC("OldDukeToothBall", "Зубастый шар (Старый герцог)");
                TranslationHelper.WikithisRedirectNPC("CalamitasEnchantDemon", "Зачарование");
                TranslationHelper.WikithisRedirectNPC("LeviathanStart", "%3F%3F%3F");

            }
        }
    }
}