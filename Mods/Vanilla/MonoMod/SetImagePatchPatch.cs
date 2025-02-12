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
//         if (ModInstances.Spirit != null && TRuConfig.Instance.SpiritLocalization)
//         {
//             if (texture == ModInstances.Spirit.Assets.Request<Texture2D>("Items/Books/UI/BlossmoonPage"))
//             {
//                 texture = CalamityRuTranslate.Instance.Assets.Request<Texture2D>("Assets/Sprites/Spirit/Books/UI/BlossmoonPage");
//             }
//             
//             if (texture == ModInstances.Spirit.Assets.Request<Texture2D>("Items/Books/UI/LumothPage"))
//             {
//                 texture = CalamityRuTranslate.Instance.Assets.Request<Texture2D>("Assets/Sprites/Spirit/Books/UI/LumothPage");
//             }
//             
//             if (texture == ModInstances.Spirit.Assets.Request<Texture2D>("Items/Books/UI/SoulbloomPage"))
//             {
//                 texture = CalamityRuTranslate.Instance.Assets.Request<Texture2D>("Assets/Sprites/Spirit/Books/UI/SoulbloomPage");
//             }
//             
//             if (texture == ModInstances.Spirit.Assets.Request<Texture2D>("Items/Books/UI/TheBriar"))
//             {
//                 texture = CalamityRuTranslate.Instance.Assets.Request<Texture2D>("Assets/Sprites/Spirit/Books/UI/TheBriar");
//             }
//             
//             if (texture == ModInstances.Spirit.Assets.Request<Texture2D>("Items/Books/UI/TheSpirit"))
//             {
//                 texture = CalamityRuTranslate.Instance.Assets.Request<Texture2D>("Assets/Sprites/Spirit/Books/UI/TheSpirit");
//             }
//         }
//         
//         orig.Invoke(self, texture);
//     }
// }