using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.Content.UI.Elements;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod;

public class FargoUIHeaderPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.FargowiltasSouls != null && TRuConfig.Instance.FargowiltasSoulsLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(FargoUIHeader).FindMethod("DrawSelf");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, 1f, 0.9f);
    };
}