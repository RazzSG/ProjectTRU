using System;
using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Core.ArmorSetBonusPreview;

public class ArmorSetBonusPreviewSystem : ModSystem
{
    internal static List<ArmorSetBonusData> ArmorSetBonuses;

    internal static void AddSetBonusForItem(int itemID, Func<string> setBonusText)
    {
        ArmorSetBonuses.Add(new ArmorSetBonusData(itemID, setBonusText));
    }
    
    internal static string GetSetBonusForItem(int itemID)
    {
        return ArmorSetBonuses.Find(x => x.ItemID == itemID)?.GetSetBonusText() ?? "";
    }

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
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.ShroomiteHeadgear, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Shroomite");
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.ShroomiteMask, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Shroomite");
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.ShroomiteHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Shroomite");
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.WoodHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Wood");
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.EbonwoodHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Wood");
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.RichMahoganyHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Wood");
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.PearlwoodHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Wood");
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.ShadewoodHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Wood");
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.BorealWoodHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Wood");
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.PalmWoodHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Wood");
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.AshWoodHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.AshWood");
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.CopperHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.MetalTier1");
            if (ModInstances.Calamity != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Copper", 2)}";
            }

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Thunder.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.AncientIronHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.MetalTier1");
            if (ModInstances.Calamity != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Iron", 1.5)}";
            }

            if (ModInstances.Redemption != null)
            {
               bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Earth.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.IronHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.MetalTier1");
            if (ModInstances.Calamity != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Iron", 1.5)}";
            }

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Earth.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.TinHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.MetalTier1");
            if (ModInstances.Calamity != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Tin", 10)}";
            }

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Thunder.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.SilverHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.MetalTier2");
            if (ModInstances.Calamity != null)
            {
                object[] args = [2, 20, 10];
                bonus += $"\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Silver", args)}";
            }

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Damage", 20, Language.GetTextValue("Mods.Redemption.Items.Thunder.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.GoldHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.MetalTier2");
            if (ModInstances.Calamity != null)
            {
                object[] args = [2, 3, 0.2, 5];
                bonus += $"\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Gold", args)}";
            }

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Arcane.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.AncientGoldHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.MetalTier2");
            if (ModInstances.Calamity != null)
            {
                object[] args = [2, 3, 0.2, 5];
                bonus += $"\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Gold", args)}";
            }

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Arcane.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.LeadHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.MetalTier2");
            if (ModInstances.Calamity != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Lead")}";
            }

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Earth.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.TungstenHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.MetalTier2");
            if (ModInstances.Calamity != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Tungsten", 50)}";
            }

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Damage", 20, Language.GetTextValue("Mods.Redemption.Items.Thunder.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.PlatinumHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Platinum");
            if (ModInstances.Calamity != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Platinum", 10)}";
            }

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Damage", 20, Language.GetTextValue("Mods.Redemption.Items.Arcane.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.PumpkinHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Pumpkin");
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.GladiatorHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Gladiator");
            if (ModInstances.Calamity != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Gladiator")}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.NinjaHood, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Ninja");
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.FossilHelm, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Fossil");

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Earth.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.AncientNecroHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Bone");
            if (ModInstances.Calamity != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Necro", 10)}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.NecroHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Bone");
            if (ModInstances.Calamity != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Necro", 10)}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.BeetleHelmet, () =>
        {
            string beetleScaleMail = $"Если надета {Language.GetTextValue("ItemName.BeetleScaleMail")}: {Language.GetTextValue("ArmorSetBonus.BeetleDamage")}";
            string beetleShell = $"Если надет {Language.GetTextValue("ItemName.BeetleShell")}: {Language.GetTextValue("ArmorSetBonus.BeetleDefense")}";
            string bonus = $"{beetleScaleMail}\n{beetleShell}";

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Nature.DisplayName"))}";
            }

            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.WizardHat, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Wizard");
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.MagicHat, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.MagicHat");
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.ShadowHelmet, () =>
        { 
            string bonus = Language.GetTextValue("ArmorSetBonus.ShadowScale");

            if (ModInstances.Redemption != null)
            {
               bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Shadow.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.AncientShadowHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.ShadowScale");

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Shadow.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.CrimsonHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Crimson");
            if (ModInstances.Calamity != null)
            {
                bonus = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Crimson");
            }

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Blood.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.SpectreHood, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.SpectreHealing");
            if (ModInstances.Calamity != null)
            {
                bonus = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.SpectreHealing");
            }

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Arcane.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.SpectreMask, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.SpectreDamage");
            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Arcane.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.MeteorHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Meteor");
            if (ModInstances.Calamity != null)
            {
                bonus = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Meteor");
            }

            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.FrostHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Frost");
            if (ModInstances.Calamity != null)
            {
                bonus = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Frost", 20);
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.AncientCobaltHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Jungle");
            if (ModInstances.Calamity != null)
            {
                bonus = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Jungle");
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.JungleHat, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Jungle");
            if (ModInstances.Calamity != null)
            {
                bonus = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Jungle");
            }

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Nature.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.MoltenHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Molten");
            if (ModInstances.Calamity != null)
            {
                bonus = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Molten");
            }

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Fire.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.EskimoHood, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Snow");
            if (ModInstances.Calamity != null)
            {
                bonus = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Eskimo");
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.PinkEskimoHood, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Snow");
            if (ModInstances.Calamity != null)
            {
                bonus = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Eskimo");
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.MiningHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Mining");
            if (ModInstances.Calamity != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Mining")}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.UltrabrightHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Mining");
            if (ModInstances.Calamity != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Mining")}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.ChlorophyteMask, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.ChlorophyteMelee");

            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.ChlorophyteHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Chlorophyte");

            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.ChlorophyteHeadgear, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Chlorophyte");

            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.AnglerHat, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Angler");
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.CactusHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Cactus");
            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Nature.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.TurtleHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Turtle");

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Nature.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.CobaltHat, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.CobaltCaster");
            if (ModInstances.Calamity != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Cobalt", 10)}";
            }
            
            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Water.DisplayName"))}";
            }

            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.CobaltHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.CobaltMelee");
            if (ModInstances.Calamity != null)
            {
                string meleeBonus = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Cobalt.Melee");
                string mainBonus = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Cobalt", 10);
                bonus = $"{meleeBonus}\n{mainBonus}";
            }

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Water.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.CobaltMask, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.CobaltRanged");
            if (ModInstances.Calamity != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Cobalt", 10)}";
            }
            
            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Water.DisplayName"))}";
            }

            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.MythrilHood, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.MythrilCaster");
            if (ModInstances.Calamity != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Mythril", 12)}";
            }
            
            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Arcane.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.MythrilHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.MythrilMelee");
            if (ModInstances.Calamity != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Mythril", 12)}";
            }

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Arcane.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.MythrilHat, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.MythrilRanged");
            if (ModInstances.Calamity != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Mythril", 12)}";
            }
            
            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Arcane.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.AdamantiteHeadgear, () =>
        {
            object[] args = [25, 10, 3.5];
            string bonus = Language.GetTextValue("ArmorSetBonus.AdamantiteCaster");
            if (ModInstances.Calamity != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Adamantite", args)}";
            }
            
            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Earth.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.AdamantiteHelmet, () =>
        {
            object[] args = [25, 10, 3.5];
            string bonus = Language.GetTextValue("ArmorSetBonus.AdamantiteMelee");
            if (ModInstances.Calamity != null)
            {
                bonus = $"{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Adamantite.Melee")}\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Adamantite", args)}";
            }

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Earth.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.AdamantiteMask, () =>
        {
            object[] args = [25, 10, 3.5];
            string bonus = Language.GetTextValue("ArmorSetBonus.AdamantiteRanged");
            if (ModInstances.Calamity != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Adamantite", args)}";
            }
            
            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Earth.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.PalladiumMask, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Palladium");
            if (ModInstances.Calamity != null)
            {
                bonus = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Palladium");
            }
            
            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Holy.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.PalladiumHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Palladium");
            if (ModInstances.Calamity != null)
            {
                bonus = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Palladium");
            }

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Holy.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.PalladiumHeadgear, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Palladium");
            if (ModInstances.Calamity != null)
            {
                bonus = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Palladium");
            }
            
            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Holy.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.OrichalcumMask, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Orichalcum");

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Nature.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.OrichalcumHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Orichalcum");

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Nature.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.OrichalcumHeadgear, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Orichalcum");

            if (ModInstances.Redemption != null)
            {
               bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Nature.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.TitaniumHeadgear, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Titanium");

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Damage", 20, Language.GetTextValue("Mods.Redemption.Items.Thunder.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.TitaniumMask, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Titanium");

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Damage", 20, Language.GetTextValue("Mods.Redemption.Items.Thunder.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.TitaniumHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Titanium");

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Damage", 20, Language.GetTextValue("Mods.Redemption.Items.Thunder.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.HallowedHeadgear, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Hallowed");

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Holy.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.HallowedHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Hallowed");

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Holy.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.HallowedMask, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Hallowed");

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Holy.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.HallowedHood, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.HallowedSummoner");
            
            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Holy.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.AncientHallowedHeadgear, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Hallowed");

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Holy.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.AncientHallowedHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Hallowed");

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Holy.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.AncientHallowedMask, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Hallowed");

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Holy.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.AncientHallowedHood, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.HallowedSummoner");
            
            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Holy.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.CrystalNinjaHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.CrystalNinja");
            if (ModInstances.Calamity != null)
            {
                bonus = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.CrystalAssassin");
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.TikiMask, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Tiki");
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.SpookyHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Spooky");
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.BeeHeadgear, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Bee");
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.SpiderMask, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Spider");
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.SolarFlareHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Solar");

            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.SolarCelestial",
                    Language.GetTextValue("Mods.Redemption.Items.Celestial.DisplayName"),
                    Language.GetTextValue("Mods.Redemption.Items.Fire.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.VortexHelmet, () =>
        {
            string reversedUpDown = Language.GetTextValue(Main.ReversedUpDownArmorSetBonuses ? "Key.UP" : "Key.DOWN");
            string bonus = Language.GetTextValue("ArmorSetBonus.Vortex", reversedUpDown);
            
            if (ModInstances.Calamity != null)
            {
                string key = (string)ModInstances.Calamity.Code.GetType("CalamityMod.CalamityUtils").FindMethod("GetArmorSetBonusKey").Invoke(null, null);
                bonus = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Vortex", key).Replace($"{Language.GetTextValue("LegacyTooltip.48")} ", "");
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.NebulaHelmet, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.Nebula");
            if (ModInstances.Calamity != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Nebula")}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.StardustHelmet, () =>
        {
            string reversedUpDown = Language.GetTextValue(Main.ReversedUpDownArmorSetBonuses ? "Key.UP" : "Key.DOWN");
            string bonus = Language.GetTextValue("ArmorSetBonus.Stardust", reversedUpDown);
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.AncientBattleArmorHat, () =>
        {
            string reversedUpDown = Language.GetTextValue(Main.ReversedUpDownArmorSetBonuses ? "Key.UP" : "Key.DOWN");
            string bonus = Language.GetTextValue("ArmorSetBonus.Forbidden", reversedUpDown);

            if (ModInstances.Calamity != null)
            {
                string key = (string)ModInstances.Calamity.Code.GetType("CalamityMod.CalamityUtils").FindMethod("GetArmorSetBonusKey").Invoke(null, null);
                bonus = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Forbidden", key)
                    .Replace($"{Language.GetTextValue("LegacyTooltip.48")} ", "");
            }
            
            if (ModInstances.Redemption != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.VanillaArmor.Resistance", 20, Language.GetTextValue("Mods.Redemption.Items.Earth.DisplayName"))}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.SquireGreatHelm, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.SquireTier2");
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.ApprenticeHat, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.ApprenticeTier2");
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.HuntressWig, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.HuntressTier2");
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.MonkBrows, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.MonkTier2");
            if (ModInstances.Calamity != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.MonkTier2", 90)}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.SquireAltHead, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.SquireTier3");
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.ApprenticeAltHead, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.ApprenticeTier3");
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.HuntressAltHead, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.HuntressTier3");
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.MonkAltHead, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.MonkTier3");
            if (ModInstances.Calamity != null)
            {
                bonus += $"\n{Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.MonkTier3", 90)}";
            }
            
            return bonus;
        }));
        ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.ObsidianHelm, () =>
        {
            string bonus = Language.GetTextValue("ArmorSetBonus.ObsidianOutlaw");
            if (ModInstances.Calamity != null)
            {
                bonus = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Obsidian");
            }
            
            return bonus;
        }));

        if (ModInstances.Calamity != null)
        {
            ArmorSetBonuses.Add(new ArmorSetBonusData(ItemID.RainHat, () =>
            {
                string bonus = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SetBonus.Rain");
            
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/AstralHelm"), () =>
            {
                object[] args = [3, 10, 1];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/AstralHelm", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/BrimflameCowl"), () =>
            {
                string key = (string)ModInstances.Calamity.Code.GetType("CalamityMod.CalamityUtils").FindMethod("GetArmorSetBonusKey").Invoke(null, null);
                object[] args = [8, "FF9173", key, 10, 40, 30];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/BrimflameCowl", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/DaedalusHeadMagic"), () =>
            {
                object[] args = [10, 50];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/DaedalusHeadMagic", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/DaedalusHeadMelee"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("CalamityMod/DaedalusHeadMelee", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/DaedalusHeadRanged"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("CalamityMod/DaedalusHeadRanged", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/DaedalusHeadRogue"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("CalamityMod/DaedalusHeadRogue", "SetBonus", 105);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/DaedalusHeadSummon"), () =>
            {
                object[] args = [1, 10];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/DaedalusHeadSummon", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/FathomSwarmerVisage"), () =>
            {
                object[] args = [2, 10, 20, 10, 2.5];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/FathomSwarmerVisage", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/ForbiddenCirclet"), () =>
            {
                string key = (string)ModInstances.Calamity.Code.GetType("CalamityMod.CalamityUtils").FindMethod("GetArmorSetBonusKey").Invoke(null, null);
                float manaCost = 60 * Main.LocalPlayer.manaCost;
                object[] args = [40, key, (int)manaCost];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/ForbiddenCirclet", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/LunicCorpsHelmet"), () =>
            {
                string shieldAdren = TranslationHelper.GetTextValue("CalamityMod/LunicCorpsHelmet", "ShieldAdren");
                object[] args = [20, "52CBDE", 50, $"\n{shieldAdren}", 5, 2];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/LunicCorpsHelmet", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/MolluskShellmet"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("CalamityMod/MolluskShellmet", "SetBonus", 10);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/PlaguebringerVisor"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("CalamityMod/PlaguebringerVisor", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/PlagueReaperMask"), () =>
            {
                string key = (string)ModInstances.Calamity.Code.GetType("CalamityMod.CalamityUtils").FindMethod("GetArmorSetBonusKey").Invoke(null, null);
                object[] args = [5, 1.1, "009418", key, 60, 20, 5, 25];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/PlagueReaperMask", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/ReaverHeadExplore"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("CalamityMod/ReaverHeadExplore", "SetBonus", 7);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/ReaverHeadMobility"), () =>
            {
                object[] args = [10, 50, 33.3];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/ReaverHeadMobility", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/ReaverHeadTank"), () =>
            {
                object[] args = [20, 30, 5];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/ReaverHeadTank", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/TitanHeartMask"), () =>
            {
                object[] args = [100, 2];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/TitanHeartMask", "SetBonus", args);
            
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/UmbraphileHood"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("CalamityMod/UmbraphileHood", "SetBonus", 110);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/AuricTeslaHeadRanged"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("CalamityMod/AuricTeslaHeadRanged", "SetBonus");
            
                if (ModInstances.Catalyst != null)
                {
                    bonus += $"\n\nУлучшенная версия: {Language.GetTextValue("Mods.CatalystMod.AuricTeslaPlusSet.Ranged", "[Межгелектический бонус комплекта]")}";
                }
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/AuricTeslaHeadRogue"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("CalamityMod/AuricTeslaHeadRogue", "SetBonus", 130);
                
                if (ModInstances.Catalyst != null)
                {
                    bonus += $"\n\nУлучшенная версия: {Language.GetTextValue("Mods.CatalystMod.AuricTeslaPlusSet.Rogue", "[Межгелектический бонус комплекта]")}";
                }
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/AuricTeslaHeadMelee"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("CalamityMod/AuricTeslaHeadMelee", "SetBonus");
                
                if (ModInstances.Catalyst != null)
                {
                    bonus += $"\n\nУлучшенная версия: {Language.GetTextValue("Mods.CatalystMod.AuricTeslaPlusSet.Melee", "[Межгелектический бонус комплекта]")}";
                }
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/AuricTeslaHeadSummon"), () =>
            {
                object[] args = [4, 55];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/AuricTeslaHeadSummon", "SetBonus", args);
            
                if (ModInstances.Catalyst != null)
                {
                    bonus += $"\n\nУлучшенная версия: {Language.GetTextValue("Mods.CatalystMod.AuricTeslaPlusSet.Summoner", "[Межгелектический бонус комплекта]")}";
                }
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/AuricTeslaHeadMagic"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("CalamityMod/AuricTeslaHeadMagic", "SetBonus");
            
                if (ModInstances.Catalyst != null)
                {
                    bonus += $"\n\nУлучшенная версия: {Language.GetTextValue("Mods.CatalystMod.AuricTeslaPlusSet.Magic", "[Межгелектический бонус комплекта]")}";
                }
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/DemonshadeHelm"), () =>
            {
                string key = (string)ModInstances.Calamity.Code.GetType("CalamityMod.CalamityUtils").FindMethod("GetArmorSetBonusKey").Invoke(null, null);
                object[] args = [8, 100, key, 10, 1.5, 1.25];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/DemonshadeHelm", "SetBonus", args);
                
                // if (ModInstances.NoxusBoss != null)
                // {
                //     bonus = bonus.Replace("125", "50").Replace("25", "50");
                // }
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/EmpyreanMask"), () =>
            {
                object[] args = [115, 50];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/EmpyreanMask", "SetBonus", args);
            
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/FearmongerGreathelm"), () =>
            {
                object[] args = [2, 2.5];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/FearmongerGreathelm", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/OmegaBlueHelmet"), () =>
            {
                string key = (string)ModInstances.Calamity.Code.GetType("CalamityMod.CalamityUtils").FindMethod("GetArmorSetBonusKey").Invoke(null, null);
                object[] args = [2, "99ABFF", key, 5, 10, 25];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/OmegaBlueHelmet", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/PrismaticHelmet"), () =>
            {
                string key = (string)ModInstances.Calamity.Code.GetType("CalamityMod.CalamityUtils").FindMethod("GetArmorSetBonusKey").Invoke(null, null);
                object[] args = ["67F4FB", key, 5, 30];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/PrismaticHelmet", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/SnowRuffianMask"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("CalamityMod/SnowRuffianMask", "SetBonus", 3);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/SulphurousHelmet"), () =>
            {
                object[] args = [65, 1];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/SulphurousHelmet", "SetBonus", args);
            
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/VictideHeadRanged"), () =>
            {
                string commonSetBonus = TranslationHelper.GetTextValue("CalamityMod/VictideBreastplate", "CommonSetBonus");
                string bonus = TranslationHelper.GetTextValue("CalamityMod/VictideHeadRanged", "SetBonus");
            
                return $"{bonus}\n{commonSetBonus}";
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/VictideHeadMagic"), () =>
            {
                string commonSetBonus = TranslationHelper.GetTextValue("CalamityMod/VictideBreastplate", "CommonSetBonus");
                string bonus = TranslationHelper.GetTextValue("CalamityMod/VictideHeadMagic", "SetBonus");
                
                return $"{bonus}\n{commonSetBonus}";
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/VictideHeadMelee"), () =>
            {
                string commonSetBonus = TranslationHelper.GetTextValue("CalamityMod/VictideBreastplate", "CommonSetBonus");
                string bonus = TranslationHelper.GetTextValue("CalamityMod/VictideHeadMelee", "SetBonus");
                
                return $"{bonus}\n{commonSetBonus}";
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/VictideHeadRogue"), () =>
            {
                string commonSetBonus = TranslationHelper.GetTextValue("CalamityMod/VictideBreastplate", "CommonSetBonus");
                string bonus = TranslationHelper.GetTextValue("CalamityMod/VictideHeadRogue", "SetBonus");
                
                return $"{bonus}\n{commonSetBonus}";
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/VictideHeadSummon"), () =>
            {
                string commonSetBonus = TranslationHelper.GetTextValue("CalamityMod/VictideBreastplate", "CommonSetBonus");
                string bonus = TranslationHelper.GetTextValue("CalamityMod/VictideHeadSummon", "SetBonus");
                
                return $"{bonus}\n{commonSetBonus}";
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/StatigelHeadMagic"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("CalamityMod/StatigelArmor", "CommonSetBonus", 12);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/StatigelHeadRanged"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("CalamityMod/StatigelArmor", "CommonSetBonus", 12);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/StatigelHeadMelee"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("CalamityMod/StatigelHeadMelee", "SetBonus", 12);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/StatigelHeadRogue"), () =>
            {
                object[] args = [90, 12];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/StatigelHeadRogue", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/StatigelHeadSummon"), () =>
            {
                object[] args = [15, 12];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/StatigelHeadSummon", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/HydrothermicHeadMagic"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("CalamityMod/HydrothermicHeadMagic", "SetBonus", 50);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/HydrothermicHeadMelee"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("CalamityMod/HydrothermicHeadMelee", "SetBonus", 50);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/HydrothermicHeadRanged"), () =>
            {
                object[] args = [0.33, 50];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/HydrothermicHeadRanged", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/HydrothermicHeadRogue"), () =>
            {
                object[] args = [110, 2, 50];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/HydrothermicHeadRogue", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/HydrothermicHeadSummon"), () =>
            {
                object[] args = [1, 25, 50];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/HydrothermicHeadSummon", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/BloodflareHeadMagic"), () =>
            {
                object[] args = [1.67, 2];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/BloodflareHeadMagic", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/BloodflareHeadMelee"), () =>
            {
                object[] args = [15, 5, 25, 50, 30];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/BloodflareHeadMelee", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/BloodflareHeadRanged"), () =>
            {
                string key = (string)ModInstances.Calamity.Code.GetType("CalamityMod.CalamityUtils").FindMethod("GetArmorSetBonusKey").Invoke(null, null);
                object[] args = [key, 30, 2.5];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/BloodflareHeadRanged", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/BloodflareHeadRogue"), () =>
            {
                object[] args = [120, 30, 80];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/BloodflareHeadRogue", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/BloodflareHeadSummon"), () =>
            {
                object[] args = [2, 30, 20, 50];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/BloodflareHeadSummon", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/GodSlayerHeadMelee"), () =>
            {
                object[] args = [80, "[Простанственный скачок]", 45];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/GodSlayerHeadMelee", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/GodSlayerHeadRanged"), () =>
            {
                object[] args = [2.5, "[Простанственный скачок]", 45];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/GodSlayerHeadRanged", "SetBonus", args);
                    
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/GodSlayerHeadRogue"), () =>
            {
                object[] args = [120, 10, 80, "[Простанственный скачок]", 45];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/GodSlayerHeadRogue", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/SilvaHeadMagic"), () =>
            {
                object[] args = [3, 5, 5, 5];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/SilvaHeadMagic", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/SilvaHeadSummon"), () =>
            {
                object[] args = [3, 40, 3, 5, 5, 5];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/SilvaHeadSummon", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/TarragonHeadMagic"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("CalamityMod/TarragonHeadMagic", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/TarragonHeadMelee"), () =>
            {
                string key = (string)ModInstances.Calamity.Code.GetType("CalamityMod.CalamityUtils").FindMethod("GetArmorSetBonusKey").Invoke(null, null);
                object[] args = [1.5, key, 10, 30];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/TarragonHeadMelee", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/TarragonHeadRanged"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("CalamityMod/TarragonHeadRanged", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/TarragonHeadRogue"), () =>
            {
                object[] args = [115, 50, 2.5, 25, 10];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/TarragonHeadRogue", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/TarragonHeadSummon"), () =>
            {
                object[] args = [2, 30];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/TarragonHeadSummon", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/AerospecHeadMagic"), () =>
            {
                object[] args = [8, 5, 25];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/AerospecHeadMagic", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/AerospecHeadRogue"), () =>
            {
                object[] args = [80, 5, 25];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/AerospecHeadRogue", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/AerospecHeadMelee"), () =>
            {
                object[] args = [5, 25];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/AerospecHeadMelee", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/AerospecHeadSummon"), () =>
            {
                object[] args = [1, 11, 25];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/AerospecHeadSummon", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/AerospecHeadRanged"), () =>
            {
                object[] args = [5, 25];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/AerospecHeadRanged", "SetBonus", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/DesertProwlerHat"), () =>
            {
                string key = (string)ModInstances.Calamity.Code.GetType("CalamityMod.CalamityUtils").FindMethod("GetArmorSetBonusKey").Invoke(null, null);
                object[] args = [50, "CCB648", key, 200, 200, 2];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/DesertProwlerHat", "SetBonus", args);

                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/WulfrumHat"), () =>
            {
                string key = (string)ModInstances.Calamity.Code.GetType("CalamityMod.CalamityUtils").FindMethod("GetArmorSetBonusKey").Invoke(null, null);
                object[] args = ["6EC05D", key, 30, 2];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/WulfrumHat", "SetBonus", args);

                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/MarniteArchitectHeadgear"), () =>
            {
                object[] args = ["91C5EF", 10];
                string bonus = TranslationHelper.GetTextValue("CalamityMod/MarniteArchitectHeadgear", "SetBonus", args);

                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CalamityMod/GemTechHeadgear"), () =>
            {
                string abilityBrief = TranslationHelper.GetTextValue("CalamityMod/GemTechHeadgear", "AbilityBrief", "808080");
                string abilityDescription = TranslationHelper.GetTextValue("CalamityMod/GemTechHeadgear", "AbilityDescription");

                return $"{abilityBrief}\n{abilityDescription}";
            }));
        }

        if (ModInstances.FargowiltasSouls != null)
        {
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("FargowiltasSouls/EridanusHat"), () =>
            {
                string reversedUpDown = Language.GetTextValue(Main.ReversedUpDownArmorSetBonuses ? "Key.UP" : "Key.DOWN");
                string bonus = Language.GetTextValue("Mods.FargowiltasSouls.SetBonus.EridanusOff", reversedUpDown);

                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("FargowiltasSouls/GaiaHelmet"), () =>
            {
                string reversedUpDown = Language.GetTextValue(Main.ReversedUpDownArmorSetBonuses ? "Key.UP" : "Key.DOWN");
                string bonus = Language.GetTextValue("Mods.FargowiltasSouls.SetBonus.Gaia", reversedUpDown);

                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("FargowiltasSouls/MutantMask"), () =>
            {
                string bonus = Language.GetTextValue("Mods.FargowiltasSouls.SetBonus.Mutant");

                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("FargowiltasSouls/StyxCrown"), () =>
            {
                string reversedUpDown = Language.GetTextValue(Main.ReversedUpDownArmorSetBonuses ? "Key.UP" : "Key.DOWN");
                string bonus = Language.GetTextValue("Mods.FargowiltasSouls.SetBonus.Styx", reversedUpDown);

                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("FargowiltasSouls/NekomiHood"), () =>
            {
                string reversedUpDown = Language.GetTextValue(Main.ReversedUpDownArmorSetBonuses ? "Key.UP" : "Key.DOWN");
                string bonus = Language.GetTextValue("Mods.FargowiltasSouls.SetBonus.Nekomi", reversedUpDown);

                return bonus;
            }));
        }

        if (ModInstances.Thorium != null)
        {
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/WhisperingHood"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/WhisperingHood", "SetBonus", 6);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/FlightMask"), () =>
            {
                string bonus = "Позволяет кратковременно летать";
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/YewWoodHelmet"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/YewWoodHelmet", "SetBonus", 150);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/CriersCap"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/CriersCap", "SetBonus", 3);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/CyberPunkHeadset"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/CyberPunkHeadset", "SetBonus", "II");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/JestersMask"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/JestersMask", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/JestersMask2"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/JestersMask", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/MaestroWig"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/MaestroWig", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/MarchingBandShako"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/MarchingBandShako", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/NoblesHat"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/NoblesHat", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/OrnateHat"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/OrnateHat", "SetBonus", 5);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/ShootingStarHat"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/OrnateHat", "SetBonus", 6, 5, 2);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/LichCowl"), () =>
            {
                string bonus = "Из убитого врага можно извлечь фрагмент души\nКоснувшись фрагмента души, вы значительно увеличиваете скорость передвижения и метания на короткое время";
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/TideTurnerHelmet"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/TideTurnerHelmet", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/TideTurnersGaze"), () =>
            {
                string bonus = "При нанесении метательного урона с 20% шансом вокруг вас выпускаются акватические самонаводящиеся кинжалы";
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/DreamWeaversHelmet"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/DreamWeaversHelmet", "SetBonus", 200, 15);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/DreamWeaversHood"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/DreamWeaversHood", "SetBonus", 200);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/MasterArbalestHood"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/DreamWeaversHood", "SetBonus", 10, 15);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/MasterMarksmansScouter"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/DreamWeaversHood", "SetBonus", 5, 5);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/InspiratorsHelmet"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/InspiratorsHelmet", "SetBonus", "III", 15, 20, 1);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/SoloistHat"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/SoloistHat", "SetBonus", 10, 1);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/MagmaSeersMask"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/MagmaSeersMask", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/PyromancerCowl"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/PyromancerCowl", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/BronzeHelmet"), () =>
            {
                string bonus = "Метательный урон с 20% шансом высвобождает пронзающий удар молнии";
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/CoralHelmet"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/CoralHelmet", "SetBonus", 1, 20);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/DarksteelFaceGuard"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/DarksteelFaceGuard", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/DemonBloodHelmet"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/DemonBloodHelmet", "SetBonus", 100);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/DepthDiverHelmet"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/DepthDiverHelmet", "SetBonus", 10, 10);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/NagaSkinMask"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/NagaSkinMask", "SetBonus", 75);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/TideHunterCap"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/TideHunterCap", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/FeralFurHead"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/FeralFurHead", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/DragonMask"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/DragonMask", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/DreadSkull"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/DreadSkull", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/SilkHat"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/DreadSkull", "SetBonus", 25, 90);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/FleshMask"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/FleshMask", "SetBonus", 10);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/GeodeHelmet"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/GeodeHelmet", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/GraniteHelmet"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/GraniteHelmet", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/BioTechHood"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/BioTechHood", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/BloomingCrown"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/BloomingCrown", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/CelestialCrown"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/CelestialCrown", "SetBonus", 150, 15);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/EbonHood"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/EbonHood", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/FallenPaladinFaceguard"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/FallenPaladinFaceguard", "SetBonus", 15);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/IridescentHelmet"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/IridescentHelmet", "SetBonus", 15, "[X]");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/LifeBinderMask"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/LifeBinderMask", "SetBonus", 50);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/NoviceClericCowl"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/NoviceClericCowl", "SetBonus", 5, 3);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/SacredHelmet"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/SacredHelmet", "SetBonus", 5);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/TemplarsCirclet"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/TemplarsCirclet", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/WarlockHood"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/WarlockHood", "SetBonus", 15);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/IcyHeadgear"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/IcyHeadgear", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/IllumiteMask"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/IllumiteMask", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/LodeStoneFaceGuard"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/LodeStoneFaceGuard", "SetBonus", 6, 25, 18);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/CryomancersCrown"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/CryomancersCrown", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/WhiteKnightMask"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/WhiteKnightMask", "SetBonus", 40, "X", "X", "X");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/ConduitHelmet"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/ConduitHelmet", "SetBonus", 5);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/HallowedChapeau"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/HallowedChapeau", "SetBonus", 8);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/AncientHallowedChapeau"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/HallowedChapeau", "SetBonus", 8);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/HallowedCowl"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/HallowedCowl", "SetBonus", 6);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/AncientHallowedCowl"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/HallowedCowl", "SetBonus", 6);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/HallowedGuise"), () =>
            {
                string bonus = "После удара по врагу вы становитесь неуязвимым; увеличивает максимальное число очков техники на 2";
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/SandStoneHelmet"), () =>
            {
                string bonus = "Пустынные ветра дают песчаный двойной прыжок";
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/DurasteelHelmet"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/DurasteelHelmet", "SetBonus", 10);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/SteelHelmet"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/SteelHelmet", "SetBonus", 8);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/AstroHelmet"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/AstroHelmet", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/LifeBloomMask"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/LifeBloomMask", "SetBonus", 25, 50, 10);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/LivingWoodMask"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/LivingWoodMask", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/SpiritTrapperCowl"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/SpiritTrapperCowl", "SetBonus", 1, 5, 10);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/SpiritTrapperMask"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/SpiritTrapperMask", "SetBonus", 1, 5, 10);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/TerrariumHelmet"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/TerrariumHelmet", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/ThoriumHelmet"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/ThoriumHelmet", "SetBonus", 10);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/FungusHat"), () =>
            {
                string bonus = "Увеличивает урон по заражённым мицелием врагам на 10%\nПри нанесении урона врагам, заражённым мицелием, метательная скорость атаки временно увеличивается на 10%";
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/PlagueDoctorsMask"), () =>
            {
                string bonus = "Чумной газ рассеивается в воздухе вдвое медленнее, а чумные реактивы наносят на 20% больше урона";
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/ShadeMasterMask"), () =>
            {
                string bonus = "До 50% полученного урона распределяется равномерно в течение 10 секунд";
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/WhiteDwarfMask"), () =>
            {
                string bonus = "Критические удары высвобождают из космоса изумрудные вспышки\nИзумрудные вспышки наносят урон, равный 0.1% от максимального здоровья цели";
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/TitanHeadgear"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/TitanHeadgear", "SetBonus", 18);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/TitanHelmet"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/TitanHelmet", "SetBonus", 18);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/TitanMask"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/TitanMask", "SetBonus", 18);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/ValadiumHelmet"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/ValadiumHelmet", "SetBonus", 15);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/BlueKnightHelmet"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/BlueKnightHelmet", "SetBonus");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("ThoriumMod/GlitteringHelmet"), () =>
            {
                string bonus = TranslationHelper.GetTextValue("ThoriumMod/GlitteringHelmet", "SetBonus");
                
                return bonus;
            }));
        }
        
        if (ModInstances.StarsAbove != null)
        {
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("StarsAbove/NeopursuantHeadbooster"), () =>
            {
                string neopursuantPlasteel = $"Если надета {TranslationHelper.GetTextValue("StarsAbove/NeopursuantPlasteel", "DisplayName")}: {Language.GetTextValue("Mods.StarsAbove.Common.NeopursuantSetBonusFullMetalArcanist")}";
                string neopursuantRoguegarb = $"Если надето {TranslationHelper.GetTextValue("StarsAbove/NeopursuantRoguegarb", "DisplayName")}: {Language.GetTextValue("Mods.StarsAbove.Common.NeopursuantSetBonusInfiltrator")}";
                
                return $"{neopursuantPlasteel}\n{neopursuantRoguegarb}";
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("StarsAbove/NeopursuantDualShield"), () =>
            {
                string neopursuantPlasteel = $"Если надета {TranslationHelper.GetTextValue("StarsAbove/NeopursuantPlasteel", "DisplayName")}: {Language.GetTextValue("Mods.StarsAbove.Common.NeopursuantSetBonusBackupBattery")}";
                string neopursuantRoguegarb = $"Если надето {TranslationHelper.GetTextValue("StarsAbove/NeopursuantRoguegarb", "DisplayName")}: {Language.GetTextValue("Mods.StarsAbove.Common.NeopursuantSetBonusEnviroSavant")}";

                return $"{neopursuantPlasteel}\n{neopursuantRoguegarb}";
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("StarsAbove/NeopursuantHiGuard"), () =>
            {
                string neopursuantPlasteel = $"Если надета {TranslationHelper.GetTextValue("StarsAbove/NeopursuantPlasteel", "DisplayName")}: {Language.GetTextValue("Mods.StarsAbove.Common.NeopursuantSetBonusCataphractArms")}";
                string neopursuantRoguegarb = $"Если надето {TranslationHelper.GetTextValue("StarsAbove/NeopursuantRoguegarb", "DisplayName")}: {Language.GetTextValue("Mods.StarsAbove.Common.NeopursuantSetBonusViralUpload")}";
                
                return $"{neopursuantPlasteel}\n{neopursuantRoguegarb}";
            }));
        }
        
        if (ModInstances.Redemption != null)
        {
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("Redemption/LivingWoodHelmet"), () =>
            {
                string bonus = Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.LivingWood",
                    Language.GetTextValue("Mods.Redemption.Items.Nature.DisplayName"));

                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("Redemption/CommonGuardHelm1"), () =>
            {
                string args = Language.GetTextValue("Mods.Redemption.Keybinds.SpecialAbilityKey.DisplayName");
                string bonus = Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.CommonGuardHelm1", $"[{args}]");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("Redemption/CommonGuardHelm2"), () =>
            {
                string args = Language.GetTextValue("Mods.Redemption.Keybinds.SpecialAbilityKey.DisplayName");
                string bonus = Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.CommonGuardHelm2", $"[{args}]");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("Redemption/PureIronHelmet"), () =>
            {
                string bonus = Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.PureIron.Bonus",
                    Language.GetTextValue("Mods.Redemption.Items.Fire.DisplayName"),
                    Language.GetTextValue("Mods.Redemption.Items.Ice.DisplayName"));
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("Redemption/DragonLeadSkull"), () =>
            {
                string bonus = Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.DragonLead.Bonus",
                    Language.GetTextValue("Mods.Redemption.Items.Ice.DisplayName"),
                    Language.GetTextValue("Mods.Redemption.Items.Fire.DisplayName"));
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("Redemption/XenomiteHelmet"), () =>
            {
                string bonus = Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Xenomite.Bonus1") +
                               Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Xenomite.Press") +
                               "[Особая способность]" +
                               Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Xenomite.Bonus2");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("Redemption/XeniumVisor"), () =>
            {
                object[] args = [
                    $"[{Language.GetTextValue("Mods.Redemption.Keybinds.SpecialAbilityKey.DisplayName")}]",
                    Language.GetTextValue("Mods.Redemption.Items.Poison.DisplayName"),
                    Language.GetTextValue("Mods.Redemption.Items.Explosive.DisplayName"),
                ];
                string bonus = Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Xenium", args);
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("Redemption/HardlightCowl"), () =>
            {
                string bonus = Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Hardlight.Press") +
                               "[Особая способность]" +
                               Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Hardlight.Support") +
                               Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Hardlight.Cowl");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("Redemption/HardlightCasque"), () =>
            {
                string bonus = Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Hardlight.Press") +
                               "[Особая способность]" +
                               Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Hardlight.Support") +
                               Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Hardlight.Casque");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("Redemption/HardlightHelm"), () =>
            {
                string bonus =  Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Hardlight.Press") +
                                "[Особая способность]" +
                                Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Hardlight.Support") +
                                Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Hardlight.Helm");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("Redemption/HardlightHood"), () =>
            {
                string bonus = Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Hardlight.Press") +
                               "[Особая способность]" +
                               Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Hardlight.Support") +
                               Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Hardlight.Hood");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("Redemption/HardlightVisor"), () =>
            {
                string bonus = Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Hardlight.Press") +
                               "[Особая способность]" +
                               Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Hardlight.Support") +
                               Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.Hardlight.Visor");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("Redemption/ElderWoodHelmet"), () =>
            {
                string bonus = Language.GetTextValue("Mods.Redemption.GenericTooltips.ArmorSetBonus.ElderWood",
                    Language.GetTextValue("Mods.Redemption.Items.Nature.DisplayName"),
                    Language.GetTextValue("Mods.Redemption.Items.Poison.DisplayName"));
                
                return bonus;
            }));
        }
        
        if (ModInstances.Catalyst != null)
        {
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CatalystMod/IntergelacticHeadMelee"), () =>
            {
                string bonus = Language.GetTextValue("Mods.CatalystMod.ArmorSetBonus.IntergelacticMelee", "[Межгелектический бонус комплекта]");
                
                return bonus;
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CatalystMod/IntergelacticHeadRanged"), () =>
            {
                string intergelacticAll = Language.GetTextValue("Mods.CatalystMod.ArmorSetBonus.IntergelacticAll", "[Межгелектический бонус комплекта]");
                string intergelacticRanged = Language.GetTextValue("Mods.CatalystMod.ArmorSetBonus.IntergelacticRanged");
                
                return $"{intergelacticAll}\n{intergelacticRanged}";
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CatalystMod/IntergelacticHeadMagic"), () =>
            {
                string intergelacticAll = Language.GetTextValue("Mods.CatalystMod.ArmorSetBonus.IntergelacticAll", "[Межгелектический бонус комплекта]");
                string intergelacticMagic = Language.GetTextValue("Mods.CatalystMod.ArmorSetBonus.IntergelacticMagic");
                
                return $"{intergelacticAll}\n{intergelacticMagic}";
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CatalystMod/IntergelacticHeadSummon"), () =>
            {
                string intergelacticAll = Language.GetTextValue("Mods.CatalystMod.ArmorSetBonus.IntergelacticAll", "[Межгелектический бонус комплекта]");
                string intergelacticSummon = Language.GetTextValue("Mods.CatalystMod.ArmorSetBonus.IntergelacticSummon");
                
                return $"{intergelacticAll}\n{intergelacticSummon}";
            }));
            ArmorSetBonuses.Add(new ArmorSetBonusData(TranslationHelper.GetItemID("CatalystMod/IntergelacticHeadRogue"), () =>
            {
                string intergelacticAll = Language.GetTextValue("Mods.CatalystMod.ArmorSetBonus.IntergelacticAll", "[Межгелектический бонус комплекта]");
                string intergelacticRogue = Language.GetTextValue("Mods.CatalystMod.ArmorSetBonus.IntergelacticRogue");
                
                return $"{intergelacticAll}\n{intergelacticRogue}";
            }));
        }
    }
}