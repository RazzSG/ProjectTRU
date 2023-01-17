﻿using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.GlobalInstances;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class GlobalNPCOverridesPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(GlobalNPCOverrides).GetCachedMethod(nameof(GlobalNPCOverrides.OnKill));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "A profaned shrine has erupted from the ashes at the underworld's edge!", "Осквернённое святилище вырывается из пепла на границе преисподней!");
        TranslationHelper.ModifyIL(il, "Mysterious ruins have materialized in the heart of the desert!", "Загадочные руины материализовались в самом сердце пустыни!");
    };
}