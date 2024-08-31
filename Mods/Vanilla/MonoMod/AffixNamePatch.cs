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
        string result = orig.Invoke(self);
        PrefixOverhaul prefixOverhaul = new();
        foreach (var t in prefixOverhaul.Prefixes)
        {
            if (t[0] == Lang.prefix[self.prefix].Value)
                return prefixOverhaul.GetGenderedPrefix(t, self.type) + " " + (self.Name.Contains('.') ? self.Name : self.Name.ToLower());
        }

        return result;
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
        if (self.prefix < 0 || self.prefix >= Lang.prefix.Length)
            return self.Name;

        PrefixOverhaul prefixOverhaul = new();
        string goblinPrefix = Lang.prefix[self.prefix].Value;
        string calamityEnchantment = string.Empty;

        foreach (var t in prefixOverhaul.Prefixes)
        {
            if (!self.IsAir && self.TryGetGlobalItem(out CalamityGlobalItem calamityGlobalItem) && calamityGlobalItem.AppliedEnchantment.HasValue)
            {
                if (t[0] == calamityGlobalItem.AppliedEnchantment?.Name.ToString())
                    calamityEnchantment = prefixOverhaul.GetGenderedPrefix(t, self.type);
            }

            if (t[0] == goblinPrefix)
                goblinPrefix = prefixOverhaul.GetGenderedPrefix(t, self.type);
        }

        string formattedName = self.Name.Contains('.') ? self.Name : self.Name.ToLower();
        
        if (calamityEnchantment != string.Empty && goblinPrefix == string.Empty)
            return calamityEnchantment + " " + formattedName;

        if (goblinPrefix != string.Empty && calamityEnchantment == string.Empty)
            return goblinPrefix + " " + formattedName;

        if (calamityEnchantment != string.Empty && goblinPrefix != string.Empty)
            return calamityEnchantment + " " + goblinPrefix.ToLower() + " " + formattedName;

        return self.Name;
    }
}