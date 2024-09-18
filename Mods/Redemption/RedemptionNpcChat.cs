// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.Config;
// using Redemption.Globals;
// using Redemption.NPCs.Friendly;
// using Redemption.NPCs.Friendly.TownNPCs;
// using Terraria;
// using Terraria.Localization;
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
//                 chat = "Дэрел лежит без сознания меньше минуты";
//
//             if (chat == $"Daerel has been unconsious for {RedeWorld.daerelDownedTimer / 3600} minute(s).")
//             {
//                 string valueSuffix = LocalizedText.ApplyPluralization("{^0:минуту;минуты;минут}", RedeWorld.daerelDownedTimer / 3600);
//                 chat = $"Дэрел лежит без сознания {RedeWorld.daerelDownedTimer / 3600} {valueSuffix}.";
//             }
//         }
//         
//         if (npc.type == ModContent.NPCType<TBotUnconscious>())
//         {
//             if (chat == "Adam has been unconsious for less than a minute.")
//                 chat = "Адам лежит без сознания меньше минуты";
//
//             if (chat == $"Adam has been unconsious for {RedeWorld.tbotDownedTimer / 3600} minute(s).")
//             {
//                 string valueSuffix = LocalizedText.ApplyPluralization("{^0:минуту;минуты;минут}", RedeWorld.tbotDownedTimer / 3600);
//                 chat = $"Адам лежит без сознания {RedeWorld.tbotDownedTimer / 3600} {valueSuffix}.";
//             }
//         }
//         
//         if (npc.type == ModContent.NPCType<ZephosUnconscious>())
//         {
//             if (chat == "Zephos has been unconsious for less than a minute.")
//                 chat = "Зефос лежит без сознания меньше минуты";
//
//             if (chat == $"Zephos has been unconsious for {RedeWorld.zephosDownedTimer / 3600} minute(s).")
//             {
//                 string valueSuffix = LocalizedText.ApplyPluralization("{^0:минуту;минуты;минут}", RedeWorld.zephosDownedTimer / 3600);
//                 chat = $"Зефос лежит без сознания {RedeWorld.zephosDownedTimer / 3600} {valueSuffix}.";
//             }
//         }
//         
//         if (npc.type == ModContent.NPCType<SoullessPortal>())
//         {
//             chat = chat switch
//             {
//                 "You wish to escape this cursed place..." => "Ты жаждешь покинуть это проклятое место...",
//                 "You hear an ominous hum from the portal..." => "Из портала доносится зловещий гул...",
//                 _ => chat
//             };
//         }
//         
//         if (npc.type == ModContent.NPCType<TreebarkDryad>())
//         {
//             if (chat.Contains("Hmmmm..."))
//             {
//                 chat = chat.Replace("Hmmmm...", "Хм-м-м...");
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
//                 "You aren't holding a Revival Potion." => "У вас нет при себе зелья восстановления.",
//                 "Did I just get knocked out? Thanks for waking me." => "Я что, был в отключке? Спасибо, что разбудил.",
//                 "I'm up. Wide awake. What did you give me? Some sort of potion?" => "Я на ногах. Бодрячком. Что ты мне дал? Какое-то зелье?",
//                 "Was I asleep or unconscious? Most likely unconscious since, well, I wouldn't just go to sleep on the floor." => "Я спал или был в сознания? Скорее всего, без сознания, ведь я бы не стал просто так спать на земле.",
//                 _ => Main.npcChatText
//             };
//         }
//         
//         if (npc.type == ModContent.NPCType<TBotUnconscious>())
//         {
//             Main.npcChatText = Main.npcChatText switch
//             {
//                 "You aren't holding a Revival Potion." => "У вас нет при себе зелья восстановления.",
//                 "Rebooting systems..." => "Перезапуск систем...",
//                 "Running self-repairs..." => "Активация самовосстановления...",
//                 "I'm not sure how I drank that, since I'm a robot. I probably shouldn't question it." => "Не понимаю, как я это выпил, ведь я робот. Пожалуй, не стоит забивать себе этим голову.",
//                 _ => Main.npcChatText
//             };
//         }
//         
//         if (npc.type == ModContent.NPCType<ZephosUnconscious>())
//         {
//             Main.npcChatText = Main.npcChatText switch
//             {
//                 "You aren't holding a Revival Potion." => "У вас нет при себе зелья восстановления.",
//                 "*Yawn* Why'd ya wake me up? I was havin' a dream about... doesn't matter." => "*Зевает* Чего разбудил-то? Мне такой сон снился про... ладно, неважно.",
//                 "Alright, I'm up. Did I fall asleep or somethin'?" => "Лады, я проснулся. Я что, дрыхнул, что ли?",
//                 "Yuck, what did you make me drink? Tastes bitter... like strawberries..." => "Тьфу, чем ты меня напоил? Горчит... прям как клубника...",
//                 _ => Main.npcChatText
//             };
//         }
//     }
// }