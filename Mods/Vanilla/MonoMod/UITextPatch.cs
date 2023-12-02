// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using Terraria.GameContent.UI.Elements;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Vanilla.MonoMod;
//
// public class UITextPatch : ILoadable
// {
//     public bool IsLoadingEnabled(Mod mod)
//     {
//         return TranslationHelper.IsRussianLanguage;
//     }
//
//     public void Load(Mod mod)
//     {
//         On_UIText.SetText_string += On_UITextOnSetText_string;
//     }
//
//     public void Unload()
//     {
//         On_UIText.SetText_string -= On_UITextOnSetText_string;
//     }
//
//     private void On_UITextOnSetText_string(On_UIText.orig_SetText_string orig, UIText self, string text)
//     {
//         text = text switch
//         {
//             "Asphodene" => "Асфодена",
//             "Eridani" => "Эридани",
//             "Perseus" => "Персей",
//             "Yojimbo" => "Йодзимбо",
//             "Garridine" => "Гарридин",
//             "[c/FF9D4B:Heavensfall]" => "[c/FF9D4B:Небесный водопад]",
//             "[c/FF9D4B:A World Rent Asunder]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Surpassing Infinity]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Ascendance]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:The Flood Of Light]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Coruscant Saber]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Coruscant Saber II]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Blotted Whims]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Sanctified Slaughter]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Perfect Strokes]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Thousand Strikes]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Thousand Strikes ]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Blazing Skies II]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:The Bitter End]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Synaptic Static]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Absolute Fire III]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Absolute Blizzard III]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Terror Unleashed]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:A Dash of Chaos]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Ink Over]" => "[c/FF9D4B:Вездесущие чернила]",
//             "[c/FF9D4B:The Garden of Avalon]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Gravitational Anomaly]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Ars Laevateinn]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Painted Attendants]" => "[c/FF9D4B:Нарисованные слуги]",
//             "[c/FF9D4B:Aegis of Frost]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Absolute Thunder IV]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Quintuplecast]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Absolute Holy]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Crack The Sky]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Magnum Opus]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Linear Mystics]" => "[c/FF9D4B:Линейные мистики]",
//             "[c/FF9D4B:Splattered Sundering]" => "[c/FF9D4B:Забрызганная скованность]",
//             "[c/FF9D4B:SOUL Extraction]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Light Rampant]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Radiant Braver]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Meteor Shower]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Quasar Forthcoming]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Spilled Violet]" => "[c/FF9D4B:Пролитый пурпур]",
//             "[c/FF9D4B:Plutonic Barrage]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Spatial Rip]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Transplacement]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Recall]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Relinquish]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Galactic Swarm]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Concentrativity]" => "[c/FF9D4B:]",
//             "[c/5970cf:Reload]" => "[c/5970cf:Перезарядка]",
//             "[c/FF9D4B:Threads of Fate]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:The Void Consumes All]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Rend Heaven]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Beneath a Bleak Sky]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Sanctified Slaughter II]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Total Isolation]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Hello, World]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Suppuration]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Synaptic Syntax]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Overflow Error]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:To The Limit]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Titanomachy]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Abrasion]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Order through Chaos]" => "[c/FF9D4B:]",
//             "[c/FF9D4B:Chaos through Order]" => "[c/FF9D4B:]",
//             _ => text
//         };
//         
//         orig.Invoke(self, text);
//     }
// }