using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Terraria;

namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;

public class DrawInfoAccsPatch : ILPatcher
{
    public override bool AutoLoad => TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(Main).GetCachedMethod("DrawInfoAccs");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, 12, 24);
        TranslationHelper.ModifyIL(il, 12, 0, 3);
    };
}