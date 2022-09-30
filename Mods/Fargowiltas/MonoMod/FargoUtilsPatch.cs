﻿using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Microsoft.Xna.Framework;
using MonoMod.Cil;
using Terraria;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod;

public class FargoUtilsPatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => ModsCall.Fargo.Code.GetType("Fargowiltas.FargoUtils")?.GetMethod("TryDowned", BindingFlags.Public | BindingFlags.Static, new []{typeof(NPC), typeof(string), typeof(Color), typeof(bool), typeof(string[])});

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "A new item has been unlocked in ", "У ");
        TranslationHelper.ModifyIL(il, "'s shop!", " разблокировался новый предмет для продажи!");
    };
}