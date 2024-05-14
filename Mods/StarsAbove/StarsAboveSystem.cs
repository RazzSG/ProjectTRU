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
// public partial class StarsAboveSystem : ModSystem
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
//         StellarNovasStats();
//         
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
//                     "'A World Shrouded in Light'" => "'Мир, окутанный светом'",
//                     "Entering the Observatory" => "Прибытие в обсерваторию",
//                     "Explaining Cosmic Voyages" => "Объяснение космических путешествий",
//                     "Idle in the Observatory" => "Покой в обсерватории",
//                     "Idle in Space" => "Покой в космосе",
//                     _ => archiveListing.Name
//                 };
//                 
//                 archiveListing.ListInformation = archiveListing.ListInformation switch
//                 {
//                     "Pre Hardmode idle dialogue." => "Пре-хардмодный диалог покоя.",
//                     "Hardmode idle dialogue." => "Хардмодный диалог покоя.",
//                     "Idle dialogue during Light Everlasting." => "Диалог покоя во время Вечного света.",
//                     "Dialogue on the Observatory Hyperborea." => "Диалог об Обсерватории Заполярье.",
//                     "An explanation of the mechanics of Cosmic Voyages." => "Объяснение механики космических путешествий.",
//                     "Neutral dialogue within the Observatory Hyperborea." => "Нейтральный диалог в Обсерватории Заполярье.",
//                     "Neutral dialogue when on a normal-type Cosmic Voyage. Unused." => "Нейтральный диалог во время космического путешествия обычного типа. Не используется.",
//                     _ => archiveListing.ListInformation
//                 };
//                 
//                 archiveListing.UnlockConditions = archiveListing.UnlockConditions switch
//                 {
//                     "Enter Hardmode" => "Нужен хардмод.",
//                     "Unlocked after witnessing Light Everlasting for the first time." => "Открывается после первого лицезрения Вечного света.",
//                     "Unlocked after entering the Observatory Hyperborea for the first time." => "Открывается после первого посещения Обсерватории Заполярье.",
//                     _ => archiveListing.UnlockConditions
//                 };
//             }
//
//             foreach (BossArchiveListing archiveListing in ArchivePlayer.BossArchiveList)
//             {
//                 archiveListing.Name = archiveListing.Name switch
//                 {
//                     "Slime King Dethroned" => "Король слизней свернут",
//                     "Eye of Cthulhu Pierced" => "Глаз Ктулху проткнут",
//                     "Worldly Evil Sanctified" => "Мирское зло освящено",
//                     "Queen Bee Exterminated" => "Королева пчёл уничтожена",
//                     "Skeletron Buried" => "Скелетрон погребён",
//                     "Deerclops Extinct" => "Циклоп-олень вымер",
//                     "Wall of Flesh Purged" => "Стена плоти очищена",
//                     "Queen Slime Overthrown" => "Королева слизней свергнута",
//                     "The Twins Scrapped" => "Близнецы списаны",
//                     "The Destroyer Deleted" => "Уничтожитель удалён",
//                     "Skeletron Prime Erased" => "Скелетрон Прайм стёрт",
//                     "All Mechanical Bosses Rended" => "Все механические боссы разрушены",
//                     "Plantera Uprooted" => "Плантера вырвана с корнем",
//                     "Golem Deactivated" => "Голем деактивирован",
//                     "Duke Fishron Hunted" => "Герцог Рыброн пойманный",
//                     "Empress of Light Dimmed" => "Императрица света померкла",
//                     "Lunatic Cultist Crucified" => "Культист-лунатик распят",
//                     "Moon Lord Defeated" => "Лунный лорд побеждён",
//                     "Terraria's Hero" => "Герой Террарии",
//                     "Hero of the Realm" => "Герой королевства",
//                     "The Shattered Disk" => "Разбитый диск",
//                     "Perseus's Appeal: The Twin Forces" => "",
//                     "Perseus's Appeal: The Witch of Ink" => "",
//                     "Perseus's Appeal: The Burnished King" => "",
//                     "Perseus's Appeal: The Warrior of Light" => "",
//                     "Dioskouroi Defeated" => "Диоскуры побеждены",
//                     "Penthesilea Washed" => "Пентесилея смылась",
//                     "Nalhaun Kneeled" => "Налхан преклонил колено",
//                     "Warrior of Light Vanquished" => "Воин света уничтожен",
//                     "The First Starfarer Defeated" => "Первая Астра побеждена",
//                     "Desert Scourge Defeated" => "Пустынный бич побеждён",
//                     "Crabulon Defeated" => "Крабулон побеждён",
//                     "Hive Mind Defeated" => "Разум улья побеждён",
//                     "Perforators Defeated" => "Перфораторы побеждены",
//                     "Slime God Defeated" => "Бог слизней побеждён",
//                     "Cryogen Defeated" => "Криоген побеждён",
//                     "Aquatic Scourge Defeated" => "Акватический бич побеждён",
//                     "Brimstone Elemental Defeated" => "Серный элементаль побеждён",
//                     "Calamitas's Clone Defeated" => "Клон Каламитас побеждён",
//                     "Leviathan Defeated" => "Левиафан побеждена",
//                     "Astrum Aureus Defeated" => "Аструм Ареус побеждён",
//                     "Plaguebringer Goliath" => "Разносчица чумы, Голиаф",
//                     "Ravager Defeated" => "Разрушитель побеждён",
//                     "Astrum Deus Defeated" => "Аструм Деус побеждён",
//                     _ => archiveListing.Name
//                 };
//                 
//                 archiveListing.ListInformation = archiveListing.ListInformation switch
//                 {
//                     "Unlocked after defeating King Slime." => "Открывается после победы над Королём слизней.",
//                     "Unlocked after defeating Eye of Cthulhu." => "Открывается после победы над Глазом Ктулху.",
//                     "Unlocked after defeating the Corruption/Crimson boss." => "Открывается после победы над боссом искажения/багрянца.",
//                     "Unlocked after defeating Queen Bee." => "Открывается после победы над Королевой пчёл.",
//                     "Unlocked after defeating Skeletron." => "Открывается после победы над Скелетроном.",
//                     "Unlocked after defeating Deerclops." => "Открывается после победы над Циклопом-оленем.",
//                     "Unlocked after defeating the Wall of Flesh." => "Открывается после победы над Стеной плоти.",
//                     "Unlocked after defeating Queen Slime" => "Открывается после победы над Королевой слизней.",
//                     "Unlocked after defeating the Twins." => "Открывается после победы над Близнецами.",
//                     "Unlocked after defeating the Destroyer." => "Открывается после победы над Уничтожителем.",
//                     "Unlocked after defeating Skeletron Prime." => "Открывается после победы над Скелетроном Праймом.",
//                     "Unlocked after defeating all of the Mechanical Bosses." => "Открывается после победы над всеми механическими боссами.",
//                     "Unlocked after defeating Plantera." => "Открывается после победы над Плантерой.",
//                     "Unlocked after defeating Golem." => "Открывается после победы над Големом.",
//                     "Unlocked after defeating Duke Fishron." => "Открывается после победы над Герцогом Рыброном.",
//                     "Unlocked after defeating the Empress of Light." => "Открывается после победы над Императрицей света.",
//                     "Unlocked after defeating the Lunatic Cultist." => "Открывается после победы над Культистом-лунатиком.",
//                     "Unlocked after defeating the Moon Lord." => "Открывается после победы над Лунным лордом.",
//                     "Unlocked after defeating all vanilla Terraria bosses. Grants an Essence." => "Открывается после победы над всеми ванильными боссами Террарии. Даёт эссенцию.",
//                     "Unlocked after defeating all vanilla Terraria bosses, and cleansing the world of Light Everlasting. Grants an Essence." => "Открывается после победы над всеми ванильными боссами Террарии и очищения мира от Вечного света. Даёт эссенцию.",
//                     "Grants the item to summon the Vagrant of Space and Time." => "Даёт предмет для призыва Скитальца между измерениями.",
//                     "Grants the item to summon the Twin Forces." => "Даёт предмет для призыва Близнецов-воителей.",
//                     "Grants the item to summon the Witch of Ink" => "Даёт предмет для призыва Ведьмы чернил.",
//                     "Grants the item to summon the Burnished King." => "Даёт предмет для призыва Воронёного короля.",
//                     "Grants the item to summon the Warrior of Light." => "Даёт предмет для призыва Воина света.",
//                     "Unlocked after defeating Dioskouroi, the Twin Forces. Grants a material needed for confronting the final boss." => "Открывается после победы над Диоскурами, Близнецами-воителями. Даёт материал, необходимый для сражения с финальным боссом.",
//                     "Unlocked after defeating Penthesilea, the Witch of Ink. Grants a material needed for confronting the final boss." => "Открывается после победы над Пентесилеей, Ведьмой чернил. Даёт материал, необходимый для сражения с финальным боссом.",
//                     "Unlocked after defeating Nalhaun, the Burnished King. Grants a material needed for confronting the final boss." => "Открывается после победы над Налханом, Воронёным королём. Даёт материал, необходимый для сражения с финальным боссом.",
//                     "Unlocked after defeating the Warrior of Light. Grants a material needed for confronting the final boss." => "Открывается после победы над Воином света. Даёт материал, необходимый для сражения с финальным боссом.",
//                     "Unlocked after defeating Tsukiyomi, the First Starfarer. Grants an item used for crafting." => "Открывается после победы над Цукиёми, Первой Астрой. Даёт предмет, используемый для создания.",
//                     "Unlocked after defeating the Desert Scourge" => "Открывается после победы над Пустынным бичом.",
//                     "Unlocked after defeating Crabulon" => "Открывается после победы над Крабулоном.",
//                     "Unlocked after defeating the Hive Mind" => "Открывается после победы над Разумом улья.",
//                     "Unlocked after defeating the Perforators" => "Открывается после победы над Перфораторами.",
//                     "Unlocked after defeating the Slime God" => "Открывается после победы над Богом слизней.",
//                     "Unlocked after defeating Cryogen" => "Открывается после победы над Криогеном.",
//                     "Unlocked after defeating the Aquatic Scourge" => "Открывается после победы над Акватическим бичом.",
//                     "Unlocked after defeating the Brimstone Elemental" => "Открывается после победы над Серным элементалем.",
//                     "Unlocked after defeating Calamitas's Clone" => "Открывается после победы над Клоном Каламитас.",
//                     "Unlocked after defeating the Leviathan" => "Открывается после победы над Левиафан.",
//                     "Unlocked after defeating Astrum Aureus" => "Открывается после победы над Аструм Ареусом.",
//                     "Unlocked after defeating the Plaguebringer Goliath" => "Открывается после победы над Разносчицей чумы, Голиаф.",
//                     "Unlocked after defeating the Ravager" => "Открывается после победы над Разрушителем.",
//                     "Unlocked after defeating Astrum Deus" => "Открывается после победы над Аструм Деусом.",
//                     _ => archiveListing.ListInformation
//                 };
//                 
//                 archiveListing.UnlockConditions = archiveListing.UnlockConditions switch
//                 {
//                     "Defeat King Slime." => "Одолейте Короля слизней.",
//                     "Defeat Eye of Cthulhu." => "Одолейте Глаз Ктулху.",
//                     "Defeat the world's Corruption/Crimson boss." => "Одолейте босса искажения/багрянца.",
//                     "Defeat Queen Bee." => "Одолейте Королеву пчёл.",
//                     "Defeat Skeletron." => "Одолейте Скелетрона.",
//                     "Defeat Deerclops." => "Одолейте Циклопа-оленя.",
//                     "Defeat the Wall of Flesh." => "Одолейте Стену плоти.",
//                     "Defeat Queen Slime" => "Одолейте Королеву слизней.",
//                     "Defeat the Twins." => "Одолейте Близнецов.",
//                     "Defeat the Destroyer." => "Одолейте Уничтожителя.",
//                     "Defeat Skeletron Prime." => "Одолейте Скелетрона Прайма.",
//                     "Defeat all of the Mechanical Bosses." => "Одолейте всех механических боссов.",
//                     "Defeat Plantera." => "Одолейте Плантеру.",
//                     "Defeat Golem." => "Одолейте Голема.",
//                     "Defeat Duke Fishron." => "Одолейте Герцога Рыброна.",
//                     "Defeat the Empress of Light." => "Одолейте Императрицу света.",
//                     "Defeat the Lunatic Cultist." => "Одолейте Культиста-лунатика.",
//                     "Defeat the Moon Lord." => "Одолейте Лунного лорда.",
//                     "Defeat all vanilla bosses." => "Одолейте всех ванильных боссов.",
//                     "Defeat all vanilla bosses and the Warrior of Light in Expert Mode." => "Одолейте всех ванильных боссов и Воина света в режиме Эксперта.",
//                     "Visit a Meteorite" => "Посетите метеорит.",
//                     "Defeat Nalhaun, the Burnished King." => "Одолейте Налхана, Воронёного короля.",
//                     "Defeat Penthesilea, the Witch of Ink." => "Одолейте Пентесилею, Ведьму чернил.",
//                     "Defeat the Warrior of Light." => "Одолейте Воина света.",
//                     "Defeat ???" => "Одолейте ???.",
//                     "Defeat the Desert Scourge" => "Одолейте Пустынного бича.",
//                     "Defeat Crabulon" => "Одолейте Крабулона.",
//                     "Defeat the Hive Mind" => "Одолейте Разум улья.",
//                     "Defeat the Perforators" => "Одолейте Перфораторов.",
//                     "Defeat the Slime God" => "Одолейте Бога слизней.",
//                     "Defeat Cryogen" => "Одолейте Криогена.",
//                     "Defeat the Aquatic Scourge" => "Одолейте Акватического бича.",
//                     "Defeat the Brimstone Elemental" => "Одолейте Серного элементаля.",
//                     "Defeat Calamitas" => "Одолейте Каламитас.",
//                     "Defeat the Leviathan" => "Одолейте Левиафан.",
//                     "Defeat Astrum Aureus" => "Одолейте Аструм Ареуса.",
//                     "Defeat the Plaguebringer Goliath" => "Одолейте Разносчицу чумы, Голиаф",
//                     "Defeat the Ravager" => "Одолейте Разрушителя.",
//                     "Defeat Astrum Deus" => "Одолейте Аструм Деуса.",
//                     _ => archiveListing.UnlockConditions
//                 };
//             }
//             
//             foreach (WeaponArchiveListing archiveListing in ArchivePlayer.WeaponArchiveList)
//             {
//                 archiveListing.Name = archiveListing.Name switch
//                 {
//                     "King Slime Weapon" => "Оружие Короля слизней",
//                     "Eye of Cthulhu Weapon" => "Оружие Глаза Ктулху",
//                     "Graveyard Weapon" => "Оружие кладбища",
//                     "Corruption/Crimson Boss Weapon" => "Оружие босса искажения/багрянца",
//                     "Queen Bee Weapon" => "Оружие Королевы пчёл",
//                     "Tier 2 Stellaglyph Weapon" => "Оружие Космографа (Ранг 2)",
//                     "Skeletron Weapon" => "Оружие Скелетрона",
//                     "Wall of Flesh Weapon" => "Оружие Стены плоти",
//                     "Guide Voodoo Doll Weapon" => "Оружие куклы вуду гида",
//                     "Hallowed Biome Weapon" => "Оружие освящения",
//                     "Pirate Invasion Weapon" => "Оружие вторжения пиратов",
//                     "Queen Slime Weapon" => "Оружие Королевы слизней",
//                     "Any Mechanical Boss Weapon" => "Оружие любого механического босса",
//                     "All Mechanical Bosses Weapon" => "Оружие всех механических боссов",
//                     "Dioskouroi Weapon" => "Оружие Диоскуров",
//                     "Plantera Weapon" => "Оружие Плантеры",
//                     "Frost Queen Weapon" => "Оружие ледяной королевы",
//                     "Penthesilea Weapon" => "Оружие Пентесилеи",
//                     "Golem Weapon" => "Оружие Голема",
//                     "Martian Madness Weapon" => "Оружие марсианского безумия",
//                     "Nalhaun Weapon" => "Оружие Налхана",
//                     "Duke Fishron Weapon" => "Оружие Герцона Рыброна",
//                     "Lunatic Cultist Weapon" => "Оружие Культиста-лунатика",
//                     "Moon Lord Weapon" => "Оружие Лунного лорда",
//                     "Warrior of Light Weapon" => "Оружие Воина света",
//                     "Tsukiyomi Weapon" => "Оружие Цукиёми",
//                     "Empress of Light Weapon" => "Оружие Императрицы света",
//                     "Pumpkin King Weapon" => "Оружие тыквенного короля",
//                     "Deerclops Weapon" => "Оружие Циклопа-оленя",
//                     _ => archiveListing.Name
//                 };
//                 
//                 archiveListing.UnlockConditions = archiveListing.UnlockConditions switch
//                 {
//                     "Defeat King Slime" => "Одолейте Короля слизней.",
//                     "Defeat King Slime." => "Одолейте Короля слизней.",
//                     "Defeat Eye of Cthulhu" => "Одолейте Глаз Ктулху.",
//                     "Visit a Graveyard biome." => "Посетите кладбище.",
//                     "Defeat the boss of the world's evil." => "Одолейте босса мирового зла.",
//                     "Defeat the boss of the world's evil, then wait." => "Одолейте босса мирового зла, а затем подождите.",
//                     "Defeat the Queen Bee." => "Одолейте Королеву пчёл.",
//                     "Obtain a Tier 2 Stellaglyph." => "Получите Космограф (Ранг 2).",
//                     "Defeat Skeletron." => "Одолейте Скелетрона.",
//                     "Defeat Skeletron, then wait." => "Одолейте Скелетрона, а затем подождите.",
//                     "Defeat Skeletron, then visit the beach." => "Одолейте Скелетрона, а затем посетите пляж.",
//                     "Defeat Skeletron, then visit the Underworld." => "Одолейте Скелетрона, а затем посетите преисподнюю.",
//                     "Defeat the Wall of Flesh, then wait." => "Одолейте Стену плоти, а затем подождите.",
//                     "Find a Guide Voodoo Doll on a Hardcore character." => "Найдите куклу вуду гида на хардкорном персонаже.",
//                     "Visit the Hallowed biome." => "Посетите освящение.",
//                     "Defeat a pirate invasion, then wait." => "Одолейте вторжения пиратов, а затем подождите.",
//                     "Defeat Queen Slime." => "Одолейте Королеву слизней.",
//                     "Defeat Queen Slime, then wait." => "Одолейте Королеву слизней, а затем подождите.",
//                     "Skeletron Prime Weapon" => "Оружие Скелетрона Прайма",
//                     "Defeat all the mechanical bosses." => "Одолейте всех механических боссов.",
//                     _ => archiveListing.UnlockConditions
//                 };
//             
//                 if (archiveListing.ListInformation == $"Grants the Essence for either the [i:{ModContent.ItemType<Astral>()}] Aegis Driver or the [i:{ModContent.ItemType<Umbral>()}] Rad Gun")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Astral>()}] 'Аегис Драйвер' или [i:{ModContent.ItemType<Umbral>()}] 'Рад-пушка'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Trickspin Two-Step. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Двухступенчатый спин'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Astral>()}] Carian Dark Moon or [i:{ModContent.ItemType<Umbral>()}] Konpaku Katana.")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Astral>()}] 'Карианская тёмная луна' или [i:{ModContent.ItemType<Umbral>()}] 'Катана Компаку'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Astral>()}] Kevesi Farewell or [i:{ModContent.ItemType<Umbral>()}] Agnian Farewell.")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Astral>()}] 'Прощание кевеси' или [i:{ModContent.ItemType<Umbral>()}] 'Прощание Агниан'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Astral>()}] Neo Dealmaker or [i:{ModContent.ItemType<Umbral>()}] Ashen Ambition.")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Astral>()}] 'Сделкодел Нео' или [i:{ModContent.ItemType<Umbral>()}] 'Пепельная амбиция'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Takonomicon. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Такономикон'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Shock & Awe. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Шок и трепет'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Astral>()}] Skofnung or [i:{ModContent.ItemType<Umbral>()}] Inugami Ripsaw.")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Astral>()}] 'Скофнунг' или [i:{ModContent.ItemType<Umbral>()}] 'Цепная пила Инугами'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Umbral>()}] Irminsul's Dream or [i:{ModContent.ItemType<Astral>()}] Pod Zero-42.")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Umbral>()}] 'Сон Ирминсуля' или [i:{ModContent.ItemType<Astral>()}] 'Под Зеро-42'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Umbral>()}] Death in Four Acts or [i:{ModContent.ItemType<Astral>()}] Der Freischutz.")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Umbral>()}] 'Смерть в четырёх актах' или [i:{ModContent.ItemType<Astral>()}] 'Дер Фрайшуц'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Misery's Company. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Компания несчастья'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Nanomachina Reactor. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Наномашинный реактор'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Apalistik. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Апалистик'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Astral>()}] Gossamer Needle or [i:{ModContent.ItemType<Umbral>()}] Kazimierz Seraphim.")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Astral>()}] 'Паучья игла' или [i:{ModContent.ItemType<Umbral>()}] 'Серафим Казимежа'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Astral>()}] Karlan Truesilver or [i:{ModContent.ItemType<Umbral>()}] Dragged Below.")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Astral>()}] 'Истинное серебро Карлан' или [i:{ModContent.ItemType<Umbral>()}] 'Затянутый в бездну'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Luminary Wand. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Освещающая палочка'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Force-of-Nature. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Неумолимая сила'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Sanguine Despair. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Кровавое отчаяние'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Aurum Edge. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Золотая грань'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Saltwater Scourge. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Гроза морей'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Astral>()}] Hunter's Symphony or [i:{ModContent.ItemType<Umbral>()}] Sparkblossom's Beacon.")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Astral>()}] 'Симфония охотника' или [i:{ModContent.ItemType<Umbral>()}] 'Маяк цветущей искры'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Adornment of the Chaotic God.")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Цилиндр хаотичного бога'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Astral>()}] Izanagi's Edge or [i:{ModContent.ItemType<Umbral>()}] Hawkmoon.")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Astral>()}] 'Грань Идзанаги' или [i:{ModContent.ItemType<Umbral>()}] 'Хоукмун'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Chronoclock. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Хроночасы'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Astral>()}] Veneration of Butterflies or [i:{ModContent.ItemType<Umbral>()}] Memento Muse.")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Astral>()}] 'Почитание бабочек' или [i:{ModContent.ItemType<Umbral>()}] 'Мементо Мьюз'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Astral>()}] Ride the Bull or [i:{ModContent.ItemType<Umbral>()}] Drachenlance.")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Astral>()}] 'Родео' или [i:{ModContent.ItemType<Umbral>()}] 'Драхеланс'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Xenoblade. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Ксеноклинок'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Armaments of the Sky Striker. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Арсенал небесного воина'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Hullwrought. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Железный кованный'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] El Capitan's Hardware.")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Железо Эль Капитана'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Astral>()}] Phantom in the Mirror or [i:{ModContent.ItemType<Umbral>()}] Hollowheart Albion.")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Astral>()}] 'Фантом в зеркале' или [i:{ModContent.ItemType<Umbral>()}] 'Пустое сердце Альбиона'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Astral>()}] Crimson Outbreak or [i:{ModContent.ItemType<Umbral>()}] Voice of the Fallen.")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Astral>()}] 'Багровая эпидемия' или [i:{ModContent.ItemType<Umbral>()}] 'Глас падшего'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Kifrosse. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Кифросс'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Dreamer's Inkwell. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Чернильница мечтателя'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Astral>()}] Stygian Nymph or [i:{ModContent.ItemType<Umbral>()}] Caesura of Despair.")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Astral>()}] 'Стигийская нимфа' или [i:{ModContent.ItemType<Umbral>()}] 'Цезура отчаяния'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Astral>()}] Vision of Euthymia or [i:{ModContent.ItemType<Umbral>()}] Kroniic Principality.")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Astral>()}] 'Глаз эвтюмии' или [i:{ModContent.ItemType<Umbral>()}] 'Кроническое господство'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Penthesilea's Muse. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Муза Пентесилеи'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Astral>()}] Plenilune Gaze or [i:{ModContent.ItemType<Umbral>()}] Tartaglia.")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Astral>()}] 'Взгляд полнолуния' или [i:{ModContent.ItemType<Umbral>()}] 'Тарталья'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Gloves of the Black Silence. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Перчатки чёрной тишины'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] The Kiss of Death. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Поцелуй смерти'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Astral>()}] Liberation Blazing or [i:{ModContent.ItemType<Umbral>()}] Unforgotten.")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Astral>()}] 'Огненная заря освобождения' или [i:{ModContent.ItemType<Umbral>()}] 'Незабытый'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Claimh Solais. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Клив-Солаш'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Boltstorm Axe. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Топор ревущих молний'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Astral>()}] Key of the Sinner or [i:{ModContent.ItemType<Umbral>()}] Crimson Sakura Alpha.")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Astral>()}] 'Ключ грешника' или [i:{ModContent.ItemType<Umbral>()}] 'Багровая сакура альфа'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Maniacal Justice. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Маниакальное правосудие'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Kariumu's Favor. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Благосклонность Кариума'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Astral>()}] Rex Lapis or [i:{ModContent.ItemType<Umbral>()}] Yunlai Stiletto.")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Astral>()}] 'Рекс Ляпис' или [i:{ModContent.ItemType<Umbral>()}] 'Грозовой стилет'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Twin Stars of Albiero. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Двойные звёзды Альбиеро'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Catalyst's Memory. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Воспоминание катализатора'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Umbra. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Умбра'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Astral>()}] Suistrume or [i:{ModContent.ItemType<Umbral>()}] Naganadel.")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Astral>()}] 'Суйсэйфон' или [i:{ModContent.ItemType<Umbral>()}] 'Наганадель'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Shadowless Cerulean. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Бестеневая лазурь'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Soul Reaver. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Жнец душ'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Virtue's Edge. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Грань добродетели'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for either [i:{ModContent.ItemType<Astral>()}] Key of the King's Law or [i:{ModContent.ItemType<Umbral>()}] Light Unrelenting.")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Astral>()}] 'Ключ королевской власти' или [i:{ModContent.ItemType<Umbral>()}] 'Безжалостный свет'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Vermilion Riposte. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Киноварное парирование'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Supreme Authority. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Высшая власть'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Burning Desire. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Пылающая страсть'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] The Everlasting Pickaxe. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Неуничтожимая кирка'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Architect's Luminance. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Ясность Архитектора'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Cosmic Destroyer. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Космический уничтожитель'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Sunset of the Sun God. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Рассвет солнечного божества'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Arachnid Needlepoint. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Крючковорот арахнидов'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Mercy. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Милость'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Sakura's Vengeance. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Месть сакуры'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Eternal Star. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Вечная звезда'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Vermilion Daemon. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Алый демон'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Ozma Ascendant. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Возвышенная Озма'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] Dreadnought Chemtank. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Химдоспех дредноута'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] The Blood Blade. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Кровавый клинок'.";
//                 }
//                 
//                 if (archiveListing.ListInformation == $"Grants the Essence for [i:{ModContent.ItemType<Spatial>()}] The Morning Star. ")
//                 {
//                     archiveListing.ListInformation = $"Даёт эссенцию для [i:{ModContent.ItemType<Spatial>()}] 'Утренняя звезда'.";
//                 }
//             }
//             
//             foreach (VNArchiveListing archiveListing in ArchivePlayer.VNArchiveList)
//             {
//                 archiveListing.Name = archiveListing.Name switch
//                 {
//                     "Intro Dialogue" => "Вступительный диалог",
//                     "Eridani's Intro Dialogue" => "Вступительный диалог Эридани",
//                     "Vagrant Post-Battle (Asphodene)" => "Скиталец после битвы (Асфодена)",
//                     "Vagrant Post-Battle (Eridani)" => "Скиталец после битвы (Эридани)",
//                     "The Astrolabe (Asphodene)" => "Астролябия (Асфодена)",
//                     "The Astrolabe (Eridani)" => "Астролябия (Эридани)",
//                     "The Observatory's Introduction" => "Знакомство с Обсерваторией",
//                     "Yojimbo's Introduction (Asphodene)" => "Знакомство с Йодзимбо (Асфодена)",
//                     "Yojimbo's Introduction (Eridani)" => "Знакомство с Йодзимбо (Эридани)",
//                     "Yojimbo: About the galaxy..." => "Йодзимбо: О галактике...",
//                     "Yojimbo: About the Empire..." => "Йодзимбо: Об империи...",
//                     "Yojimbo: About the Ardor..." => "Йодзимбо: Об Ардоре...",
//                     "Garridine's Introduction (Asphodene)" => "Знакомство с Гарридиной (Асфодена)",
//                     "Garridine's Introduction (Eridani)" => "Знакомство с Гарридиной (Эридани)",
//                     _ => archiveListing.Name
//                 };
//             
//                 archiveListing.ListInformation = archiveListing.ListInformation switch
//                 {
//                     "The Starfarer's introduction dialogue." => "Вступительный диалог Астры.",
//                     "Perseus's introduction." => " Знакомство с Персеем.",
//                     "Acquisition of the Astrolabe." => "Получение Астролябии.",
//                     "Explaining Cosmic Voyages and the Astrolabe." => "Объяснение космических путешествий и Астролябии.",
//                     "Yojimbo, the lumenkin bounty hunter, makes his appearance." => "",
//                     "Yojimbo's comments on the state of the galaxy." => "",
//                     "Garridine, the lupine machinist, makes her appearance." => "",
//                     _ => archiveListing.ListInformation
//                 };
//             
//                 archiveListing.UnlockConditions = archiveListing.UnlockConditions switch
//                 {
//                     "Asphodene's intro dialogue." => "Вступительный диалог Асфодены.",
//                     "Eridani's intro dialogue." => "Вступительный диалог Эридани.",
//                     "Defeat the Vagrant of Space and Time. (Asphodene)" => "Одолейте Скитальца между измерениями (Асфодена).",
//                     "Defeat the Vagrant of Space and Time. (Eridani)" => "Одолейте Скитальца между измерениями (Эридани).",
//                     "Defeat the Eye of Cthulhu." => "Одолейте Глаз Ктулху",
//                     "Visit the Observatory." => "Посетите обсерваторию.",
//                     "Meet Yojimbo during a Cosmic Voyage. (Asphodene)" => "Познакомьтесь с Йодзимбо во время космического путешествия (Асфодена).",
//                     "Meet Yojimbo during a Cosmic Voyage. (Eridani)" => "Познакомьтесь с Йодзимбо во время космического путешествия (Эридани).",
//                     "Talk to Yojimbo during a Cosmic Voyage. (Random unlock)" => "Поговорите с Йодзимбо во время космического путешествия (Случайная разблокировка).",
//                     "Meet Garridine during a Cosmic Voyage. (Asphodene)" => "Познакомьтесь с Гарридиной во время космического путешествия (Асфодена).",
//                     "Meet Garridine during a Cosmic Voyage. (Eridani)" => "Познакомьтесь с Гарридиной во время космического путешествия (Эридани).",
//                     _ => archiveListing.UnlockConditions
//                 };
//             }
//         }
//     }
// }