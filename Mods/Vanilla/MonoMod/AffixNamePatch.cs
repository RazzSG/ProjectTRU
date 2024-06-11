using CalamityMod.Items;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.ItemGenderPrefixes;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;

public class AffixName : ILoadable
{
    public bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.Calamity == null && TranslationHelper.IsRussianLanguage;
    }

    public void Load(Mod mod)
    {
        On_Item.AffixName += ItemOnAffixName;
    }

    public void Unload()
    {
        On_Item.AffixName -= ItemOnAffixName;
    }

    private string ItemOnAffixName(On_Item.orig_AffixName orig, Item self)
    {
        if (self.prefix < 0 && self.prefix >= Lang.prefix.Length)
            return self.Name;

        string prefix = Lang.prefix[self.prefix].Value;
        PrefixOverhaul prefixOverhaul = new();
        if (prefix == string.Empty)
            return self.Name;

        foreach (var t in prefixOverhaul.Prefixes)
        {
            if (t[0] == prefix)
                return prefixOverhaul.GetGenderedPrefix(t, self.type) + " " + (self.Name.Contains('.') ? self.Name : self.Name.ToLower());
        }

        return prefix + " " + self.Name;
    }
}

public class AffixNameWithCalamity : ILoadable
{
    public bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.Calamity != null && TRuConfig.Instance.CalamityModLocalization && TranslationHelper.IsRussianLanguage;
    }

    public void Load(Mod mod)
    {
        On_Item.AffixName += ItemOnAffixName;
    }

    public void Unload()
    {
        On_Item.AffixName -= ItemOnAffixName;
    }

    private string ItemOnAffixName(On_Item.orig_AffixName orig, Item self)
    {
        string calamityEnchantment = string.Empty, goblinPrefix = string.Empty;
        PrefixOverhaul prefixOverhaul = new();
        
        foreach (string[] t in prefixOverhaul.Prefixes)
        {
            if (!self.IsAir && self.TryGetGlobalItem(out CalamityGlobalItem calamityGlobalItem) && calamityGlobalItem.AppliedEnchantment.HasValue)
            {
                if (t[0] == calamityGlobalItem.AppliedEnchantment?.Name.ToString())
                    calamityEnchantment = prefixOverhaul.GetGenderedPrefix(t, self.type) + " ";

                if (calamityEnchantment != string.Empty)
                    goblinPrefix = goblinPrefix.ToLower();
            }

            if (t[0] == Lang.prefix[self.prefix].Value)
                goblinPrefix = prefixOverhaul.GetGenderedPrefix(t, self.type) + " ";
        }

        if (goblinPrefix == string.Empty && calamityEnchantment == string.Empty)
            return self.Name;
        
        return calamityEnchantment + goblinPrefix + (self.Name.Contains('.') ? self.Name : self.Name.ToLower());
    }
}