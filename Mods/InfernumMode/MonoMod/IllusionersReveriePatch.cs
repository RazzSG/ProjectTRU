using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.Items.Weapons.Magic;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class IllusionersReveriePatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.Infernum != null && ModInstances.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(IllusionersReverie).GetCachedMethod(nameof(IllusionersReverie.PreDrawTooltipLine));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "An ", "");
        TranslationHelper.ModifyIL(il, "incomprehensibly ", "Непостижимая ");
        TranslationHelper.ModifyIL(il, "old tome. Somehow, in spite of its supposed age, it appears to be completely unscathed", "древняя книга. Вопреки своему предполагаемому возрасту, она выглядит совершенно нетронутой");
    };
}