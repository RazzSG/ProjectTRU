using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.ThoriumMod.MonoMod;

public class BreadcrumbItemPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.Thorium != null && TRuConfig.Instance.ThoriumModLocalization && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => ModInstances.Thorium.Code.GetType("ThoriumMod.UI.TrackerUIBreadcrumbs+BreadcrumbItem").FindMethod("DrawSelf");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "{0} [Unlocks in shop]", "{0} [Открывается в магазине]");
    };
}