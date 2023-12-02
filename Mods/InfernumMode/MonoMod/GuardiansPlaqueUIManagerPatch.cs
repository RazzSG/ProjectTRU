using System;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.UI;
using MonoMod.Cil;
using ReLogic.Content;
using ReLogic.Graphics;
using Terraria.GameContent;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class GuardiansPlaqueUIManagerDraw : ILPatcher
{
    public override bool AutoLoad => ModInstances.Infernum != null && ModInstances.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodBase ModifiedMethod => typeof(GuardiansPlaqueUIManager).GetCachedMethod(nameof(GuardiansPlaqueUIManager.Draw));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Three disciples. One mind. One deity. One purpose. Tempered by the holy flames of Providence, an ancient artifact is crystalized, with the sole purpose of initiating the Ritual at the cliff of this Temple.", "Три апостола. Одно единое сознание. Одна богиня. Одна священная миссия. Окутанный священным пламенем Провиденс, древний артефакт кристаллизуется с единственной целью инициировать ритуал на утёсе этого храма.");
        TranslationHelper.ModifyIL(il, "ancient artifact", "древний артефакт");
        TranslationHelper.ModifyIL(il, "ancient artifact", "древний артефакт", 2);
        TranslationHelper.ModifyIL(il, "ancient artifact", "древний артефакт", 3);
    };
}

public class GuardiansPlaqueUIManagerTextFont : OnPatcher
{
    public override bool AutoLoad => ModInstances.Infernum != null && ModInstances.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(GuardiansPlaqueUIManager).GetCachedMethod("get_TextFont");

    private delegate DynamicSpriteFont TextFontDelegate();

    public override Delegate Delegate => Translation;
    
    private DynamicSpriteFont Translation(TextFontDelegate orig)
    {
        if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            return CalamityRuTranslate.Instance.Assets.Request<DynamicSpriteFont>("Assets/Fonts/ProfanedText", AssetRequestMode.ImmediateLoad).Value;

        return FontAssets.MouseText.Value;
    }
}

public class GuardiansPlaqueUIManagerDrawTextLine : ILPatcher
{
    public override bool AutoLoad => ModInstances.Infernum != null && ModInstances.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(GuardiansPlaqueUIManager).GetCachedMethod(nameof(GuardiansPlaqueUIManager.DrawTextLine));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "ancient artifact", "древний артефакт");
        TranslationHelper.ModifyIL(il, "Profaned Shard", "Осквернённый осколок");
    };
}