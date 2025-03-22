using System;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Core.ModCompatibilities;

public class ModCompatibilityChecker : ModSystem
{
    private readonly ModCompatibilityInfo[] _modCompatibilityInfo =
    {
        new("CalamityMod", new Version(2, 0, 4, 6), TRuConfig.Instance.CalamityModLocalization, true),
        new("Redemption", new Version(0, 8, 0, 4072), TRuConfig.Instance.RedemptionLocalization, true),
        new("InfernumMode", new Version(2, 0, 1, 17), TRuConfig.Instance.InfernumModeLocalization, true),
        new("FargowiltasSouls", new Version(1, 7, 2, 2), TRuConfig.Instance.FargowiltasSoulsLocalization, false),
        new("Fargowiltas", new Version(3, 3, 6), TRuConfig.Instance.FargowiltasLocalization, false),
        new("ThoriumMod", new Version(1, 7, 2, 3), TRuConfig.Instance.ThoriumModLocalization, true),
        new("StarsAbove", new Version(2, 1, 3, 4), TRuConfig.Instance.StarsAboveLocalization, true),
        new("CatalystMod", new Version(1, 1, 2, 3), TRuConfig.Instance.CatalystLocalization, true),
    };

    public override bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public override void Load()
    {
        foreach (ModCompatibilityInfo compatibilityInfo in _modCompatibilityInfo)
        {
            ModLoader.TryGetMod(compatibilityInfo.InternalName, out Mod modInstance);
            if (modInstance != null && modInstance.Version != compatibilityInfo.ExpectedVersion && compatibilityInfo.ModLocalization && compatibilityInfo.ShouldCheckVersion)
            {
                throw new ModCompatibilityException(GetModNameException(compatibilityInfo.InternalName), modInstance.Version, compatibilityInfo.ExpectedVersion);
            }
        }
    }

    private string GetModNameException(string internalName)
    {
        return internalName switch
        {
            "CalamityMod" => "Calamity Mod",
            "ThoriumMod" => "Thorium Mod",
            "Fargowiltas" => "Fargo's Mutant Mod",
            "FargowiltasSouls" => "Fargo's Souls Mod",
            "InfernumMode" => "Calamity Mod Infernum Mode",
            "Redemption" => "Mod of Redemption",
            "StarsAbove" => "The Stars Above",
            "NoxusBoss" => "Calamity: Wrath of the Gods",
            "CatalystMod" => "Catalyst Mod",
            _ => throw new ArgumentException(internalName)
        };
    }
}