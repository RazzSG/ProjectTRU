// using System;
// using System.Reflection;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using Microsoft.Xna.Framework;
// using Microsoft.Xna.Framework.Graphics;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;
//
// public class DrawPatch : OnPatcher
// {
//     private delegate void DrawDelegate(SpriteBatch self, Texture2D texture, Rectangle destinationRectangle, Color color);
//     
//     public override bool AutoLoad => TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => typeof(SpriteBatch).GetCachedMethod("Draw", new[] {typeof(Texture2D), typeof(Rectangle), typeof(Color)});
//
//     public override Delegate Delegate => Translate;
//
//     private void Translate(DrawDelegate orig, SpriteBatch self, Texture2D texture, Rectangle destinationRectangle, Color color)
//     {
//         if (texture == (Texture2D) ModContent.Request<Texture2D>("StarsAbove/UI/StellarNova/prototokiaIcon"))
//         {
//             texture = (Texture2D) ModContent.Request<Texture2D>("CalamityRuTranslate/Assets/Sprites/StarsAbove/prototokiaIcon");
//         }
//         
//         if (texture == (Texture2D) ModContent.Request<Texture2D>("StarsAbove/UI/StellarNova/laevateinnIcon"))
//         {
//             texture = (Texture2D) ModContent.Request<Texture2D>("CalamityRuTranslate/Assets/Sprites/StarsAbove/laevateinnIcon");
//         }
//         
//         if (texture == (Texture2D) ModContent.Request<Texture2D>("StarsAbove/UI/StellarNova/KiwamiRyukenIcon"))
//         {
//             texture = (Texture2D) ModContent.Request<Texture2D>("CalamityRuTranslate/Assets/Sprites/StarsAbove/KiwamiRyukenIcon");
//         }
//         
//         if (texture == (Texture2D) ModContent.Request<Texture2D>("StarsAbove/UI/StellarNova/gardenofavalonIcon"))
//         {
//             texture = (Texture2D) ModContent.Request<Texture2D>("CalamityRuTranslate/Assets/Sprites/StarsAbove/gardenofavalonIcon");
//         }
//         
//         if (texture == (Texture2D) ModContent.Request<Texture2D>("StarsAbove/UI/StellarNova/edingenesisquasarIcon"))
//         {
//             texture = (Texture2D) ModContent.Request<Texture2D>("CalamityRuTranslate/Assets/Sprites/StarsAbove/edingenesisquasarIcon");
//         }
//         
//         if (texture == (Texture2D) ModContent.Request<Texture2D>("StarsAbove/UI/StellarNova/unlimitedbladeworksIcon"))
//         {
//             texture = (Texture2D) ModContent.Request<Texture2D>("CalamityRuTranslate/Assets/Sprites/StarsAbove/unlimitedbladeworksIcon");
//         }
//         
//         if (texture == (Texture2D) ModContent.Request<Texture2D>("StarsAbove/UI/StellarNova/guardianslightIcon"))
//         {
//             texture = (Texture2D) ModContent.Request<Texture2D>("CalamityRuTranslate/Assets/Sprites/StarsAbove/guardianslightIcon");
//         }
//         
//         orig.Invoke(self, texture, destinationRectangle, color);
//     }
// }