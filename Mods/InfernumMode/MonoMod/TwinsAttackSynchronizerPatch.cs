﻿using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.BehaviorOverrides.BossAIs.Twins;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

[JITWhenModsEnabled("InfernumMode", "CalamityMod")]
public class TwinsAttackSynchronizerPatch : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(TwinsAttackSynchronizer).GetCachedMethod(nameof(TwinsAttackSynchronizer.DoAI));

    protected override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "SPA-MK1", "СПА-МК1");
        TranslationHelper.ModifyIL(il, "SPA-MK1", "СПА-МК1", 2);
        TranslationHelper.ModifyIL(il, "RET-MK1", "РЕТ-МК1");
        TranslationHelper.ModifyIL(il, "RET-MK1", "РЕТ-МК1", 2);
        TranslationHelper.ModifyIL(il, ": DEFENSES PENETRATED. INITIATING PROCEDURE SHLD-17ECF9.", ": ЗАЩИТА ПРОРВАНА. ИНИЦИИРУЮ ПРОЦЕДУРУ  ЩТ-17ECF9.");
        TranslationHelper.ModifyIL(il, ": ERROR DETECTING SECONDARY UNIT. BURNING EXCESS FUEL RESERVES.", ": ВТОРИЧНАЯ ЕДИНИЦА НЕ ОБНАРУЖЕНА. СЖИГАНИЕ ИЗБЫТОЧНЫХ ЗАПАСОВ ТОПЛИВА.");
    };
}