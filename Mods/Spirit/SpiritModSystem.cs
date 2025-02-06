// using System.Linq;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.Config;
// using SpiritMod.Mechanics.QuestSystem;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.Spirit;
//
// public class SpiritModSystem : ModSystem
// {
//     public override bool IsLoadingEnabled(Mod mod)
//     {
//         return ModInstances.Spirit != null && TRuConfig.Instance.SpiritLocalization && TranslationHelper.IsRussianLanguage;
//     }
//
//     public override void PostSetupContent()
//     {
//         foreach (string key in QuestManager.Categories.Keys.ToList())
//         {
//             QuestManager.QuestCategory category = QuestManager.Categories[key];
//             category.Name = key switch
//             {
//                 "Main" => "Основной",
//                 "Explorer" => "Исследовательский",
//                 "Forager" => "Собирательский",
//                 "Slayer" => "Охотничий",
//                 "Designer" => "Строительский",
//                 "Other" => "Прочий",
//                 _ => category.Name
//             };
//
//             QuestManager.Categories[key] = category;
//         }
//     }
// }