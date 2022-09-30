﻿using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.Items.Summons.Abom;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod;

public class AnemometerPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(Anemometer).GetCachedMethod(nameof(Anemometer.UseItem));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "The wind begins howling.", "Начинает завывать ветер.");
    };
}