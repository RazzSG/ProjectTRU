using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
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
                TranslationHelper.WikithisRedirect("BloodOrange", "Кровавый апельсин (calamity)");
                TranslationHelper.WikithisRedirect("Elderberry", "Бузина (calamity)");
                TranslationHelper.WikithisRedirect("PineapplePet", "Ананас (calamity)");
                TranslationHelper.WikithisRedirect("TrashmanTrashcan", "Урна (питомец)");
                TranslationHelper.WikithisRedirect("Butcher", "Мясник (оружие)");
                TranslationHelper.WikithisRedirect("SandstormGun", "Песчаная буря (оружие)");
                TranslationHelper.WikithisRedirect("Thunderstorm", "Гроза (оружие)");
                TranslationHelper.WikithisRedirect("AtlasMunitionsBeacon", "Маячок установки Атлас");
                TranslationHelper.WikithisRedirect(
                ["LoreAstralInfection", "LoreAbyss", "LoreAquaticScourge", "LoreArchmage", "LoreAstrumAureus",
                    "LoreAstrumDeus", "LoreAwakening", "LoreAzafure", "LoreBloodMoon", "LoreBrainofCthulhu",
                    "LoreBrimstoneElemental", "LoreCalamitas", "LoreCalamitasClone", "LoreCeaselessVoid",
                    "LoreCorruption", "LoreCrabulon", "LoreCrimson", "LoreCynosure", "LoreDesertScourge",
                    "LoreDestroyer", "LoreDevourerofGods", "LoreDragonfolly", "LoreDukeFishron", "LoreEaterofWorlds",
                    "LoreEmpressofLight", "LoreExoMechs", "LoreEyeofCthulhu", "LoreGolem", "LoreHiveMind",
                    "LoreKingSlime", "LoreLeviathanAnahita", "LoreMechs", "LoreOldDuke", "LorePerforators",
                    "LorePlaguebringerGoliath", "LorePlantera", "LorePolterghast", "LorePrelude", "LoreProfanedGuardians",
                    "LoreProvidence", "LoreQueenBee", "LoreQueenSlime", "LoreRavager", "LoreRequiem",
                    "LoreSignus", "LoreSkeletron", "LoreSkeletronPrime", "LoreSlimeGod", "LoreStormWeaver",
                    "LoreSulphurSea", "LoreTwins", "LoreUnderworld", "LoreWallofFlesh", "LoreYharon"], "История#Предметы_истории");
                TranslationHelper.WikithisRedirect("HiveEnemy", "Улей (враг)", false);
                TranslationHelper.WikithisRedirect("KingSlimeJewelRuby", "Драгоценности Короля слизней", false);
                TranslationHelper.WikithisRedirect("KingSlimeJewelSapphire", "Драгоценности Короля слизней", false);
                TranslationHelper.WikithisRedirect("KingSlimeJewelEmerald", "Драгоценности Короля слизней", false);
                TranslationHelper.WikithisRedirect("OldDukeToothBall", "Зубастый шар (Старый герцог)", false);
                TranslationHelper.WikithisRedirect("CalamitasEnchantDemon", "Зачарование", false);
                TranslationHelper.WikithisRedirect("LeviathanStart", "%3F%3F%3F", false);

            }
        }
    }
}