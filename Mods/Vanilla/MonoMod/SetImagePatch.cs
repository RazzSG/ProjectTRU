// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.Config;
// using Microsoft.Xna.Framework.Graphics;
// using ReLogic.Content;
// using Terraria.GameContent.UI.Elements;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;
//
// public class SetImagePatch : ILoadable
// {
//     public bool IsLoadingEnabled(Mod mod)
//     {
//         return TranslationHelper.IsRussianLanguage;
//     }
//
//     public void Load(Mod mod)
//     {
//         On_UIImage.SetImage_Asset1 += On_UIImageOnSetImage_Asset1;
//     }
//
//     public void Unload()
//     {
//         On_UIImage.SetImage_Asset1 -= On_UIImageOnSetImage_Asset1;
//     }
//     
//     private void On_UIImageOnSetImage_Asset1(On_UIImage.orig_SetImage_Asset1 orig, UIImage self, Asset<Texture2D> texture)
//     {
//         if (ModInstances.Redemption != null && TRuConfig.Instance.RedemptionLocalization)
//         {
//             if (texture == ModInstances.Redemption.Assets.Request<Texture2D>("UI/NukeDetonationUI_BG"))
//             {
//                 texture = CalamityRuTranslate.Instance.Assets.Request<Texture2D>("Assets/Sprites/Redemption/NukeDetonationUI_BG");
//             } 
//         }
//         
//         orig.Invoke(self, texture);
//     }
// }