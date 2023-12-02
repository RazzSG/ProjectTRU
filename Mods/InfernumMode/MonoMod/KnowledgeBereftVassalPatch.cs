using System;
using System.Reflection;
using CalamityMod;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.Items.LoreItems;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class KnowledgeBereftVassalPatch : OnPatcher
{
    public override bool AutoLoad => ModInstances.Infernum != null && ModInstances.Calamity != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(KnowledgeBereftVassal).GetCachedMethod("get_Tooltip");

    private delegate LocalizedText TooltipDelegate(KnowledgeBereftVassal self);

    public override Delegate Delegate => Translation;
    
    private LocalizedText Translation(TooltipDelegate orig, KnowledgeBereftVassal self)
    {
        return CalamityUtils.GetText("Items.Lore.ShortTooltip");
    }
}