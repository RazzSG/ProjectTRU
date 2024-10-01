// using System.Collections.Generic;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using Microsoft.Xna.Framework.Graphics;
// using Redemption;
// using Redemption.NPCs.Bosses.Neb;
// using Terraria.Audio;
// using Terraria.GameContent;
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
//
//     public override void PostSetupContent()
//     {
//         TextureAssets.Projectile[ModContent.ProjectileType<Shout1>()] = Mod.Assets.Request<Texture2D>("Assets/Sprites/Redemption/Shout1");
//         TextureAssets.Projectile[ModContent.ProjectileType<Shout2>()] = Mod.Assets.Request<Texture2D>("Assets/Sprites/Redemption/Shout2");
//         TextureAssets.Projectile[ModContent.ProjectileType<Shout3>()] = Mod.Assets.Request<Texture2D>("Assets/Sprites/Redemption/Shout3");
//         TextureAssets.Projectile[ModContent.ProjectileType<Shout4>()] = Mod.Assets.Request<Texture2D>("Assets/Sprites/Redemption/Shout4");
//         TextureAssets.Projectile[ModContent.ProjectileType<Shout5>()] = Mod.Assets.Request<Texture2D>("Assets/Sprites/Redemption/Shout5");
//         TextureAssets.Projectile[ModContent.ProjectileType<Shout6>()] = Mod.Assets.Request<Texture2D>("Assets/Sprites/Redemption/Shout6");
//         TextureAssets.Projectile[ModContent.ProjectileType<Shout7>()] = Mod.Assets.Request<Texture2D>("Assets/Sprites/Redemption/Shout7");
//         TextureAssets.Projectile[ModContent.ProjectileType<Shout8>()] = Mod.Assets.Request<Texture2D>("Assets/Sprites/Redemption/Shout8");
//         TextureAssets.Projectile[ModContent.ProjectileType<Shout9>()] = Mod.Assets.Request<Texture2D>("Assets/Sprites/Redemption/Shout9");
//         TextureAssets.Projectile[ModContent.ProjectileType<Shout10>()] = Mod.Assets.Request<Texture2D>("Assets/Sprites/Redemption/Shout10");
//         TextureAssets.Projectile[ModContent.ProjectileType<Shout11>()] = Mod.Assets.Request<Texture2D>("Assets/Sprites/Redemption/Shout11");
//     }
// }