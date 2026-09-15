using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.Content.UI.Elements;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod;

public class UITogglePatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.FargowiltasSouls != null && TRuConfig.Instance.FargowiltasSoulsLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(UIToggle).FindMethod("DrawSelf");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, 1f, 0.9f);
    };
}