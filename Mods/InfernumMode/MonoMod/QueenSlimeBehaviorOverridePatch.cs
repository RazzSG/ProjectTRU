﻿using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BehaviorOverrides.BossAIs.QueenSlime;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class QueenSlimeBehaviorOverridePatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(QueenSlimeBehaviorOverride).GetCachedMethod(nameof(QueenSlimeBehaviorOverride.GetTips));

    private delegate IEnumerable<Func<NPC, string>> GetTipsDelegate(QueenSlimeBehaviorOverride self);

    public override Delegate Delegate => Translation;

    private IEnumerable<Func<NPC, string>> Translation(GetTipsDelegate orig, QueenSlimeBehaviorOverride self)
    {
        yield return n => "Давай, беги, наши ноги не для скуки! Эта желатиновая королева не остановится, пока не сокрушит своих врагов!";
        yield return n => "Короткие прыжки намного полезнее, чем попытки улететь от этой хрустальной шрапнели!";
    }
}