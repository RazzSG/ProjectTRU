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
        AddRedemptionSetBonuses();
        AddCatalystSetBonuses();
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
        ArmorSetBonuses[ItemID.GoldHelmet] = Language.GetTextValue("ArmorSetBonus.MetalTier2");
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
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/SulphurousHelmet")] = TranslationHelper.GetTextValue("CalamityMod/SulphurousHelmet", "SetBonus");
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
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/WhisperingHood")] = TranslationHelper.GetTextValue("ThoriumMod/WhisperingHood", "SetBonus", 1, 1);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/FlightMask")] = "Позволяет кратковременно летать";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/YewWoodHelmet")] = TranslationHelper.GetTextValue("ThoriumMod/YewWoodHelmet", "SetBonus", 150);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/CriersCap")] = TranslationHelper.GetTextValue("ThoriumMod/CriersCap", "SetBonus", 3);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/CyberPunkHeadset")] = TranslationHelper.GetTextValue("ThoriumMod/CyberPunkHeadset", "SetBonus", "II");
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/JestersMask")] = TranslationHelper.GetTextValue("ThoriumMod/JestersMask", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/JestersMask2")] = TranslationHelper.GetTextValue("ThoriumMod/JestersMask", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/MaestroWig")] = TranslationHelper.GetTextValue("ThoriumMod/MaestroWig", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/MarchingBandShako")] = TranslationHelper.GetTextValue("ThoriumMod/MarchingBandShako", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/NoblesHat")] = TranslationHelper.GetTextValue("ThoriumMod/NoblesHat", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/OrnateHat")] = TranslationHelper.GetTextValue("ThoriumMod/OrnateHat", "SetBonus", 5);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/ShootingStarHat")] = TranslationHelper.GetTextValue("ThoriumMod/OrnateHat", "SetBonus", 6, 5, 2);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/LichCowl")] = "Из убитого врага можно извлечь фрагмент души\nКоснувшись фрагмента души, вы значительно увеличиваете скорость передвижения и метания на короткое время";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/TideTurnerHelmet")] = TranslationHelper.GetTextValue("ThoriumMod/TideTurnerHelmet", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/TideTurnersGaze")] = "При нанесении метательного урона с 20% шансом вокруг вас выпускаются акватические самонаводящиеся кинжалы";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/DreamWeaversHelmet")] = TranslationHelper.GetTextValue("ThoriumMod/DreamWeaversHelmet", "SetBonus", 200, 15);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/DreamWeaversHood")] = TranslationHelper.GetTextValue("ThoriumMod/DreamWeaversHood", "SetBonus", 200);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/MasterArbalestHood")] = TranslationHelper.GetTextValue("ThoriumMod/DreamWeaversHood", "SetBonus", 10, 15);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/MasterMarksmansScouter")] = TranslationHelper.GetTextValue("ThoriumMod/DreamWeaversHood", "SetBonus", 5, 5);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/InspiratorsHelmet")] = TranslationHelper.GetTextValue("ThoriumMod/InspiratorsHelmet", "SetBonus", "III", 15, 20, 1);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/SoloistHat")] = TranslationHelper.GetTextValue("ThoriumMod/SoloistHat", "SetBonus", 10, 1);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/MagmaSeersMask")] = TranslationHelper.GetTextValue("ThoriumMod/MagmaSeersMask", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/PyromancerCowl")] = TranslationHelper.GetTextValue("ThoriumMod/PyromancerCowl", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/BronzeHelmet")] = "Метательный урон с 20% шансом высвобождает пронзающий удар молнии";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/CoralHelmet")] = TranslationHelper.GetTextValue("ThoriumMod/CoralHelmet", "SetBonus", 20);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/DarksteelFaceGuard")] = TranslationHelper.GetTextValue("ThoriumMod/DarksteelFaceGuard", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/DemonBloodHelmet")] = TranslationHelper.GetTextValue("ThoriumMod/DemonBloodHelmet", "SetBonus", 100);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/DepthDiverHelmet")] = TranslationHelper.GetTextValue("ThoriumMod/DepthDiverHelmet", "SetBonus", 10, 10);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/NagaSkinMask")] = TranslationHelper.GetTextValue("ThoriumMod/NagaSkinMask", "SetBonus", 75);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/TideHunterCap")] = TranslationHelper.GetTextValue("ThoriumMod/TideHunterCap", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/FeralFurHead")] = TranslationHelper.GetTextValue("ThoriumMod/FeralFurHead", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/DragonMask")] = TranslationHelper.GetTextValue("ThoriumMod/DragonMask", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/DreadSkull")] = TranslationHelper.GetTextValue("ThoriumMod/DreadSkull", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/SilkHat")] = TranslationHelper.GetTextValue("ThoriumMod/DreadSkull", "SetBonus", 12, 90);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/FleshMask")] =  TranslationHelper.GetTextValue("ThoriumMod/FleshMask", "SetBonus", 10);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/GeodeHelmet")] = TranslationHelper.GetTextValue("ThoriumMod/GeodeHelmet", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/GraniteHelmet")] = TranslationHelper.GetTextValue("ThoriumMod/GraniteHelmet", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/BioTechHood")] = TranslationHelper.GetTextValue("ThoriumMod/BioTechHood", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/BloomingCrown")] = TranslationHelper.GetTextValue("ThoriumMod/BloomingCrown", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/CelestialCrown")] = TranslationHelper.GetTextValue("ThoriumMod/CelestialCrown", "SetBonus", 150, 15);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/EbonHood")] = TranslationHelper.GetTextValue("ThoriumMod/EbonHood", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/FallenPaladinFaceguard")] = TranslationHelper.GetTextValue("ThoriumMod/FallenPaladinFaceguard", "SetBonus", 15);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/IridescentHelmet")] = TranslationHelper.GetTextValue("ThoriumMod/IridescentHelmet", "SetBonus", 15);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/LifeBinderMask")] = TranslationHelper.GetTextValue("ThoriumMod/LifeBinderMask", "SetBonus", 50);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/NoviceClericCowl")] = TranslationHelper.GetTextValue("ThoriumMod/NoviceClericCowl", "SetBonus", 5, 3);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/SacredHelmet")] = TranslationHelper.GetTextValue("ThoriumMod/SacredHelmet", "SetBonus", 5);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/TemplarsCirclet")] = TranslationHelper.GetTextValue("ThoriumMod/TemplarsCirclet", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/WarlockHood")] = TranslationHelper.GetTextValue("ThoriumMod/WarlockHood", "SetBonus", 15);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/IcyHeadgear")] = TranslationHelper.GetTextValue("ThoriumMod/IcyHeadgear", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/IllumiteMask")] = TranslationHelper.GetTextValue("ThoriumMod/IllumiteMask", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/LodeStoneFaceGuard")] = TranslationHelper.GetTextValue("ThoriumMod/LodeStoneFaceGuard", "SetBonus", 6, 25, 18);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/CryomancersCrown")] = TranslationHelper.GetTextValue("ThoriumMod/CryomancersCrown", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/WhiteKnightMask")] = TranslationHelper.GetTextValue("ThoriumMod/WhiteKnightMask", "SetBonus", 40, "X", "X", "X");
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/ConduitHelmet")] = TranslationHelper.GetTextValue("ThoriumMod/ConduitHelmet", "SetBonus", 5);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/HallowedChapeau")] = TranslationHelper.GetTextValue("ThoriumMod/HallowedChapeau", "SetBonus", 8);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/AncientHallowedChapeau")] = TranslationHelper.GetTextValue("ThoriumMod/HallowedChapeau", "SetBonus", 8);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/HallowedCowl")] = TranslationHelper.GetTextValue("ThoriumMod/HallowedCowl", "SetBonus", 6);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/AncientHallowedCowl")] = TranslationHelper.GetTextValue("ThoriumMod/HallowedCowl", "SetBonus", 6);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/HallowedGuise")] = "После удара по врагу вы становитесь неуязвимым; увеличивает максимальное число очков техники на 2";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/SandStoneHelmet")] = "Пустынные ветра дают песчаный двойной прыжок";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/DurasteelHelmet")] = TranslationHelper.GetTextValue("ThoriumMod/DurasteelHelmet", "SetBonus", 10);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/SteelHelmet")] = TranslationHelper.GetTextValue("ThoriumMod/SteelHelmet", "SetBonus", 8);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/AstroHelmet")] = TranslationHelper.GetTextValue("ThoriumMod/AstroHelmet", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/LifeBloomMask")] = TranslationHelper.GetTextValue("ThoriumMod/LifeBloomMask", "SetBonus", 25, 50, 10);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/LivingWoodMask")] = TranslationHelper.GetTextValue("ThoriumMod/LivingWoodMask", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/SpiritTrapperCowl")] = TranslationHelper.GetTextValue("ThoriumMod/SpiritTrapperCowl", "SetBonus", 1, 5, 10);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/SpiritTrapperMask")] = TranslationHelper.GetTextValue("ThoriumMod/SpiritTrapperMask", "SetBonus", 1, 5, 10);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/TerrariumHelmet")] = TranslationHelper.GetTextValue("ThoriumMod/TerrariumHelmet", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/ThoriumHelmet")] = TranslationHelper.GetTextValue("ThoriumMod/ThoriumHelmet", "SetBonus", 10);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/FungusHat")] = "Увеличивает урон по заражённым мицелием врагам на 10%\nПри нанесении урона врагам, заражённым мицелием, метательная скорость атаки временно увеличивается на 10%";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/PlagueDoctorsMask")] = "Чумной газ рассеивается в воздухе вдвое медленнее, а чумные реактивы наносят на 20% больше урона";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/ShadeMasterMask")] = "До 50% полученного урона распределяется равномерно в течение 10 секунд";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/WhiteDwarfMask")] = "Критические удары высвобождают из космоса изумрудные вспышки\nИзумрудные вспышки наносят урон, равный 0.1% от максимального здоровья цели";
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/TitanHeadgear")] = TranslationHelper.GetTextValue("ThoriumMod/TitanHeadgear", "SetBonus", 18);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/TitanHelmet")] = TranslationHelper.GetTextValue("ThoriumMod/TitanHelmet", "SetBonus", 18);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/TitanMask")] = TranslationHelper.GetTextValue("ThoriumMod/TitanMask", "SetBonus", 18);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/ValadiumHelmet")] = TranslationHelper.GetTextValue("ThoriumMod/ValadiumHelmet", "SetBonus", 15);
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/BlueKnightHelmet")] = TranslationHelper.GetTextValue("ThoriumMod/BlueKnightHelmet", "SetBonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("ThoriumMod/GlitteringHelmet")] = TranslationHelper.GetTextValue("ThoriumMod/GlitteringHelmet", "SetBonus");
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
    
    private void AddRedemptionSetBonuses()
    {
        if (ModInstances.Redemption != null)
        {
            ArmorSetBonuses[ItemID.CopperHelmet] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Thunder.DisplayName"));
            ArmorSetBonuses[ItemID.TinHelmet] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Thunder.DisplayName"));
            ArmorSetBonuses[ItemID.CactusHelmet] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Nature.DisplayName"));
            ArmorSetBonuses[ItemID.IronHelmet] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Earth.DisplayName"));
            ArmorSetBonuses[ItemID.AncientIronHelmet] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Earth.DisplayName"));
            ArmorSetBonuses[ItemID.LeadHelmet] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Earth.DisplayName"));
            ArmorSetBonuses[ItemID.SilverHelmet] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Damage", 20, Language.GetTextValue("Mods.Redemption.Items.Thunder.DisplayName"));
            ArmorSetBonuses[ItemID.TungstenHelmet] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Damage", 20, Language.GetTextValue("Mods.Redemption.Items.Thunder.DisplayName"));
            ArmorSetBonuses[ItemID.GoldHelmet] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Arcane.DisplayName"));
            ArmorSetBonuses[ItemID.AncientGoldHelmet] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Arcane.DisplayName"));
            ArmorSetBonuses[ItemID.PlatinumHelmet] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Damage", 20, Language.GetTextValue("Mods.Redemption.Items.Arcane.DisplayName"));
            ArmorSetBonuses[ItemID.FossilHelm] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Earth.DisplayName"));
            ArmorSetBonuses[ItemID.JungleHat] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Nature.DisplayName"));
            ArmorSetBonuses[ItemID.ShadowHelmet] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Shadow.DisplayName"));
            ArmorSetBonuses[ItemID.AncientShadowHelmet] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Shadow.DisplayName"));
            ArmorSetBonuses[ItemID.CrimsonHelmet] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Blood.DisplayName"));
            ArmorSetBonuses[ItemID.MoltenHelmet] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Fire.DisplayName"));
            ArmorSetBonuses[ItemID.CobaltHelmet] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Water.DisplayName"));
            ArmorSetBonuses[ItemID.CobaltMask] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Water.DisplayName"));
            ArmorSetBonuses[ItemID.CobaltHat] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Water.DisplayName"));
            ArmorSetBonuses[ItemID.PalladiumHelmet] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Holy.DisplayName"));
            ArmorSetBonuses[ItemID.PalladiumHeadgear] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Holy.DisplayName"));
            ArmorSetBonuses[ItemID.PalladiumMask] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Holy.DisplayName"));
            ArmorSetBonuses[ItemID.MythrilHelmet] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Arcane.DisplayName"));
            ArmorSetBonuses[ItemID.MythrilHat] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Arcane.DisplayName"));
            ArmorSetBonuses[ItemID.MythrilHood] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Arcane.DisplayName"));
            ArmorSetBonuses[ItemID.OrichalcumHelmet] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Nature.DisplayName"));
            ArmorSetBonuses[ItemID.OrichalcumHeadgear] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Nature.DisplayName"));
            ArmorSetBonuses[ItemID.OrichalcumMask] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Nature.DisplayName"));
            ArmorSetBonuses[ItemID.AdamantiteHelmet] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Earth.DisplayName"));
            ArmorSetBonuses[ItemID.AdamantiteHeadgear] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Earth.DisplayName"));
            ArmorSetBonuses[ItemID.AdamantiteMask] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Earth.DisplayName"));
            ArmorSetBonuses[ItemID.TitaniumHelmet] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Damage", 20, Language.GetTextValue("Mods.Redemption.Items.Thunder.DisplayName"));
            ArmorSetBonuses[ItemID.TitaniumHeadgear] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Damage", 20, Language.GetTextValue("Mods.Redemption.Items.Thunder.DisplayName"));
            ArmorSetBonuses[ItemID.TitaniumMask] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Damage", 20, Language.GetTextValue("Mods.Redemption.Items.Thunder.DisplayName"));
            ArmorSetBonuses[ItemID.AncientBattleArmorHat] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Earth.DisplayName"));
            ArmorSetBonuses[ItemID.HallowedHeadgear] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Holy.DisplayName"));
            ArmorSetBonuses[ItemID.HallowedHelmet] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Holy.DisplayName"));
            ArmorSetBonuses[ItemID.HallowedHood] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Holy.DisplayName"));
            ArmorSetBonuses[ItemID.HallowedMask] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Holy.DisplayName"));
            ArmorSetBonuses[ItemID.AncientHallowedHeadgear] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Holy.DisplayName"));
            ArmorSetBonuses[ItemID.AncientHallowedHelmet] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Holy.DisplayName"));
            ArmorSetBonuses[ItemID.AncientHallowedHood] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Holy.DisplayName"));
            ArmorSetBonuses[ItemID.AncientHallowedMask] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Holy.DisplayName"));
            ArmorSetBonuses[ItemID.TurtleHelmet] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Nature.DisplayName"));
            ArmorSetBonuses[ItemID.BeetleHelmet] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Nature.DisplayName"));
            ArmorSetBonuses[ItemID.SpectreHood] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Arcane.DisplayName"));
            ArmorSetBonuses[ItemID.SpectreMask] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Arcane.DisplayName"));
            ArmorSetBonuses[ItemID.SolarFlareHelmet] += Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.SolarCelestial", Language.GetTextValue("Mods.Redemption.Items.Celestial.DisplayName"), Language.GetTextValue("Mods.Redemption.Items.Fire.DisplayName"));
            ArmorSetBonuses[TranslationHelper.GetItemID("Redemption/LivingWoodHelmet")] = Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.LivingWood");
            ArmorSetBonuses[TranslationHelper.GetItemID("Redemption/CommonGuardHelm1")] = Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.CommonGuardHelm1");
            ArmorSetBonuses[TranslationHelper.GetItemID("Redemption/CommonGuardHelm2")] = Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.CommonGuardHelm2");
            ArmorSetBonuses[TranslationHelper.GetItemID("Redemption/PureIronHelmet")] = Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.PureIron.Bonus", Language.GetTextValue("Mods.Redemption.Items.Fire.DisplayName"), Language.GetTextValue("Mods.Redemption.Items.Ice.DisplayName"));
            ArmorSetBonuses[TranslationHelper.GetItemID("Redemption/DragonLeadSkull")] = Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.DragonLead.Bonus", Language.GetTextValue("Mods.Redemption.Items.Ice.DisplayName"), Language.GetTextValue("Mods.Redemption.Items.Fire.DisplayName"));
            ArmorSetBonuses[TranslationHelper.GetItemID("Redemption/XenomiteHelmet")] = Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Xenomite.Bonus1") + Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Xenomite.Press") + "[Особая способность]" + Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Xenomite.Bonus2");
            ArmorSetBonuses[TranslationHelper.GetItemID("Redemption/XeniumVisor")] = Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Xenium.Bonus");
            ArmorSetBonuses[TranslationHelper.GetItemID("Redemption/HardlightCowl")] = Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Hardlight.Press") + "[Особая способность]" + Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Hardlight.Support") + Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Hardlight.Cowl");
            ArmorSetBonuses[TranslationHelper.GetItemID("Redemption/HardlightCasque")] = Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Hardlight.Press") + "[Особая способность]" + Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Hardlight.Support") + Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Hardlight.Casque");
            ArmorSetBonuses[TranslationHelper.GetItemID("Redemption/HardlightHelm")] = Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Hardlight.Press") + "[Особая способность]" + Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Hardlight.Support") + Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Hardlight.Helm");
            ArmorSetBonuses[TranslationHelper.GetItemID("Redemption/HardlightHood")] = Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Hardlight.Press") + "[Особая способность]" + Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Hardlight.Support") + Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Hardlight.Hood");
            ArmorSetBonuses[TranslationHelper.GetItemID("Redemption/HardlightVisor")] = Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Hardlight.Press") + "[Особая способность]" + Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Hardlight.Support") + Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Hardlight.Visor");
        }
    }
    
    private void AddCatalystSetBonuses()
    {
        if (ModInstances.Catalyst != null)
        {
            ArmorSetBonuses[TranslationHelper.GetItemID("CatalystMod/IntergelacticHeadMelee")] = Language.GetTextValue("Mods.CatalystMod.ArmorSetBonus.IntergelacticMelee", "[Межгелектический бонус комплекта]");
            ArmorSetBonuses[TranslationHelper.GetItemID("CatalystMod/IntergelacticHeadRanged")] = Language.GetTextValue("Mods.CatalystMod.ArmorSetBonus.IntergelacticAll", "[Межгелектический бонус комплекта]") + "\n" + Language.GetTextValue("Mods.CatalystMod.ArmorSetBonus.IntergelacticRanged");
            ArmorSetBonuses[TranslationHelper.GetItemID("CatalystMod/IntergelacticHeadMagic")] = Language.GetTextValue("Mods.CatalystMod.ArmorSetBonus.IntergelacticAll", "[Межгелектический бонус комплекта]") + "\n" + Language.GetTextValue("Mods.CatalystMod.ArmorSetBonus.IntergelacticMagic");
            ArmorSetBonuses[TranslationHelper.GetItemID("CatalystMod/IntergelacticHeadSummon")] = Language.GetTextValue("Mods.CatalystMod.ArmorSetBonus.IntergelacticAll", "[Межгелектический бонус комплекта]") + "\n" + Language.GetTextValue("Mods.CatalystMod.ArmorSetBonus.IntergelacticSummon");
            ArmorSetBonuses[TranslationHelper.GetItemID("CatalystMod/IntergelacticHeadRogue")] = Language.GetTextValue("Mods.CatalystMod.ArmorSetBonus.IntergelacticAll", "[Межгелектический бонус комплекта]") + "\n" + Language.GetTextValue("Mods.CatalystMod.ArmorSetBonus.IntergelacticRogue");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/AuricTeslaHoodedFacemask")] += "\n\nУлучшенная версия: " + Language.GetTextValue("Mods.CatalystMod.AuricTeslaPlusSet.Ranged", "[Межгелектический бонус комплекта]");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/AuricTeslaPlumedHelm")] +="\n\nУлучшенная версия: " + Language.GetTextValue("Mods.CatalystMod.AuricTeslaPlusSet.Rogue", "[Межгелектический бонус комплекта]");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/AuricTeslaRoyalHelm")] += "\n\nУлучшенная версия: " + Language.GetTextValue("Mods.CatalystMod.AuricTeslaPlusSet.Melee", "[Межгелектический бонус комплекта]");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/AuricTeslaSpaceHelmet")] += "\n\nУлучшенная версия: " + Language.GetTextValue("Mods.CatalystMod.AuricTeslaPlusSet.Summoner", "[Межгелектический бонус комплекта]");
            ArmorSetBonuses[TranslationHelper.GetItemID("CalamityMod/AuricTeslaWireHemmedVisage")] += "\n\nУлучшенная версия: " + Language.GetTextValue("Mods.CatalystMod.AuricTeslaPlusSet.Magic", "[Межгелектический бонус комплекта]");
        }
    }
}