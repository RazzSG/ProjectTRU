// using System.Collections.Generic;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using StarsAbove.Items;
// using StarsAbove.Systems;
// using Terraria;
// using Terraria.ModLoader;
// using Terraria.UI;
//
// namespace CalamityRuTranslate.Mods.StarsAbove;
//
// public class StarsAboveSystem : ModSystem
// {
//     private static ArchivePlayer ArchivePlayer => Main.LocalPlayer.GetModPlayer<ArchivePlayer>();
//     
//     public override bool IsLoadingEnabled(Mod mod)
//     {
//         return ModInstances.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//     }
//
//     public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
//     {
//         if (ArchivePlayer.archiveActive && ArchivePlayer.archivePopulated)
//         {
//             foreach (IdleArchiveListing archiveListing in ArchivePlayer.IdleArchiveList)
//             {
//                 archiveListing.Name = archiveListing.Name switch
//                 {
//                     "Idle Conversation 1" => "Пустая болтовня 1",
//                     "Idle Conversation 2" => "Пустая болтовня 2",
//                     "Idle Conversation 3" => "Пустая болтовня 3",
//                     "Idle Conversation 4" => "Пустая болтовня 4",
//                     "Idle Conversation 5" => "Пустая болтовня 5",
//                     "Idle Conversation 6" => "Пустая болтовня 6",
//                     "Idle Conversation 7" => "Пустая болтовня 7",
//                     "Idle Conversation 8" => "Пустая болтовня 8",
//                     "Idle Conversation 9" => "Пустая болтовня 9",
//                     "Idle Conversation 10" => "Пустая болтовня 10",
//                     "Idle Conversation 11" => "Пустая болтовня 11",
//                     "Idle Conversation 12" => "Пустая болтовня 12",
//                     "Idle Conversation 13" => "Пустая болтовня 13",
//                     "Idle Conversation 14" => "Пустая болтовня 14",
//                     "Idle Conversation 15" => "Пустая болтовня 15",
//                     "Idle Conversation 16" => "Пустая болтовня 16",
//                     "Idle Conversation 17" => "Пустая болтовня 17",
//                     "Idle Conversation 18" => "Пустая болтовня 18",
//                     "'A World Shrouded in Light'" => "'Мир, окутанный\nсветом'",
//                     "Entering the Observatory" => "Прибытие в\nобсерваторию",
//                     "Explaining Cosmic Voyages" => "Объяснение\nкосмических\nпутешествий",
//                     "Idle in the Observatory" => "Покой в обсерватории",
//                     "Idle in Space" => "Покой в космосе",
//                     _ => archiveListing.Name
//                 };
//                 
//                 archiveListing.ListInformation = archiveListing.ListInformation switch
//                 {
//                     "Pre Hardmode idle dialogue." => "Пре-хардмодный\nдиалог покоя.",
//                     "Hardmode idle dialogue." => "Хардмодный диалог\nпокоя.",
//                     "Idle dialogue during Light Everlasting." => "Диалог покоя во\nвремя Вечного света.",
//                     "Dialogue on the Observatory Hyperborea." => "Диалог об\nОбсерватории\nЗаполярье",
//                     "An explanation of the mechanics of Cosmic Voyages." => "Объяснение механики\nкосмических\nпутешествий.",
//                     "Neutral dialogue within the Observatory Hyperborea." => "Нейтральный диалог\nв Обсерватории\nЗаполярье.",
//                     "Neutral dialogue when on a normal-type Cosmic Voyage. Unused." => "Нейтральный диалог\nво время\nкосмического\nпутешествия\nобычного типа. Не\nиспользуется.",
//                     _ => archiveListing.ListInformation
//                 };
//                 
//                 archiveListing.UnlockConditions = archiveListing.UnlockConditions switch
//                 {
//                     "Enter Hardmode" => "Нужен хардмод.",
//                     "Unlocked after witnessing Light Everlasting for the first time." => "Открывается после\nпервого лицезрения\nВечного света.",
//                     "Unlocked after entering the Observatory Hyperborea for the first time." => "Открывается после\nпервого посещения\nОбсерватории\nЗаполярье.",
//                     _ => archiveListing.UnlockConditions
//                 };
//             }
//
//             foreach (BossArchiveListing archiveListing in ArchivePlayer.BossArchiveList)
//             {
//                 archiveListing.Name = archiveListing.Name switch
//                 {
//                     "Slime King Dethroned" => "",
//                     "Eye of Cthulhu Pierced" => "",
//                     "Worldly Evil Sanctified" => "",
//                     "Queen Bee Exterminated" => "",
//                     "Skeletron Buried" => "",
//                     "Deerclops Extinct" => "",
//                     "Wall of Flesh Purged" => "",
//                     "Queen Slime Overthrown" => "",
//                     "The Twins Scrapped" => "",
//                     "The Destroyer Deleted" => "",
//                     "Skeletron Prime Erased" => "",
//                     "All Mechanical Bosses Rended" => "",
//                     "Plantera Uprooted" => "",
//                     "Golem Deactivated" => "",
//                     "Duke Fishron Hunted" => "",
//                     "Empress of Light Dimmed" => "",
//                     "Lunatic Cultist Crucified" => "",
//                     "Moon Lord Defeated" => "",
//                     "Terraria's Hero" => "",
//                     "Hero of the Realm" => "",
//                     "The Shattered Disk" => "",
//                     "Perseus's Appeal: The Twin Forces" => "",
//                     "Perseus's Appeal: The Witch of Ink" => "",
//                     "Perseus's Appeal: The Burnished King" => "",
//                     "Perseus's Appeal: The Warrior of Light" => "",
//                     "Dioskouroi Defeated" => "",
//                     "Penthesilea Washed" => "",
//                     "Nalhaun Kneeled" => "",
//                     "Warrior of Light Vanquished" => "",
//                     "The First Starfarer Defeated" => "",
//                     "Desert Scourge Defeated" => "",
//                     "Crabulon Defeated" => "",
//                     "Hive Mind Defeated" => "",
//                     "Perforators Defeated" => "",
//                     "Slime God Defeated" => "",
//                     "Cryogen Defeated" => "",
//                     "Aquatic Scourge Defeated" => "",
//                     "Brimstone Elemental Defeated" => "",
//                     "Calamitas's Clone Defeated" => "",
//                     "Leviathan Defeated" => "",
//                     "Astrum Aureus Defeated" => "",
//                     "Plaguebringer Goliath" => "",
//                     "Ravager Defeated" => "",
//                     "Astrum Deus Defeated" => "",
//                     _ => archiveListing.Name
//                 };
//                 
//                 archiveListing.ListInformation = archiveListing.ListInformation switch
//                 {
//                     "Unlocked after defeating King Slime." => "",
//                     "Unlocked after defeating Eye of Cthulhu." => "",
//                     "Unlocked after defeating the Corruption/Crimson boss." => "",
//                     "Unlocked after defeating Queen Bee." => "",
//                     "Unlocked after defeating Skeletron." => "",
//                     "Unlocked after defeating Deerclops." => "",
//                     "Unlocked after defeating the Wall of Flesh." => "",
//                     "Unlocked after defeating Queen Slime" => "",
//                     "Unlocked after defeating the Twins." => "",
//                     "Unlocked after defeating the Destroyer." => "",
//                     "Unlocked after defeating Skeletron Prime." => "",
//                     "Unlocked after defeating all of the Mechanical Bosses." => "",
//                     "Unlocked after defeating Plantera." => "",
//                     "Unlocked after defeating Golem." => "",
//                     "Unlocked after defeating Duke Fishron." => "",
//                     "Unlocked after defeating the Empress of Light." => "",
//                     "Unlocked after defeating the Lunatic Cultist." => "",
//                     "Unlocked after defeating the Moon Lord." => "",
//                     "Unlocked after defeating all vanilla Terraria bosses. Grants an Essence." => "",
//                     "Unlocked after defeating all vanilla Terraria bosses, and cleansing the world of Light Everlasting. Grants an Essence." => "",
//                     "Grants the item to summon the Vagrant of Space and Time." => "",
//                     "Grants the item to summon the Twin Forces." => "",
//                     "Grants the item to summon the Witch of Ink" => "",
//                     "Grants the item to summon the Burnished King." => "",
//                     "Grants the item to summon the Warrior of Light." => "",
//                     "Unlocked after defeating Dioskouroi, the Twin Forces. Grants a material needed for confronting the final boss." => "",
//                     "Unlocked after defeating Penthesilea, the Witch of Ink. Grants a material needed for confronting the final boss." => "",
//                     "Unlocked after defeating Nalhaun, the Burnished King. Grants a material needed for confronting the final boss." => "",
//                     "Unlocked after defeating the Warrior of Light. Grants a material needed for confronting the final boss." => "",
//                     "Unlocked after defeating Tsukiyomi, the First Starfarer. Grants an item used for crafting." => "",
//                     "Unlocked after defeating the Desert Scourge" => "",
//                     "Unlocked after defeating Crabulon" => "",
//                     "Unlocked after defeating the Hive Mind" => "",
//                     "Unlocked after defeating the Perforators" => "",
//                     "Unlocked after defeating the Slime God" => "",
//                     "Unlocked after defeating Cryogen" => "",
//                     "Unlocked after defeating the Aquatic Scourge" => "",
//                     "Unlocked after defeating the Brimstone Elemental" => "",
//                     "Unlocked after defeating Calamitas's Clone" => "",
//                     "Unlocked after defeating the Leviathan" => "",
//                     "Unlocked after defeating Astrum Aureus" => "",
//                     "Unlocked after defeating the Plaguebringer Goliath" => "",
//                     "Unlocked after defeating the Ravager" => "",
//                     "Unlocked after defeating Astrum Deus" => "",
//                     _ => archiveListing.ListInformation
//                 };
//                 
//                 archiveListing.UnlockConditions = archiveListing.UnlockConditions switch
//                 {
//                     "Defeat King Slime." => "",
//                     "Defeat Eye of Cthulhu." => "",
//                     "Defeat the world's Corruption/Crimson boss." => "",
//                     "Defeat Queen Bee." => "",
//                     "Defeat Skeletron." => "",
//                     "Defeat Deerclops." => "",
//                     "Defeat the Wall of Flesh." => "",
//                     "Defeat Queen Slime" => "",
//                     "Defeat the Twins." => "",
//                     "Defeat the Destroyer." => "",
//                     "Defeat Skeletron Prime." => "",
//                     "Defeat all of the Mechanical Bosses." => "",
//                     "Defeat Plantera." => "",
//                     "Defeat Golem." => "",
//                     "Defeat Duke Fishron." => "",
//                     "Defeat the Empress of Light." => "",
//                     "Defeat the Lunatic Cultist." => "",
//                     "Defeat the Moon Lord." => "",
//                     "Defeat all vanilla bosses." => "",
//                     "Defeat all vanilla bosses and the Warrior of Light in Expert Mode." => "",
//                     "Visit a Meteorite" => "",
//                     "Defeat Nalhaun, the Burnished King." => "",
//                     "Defeat Penthesilea, the Witch of Ink." => "",
//                     "Defeat the Warrior of Light." => "",
//                     "Defeat ???" => "",
//                     "Defeat the Desert Scourge" => "",
//                     "Defeat Crabulon" => "",
//                     "Defeat the Hive Mind" => "",
//                     "Defeat the Perforators" => "",
//                     "Defeat the Slime God" => "",
//                     "Defeat Cryogen" => "",
//                     "Defeat the Aquatic Scourge" => "",
//                     "Defeat the Brimstone Elemental" => "",
//                     "Defeat Calamitas" => "",
//                     "Defeat the Leviathan" => "",
//                     "Defeat Astrum Aureus" => "",
//                     "Defeat the Plaguebringer Goliath" => "",
//                     "Defeat the Ravager" => "",
//                     "Defeat Astrum Deus" => "",
//                     _ => archiveListing.UnlockConditions
//                 };
//             }
//             
//             foreach (WeaponArchiveListing archiveListing in ArchivePlayer.WeaponArchiveList)
//             {
//                 archiveListing.Name = archiveListing.Name switch
//                 {
//                     "King Slime Weapon" => "",
//                     "Eye of Cthulhu Weapon" => "",
//                     "Graveyard Weapon" => "",
//                     "Corruption/Crimson Boss Weapon" => "",
//                     "Queen Bee Weapon" => "",
//                     "Tier 2 Stellaglyph Weapon" => "",
//                     "Skeletron Weapon" => "",
//                     "Wall of Flesh Weapon" => "",
//                     "Guide Voodoo Doll Weapon" => "",
//                     "Hallowed Biome Weapon" => "",
//                     "Pirate Invasion Weapon" => "",
//                     "Queen Slime Weapon" => "",
//                     "Any Mechanical Boss Weapon" => "",
//                     "" => "",
//                     "" => "",
//                     "" => "",
//                     _ => archiveListing.Name
//                 };
//                 
//                 archiveListing.UnlockConditions = archiveListing.UnlockConditions switch
//                 {
//                     "Defeat King Slime" => "",
//                     "Defeat King Slime." => "",
//                     "Defeat Eye of Cthulhu" => "",
//                     "Visit a Graveyard biome." => "",
//                     "Defeat the boss of the world's evil." => "",
//                     "Defeat the boss of the world's evil, then wait." => "",
//                     "Defeat the Queen Bee." => "",
//                     "Obtain a Tier 2 Stellaglyph." => "",
//                     "Defeat Skeletron." => "",
//                     "Defeat Skeletron, then wait." => "",
//                     "Defeat Skeletron, then visit the beach." => "",
//                     "Defeat Skeletron, then visit the Underworld." => "",
//                     "Defeat the Wall of Flesh, then wait." => "",
//                     "Find a Guide Voodoo Doll on a Hardcore character." => "",
//                     "Visit the Hallowed biome." => "",
//                     "Defeat a pirate invasion, then wait." => "",
//                     "Defeat Queen Slime." => "",
//                     "Defeat Queen Slime, then wait." => "",
//                     "" => "",
//                     "" => "",
//                     "" => "",
//                     "" => "",
//                     _ => archiveListing.UnlockConditions
//                 };
//
//                 if (archiveListing.ListInformation == $"Grants the Essence for either the [i:{ModContent.ItemType<Astral>()}] Aegis Driver or the [i:{ModContent.ItemType<Umbral>()}] Rad Gun")
//                 {
//                     archiveListing.ListInformation = "";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Trickspin Two-Step. ")
//                 {
//                     archiveListing.ListInformation = "";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Astral>()}] Carian Dark Moon or [i:{ModContent.ItemType<Umbral>()}] Konpaku Katana.")
//                 {
//                     archiveListing.ListInformation = "";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Astral>()}] Kevesi Farewell or [i:{ModContent.ItemType<Umbral>()}] Agnian Farewell.")
//                 {
//                     archiveListing.ListInformation = "";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Astral>()}] Neo Dealmaker or [i:{ModContent.ItemType<Umbral>()}] Ashen Ambition.")
//                 {
//                     archiveListing.ListInformation = "";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Takonomicon. ")
//                 {
//                     archiveListing.ListInformation = "";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Shock & Awe. ")
//                 {
//                     archiveListing.ListInformation = "";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Astral>()}] Skofnung or [i:{ModContent.ItemType<Umbral>()}] Inugami Ripsaw.")
//                 {
//                     archiveListing.ListInformation = "";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Umbral>()}] Irminsul's Dream or [i:{ModContent.ItemType<Astral>()}] Pod Zero-42.")
//                 {
//                     archiveListing.ListInformation = "";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Umbral>()}] Death in Four Acts or [i:{ModContent.ItemType<Astral>()}] Der Freischutz.")
//                 {
//                     archiveListing.ListInformation = "";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Misery's Company. ")
//                 {
//                     archiveListing.ListInformation = "";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Nanomachina Reactor. ")
//                 {
//                     archiveListing.ListInformation = "";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Apalistik. ")
//                 {
//                     archiveListing.ListInformation = "";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Astral>()}] Gossamer Needle or [i:{ModContent.ItemType<Umbral>()}] Kazimierz Seraphim.")
//                 {
//                     archiveListing.ListInformation = "";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Astral>()}] Karlan Truesilver or [i:{ModContent.ItemType<Umbral>()}] Dragged Below.")
//                 {
//                     archiveListing.ListInformation = "";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Luminary Wand. ")
//                 {
//                     archiveListing.ListInformation = "";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Force-of-Nature. ")
//                 {
//                     archiveListing.ListInformation = "";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Sanguine Despair. ")
//                 {
//                     archiveListing.ListInformation = "";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Aurum Edge. ")
//                 {
//                     archiveListing.ListInformation = "";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Saltwater Scourge. ")
//                 {
//                     archiveListing.ListInformation = "";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Astral>()}] Hunter's Symphony or [i:{ModContent.ItemType<Umbral>()}] Sparkblossom's Beacon.")
//                 {
//                     archiveListing.ListInformation = "";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Adornment of the Chaotic God.")
//                 {
//                     archiveListing.ListInformation = "";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Astral>()}] Izanagi's Edge or [i:{ModContent.ItemType<Umbral>()}] Hawkmoon.")
//                 {
//                     archiveListing.ListInformation = "";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Chronoclock. ")
//                 {
//                     archiveListing.ListInformation = "";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Astral>()}] Veneration of Butterflies or [i:{ModContent.ItemType<Umbral>()}] Memento Muse.")
//                 {
//                     archiveListing.ListInformation = "";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Astral>()}] Ride the Bull or [i:{ModContent.ItemType<Umbral>()}] Drachenlance.")
//                 {
//                     archiveListing.ListInformation = "";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Xenoblade. ")
//                 {
//                     archiveListing.ListInformation = "";
//                 }
//             }
//
//             foreach (VNArchiveListing archiveListing in ArchivePlayer.VNArchiveList)
//             {
//                 archiveListing.Name = archiveListing.Name switch
//                 {
//                     "Intro Dialogue" => "",
//                     "Eridani's Intro Dialogue" => "",
//                     "Vagrant Post-Battle (Asphodene)" => "",
//                     "Vagrant Post-Battle (Eridani)" => "",
//                     "The Astrolabe (Asphodene)" => "",
//                     "The Astrolabe (Eridani)" => "",
//                     "The Observatory's Introduction" => "",
//                     "Yojimbo's Introduction (Asphodene)" => "",
//                     "Yojimbo's Introduction (Eridani)" => "",
//                     "Yojimbo: About the galaxy..." => "",
//                     "Yojimbo: About the Empire..." => "",
//                     "Yojimbo: About the Ardor..." => "",
//                     "Garridine's Introduction (Asphodene)" => "",
//                     "Garridine's Introduction (Eridani)" => "",
//                     _ => archiveListing.Name
//                 };
//
//                 archiveListing.ListInformation = archiveListing.ListInformation switch
//                 {
//                     "The Starfarer's introduction dialogue." => "",
//                     "Perseus's introduction." => "",
//                     "Acquisition of the Astrolabe." => "",
//                     "Explaining Cosmic Voyages and the Astrolabe." => "",
//                     "Yojimbo, the lumenkin bounty hunter, makes his appearance." => "",
//                     "Yojimbo's comments on the state of the galaxy." => "",
//                     "Garridine, the lupine machinist, makes her appearance." => "",
//                     _ => archiveListing.ListInformation
//                 };
//
//                 archiveListing.UnlockConditions = archiveListing.UnlockConditions switch
//                 {
//                     "Asphodene's intro dialogue." => "",
//                     "Eridani's intro dialogue." => "",
//                     "Defeat the Vagrant of Space and Time. (Asphodene)" => "",
//                     "Defeat the Vagrant of Space and Time. (Eridani)" => "",
//                     "Defeat the Eye of Cthulhu." => "",
//                     "Visit the Observatory." => "",
//                     "Meet Yojimbo during a Cosmic Voyage. (Asphodene)" => "",
//                     "Meet Yojimbo during a Cosmic Voyage. (Eridani)" => "",
//                     "Talk to Yojimbo during a Cosmic Voyage. (Random unlock)" => "",
//                     "Meet Garridine during a Cosmic Voyage. (Asphodene)" => "",
//                     "Meet Garridine during a Cosmic Voyage. (Eridani)" => "",
//                     _ => archiveListing.UnlockConditions
//                 };
//             }
//         }
//     }
// }