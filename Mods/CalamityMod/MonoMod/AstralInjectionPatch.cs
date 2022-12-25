﻿using System.Reflection;
using CalamityMod.Items.Potions;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class AstralInjectionPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(AstralInjection).GetCachedMethod(nameof(AstralInjection.OnConsumeItem));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "'s blood vessels burst from drug overdose.", " разрывает кровеносные сосуды от передозировки наркотиками.");
    };
}