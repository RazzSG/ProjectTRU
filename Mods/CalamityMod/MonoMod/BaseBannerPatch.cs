using System;
using System.Reflection;
using CalamityMod.Items.Placeables;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class BaseBannerPatch : OnPatcher
{
    public override bool AutoLoad => ModInstances.Calamity != null && TRuConfig.Instance.CalamityModLocalization && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(BaseBanner).GetCachedMethod("get_DisplayName");

    private delegate LocalizedText DisplayNameDelegate(BaseBanner self);
    
    public override Delegate Delegate => Translation;

    private LocalizedText Translation(DisplayNameDelegate orig, BaseBanner self)
    {
        return self.GetLocalization(nameof(self.DisplayName), self.PrettyPrintName);
    }
}