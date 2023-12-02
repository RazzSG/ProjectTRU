using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using ThoriumMod.UI.ResourceBars;

namespace CalamityRuTranslate.Mods.ThoriumMod.MonoMod;

public class InformationalIconsPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.Thorium != null && TranslationHelper.IsRussianLanguage;
        
    public override MethodInfo ModifiedMethod => typeof(InformationalIcons).GetCachedMethod("DrawSelf");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, " sec", " сек");
    };
}