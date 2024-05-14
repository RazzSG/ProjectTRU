// using CalamityRuTranslate.Common.Utilities;
// using Terraria.ModLoader;
// using Terraria.UI;
//
// namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;
//
// public class StyleDimensionPatch : ILoadable
// {
//     public bool IsLoadingEnabled(Mod mod)
//     {
//         return TranslationHelper.IsRussianLanguage;
//     }
//
//     public void Load(Mod mod)
//     {
//         On_StyleDimension.Set += On_StyleDimensionOnSet;
//     }
//     
//
//     public void Unload()
//     {
//         On_StyleDimension.Set -= On_StyleDimensionOnSet;
//     }
//     
//     private void On_StyleDimensionOnSet(On_StyleDimension.orig_Set orig, ref StyleDimension self, float pixels, float precent)
//     {
//         pixels = pixels switch
//         {
//             // Stars Above Celestial Compass
//             524f => 564f,
//             546f => 586f,
//             568f => 608f,
//             _ => pixels
//         };
//         
//         orig.Invoke(ref self, pixels, precent);
//     }
// }