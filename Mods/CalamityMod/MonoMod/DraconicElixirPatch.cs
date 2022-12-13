﻿using System.Reflection;
using CalamityMod.Cooldowns;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class DraconicElixirPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
        
    public override MethodInfo ModifiedMethod => typeof(DraconicElixir).GetCachedMethod("get_DisplayName");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Draconic Surge Cooldown", "Перезарядка драконьего всплеска");
    };
}