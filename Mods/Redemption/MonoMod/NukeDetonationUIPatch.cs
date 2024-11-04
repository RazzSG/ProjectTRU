using System;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Redemption.UI;
using ReLogic.Content;
using Terraria.GameContent.UI.Elements;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Redemption.MonoMod;

public class NukeDetonationUIPatch : OnPatcher
{
    private delegate void UpdateDelegate(NukeDetonationUI self, GameTime gameTime);
    
    public override bool AutoLoad => ModInstances.Redemption != null && TRuConfig.Instance.RedemptionLocalization && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(NukeDetonationUI).GetCachedMethod(nameof(NukeDetonationUI.Update));

    public override Delegate Delegate => Translation;

    private void Translation(UpdateDelegate orig, NukeDetonationUI self, GameTime gameTime)
    {
        orig.Invoke(self, gameTime);
        UIImage bgSpriteField = (UIImage) typeof(NukeDetonationUI).GetField("BgSprite", BindingFlags.NonPublic | BindingFlags.Instance)?.GetValue(self);
        bgSpriteField?.SetImage(ModContent.Request<Texture2D>("CalamityRuTranslate/Assets/Sprites/Redemption/NukeDetonationUI_BG", AssetRequestMode.ImmediateLoad));
    }
}