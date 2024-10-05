// using System.Collections.Generic;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.Config;
// using Redemption.NPCs.Friendly.TownNPCs;
// using Terraria;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.Redemption;
//
// public class RedemptionTownNpcNames: GlobalNPC
// {
//     private static Dictionary<int, List<string>> _townNpcNames = new()
//     {
//         { ModContent.NPCType<Daerel>(), ["Дэрел"] },
//         { ModContent.NPCType<Fallen>(), ["Хэппинс", "Тенвон", "Оковт"] },
//         { ModContent.NPCType<ForestNymph_Friendly>(), ["Нисса", "Амми", "Альдерис", "Мэйпл", "Лаванда", "Амброз", "Нелида", "Силлесса"] },
//         { ModContent.NPCType<Newb>(), ["Ньюб"] },
//         { ModContent.NPCType<TBot>(), ["Адам"] },
//         { ModContent.NPCType<Zephos>(), ["Зефос"] },
//     };
//     
//     public override bool IsLoadingEnabled(Mod mod)
//     {
//         return ModInstances.Redemption != null /*&& TRuConfig.Instance.RedemptionLocalization*/ && TranslationHelper.IsRussianLanguage;
//     }
//
//     public override void ModifyNPCNameList(NPC npc, List<string> nameList)
//     {
//         if (_townNpcNames.TryGetValue(npc.type, out List<string> names))
//         {
//             nameList.Clear();
//             nameList.AddRange(names);
//         }
//     }
//
//     public override void Unload()
//     {
//         _townNpcNames?.Clear();
//         _townNpcNames = null;
//     }
// }