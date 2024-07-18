// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using Redemption.NPCs.Bosses.KSIII;
// using Redemption.NPCs.Friendly;
// using Redemption.NPCs.Friendly.SpiritSummons;
// using Redemption.NPCs.HM;
// using Terraria;
// using Terraria.GameContent.Bestiary;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.Redemption;
//
// public class RedemptionGlobalNPC : GlobalNPC
// {
//     public override bool IsLoadingEnabled(Mod mod)
//     {
//         return TranslationHelper.IsRussianLanguage && /*TRuConfig.Instance.RedemptionLocalization &&*/ ModInstances.Redemption != null;
//     }
//
//     public override void SetBestiary(NPC npc, BestiaryDatabase database, BestiaryEntry bestiaryEntry)
//     {
//         if (npc.type == ModContent.NPCType<SpaceKeeper>())
//         {
//             bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
//             bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("The 3rd Slayer Unit created by King Slayer III during his million year voyage. Construction began after an alien war which left most of Slayer's androids damaged or broken. This unit specialises in using nanobots to heal other robots."));
//         }
//     }
//
//     public override void ModifyTypeName(NPC npc, ref string typeName)
//     {
//         if (npc.type == ModContent.NPCType<EpidotrianSkeleton_SS>())
//         {
//             typeName = $"Ancient Gladestone Golem игрока {Main.player[Main.myPlayer].name}";
//         }
//         
//         if (npc.type == ModContent.NPCType<EpidotrianSkeleton_SS>())
//         {
//             typeName = $"Epidotrian Skeleton игрока {Main.player[Main.myPlayer].name}";
//         }
//         
//         if (npc.type == ModContent.NPCType<ForestNymph_SS>())
//         {
//             typeName = $"Лесная нифма игрока {Main.player[Main.myPlayer].name}";
//         }
//         
//         if (npc.type == ModContent.NPCType<HazmatZombie_SS>())
//         {
//             typeName = $"Hazmat Zombie игрока {Main.player[Main.myPlayer].name}";
//         }
//         
//         if (npc.type == ModContent.NPCType<MossyGoliath_SS>())
//         {
//             typeName = $"Mossy Goliath игрока {Main.player[Main.myPlayer].name}";
//         }
//         
//         if (npc.type == ModContent.NPCType<SkeletonAssassin_SS>())
//         {
//             typeName = $"Скелет-убийца игрока {Main.player[Main.myPlayer].name}";
//         }
//         
//         if (npc.type == ModContent.NPCType<SkeletonDuelist_SS>())
//         {
//             typeName = $"Скелет-дуэлянт игрока {Main.player[Main.myPlayer].name}";
//         }
//         
//         if (npc.type == ModContent.NPCType<SkeletonFlagbearer_SS>())
//         {
//             typeName = $"Скелет-знаменосец игрока {Main.player[Main.myPlayer].name}";
//         }
//         
//         if (npc.type == ModContent.NPCType<SkeletonNoble_SS>())
//         {
//             typeName = $"Скелет-аристократ игрока {Main.player[Main.myPlayer].name}";
//         }
//         
//         if (npc.type == ModContent.NPCType<SkeletonWanderer_SS>())
//         {
//             typeName = $"Скелет-странник игрока {Main.player[Main.myPlayer].name}";
//         }
//         
//         if (npc.type == ModContent.NPCType<SkeletonWarden_SS>())
//         {
//             typeName = $"Скелет-страж игрока {Main.player[Main.myPlayer].name}";
//         }
//         
//         if (npc.type == ModContent.NPCType<TreebarkDryad>())
//         {
//             typeName = typeName switch
//             {
//                 "Gentlewood the Treebark Dryad" => "",
//                 "Blandwood the Treebark Dryad" => "",
//                 "Elmshade the Treebark Dryad" => "",
//                 "Vinewood the Treebark Dryad" => "",
//                 "Bitterthorn the Treebark Dryad" => "",
//                 "Irontwig the Treebark Dryad" => "",
//                 "Tapio the Treebark Dryad" => "",
//                 "Willowbark the Treebark Dryad" => "",
//                 "Cherrysplinter the Treebark Dryad" => "",
//                 "Blossomwood the Treebark Dryad" => "",
//                 _ => typeName
//             };
//         }
//         
//         if (npc.type == ModContent.NPCType<Android>())
//         {
//             if (npc.GivenName == "Apidroid Mk.I")
//                 npc.GivenName = "Андроид Мк.I";
//         }
//     }
// }