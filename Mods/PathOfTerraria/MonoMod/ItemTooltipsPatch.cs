using System;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using PathOfTerraria.Common.Enums;
using PathOfTerraria.Core.Items;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.PathOfTerraria.MonoMod;

public class ItemTooltipsPatch : OnPatcher
{
    public override bool AutoLoad => ModInstances.PathOfTerraria != null && TRuConfig.Instance.PathOfTerrariaLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(ItemTooltips).FindMethod("GetDescriptor", [typeof(string), typeof(ItemRarity), typeof(Influence)]);

    public override Delegate Delegate => Translation;

    private string Translation(Func<string, ItemRarity, Influence, string> orig, string typeName, ItemRarity rare, Influence influence)
    {
        int genderIndex = GetGenderType(typeName);
        string rareName = Language.GetTextValue("Mods.PathOfTerraria.Gear.Rarity." + rare, () => "");
        string influenceName = Language.GetTextValue("Mods.PathOfTerraria.Gear.Influence." + influence, () => "");
        
        string[] forms = rareName.Split('|');
        rareName = genderIndex < forms.Length ? forms[genderIndex] : forms[0];
        
        forms = influenceName.Split('|');
        influenceName = genderIndex < forms.Length ? forms[genderIndex] : forms[0];
        
        bool hasPrefix = !string.IsNullOrWhiteSpace(influenceName) || !string.IsNullOrWhiteSpace(rareName);

        if (hasPrefix)
            typeName = typeName.ToLower();

        return !hasPrefix ? $" {typeName}" : string.Join(" ", influenceName, rareName, typeName);
    }
    
    private static int GetGenderType(string type)
    {
        return type switch
        {
            "Карта" or "Карта для исследования" or "Карта босса" or "Книга заклинаний" => 1, // Женский
            "Магическое" or "Стрелковое" or "Призывное" or "Метательное" or "Кольцо" or "Ружьё" => 2, // Средний
            "Поножи" => 3, // Множественный
            _ => 0
        };
    }
}