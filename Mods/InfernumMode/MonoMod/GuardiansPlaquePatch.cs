using System;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.Tiles.Profaned;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class GuardiansPlaquePatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.Infernum != null && ModInstances.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(GuardiansPlaque).GetCachedMethod("MouseOver", Type.EmptyTypes);

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Read", "Читать");
    };
}