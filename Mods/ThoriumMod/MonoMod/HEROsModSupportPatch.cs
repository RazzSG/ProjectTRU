using System;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using Terraria;
using ThoriumMod.ModSupport.ModSupportModules;

namespace CalamityRuTranslate.Mods.ThoriumMod.MonoMod;

public class HEROsModSupportPatch : OnPatcher
{
    public override bool AutoLoad => ModInstances.Thorium != null && TRuConfig.Instance.ThoriumModLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(HEROsModSupport).FindMethod("AddToCategory");

    public override Delegate Delegate => Translation;
    
    private void Translation(Action<HEROsModSupport, string, string, Predicate<Item>> orig, HEROsModSupport self, string name, string category, Predicate<Item> predicate)
    {
        name = name switch
        {
            "Bard" => "Бард",
            "Healer" => "Целитель",
            _ => name
        };
        
        orig.Invoke(self, name, category, predicate);
    }
}