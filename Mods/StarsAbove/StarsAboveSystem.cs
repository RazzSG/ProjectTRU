// using System.Collections.Generic;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
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
//             foreach (ArchiveListing archiveListing in ArchivePlayer.VNArchiveList)
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