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
//         if (texture == ModContent.Request<Texture2D>("StarsAbove/UI/StellarNova/prototokiaIcon").Value)
//         {
//             texture = ModContent.Request<Texture2D>("CalamityRuTranslate/Assets/Sprites/StarsAbove/prototokiaIcon").Value;
//         }
//         
//         if (texture == ModContent.Request<Texture2D>("StarsAbove/UI/StellarNova/laevateinnIcon").Value)
//         {
//             texture = ModContent.Request<Texture2D>("CalamityRuTranslate/Assets/Sprites/StarsAbove/laevateinnIcon").Value;
//         }
//         
//         if (texture == ModContent.Request<Texture2D>("StarsAbove/UI/StellarNova/KiwamiRyukenIcon").Value)
//         {
//             texture = ModContent.Request<Texture2D>("CalamityRuTranslate/Assets/Sprites/StarsAbove/KiwamiRyukenIcon").Value;
//         }
//         
//         if (texture == ModContent.Request<Texture2D>("StarsAbove/UI/StellarNova/gardenofavalonIcon").Value)
//         {
//             texture = ModContent.Request<Texture2D>("CalamityRuTranslate/Assets/Sprites/StarsAbove/gardenofavalonIcon").Value;
//         }
//         
//         if (texture == ModContent.Request<Texture2D>("StarsAbove/UI/StellarNova/edingenesisquasarIcon").Value)
//         {
//             texture = ModContent.Request<Texture2D>("CalamityRuTranslate/Assets/Sprites/StarsAbove/edingenesisquasarIcon").Value;
//         }
//         
//         if (texture == ModContent.Request<Texture2D>("StarsAbove/UI/StellarNova/unlimitedbladeworksIcon").Value)
//         {
//             texture = ModContent.Request<Texture2D>("CalamityRuTranslate/Assets/Sprites/StarsAbove/unlimitedbladeworksIcon").Value;
//         }
//         
//         if (texture == ModContent.Request<Texture2D>("StarsAbove/UI/StellarNova/guardianslightIcon").Value)
//         {
//             texture = ModContent.Request<Texture2D>("CalamityRuTranslate/Assets/Sprites/StarsAbove/guardianslightIcon").Value;
//         }
//         
//         orig.Invoke(self, texture, destinationRectangle, color);
//     }
// }