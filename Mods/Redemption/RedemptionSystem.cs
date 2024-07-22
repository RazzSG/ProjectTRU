// using System.Collections.Generic;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using Redemption;
// using Terraria.Audio;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.Redemption;
//
// public class RedemptionSystem : ModSystem
// {
//     public static Dictionary<SoundStyle, SoundStyle> SoundMap = new()
//     {
//         { CustomSounds.Pixie1, RedemptionSoundRegistry.Pixie1 },
//         { CustomSounds.Pixie2, RedemptionSoundRegistry.Pixie2 },
//         { CustomSounds.Pixie3, RedemptionSoundRegistry.Pixie3 },
//     };
//     
//     public override bool IsLoadingEnabled(Mod mod)
//     {
//         return ModInstances.Redemption != null /*&& TRuConfig.Instance.RedemptionLocalization*/ && TranslationHelper.IsRussianLanguage;
//     }
// }