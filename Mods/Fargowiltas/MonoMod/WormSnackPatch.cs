﻿using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.Items.Summons.Deviantt;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod;

public class WormSnackPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(WormSnack).GetCachedMethod("get_NPCName");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Digger", "Землекоп");
        TranslationHelper.ModifyIL(il, "Giant Worm", "Гигантский червь");
    };
}