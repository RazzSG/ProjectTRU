using System;
using CalamityRuTranslate.Common.Utilities;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Core.ModCompatibilities;

public class ModCompatibilityChecker : ModSystem
{
    private readonly ModCompatibilityInfo[] _modCompatibilityInfo =
    {
        new("CalamityMod", new Version(2, 0, 4, 5), true),
        new("Redemption", new Version(0, 8, 0, 4045), true),
        new("InfernumMode", new Version(2, 0, 1, 14), true),
        new("FargowiltasSouls", new Version(1, 7, 0, 8), true),
        new("Fargowiltas", new Version(3, 3, 5, 1), true),
        new("ThoriumMod", new Version(1, 7, 1, 6), true),
        new("NoxusBoss", new Version(1, 1, 28), false),
        new("StarsAbove", new Version(2, 1, 2, 9), true),
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
            _ => throw new ArgumentException(internalName)
        };
    }
}