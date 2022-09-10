﻿using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.BehaviorOverrides.BossAIs.CalamitasClone;
using MonoMod.Cil;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

[JITWhenModsEnabled("InfernumMode", "CalamityMod")]
public class CalamitasCloneBehaviorOverridePatch : Patch<ILContext.Manipulator>
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(CalamitasCloneBehaviorOverride).GetCachedMethod(nameof(CalamitasCloneBehaviorOverride.PreAI));

    protected override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Destroy ", "Уничтожьте ");
        TranslationHelper.ModifyIL(il, "him", "его");
        TranslationHelper.ModifyIL(il, "her", "её");
        TranslationHelper.ModifyIL(il, ", my brothers.", ", братья мои.");
        TranslationHelper.ModifyIL(il, "I will not be defeated so easily.", "Меня так легко не одолеть.");
        TranslationHelper.ModifyIL(il, "You will suffer.", "Ты будешь страдать.");
    };
}