using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Core.ArmorSetBonusPreview;

public class ArmorSetBonusPreviewSystem : ModSystem
{
    public static Dictionary<int, string> ArmorSetBonuses;

    public override bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public override void OnModLoad()
    {
        ArmorSetBonuses = new();
    }

    public override void OnModUnload()
    {
        ArmorSetBonuses?.Clear();
        ArmorSetBonuses = null;
    }

    public override void OnLocalizationsLoaded()
    {
        AddVanillaArmorSetBonuses();
        AddCalamityArmorSetBonuses();
        AddFargoSoulsArmorSetBonuses();
        AddThoriumArmorSetBonuses();
        AddStarsAboveSetBonuses();
    }

    private void AddVanillaArmorSetBonuses()
    {
        ArmorSetBonuses[ItemID.ShroomiteHeadgear] = Language.GetTextValue("ArmorSetBonus.Shroomite");
        ArmorSetBonuses[ItemID.ShroomiteMask] = Language.GetTextValue("ArmorSetBonus.Shroomite");
        ArmorSetBonuses[ItemID.ShroomiteHelmet] = Language.GetTextValue("ArmorSetBonus.Shroomite");
        ArmorSetBonuses[ItemID.WoodHelmet] = Language.GetTextValue("ArmorSetBonus.Wood");
        ArmorSetBonuses[ItemID.EbonwoodHelmet] = Language.GetTextValue("ArmorSetBonus.Wood");
        ArmorSetBonuses[ItemID.RichMahoganyHelmet] = Language.GetTextValue("ArmorSetBonus.Wood");
        ArmorSetBonuses[ItemID.PearlwoodHelmet] = Language.GetTextValue("ArmorSetBonus.Wood");
        ArmorSetBonuses[ItemID.ShadewoodHelmet] = Language.GetTextValue("ArmorSetBonus.Wood");
        ArmorSetBonuses[ItemID.BorealWoodHelmet] = Language.GetTextValue("ArmorSetBonus.Wood");
        ArmorSetBonuses[ItemID.PalmWoodHelmet] = Language.GetTextValue("ArmorSetBonus.Wood");
        ArmorSetBonuses[ItemID.AshWoodHelmet] = Language.GetTextValue("ArmorSetBonus.AshWood");
        ArmorSetBonuses[ItemID.CopperHelmet] = Language.GetTextValue("ArmorSetBonus.MetalTier1");
        ArmorSetBonuses[ItemID.AncientIronHelmet] = Language.GetTextValue("ArmorSetBonus.MetalTier1");
        ArmorSetBonuses[ItemID.IronHelmet] = Language.GetTextValue("ArmorSetBonus.MetalTier1");
        ArmorSetBonuses[ItemID.TinHelmet] = Language.GetTextValue("ArmorSetBonus.MetalTier1");
        ArmorSetBonuses[ItemID.SilverHelmet] = Language.GetTextValue("ArmorSetBonus.MetalTier2");
        ArmorSetBonuses[ItemID.AncientGoldHelmet] = Language.GetTextValue("ArmorSetBonus.MetalTier2");
        ArmorSetBonuses[ItemID.LeadHelmet] = Language.GetTextValue("ArmorSetBonus.MetalTier2");
        ArmorSetBonuses[ItemID.TungstenHelmet] = Language.GetTextValue("ArmorSetBonus.MetalTier2");
        ArmorSetBonuses[ItemID.PlatinumHelmet] = Language.GetTextValue("ArmorSetBonus.Platinum");
        ArmorSetBonuses[ItemID.PumpkinHelmet] = Language.GetTextValue("ArmorSetBonus.Pumpkin");
        ArmorSetBonuses[ItemID.GladiatorHelmet] = Language.GetTextValue("ArmorSetBonus.Gladiator");
        ArmorSetBonuses[ItemID.NinjaHood] = Language.GetTextValue("ArmorSetBonus.Ninja");
        ArmorSetBonuses[ItemID.FossilHelm] = Language.GetTextValue("ArmorSetBonus.Fossil");
        ArmorSetBonuses[ItemID.AncientNecroHelmet] = Language.GetTextValue("ArmorSetBonus.Bone");
        ArmorSetBonuses[ItemID.NecroHelmet] = Language.GetTextValue("ArmorSetBonus.Bone");
        ArmorSetBonuses[ItemID.BeetleHelmet] = $"Если надета {Language.GetTextValue("ItemName.BeetleScaleMail")}: {Language.GetTextValue("ArmorSetBonus.BeetleDamage")}\nЕсли надет {Language.GetTextValue("ItemName.BeetleShell")}: {Language.GetTextValue("ArmorSetBonus.BeetleDefense")}";
        ArmorSetBonuses[ItemID.WizardHat] = Language.GetTextValue("ArmorSetBonus.Wizard");
        ArmorSetBonuses[ItemID.MagicHat] = Language.GetTextValue("ArmorSetBonus.MagicHat");
        ArmorSetBonuses[ItemID.ShadowHelmet] = Language.GetTextValue("ArmorSetBonus.ShadowScale");
        ArmorSetBonuses[ItemID.AncientShadowHelmet] = Language.GetTextValue("ArmorSetBonus.ShadowScale");
        ArmorSetBonuses[ItemID.CrimsonHelmet] = Language.GetTextValue("ArmorSetBonus.Crimson");
        ArmorSetBonuses[ItemID.SpectreHood] = Language.GetTextValue("ArmorSetBonus.SpectreHealing");
        ArmorSetBonuses[ItemID.SpectreMask] = Language.GetTextValue("ArmorSetBonus.SpectreDamage");
        ArmorSetBonuses[ItemID.MeteorHelmet] = Language.GetTextValue("ArmorSetBonus.Meteor");
        ArmorSetBonuses[ItemID.FrostHelmet] = Language.GetTextValue("ArmorSetBonus.Frost");
        ArmorSetBonuses[ItemID.AncientCobaltHelmet] = Language.GetTextValue("ArmorSetBonus.Jungle");
        ArmorSetBonuses[ItemID.JungleHat] = Language.GetTextValue("ArmorSetBonus.Jungle");
        ArmorSetBonuses[ItemID.MoltenHelmet] = Language.GetTextValue("ArmorSetBonus.Molten");
        ArmorSetBonuses[ItemID.EskimoHood] = Language.GetTextValue("ArmorSetBonus.Snow");
        ArmorSetBonuses[ItemID.PinkEskimoHood] = Language.GetTextValue("ArmorSetBonus.Snow");
        ArmorSetBonuses[ItemID.MiningHelmet] = Language.GetTextValue("ArmorSetBonus.Mining");
        ArmorSetBonuses[ItemID.UltrabrightHelmet] = Language.GetTextValue("ArmorSetBonus.Mining");
        ArmorSetBonuses[ItemID.ChlorophyteMask] = Language.GetTextValue("ArmorSetBonus.ChlorophyteMelee");
        ArmorSetBonuses[ItemID.ChlorophyteHelmet] = Language.GetTextValue("ArmorSetBonus.Chlorophyte");
        ArmorSetBonuses[ItemID.ChlorophyteHeadgear] = Language.GetTextValue("ArmorSetBonus.Chlorophyte");
        ArmorSetBonuses[ItemID.AnglerHat] = Language.GetTextValue("ArmorSetBonus.Angler");
        ArmorSetBonuses[ItemID.CactusHelmet] = Language.GetTextValue("ArmorSetBonus.Cactus");
        ArmorSetBonuses[ItemID.TurtleHelmet] = Language.GetTextValue("ArmorSetBonus.Turtle");
        ArmorSetBonuses[ItemID.CobaltHat] = Language.GetTextValue("ArmorSetBonus.CobaltCaster");
        ArmorSetBonuses[ItemID.CobaltHelmet] = Language.GetTextValue("ArmorSetBonus.CobaltMelee");
        ArmorSetBonuses[ItemID.CobaltMask] = Language.GetTextValue("ArmorSetBonus.CobaltRanged");
        ArmorSetBonuses[ItemID.MythrilHood] = Language.GetTextValue("ArmorSetBonus.MythrilCaster");
        ArmorSetBonuses[ItemID.MythrilHelmet] = Language.GetTextValue("ArmorSetBonus.MythrilMelee");
        ArmorSetBonuses[ItemID.MythrilHat] = Language.GetTextValue("ArmorSetBonus.MythrilRanged");
        ArmorSetBonuses[ItemID.AdamantiteHeadgear] = Language.GetTextValue("ArmorSetBonus.AdamantiteCaster");
        ArmorSetBonuses[ItemID.AdamantiteHelmet] = Language.GetTextValue("ArmorSetBonus.AdamantiteMelee");
        ArmorSetBonuses[ItemID.AdamantiteMask] = Language.GetTextValue("ArmorSetBonus.AdamantiteRanged");
        ArmorSetBonuses[ItemID.PalladiumMask] = Language.GetTextValue("ArmorSetBonus.Palladium");
        ArmorSetBonuses[ItemID.PalladiumHelmet] = Language.GetTextValue("ArmorSetBonus.Palladium");
        ArmorSetBonuses[ItemID.PalladiumHeadgear] = Language.GetTextValue("ArmorSetBonus.Palladium");
        ArmorSetBonuses[ItemID.OrichalcumMask] = Language.GetTextValue("ArmorSetBonus.Orichalcum");
        ArmorSetBonuses[ItemID.OrichalcumHelmet] = Language.GetTextValue("ArmorSetBonus.Orichalcum");
        ArmorSetBonuses[ItemID.OrichalcumHeadgear] = Language.GetTextValue("ArmorSetBonus.Orichalcum");
        ArmorSetBonuses[ItemID.TitaniumHeadgear] = Language.GetTextValue("ArmorSetBonus.Titanium");
        ArmorSetBonuses[ItemID.TitaniumMask] = Language.GetTextValue("ArmorSetBonus.Titanium");
        ArmorSetBonuses[ItemID.TitaniumHelmet] = Language.GetTextValue("ArmorSetBonus.Titanium");
        ArmorSetBonuses[ItemID.HallowedHeadgear] = Language.GetTextValue("ArmorSetBonus.Hallowed");
        ArmorSetBonuses[ItemID.HallowedHelmet] = Language.GetTextValue("ArmorSetBonus.Hallowed");
        ArmorSetBonuses[ItemID.HallowedMask] = Language.GetTextValue("ArmorSetBonus.Hallowed");
        ArmorSetBonuses[ItemID.HallowedHood] = Language.GetTextValue("ArmorSetBonus.HallowedSummoner");
        ArmorSetBonuses[ItemID.AncientHallowedHeadgear] = Language.GetTextValue("ArmorSetBonus.Hallowed");
        ArmorSetBonuses[ItemID.AncientHallowedHelmet] = Language.GetTextValue("ArmorSetBonus.Hallowed");
        ArmorSetBonuses[ItemID.AncientHallowedMask] = Language.GetTextValue("ArmorSetBonus.Hallowed");
        ArmorSetBonuses[ItemID.AncientHallowedHood] = Language.GetTextValue("ArmorSetBonus.HallowedSummoner");
        ArmorSetBonuses[ItemID.CrystalNinjaHelmet] = Language.GetTextValue("ArmorSetBonus.CrystalNinja");
        ArmorSetBonuses[ItemID.TikiMask] = Language.GetTextValue("ArmorSetBonus.Tiki");
        ArmorSetBonuses[ItemID.SpookyHelmet] = Language.GetTextValue("ArmorSetBonus.Spooky");
        ArmorSetBonuses[ItemID.BeeHeadgear] = Language.GetTextValue("ArmorSetBonus.Bee");
        ArmorSetBonuses[ItemID.SpiderMask] = Language.GetTextValue("ArmorSetBonus.Spider");
        ArmorSetBonuses[ItemID.SolarFlareHelmet] = Language.GetTextValue("ArmorSetBonus.Solar");
        ArmorSetBonuses[ItemID.VortexHelmet] = Language.GetTextValue("ArmorSetBonus.Vortex", Language.GetTextValue(Main.ReversedUpDownArmorSetBonuses ? "Key.UP" : "Key.DOWN"));
        ArmorSetBonuses[ItemID.NebulaHelmet] = Language.GetTextValue("ArmorSetBonus.Nebula");
        ArmorSetBonuses[ItemID.StardustHelmet] = Language.GetTextValue("ArmorSetBonus.Stardust", Language.GetTextValue(Main.ReversedUpDownArmorSetBonuses ? "Key.UP" : "Key.DOWN"));
        ArmorSetBonuses[ItemID.AncientBattleArmorHat] = Language.GetTextValue("ArmorSetBonus.Forbidden", Language.GetTextValue(Main.ReversedUpDownArmorSetBonuses ? "Key.UP" : "Key.DOWN"));
        ArmorSetBonuses[ItemID.SquireGreatHelm] = Language.GetTextValue("ArmorSetBonus.SquireTier2");
        ArmorSetBonuses[ItemID.ApprenticeHat] = Language.GetTextValue("ArmorSetBonus.ApprenticeTier2");
        ArmorSetBonuses[ItemID.HuntressWig] = Language.GetTextValue("ArmorSetBonus.HuntressTier2");
        ArmorSetBonuses[ItemID.MonkBrows] = Language.GetTextValue("ArmorSetBonus.MonkTier2");
        ArmorSetBonuses[ItemID.SquireAltHead] = Language.GetTextValue("ArmorSetBonus.SquireTier3");
        ArmorSetBonuses[ItemID.ApprenticeAltHead] = Language.GetTextValue("ArmorSetBonus.ApprenticeTier3");
        ArmorSetBonuses[ItemID.HuntressAltHead] = Language.GetTextValue("ArmorSetBonus.HuntressTier3");
        ArmorSetBonuses[ItemID.MonkAltHead] = Language.GetTextValue("ArmorSetBonus.MonkTier3");
        ArmorSetBonuses[ItemID.ObsidianHelm] = Language.GetTextValue("ArmorSetBonus.ObsidianOutlaw");
    }

    private void AddCalamityArmorSetBonuses()
    {
        if (ModInstances.Calamity != null)
        {
            ArmorSetBonuses[ItemID.AdamantiteHeadgear] = $"{Language.GetTextValue("ArmorSetBonus.AdamantiteCaster")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Adamantite", 15)}";
            ArmorSetBonuses[ItemID.AdamantiteHelmet] = $"{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Adamantite.Melee")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Adamantite", 15)}";
            ArmorSetBonuses[ItemID.AdamantiteMask] = $"{Language.GetTextValue("ArmorSetBonus.AdamantiteRanged")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Adamantite", 15)}";
            ArmorSetBonuses[ItemID.CobaltHelmet] = $"{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Cobalt.Melee")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Cobalt", 10, 10)}";
            ArmorSetBonuses[ItemID.CobaltHat] = $"{Language.GetTextValue("ArmorSetBonus.CobaltCaster")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Cobalt", 10, 10)}";
            ArmorSetBonuses[ItemID.CobaltMask] = $"{Language.GetTextValue("ArmorSetBonus.CobaltRanged")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Cobalt", 10, 10)}";
            ArmorSetBonuses[ItemID.MythrilHelmet] = $"{Language.GetTextValue("ArmorSetBonus.MythrilMelee")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Mythril", 12)}";
            ArmorSetBonuses[ItemID.MythrilHood] = $"{Language.GetTextValue("ArmorSetBonus.MythrilCaster")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Mythril", 12)}";
            ArmorSetBonuses[ItemID.MythrilHat] = $"{Language.GetTextValue("ArmorSetBonus.MythrilRanged")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Mythril", 12)}";
            ArmorSetBonuses[ItemID.EskimoHood] = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Eskimo");
            ArmorSetBonuses[ItemID.PinkEskimoHood] = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Eskimo");
            ArmorSetBonuses[ItemID.ChlorophyteHeadgear] = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Chlorophyte", 5, 300, 10, 4.5);
            ArmorSetBonuses[ItemID.ChlorophyteMask] = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Chlorophyte", 5, 300, 10, 4.5);
            ArmorSetBonuses[ItemID.ChlorophyteHelmet] = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Chlorophyte", 5, 300, 10, 4.5);
            ArmorSetBonuses[ItemID.SpectreHood] = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.SpectreHealing");
            ArmorSetBonuses[ItemID.MiningHelmet] = $"{Language.GetText("ArmorSetBonus.Mining")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Mining")}";
            ArmorSetBonuses[ItemID.UltrabrightHelmet] = $"{Language.GetText("ArmorSetBonus.Mining")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Mining")}";
            ArmorSetBonuses[ItemID.MeteorHelmet] = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Meteor");
            ArmorSetBonuses[ItemID.CopperHelmet] = $"{Language.GetTextValue("ArmorSetBonus.MetalTier1")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Copper")}";
            ArmorSetBonuses[ItemID.TinHelmet] = $"{Language.GetTextValue("ArmorSetBonus.MetalTier1")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Tin")}";
            ArmorSetBonuses[ItemID.IronHelmet] = $"{Language.GetTextValue("ArmorSetBonus.MetalTier1")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Iron")}";
            ArmorSetBonuses[ItemID.AncientIronHelmet] = $"{Language.GetTextValue("ArmorSetBonus.MetalTier1")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Iron")}";
            ArmorSetBonuses[ItemID.LeadHelmet] = $"{Language.GetTextValue("ArmorSetBonus.MetalTier2")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Lead")}";
            ArmorSetBonuses[ItemID.SilverHelmet] = $"{Language.GetTextValue("ArmorSetBonus.MetalTier2")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Silver")}";
            ArmorSetBonuses[ItemID.TungstenHelmet] = $"{Language.GetTextValue("ArmorSetBonus.MetalTier2")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Tungsten", "[X]", "[Y]")}";
            ArmorSetBonuses[ItemID.GoldHelmet] = $"{Language.GetTextValue("ArmorSetBonus.MetalTier2")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Gold")}";
            ArmorSetBonuses[ItemID.AncientGoldHelmet] = $"{Language.GetTextValue("ArmorSetBonus.MetalTier2")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Gold")}";
            ArmorSetBonuses[ItemID.PlatinumHelmet] = $"{Language.GetTextValue("ArmorSetBonus.Platinum")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Platinum")}";
            ArmorSetBonuses[ItemID.MoltenHelmet] = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Molten");
            ArmorSetBonuses[ItemID.MonkBrows] = $"{Language.GetTextValue("ArmorSetBonus.MonkTier2")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.MonkTier2")}";
            ArmorSetBonuses[ItemID.SquireGreatHelm] = $"{Language.GetTextValue("ArmorSetBonus.SquireTier2")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.SquireTier2")}";
            ArmorSetBonuses[ItemID.HuntressWig] = $"{Language.GetTextValue("ArmorSetBonus.HuntressTier2")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.HuntressTier2")}";
            ArmorSetBonuses[ItemID.ApprenticeHat] = $"{Language.GetTextValue("ArmorSetBonus.ApprenticeTier2")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.ApprenticeTier2")}";
            ArmorSetBonuses[ItemID.MonkAltHead] = $"{Language.GetTextValue("ArmorSetBonus.MonkTier3")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.MonkTier3")}";
            ArmorSetBonuses[ItemID.SquireAltHead] = $"{Language.GetTextValue("ArmorSetBonus.SquireTier3")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.SquireTier3")}";
            ArmorSetBonuses[ItemID.HuntressAltHead] = $"{Language.GetTextValue("ArmorSetBonus.HuntressTier3")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.HuntressTier3")}";
            ArmorSetBonuses[ItemID.ApprenticeAltHead] = $"{Language.GetTextValue("ArmorSetBonus.ApprenticeTier3")}\nLanguage.GetTextValue(\"Mods.CalamityMod.Vanilla.Armor.SetBonus.ApprenticeTier3\")}}";
            ArmorSetBonuses[ItemID.GladiatorHelmet] = $"{Language.GetTextValue("ArmorSetBonus.Gladiator")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Gladiator")}";
            ArmorSetBonuses[ItemID.ObsidianHelm] = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Obsidian");
            ArmorSetBonuses[ItemID.AncientNecroHelmet] = $"{Language.GetTextValue("ArmorSetBonus.Bone")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Necro", 7)}";
            ArmorSetBonuses[ItemID.NecroHelmet] = $"{Language.GetTextValue("ArmorSetBonus.Bone")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Necro", 7)}";
            ArmorSetBonuses[ItemID.FrostHelmet] = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Frost", 15);
            ArmorSetBonuses[ItemID.CrystalNinjaHelmet] = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.CrystalAssassin");
            ArmorSetBonuses[ItemID.CrimsonHelmet] = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Crimson");
            ArmorSetBonuses[ItemID.JungleHat] = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Jungle");
            ArmorSetBonuses[ItemID.NebulaHelmet] = $"{Language.GetTextValue("ArmorSetBonus.Nebula")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Nebula")}";
            ArmorSetBonuses[ItemID.PalladiumMask] = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Palladium");
            ArmorSetBonuses[ItemID.PalladiumHelmet] = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Palladium");
            ArmorSetBonuses[ItemID.PalladiumHeadgear] = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Palladium");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/AstralHelm")] = TranslationHelper.GetTextValue("CalamityMod/AstralHelm", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/BrimflameScowl")] = TranslationHelper.GetTextValue("CalamityMod/BrimflameScowl", "SetBonus", "[Бонус комплекта брони]");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/DaedalusHeadMagic")] = TranslationHelper.GetTextValue("CalamityMod/DaedalusHeadMagic", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/DaedalusHeadMelee")] = TranslationHelper.GetTextValue("CalamityMod/DaedalusHeadMelee", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/DaedalusHeadRanged")] = TranslationHelper.GetTextValue("CalamityMod/DaedalusHeadRanged", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/DaedalusHeadRogue")] = TranslationHelper.GetTextValue("CalamityMod/DaedalusHeadRogue", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/DaedalusHeadSummon")] = TranslationHelper.GetTextValue("CalamityMod/DaedalusHeadSummon", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/FathomSwarmerVisage")] = TranslationHelper.GetTextValue("CalamityMod/FathomSwarmerVisage", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/ForbiddenCirclet")] = TranslationHelper.GetTextValue("CalamityMod/ForbiddenCirclet", "SetBonus", "[Бонус комплекта брони]", "[X]");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/LunicCorpsHelmet")] = TranslationHelper.GetTextValue("CalamityMod/LunicCorpsHelmet", "SetBonus", $"\n{TranslationHelper.GetTextValue("CalamityMod/LunicCorpsHelmet", "ShieldAdren")}");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/MolluskShellmet")] = TranslationHelper.GetTextValue("CalamityMod/MolluskShellmet", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/PlaguebringerVisor")] = TranslationHelper.GetTextValue("CalamityMod/PlaguebringerVisor", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/PlagueReaperMask")] = TranslationHelper.GetTextValue("CalamityMod/PlagueReaperMask", "SetBonus", "[Бонус комплекта брони]");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/ReaverHeadExplore")] = TranslationHelper.GetTextValue("CalamityMod/ReaverHeadExplore", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/ReaverHeadMobility")] = TranslationHelper.GetTextValue("CalamityMod/ReaverHeadMobility", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/ReaverHeadTank")] = TranslationHelper.GetTextValue("CalamityMod/ReaverHeadTank", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/TitanHeartMask")] = TranslationHelper.GetTextValue("CalamityMod/TitanHeartMask", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/UmbraphileHood")] = TranslationHelper.GetTextValue("CalamityMod/UmbraphileHood", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/AuricTeslaHoodedFacemask")] = TranslationHelper.GetTextValue("CalamityMod/AuricTeslaHoodedFacemask", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/AuricTeslaPlumedHelm")] = TranslationHelper.GetTextValue("CalamityMod/AuricTeslaPlumedHelm", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/AuricTeslaRoyalHelm")] = TranslationHelper.GetTextValue("CalamityMod/AuricTeslaRoyalHelm", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/AuricTeslaSpaceHelmet")] = TranslationHelper.GetTextValue("CalamityMod/AuricTeslaSpaceHelmet", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/AuricTeslaWireHemmedVisage")] = TranslationHelper.GetTextValue("CalamityMod/AuricTeslaWireHemmedVisage", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/DemonshadeHelm")] = TranslationHelper.GetTextValue("CalamityMod/DemonshadeHelm", "SetBonus", "[Бонус комплекта брони]");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/EmpyreanMask")] = TranslationHelper.GetTextValue("CalamityMod/EmpyreanMask", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/FearmongerGreathelm")] = TranslationHelper.GetTextValue("CalamityMod/FearmongerGreathelm", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/OmegaBlueHelmet")] = TranslationHelper.GetTextValue("CalamityMod/OmegaBlueHelmet", "SetBonus", "[Бонус комплекта брони]");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/PrismaticHelmet")] = TranslationHelper.GetTextValue("CalamityMod/PrismaticHelmet", "SetBonus", "[Бонус комплекта брони]");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/SnowRuffianMask")] = TranslationHelper.GetTextValue("CalamityMod/SnowRuffianMask", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/SulphurousHelmet")] =TranslationHelper.GetTextValue("CalamityMod/SulphurousHelmet", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/VictideHeadRanged")] =
                TranslationHelper.GetTextValue("CalamityMod/VictideBreastplate", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/VictideHeadRanged", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/VictideHeadMagic")] =
                TranslationHelper.GetTextValue("CalamityMod/VictideBreastplate", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/VictideHeadMagic", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/StatigelHeadMagic")] = TranslationHelper.GetTextValue("CalamityMod/StatigelArmor", "CommonSetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/StatigelHeadRanged")] = TranslationHelper.GetTextValue("CalamityMod/StatigelArmor", "CommonSetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/HydrothermicHeadMagic")] =
                TranslationHelper.GetTextValue("CalamityMod/HydrothermicArmor", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/HydrothermicHeadMagic", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/HydrothermicHeadMelee")] =
                TranslationHelper.GetTextValue("CalamityMod/HydrothermicArmor", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/HydrothermicHeadMelee", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/HydrothermicHeadRanged")] =
                TranslationHelper.GetTextValue("CalamityMod/HydrothermicArmor", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/HydrothermicHeadRanged", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/HydrothermicHeadRogue")] =
                TranslationHelper.GetTextValue("CalamityMod/HydrothermicArmor", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/HydrothermicHeadRogue", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/HydrothermicHeadSummon")] =
                TranslationHelper.GetTextValue("CalamityMod/HydrothermicArmor", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/HydrothermicHeadSummon", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/BloodflareHeadMagic")] =
                TranslationHelper.GetTextValue("CalamityMod/BloodflareBodyArmor", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/BloodflareHeadMagic", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/BloodflareHeadMelee")] =
                TranslationHelper.GetTextValue("CalamityMod/BloodflareBodyArmor", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/BloodflareHeadMelee", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/BloodflareHeadRanged")] =
                TranslationHelper.GetTextValue("CalamityMod/BloodflareBodyArmor", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/BloodflareHeadRanged", "SetBonus", "[Бонус комплекта брони]");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/BloodflareHeadRogue")] =
                TranslationHelper.GetTextValue("CalamityMod/BloodflareBodyArmor", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/BloodflareHeadRogue", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/BloodflareHeadSummon")] =
                TranslationHelper.GetTextValue("CalamityMod/BloodflareBodyArmor", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/BloodflareHeadSummon", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/GodSlayerHeadMelee")] =
                TranslationHelper.GetTextValue("CalamityMod/GodSlayerChestplate", "CommonSetBonus", "[Бонус комплекта брони]", 45) + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/GodSlayerHeadMelee", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/GodSlayerHeadRanged")] =
                TranslationHelper.GetTextValue("CalamityMod/GodSlayerChestplate", "CommonSetBonus", "[Бонус комплекта брони]", 45) + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/GodSlayerHeadRanged", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/GodSlayerHeadRogue")] =
                TranslationHelper.GetTextValue("CalamityMod/GodSlayerChestplate", "CommonSetBonus", "[Бонус комплекта брони]", 45) + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/GodSlayerHeadRogue", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/SilvaHeadMagic")] =
                TranslationHelper.GetTextValue("CalamityMod/SilvaArmor", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/SilvaHeadMagic", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/SilvaHeadSummon")] =
                TranslationHelper.GetTextValue("CalamityMod/SilvaArmor", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/SilvaHeadSummon", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/TarragonHeadMagic")] =
                TranslationHelper.GetTextValue("CalamityMod/TarragonBreastplate", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/TarragonHeadMagic", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/TarragonHeadMelee")] =
                TranslationHelper.GetTextValue("CalamityMod/TarragonBreastplate", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/TarragonHeadMelee", "SetBonus", "[Бонус комплекта брони]");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/TarragonHeadRanged")] =
                TranslationHelper.GetTextValue("CalamityMod/TarragonBreastplate", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/TarragonHeadRanged", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/TarragonHeadRogue")] =
                TranslationHelper.GetTextValue("CalamityMod/TarragonBreastplate", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/TarragonHeadRogue", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/TarragonHeadSummon")] =
                TranslationHelper.GetTextValue("CalamityMod/TarragonBreastplate", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/TarragonHeadSummon", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/AerospecHat")] =
                TranslationHelper.GetTextValue("CalamityMod/AerospecBreastplate", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/AerospecHat", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/AerospecHeadgear")] =
                TranslationHelper.GetTextValue("CalamityMod/AerospecBreastplate", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/AerospecHeadgear", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/AerospecHelm")] =
                TranslationHelper.GetTextValue("CalamityMod/AerospecBreastplate", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/AerospecHelm", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/AerospecHelmet")] =
                TranslationHelper.GetTextValue("CalamityMod/AerospecBreastplate", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/AerospecHelmet", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/AerospecHood")] =
                TranslationHelper.GetTextValue("CalamityMod/AerospecBreastplate", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/AerospecHood", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/DesertProwlerHat")] =
                TranslationHelper.GetTextValue("CalamityMod/DesertProwlerHat", "SetBonus", 1) + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/DesertProwlerHat", "AbilityBrief", Language.GetTextValue(Main.ReversedUpDownArmorSetBonuses ? "Key.UP" : "Key.DOWN")) + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/DesertProwlerHat", "AbilityDescription", 200, 100, 1.5f);
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/StatigelHeadMelee")] =
                TranslationHelper.GetTextValue("CalamityMod/StatigelArmor", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/StatigelHeadMelee", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/StatigelHeadRogue")] =
                TranslationHelper.GetTextValue("CalamityMod/StatigelArmor", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/StatigelHeadRogue", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/StatigelHeadSummon")] =
                TranslationHelper.GetTextValue("CalamityMod/StatigelArmor", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/StatigelHeadSummon", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/VictideHeadMelee")] =
                TranslationHelper.GetTextValue("CalamityMod/VictideBreastplate", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/VictideHeadMelee", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/VictideHeadRogue")] =
                TranslationHelper.GetTextValue("CalamityMod/VictideBreastplate", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/VictideHeadRogue", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/VictideHeadSummon")] =
                TranslationHelper.GetTextValue("CalamityMod/VictideBreastplate", "CommonSetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/VictideHeadSummon", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/WulfrumHat")] =
                TranslationHelper.GetTextValue("CalamityMod/WulfrumHat", "SetBonus") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/WulfrumHat", "AbilityBrief", Language.GetTextValue(Main.ReversedUpDownArmorSetBonuses ? "Key.UP" : "Key.DOWN")) + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/WulfrumHat", "AbilityDescription",
                    $"[i:{TranslationHelper.GetItemID("CalamityMod/WulfrumMetalScrap")}] {TranslationHelper.GetTextValue("CalamityMod/WulfrumMetalScrap", "DisplayName")}");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/MarniteArchitectHeadgear")] =
                TranslationHelper.GetTextValue("CalamityMod/MarniteArchitectHeadgear", "AbilityBrief") + "\n" +
                TranslationHelper.GetTextValue("CalamityMod/MarniteArchitectHeadgear", "AbilityDescription");
        }
    }

    private void AddFargoSoulsArmorSetBonuses()
    {
        if (ModInstances.FargowiltasSouls != null)
        {
            ArmorSetBonuses[TranslationHelper.GetItemID("FargowiltasSouls/EridanusHat")] = Language.GetTextValue("Mods.FargowiltasSouls.SetBonus.EridanusOff", Language.GetTextValue(Main.ReversedUpDownArmorSetBonuses ? "Key.UP" : "Key.DOWN"));
            ArmorSetBonuses[TranslationHelper.GetItemID("FargowiltasSouls/GaiaHelmet")] = Language.GetTextValue("Mods.FargowiltasSouls.SetBonus.Gaia", Language.GetTextValue(Main.ReversedUpDownArmorSetBonuses ? "Key.UP" : "Key.DOWN"));
            ArmorSetBonuses[TranslationHelper.GetItemID("FargowiltasSouls/MutantMask")] = Language.GetTextValue("Mods.FargowiltasSouls.SetBonus.Mutant");
            ArmorSetBonuses[TranslationHelper.GetItemID("FargowiltasSouls/StyxCrown")] = Language.GetTextValue("Mods.FargowiltasSouls.SetBonus.Styx", Language.GetTextValue(Main.ReversedUpDownArmorSetBonuses ? "Key.UP" : "Key.DOWN"));
            ArmorSetBonuses[TranslationHelper.GetItemID("FargowiltasSouls/NekomiHood")] = Language.GetTextValue("Mods.FargowiltasSouls.SetBonus.Nekomi", Language.GetTextValue(Main.ReversedUpDownArmorSetBonuses ? "Key.UP" : "Key.DOWN"));
        }
    }

    private void AddThoriumArmorSetBonuses()
    {
        if (ModInstances.Thorium != null)
        {
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/WhisperingHood")] = "Периодически порождает щупальце бездонной энергии, которое атакует ближайших врагов\nУ вас может быть до шести щупалец, а наносимый ими урон похищает у поражённого врага по 1 единице здоровья и маны";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/FlightMask")] = "Теперь вы можете кратковременно летать";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/YewWoodHelmet")] = "После четырёх не критических ударов ваша следующая стрелковая атака нанесёт мини-критический удар в 150%\nМини-критические выстрелы считаются критическими ударами для соответствующих эффектов";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/CriersCap")] = "Симфонические усиления действуют на 3 секунды дольше";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/CyberPunkHeadset")] = "При нажатии клавиши 'Способность брони' вы переключитесь между четырьмя состояниями:\nКрасное - Вы и ближайшие союзники получаете Фиксированный урон II и Урон II\nЗелёное - Вы и ближайшие союзники получаете Скорость передвижения II и Время полёта II\nФиолетовое - Вы и ближайшие союзники получаете Максимальный запас ресурсов II и Восстановление ресурсов II\nСинее - Вы и ближайшие союзники получаете Защита II и Сопротивление урону II";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/JestersMask")] = "При симфонических критических ударах над головой зазвонит колокол, замедляя всех ближайших врагов на короткое время";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/JestersMask2")] = "При симфонических критических ударах над головой зазвонит колокол, замедляя всех ближайших врагов на короткое время";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/MaestroWig")] = "Нажатие клавиши 'Способность брони' призывает хор играющих призрачных музыкантов\nПризраки быстро наносят урон ближайшим врагам духовыми, деревянными, струнными и ударными инструментами";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/MarchingBandCap")] = "Находясь в бою, за вами следует радуга наносящих урон симфонических символов, которые следуют за вами и оглушают врагов";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/NoblesHat")] = "Выпадающие ноты вдохновения вдвое мощнее и ненадолго увеличивают ваш симфонический урон";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/OrnateHat")] = "Симфонические критические удары поднимают случайное активное усилие до четвёртного уровня силы\nЭтот эффект может сработать лишь один раз в 5 секунд";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/ShootingStarHat")] = "Увеличивает длительность симфонических усилений на 6 секунд\nКаждое имеющееся у вас уникальное усиление увеличивает симфонический урон на 5%\nКаждое имеющееся у вас уникальное усиление увеличивает скорость восстановления вдохновения на 2%";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/LichCowl")] = "Из убитого врага можно извлечь фрагмент души\nКоснувшись фрагмента души, значительно увеличивает скорость передвижения и метания на короткое время";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/TideTurnerHelmet")] = "Нажатие клавиши 'Способность брони' окутывает вас непроницаемым пузырём\nПока пузырь активен, весь получаемый урон превращается в исцеление";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/TideTurnersGaze")] = "При нанесении метательного урона с 20% шансом выпускает вокруг вас акватические самонаводящиеся кинжалы";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/DreamWeaversHelmet")] = "Нажатие клавиши 'Способность брони' расходует 200 маны и искривляет саму ткань реальности\nВраги сильно замедляются и получают на 15% больше урона от всех источников\nСоюзники получают значительное увеличение скорости передвижения и атаки";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/DreamWeaversHood")] = "Нажатие клавиши 'Способность брони' расходует 200 маны и помещает вас в состояние сна\nНаходясь во сне, исцелённые союзники на короткое время становятся неуязвимыми и избавляются от всех дебаффов";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/MasterArbalestHood")] = "Ваш стрелковый урон с 10% шансом полностью продублирует себя и нанесёт на 15% больше урона";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/MasterMarksmansScouter")] = "Ваш стрелковый урон с 5% шансом полностью уничтожит поражённую цель\nЭтот эффект можно применить к боссам только в том случае, если их максимальный запас здоровья составляет менее 5%";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/InspiratorsHelmet")] = "Нажатие клавиши 'Способность брони' перегружает всех ближайших союзников всеми усилениями III на 15 секунд\nИспользование этой способности требует 20 единиц вдохновения и перезаряжается в течение 1 минуты";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/SoloistHat")] = "Нажатие клавиши 'Способность брони' даёт бесконечное вдохновение, значительно увеличивает симфонический урон и скорость игры на инструменте\nЭтот эффект длится 10 секунд и перезаряжается в течение 1 минуты";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/MagmaSeersMask")] = "Весь урон, наносимый миньонами, оставляет после себя ожог, который наносит значительный постепенный урон";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/PyromancerCowl")] = "Ваш магический урон испепеляет и наносит урон всем ближайшим врагам";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/BronzeHelmet")] = "Метательный урон с 20% шансом высвобождает пронзающий удар молнии";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/CoralHelmet")] = "Лучезарный урон накапливает до 20 единиц жизненного щита, и жизненный щит больше не истощается\nИсцеление союзника передаёт ему жизненный щит";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/DarksteelFaceGuard")] = "Ничто не остановит ваше передвижение! Нажмите дважды в нужном направлении для рывка";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/DemonBloodHelmet")] = "Увеличивает максимальный запас здоровья на 100";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/DepthDiverHelmet")] = "Вы также получаете все эффекты, исходящие от вас";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/NagaSkinMask")] = "Каждые 75 единиц затраченной маны значительно увеличивают ваш магический урон и скорость чтения заклинаний";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/TideHunterCap")] = "Стрелковые критические удары выпускают всплеск пены, замедляя ближайших врагов";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/FeralFurHead")] = "Выглядишь хорошо!";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/DragonMask")] = "Атаки могут высвободить взрыв драконьего пламени";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/DreadSkull")] = "Ваши ботинки вибрируют с невероятной частотой, значительно увеличивая базовую скорость передвижения\nВо время движения увеличивается урон ближнего боя и шанс критического удара";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/SilkHat")] = "Увеличивает магический урон на 12% пока максимальный уровень маны превышает 90%";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/FleshMask")] = "При нанесении урона из поражённых врагов с 10% шансом выпадает плоть\nСобранная плоть восстанавливает здоровье и увеличивает наносимый урон";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/GeodeHelmet")] = "Теперь можно добывать сразу целые рудные жилы";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/GraniteHelmet")] = "Невосприимчивость к сильному жару и вражескому отбрасыванию, но скорость передвижения значительно снижается";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/BioTechHood")] = "Биотехнологический зонд помогает вам исцелять союзников\nИсцеляет здоровье союзника на сумму, равную вашему бонусному исцелению";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/BloomingCrown")] = "Ваши заклинания исцеления увеличивают восполнение здоровья и скорость восполнения здоровья исцеляемой цели";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/CelestialCrown")] = $"Нажатие клавиши 'Способность брони' призывает вокруг курсора большую ауру, затрачивая при этом 150 маны\nСоюзники, затронутые аурой, получают увеличенный урон, сопротивление урону, защиту и восполнение здоровья\nВраги, затронутые аурой, подвергаются дебаффу «{Language.GetTextValue("Mods.ThoriumMod.Buffs.HolyGlare.DisplayName")}» и получают на 15% больше урона от всех источников";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/EbonHood")] = "Усиливает некоторые лучезарные атаки тёмной энергией, позволяя им принимать тёмный облик и накладывать дополнительные эффекты";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/FallenPaladinFaceguard")] = "При получении урона исцеляет ближайших союзников на 15% от полученного урона";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/IridescentHelmet")] = $"Ваш лучезарный урон с 15% шансом выпускает ослепительную вспышку света\nВспышка исцеляет ближайших союзников на сумму, равную вашему бонусному исцелению, и накладывает на врагов дебафф «{Language.GetTextValue("BuffName.Confused")}»";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/LifeBinderMask")] = "Исцеляющие заклинания на короткое время увеличивают максимальный запас здоровья исцелённого игрока на 50";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/NoviceClericCowl")] = "Каждые 5 секунд генерируется до 3 святых крестов\nПри произнесении исцеляющих заклинаний крест расходуется вместо маны";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/SacredHelmet")] = "Исцеляющие заклинания восстанавливают дополнительно 5 единиц здоровья";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/TemplarsCirclet")] = "Увеличивает вашу способность к исцелению, если у союзника меньше половины здоровья";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/WarlockHood")] = "Лучезарные атаки могут сформировать до 15 теневых огоньков\nНажатие клавиши 'Способность брони' высвобождает все накопленные теневые огоньки в направлении курсора";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/IcyHeadgear")] = "Вас окружает оледенелая аура, замораживающая врагов, которые находятся в её пределах слишком долго";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/IllumiteMask")] = "Луки, пушки и пусковые установки периодически выпускают дополнительные снаряды";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/LodeStoneFaceGuard")] = "Увеличивает сопротивление урону на 6% за каждые 25% потерянного здоровья\nМаксимальное сопротивление урону составляет 18% при уровне здоровья ниже 25%";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/CryomancersCrown")] = "Ваш магический урон замораживает врагов на две секунды";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/WhiteKnightMask")] = $"40% затраченной маны хранится в виде энергии, до максимума в [c/99ccff:X] единиц\nНажатие клавиши 'Способность брони' позволяет израсходовать энергию на восстановление до [c/99ccff:X] единиц маны и [c/bffdbd:X] единиц здоровья за раз";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/ConduitHelmet")] = "При движении формируются до 5 неподвижных колец, каждое из которых образует жизненный щит\nКогда жизненный щит полностью заряжен, кольца заменяются энергетическим пузырём, который защищает игрока от одной атаки\nКогда пузырь блокирует атаку, в ближайших врагов выпускается электрический разряд";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/HallowedChapeau")] = "После удара по врагу вы становитесь неуязвимым; увеличивает длительность симфонических усилений на 8 секунд";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/HallowedCowl")] = "После удара по врагу вы становитесь неуязвимым; исцеляющие заклинания восстанавливают дополнительно 6 единиц здоровья";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/HallowedGuise")] = "После удара по врагу вы становитесь неуязвимым; увеличивает максимальное число очков техники на 2";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/SandStoneHelmet")] = "Пустынные ветра дают песчаный двойной прыжок";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/DurasteelHelmet")] = "Увеличивает сопротивление урону на 10%";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/SteelHelmet")] = "Увеличивает сопротивление урону на 8%";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/AstroHelmet")] = "Атаки миньонов могут вызвать выброс разрушительной плазмы";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/LifeBloomMask")] = "Атаки миньонов с 25% шансом исцеляют вас\nОднако исцеление ограничено 50 единицами каждые 10 секунд";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/LivingWoodMask")] = "Увеличивает призываемое число миньонов на 1\nАвтоатаки вашего ростка живого дерева самонаводятся на врагов";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/SpiritTrapperCowl")] = TranslationHelper.GetTextValue("ThoriumMod/SpiritTrapperCowl", "SetBonus", 1, 5, 10);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/SpiritTrapperMask")] = TranslationHelper.GetTextValue("ThoriumMod/SpiritTrapperMask", "SetBonus", 1, 5, 10);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/TerrariumHelmet")] = "Энергии Террарии будут защищать вас, когда вы находитесь в бою\nСосредоточенность ближнего боя: увеличивает сопротивление урону на 15%\nСтрелковая сосредоточенность: увеличивает скорострельность на 15%\nМагическая сосредоточенность: увеличивает максимальный запас маны на 100\nСосредоточенность призывателя: увеличивает призываемое число миньонов на 3\nМетательная сосредоточенность: Увеличивает максимальное число очков техники на 2\nЛучезарная сосредоточенность: исцеляющие заклинания восстанавливают дополнительно 3 единицы здоровья\nСимфоническая сосредоточенность: увеличивает длительность усилений на 6 секунд\nНет сосредоточенности: увеличивает урон на 20%";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/ThoriumHelmet")] = "Увеличивает урон на 10%";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/FungusHat")] = "Увеличивает урон по заражённым мицелием врагам на 10%\nПри нанесении урона врагам, заражённым мицелием, метательная скорость атаки временно увеличивается на 10%";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/PlagueDoctorsMask")] = "Чумной газ рассеивается в воздухе вдвое медленнее, а чумные реактивы наносят на 20% больше урона";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/ShadeMasterMask")] = "До 50% полученного урона распределяется равномерно в течение 10 секунд";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/WhiteDwarfMask")] = "Критические удары высвобождают из космоса изумрудные вспышки\nИзумрудные вспышки наносят урон, равный 0.1% максимального здоровья цели";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/TitanHeadgear")] = TranslationHelper.GetTextValue("ThoriumMod/TitanHeadgear", "SetBonus", 18);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/TitanHelmet")] = "Увеличивает наносимый урон на 18%";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/TitanMask")] = "Увеличивает наносимый урон на 18%";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/ValadiumHelmet")] = "Нажмите ВВЕРХ для изменения гравитации. В перевёрнутом состоянии увеличивает стрелковый урон на 15%";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/BlueKnightHelmet")] = "Выглядишь хорошо!";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/GlitteringHelmet")] = "Выглядишь хорошо!";
        }
    }

    private void AddStarsAboveSetBonuses()
    {
        if (ModInstances.StarsAbove != null)
        {
            ArmorSetBonuses[TranslationHelper.GetItemID("StarsAbove/NeopursuantHeadbooster")] = $"Если надета {TranslationHelper.GetTextValue("StarsAbove/NeopursuantPlasteel", "DisplayName")}: {Language.GetTextValue("Mods.StarsAbove.Common.NeopursuantSetBonusFullMetalArcanist")}\nЕсли надето {TranslationHelper.GetTextValue("StarsAbove/NeopursuantRoguegarb", "DisplayName")}: {Language.GetTextValue("Mods.StarsAbove.Common.NeopursuantSetBonusInfiltrator")}";
            ArmorSetBonuses[TranslationHelper.GetItemID("StarsAbove/NeopursuantDualShield")] = $"Если надета {TranslationHelper.GetTextValue("StarsAbove/NeopursuantPlasteel", "DisplayName")}: {Language.GetTextValue("Mods.StarsAbove.Common.NeopursuantSetBonusBackupBattery")}\nЕсли надето {TranslationHelper.GetTextValue("StarsAbove/NeopursuantRoguegarb", "DisplayName")}: {Language.GetTextValue("Mods.StarsAbove.Common.NeopursuantSetBonusEnviroSavant")}";
            ArmorSetBonuses[TranslationHelper.GetItemID("StarsAbove/NeopursuantHiGuard")] = $"Если надета {TranslationHelper.GetTextValue("StarsAbove/NeopursuantPlasteel", "DisplayName")}: {Language.GetTextValue("Mods.StarsAbove.Common.NeopursuantSetBonusCataphractArms")}\nЕсли надето {TranslationHelper.GetTextValue("StarsAbove/NeopursuantRoguegarb", "DisplayName")}: {Language.GetTextValue("Mods.StarsAbove.Common.NeopursuantSetBonusViralUpload")}";
        }
    }
}