using CalamityMod;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Terraria;
using Item = On.Terraria.Item;

namespace CalamityRuTranslate.Vanilla.MonoMod
{
    public class AffixName : ILEdit
    {
        public override bool Autoload() => TranslationHelper.IsRussianLanguage && ModsCall.Calamity == null;

        public override void Load() => Item.AffixName += ItemOnAffixName;

        public override void Unload() => Item.AffixName -= ItemOnAffixName;

        private string ItemOnAffixName(Item.orig_AffixName orig, Terraria.Item self)
        {
            if (self.prefix >= Lang.prefix.Length)
                return self.Name;

            string prefix = Lang.prefix[self.prefix].Value;
            if (prefix == string.Empty)
                return self.Name;

            for (int i = 0; i < RussianPrefixOverhaul.Prefixes.Length; i++)
            {
                if (RussianPrefixOverhaul.Prefixes[i][0] == prefix)
                    return RussianPrefixOverhaul.GetGenderedPrefix(RussianPrefixOverhaul.Prefixes[i], self.type) + " " +
                           self.Name.ToLower();
            }

            return prefix + " " + self.Name;
        }
    }

    public class AffixNameWithCalamity : ILEdit
    {
        public override bool Autoload() => TranslationHelper.IsRussianLanguage && ModsCall.Calamity != null;

        public override void Load() => Item.AffixName += ItemOnAffixName;

        public override void Unload() => Item.AffixName -= ItemOnAffixName;

        private string ItemOnAffixName(Item.orig_AffixName orig, Terraria.Item self)
        {
            string calamityEnchantment = string.Empty;
            string goblinPrefix = string.Empty;

            for (int i = 0; i < RussianPrefixOverhaul.Prefixes.Length; i++)
            {
                if (!self.IsAir && self.Calamity().AppliedEnchantment != null)
                {
                    if (RussianPrefixOverhaul.Prefixes[i][0] == self.Calamity().AppliedEnchantment?.Name)
                        calamityEnchantment = RussianPrefixOverhaul.GetGenderedPrefix(RussianPrefixOverhaul.Prefixes[i], self.type) + " ";

                    if (calamityEnchantment != string.Empty)
                        goblinPrefix = goblinPrefix.ToLower();
                }

                if (RussianPrefixOverhaul.Prefixes[i][0] == Lang.prefix[self.prefix].Value)
                    goblinPrefix = RussianPrefixOverhaul.GetGenderedPrefix(RussianPrefixOverhaul.Prefixes[i], self.type) + " ";
            }

            if (goblinPrefix == string.Empty && calamityEnchantment == string.Empty)
                return self.Name;

            return calamityEnchantment + goblinPrefix + self.Name.ToLower();
        }
    }
}