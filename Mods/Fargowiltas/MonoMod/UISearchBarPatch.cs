using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.UI;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod;

public class UISearchBarPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.Fargowiltas != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodBase ModifiedMethod => typeof(UISearchBar).GetCachedMethod("DrawChildren");
    
    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Search...", "Поиск...");
    };
}