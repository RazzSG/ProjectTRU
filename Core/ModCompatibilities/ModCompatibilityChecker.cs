using System;
using CalamityRuTranslate.Common.Utilities;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Core.ModCompatibilities;

public class ModCompatibilityChecker : ModSystem
{
    private readonly ModCompatibilityInfo[] _modCompatibilityInfo =
    {
        new("CalamityMod", new Version(2, 0, 4, 6), true),
        new("Redemption", new Version(0, 8, 0, 4062), true),
        new("InfernumMode", new Version(2, 0, 1, 16), true),
        new("FargowiltasSouls", new Version(1, 7, 1, 5), true),
        new("Fargowiltas", new Version(3, 3, 5, 5), true),
        new("ThoriumMod", new Version(1, 7, 2, 2), true),
        new("NoxusBoss", new Version(1, 1, 30), false),
        new("StarsAbove", new Version(2, 1, 3, 3), true),
        new("CatalystMod", new Version(1, 1, 2, 3), true),
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
            if (modInstance != null && modInstance.Version != compatibilityInfo.ExpectedVersion && compatibilityInfo.ShouldCheckVersion)
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