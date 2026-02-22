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
        
        if (self.prefix < 0 || self.prefix >= Lang.prefix.Length)
            return result;
        
        string prefixText = Lang.prefix[self.prefix].Value;
        
        if (string.IsNullOrEmpty(prefixText))
            return result;
        
        string genderedPrefix = null;
        
        foreach (var t in PrefixOverhaul.Instance.Prefixes)
        {
            if (t[0] == prefixText)
                genderedPrefix = PrefixOverhaul.Instance.GetGenderedPrefix(t, self.type);
        }

        if (genderedPrefix != null)
            result = result.Replace(prefixText, genderedPrefix);
        
        if (!self.Name.Contains('.'))
            result = result.Replace(self.Name, self.Name.ToLower());

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
        string result = orig.Invoke(self);
        
        if (self.IsAir || self.prefix < 0 || self.prefix >= Lang.prefix.Length)
            return result;

        string goblinPrefix = Lang.prefix[self.prefix].Value;
        string calamityEnchantment = null;

        if (self.TryGetGlobalItem(out CalamityGlobalItem calamityGlobalItem) && calamityGlobalItem.AppliedEnchantment.HasValue)
            calamityEnchantment = calamityGlobalItem.AppliedEnchantment?.Name.ToString();
        
        if (string.IsNullOrEmpty(goblinPrefix) && string.IsNullOrEmpty(calamityEnchantment))
            return result;
        
        string genderedGoblinPrefix = null;
        string genderedCalamityEnchant = null;

        foreach (var t in PrefixOverhaul.Instance.Prefixes)
        {
            if (t[0] == goblinPrefix)
                genderedGoblinPrefix = PrefixOverhaul.Instance.GetGenderedPrefix(t, self.type);
            
            if (t[0] == calamityEnchantment)
                genderedCalamityEnchant = PrefixOverhaul.Instance.GetGenderedPrefix(t, self.type);
        }

        bool enchantmentExists = false;
        
        if (genderedCalamityEnchant != null && calamityEnchantment != null)
        {
            enchantmentExists = true;
            result = result.Replace(calamityEnchantment, genderedCalamityEnchant);
        }

        if (genderedGoblinPrefix != null && goblinPrefix != null)
        {
            if (enchantmentExists)
                genderedGoblinPrefix = genderedGoblinPrefix.ToLower();

            result = result.Replace(goblinPrefix, genderedGoblinPrefix);
        }

        if ((genderedGoblinPrefix != null || enchantmentExists) && !self.Name.Contains('.'))
            result = result.Replace(self.Name, self.Name.ToLower());

        return result;
    }
}