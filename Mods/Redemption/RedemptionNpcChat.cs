// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.Config;
// using Redemption.Globals;
// using Redemption.NPCs.Friendly;
// using Redemption.NPCs.Friendly.TownNPCs;
// using Terraria;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.Redemption;
//
// public class RedemptionNpcChat : GlobalNPC
// {
//     public override bool IsLoadingEnabled(Mod mod)
//     {
//         return ModInstances.Redemption != null && TRuConfig.Instance.RedemptionLocalization && TranslationHelper.IsRussianLanguage;
//     }
//
//     public override void GetChat(NPC npc, ref string chat)
//     {
//         string GetNPCName(int type) => Main.npc[NPC.FindFirstNPC(type)].GivenName;
//
//         if (npc.type == ModContent.NPCType<DaerelUnconscious>())
//         {
//             if (chat == "Daerel has been unconsious for less than a minute.")
//             {
//                 chat = "";
//             }
//             if (chat == $"Daerel has been unconsious for {RedeWorld.daerelDownedTimer / 3600} minute(s).")
//             {
//                 chat = $"";
//             }
//         }
//         
//         if (npc.type == ModContent.NPCType<TBotUnconscious>())
//         {
//             if (chat == "Adam has been unconsious for less than a minute.")
//             {
//                 chat = "";
//             }
//             if (chat == $"Adam has been unconsious for {RedeWorld.daerelDownedTimer / 3600} minute(s).")
//             {
//                 chat = $"";
//             }
//         }
//         
//         if (npc.type == ModContent.NPCType<ZephosUnconscious>())
//         {
//             if (chat == "Zephos has been unconsious for less than a minute.")
//             {
//                 chat = "";
//             }
//             if (chat == $"Zephos has been unconsious for {RedeWorld.daerelDownedTimer / 3600} minute(s).")
//             {
//                 chat = $"";
//             }
//         }
//         
//         if (npc.type == ModContent.NPCType<SoullessPortal>())
//         {
//             chat = chat switch
//             {
//                 "You wish to escape this cursed place..." => "",
//                 "You hear an ominous hum from the portal..." => "",
//                 _ => chat
//             };
//         }
//         
//         if (npc.type == ModContent.NPCType<TreebarkDryad>())
//         {
//             if (chat.Contains("Hmmmm..."))
//             {
//                 chat = chat.Replace("Hmmmm...", "");
//             }
//         }
//     }
//     
//     public override void OnChatButtonClicked(NPC npc, bool firstButton)
//     {
//         string GetNPCName(int type) => Main.npc[NPC.FindFirstNPC(type)].GivenName;
//         
//         if (npc.type == ModContent.NPCType<DaerelUnconscious>())
//         {
//             Main.npcChatText = Main.npcChatText switch
//             {
//                 "You aren't holding a Revival Potion." => "",
//                 "Did I just get knocked out? Thanks for waking me." => "",
//                 "I'm up. Wide awake. What did you give me? Some sort of potion?" => "",
//                 "Was I asleep or unconscious? Most likely unconscious since, well, I wouldn't just go to sleep on the floor." => "",
//                 _ => Main.npcChatText
//             };
//         }
//         
//         if (npc.type == ModContent.NPCType<DaerelUnconscious>())
//         {
//             Main.npcChatText = Main.npcChatText switch
//             {
//                 "You aren't holding a Revival Potion." => "",
//                 "Rebooting systems..." => "",
//                 "Running self-repairs..." => "",
//                 "I'm not sure how I drank that, since I'm a robot. I probably shouldn't question it." => "",
//                 _ => Main.npcChatText
//             };
//         }
//         
//         if (npc.type == ModContent.NPCType<ZephosUnconscious>())
//         {
//             Main.npcChatText = Main.npcChatText switch
//             {
//                 "You aren't holding a Revival Potion." => "",
//                 "*Yawn* Why'd ya wake me up? I was havin' a dream about... doesn't matter." => "",
//                 "Alright, I'm up. Did I fall asleep or somethin'?" => "",
//                 "Yuck, what did you make me drink? Tastes bitter... like strawberries..." => "",
//                 _ => Main.npcChatText
//             };
//         }
//     }
// }