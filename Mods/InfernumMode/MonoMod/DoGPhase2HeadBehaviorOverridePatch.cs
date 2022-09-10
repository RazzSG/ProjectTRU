﻿using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.BehaviorOverrides.BossAIs.DoG;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

[JITWhenModsEnabled("InfernumMode", "CalamityMod")]
public class DoGPhase2HeadBehaviorOverridePatch : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(DoGPhase2HeadBehaviorOverride).GetCachedMethod(nameof(DoGPhase2HeadBehaviorOverride.Phase2AI));

    protected override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "A GOD DOES NOT FEAR DEATH!", "БОГ НЕ СТРАШИТСЯ СМЕРТИ!");
        TranslationHelper.ModifyIL(il, "I WILL NOT BE DESTROYED!!!", "МЕНЯ НЕ УНИЧТОЖИТЬ!!!");
        TranslationHelper.ModifyIL(il, "I WILL NOT BE DESTROYED!!!", "МЕНЯ НЕ УНИЧТОЖИТЬ!!!", 2);
        TranslationHelper.ModifyIL(il, "I WILL NOT BE DESTROYED!!!", "МЕНЯ НЕ УНИЧТОЖИТЬ!!!", 3);
        TranslationHelper.ModifyIL(il, "I WILL NOT...", "Я НЕ...");
        TranslationHelper.ModifyIL(il, "I...", "Я...");
    };
}