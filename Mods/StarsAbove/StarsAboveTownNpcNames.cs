// using System.Collections.Generic;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using Terraria;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.StarsAbove;
//
// public class StarsAboveTownNpcNames : GlobalNPC
// {
//     private static Dictionary<int, List<string>> _townNpcNames = new()
//     {
//         { ModContent.NPCType<Astrologian>(), new List<string> { "Одетта", "Астеропа", "Майя", "Тайгета", "Целено", "Алкиона", "Меропа", "Электра", "Селена", "Сана", "Тиферет", "Лунала" } },
//         { ModContent.NPCType<Garridine>(), new List<string> { "Гарридин" } },
//         { ModContent.NPCType<Yojimbo>(), new List<string> { "Йодзимбо" } },
//     };
//     
//     public override bool IsLoadingEnabled(Mod mod)
//     {
//         return ModInstances.StarsAbove != null && TranslationHelper.IsRussianLanguage;
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