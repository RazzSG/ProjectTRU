// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.Config;
// using SpiritMod.Buffs;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.Spirit;
//
// public class SpiritModGlobalBuff : GlobalBuff
// {
//     public override bool IsLoadingEnabled(Mod mod)
//     {
//         return ModInstances.Spirit != null && TRuConfig.Instance.SpiritLocalization && TranslationHelper.IsRussianLanguage;
//     }
//     
//     public override void ModifyBuffText(int type, ref string buffName, ref string tip, ref int rare)
//     {
//         if (type == ModContent.BuffType<EleutheriosBuff>())
//         {
//             tip = tip.Replace("Damage increased by", "Урон увеличен на");
//         }
//
//         if (type == ModContent.Find<ModBuff>("SpiritMod/ExplorerFight").Type)
//         {
//             tip = tip.Replace("Damage dealt is increased by", "Урон увеличен на");
//         }
//         
//         if (type == ModContent.Find<ModBuff>("SpiritMod/ExplorerMine").Type)
//         {
//             tip = tip.Replace("Mining speed is increased", "Скорость добычи увеличена").Replace("stacks", "стака");
//         }
//         
//         if (type == ModContent.Find<ModBuff>("SpiritMod/ExplorerPot").Type)
//         {
//             tip = tip.Replace("Movement speed is increased by", "Скорость передвижения увеличена на");
//         }
//         
//         if (type == ModContent.Find<ModBuff>("SpiritMod/BeetleFortitude").Type)
//         {
//             tip = tip.Replace("Damage taken is reduced by", "Сопротивление урону увеличено на");
//         }
//     }
// }