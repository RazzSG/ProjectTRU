using System;
using CalamityRuTranslate.Common.Utilities;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Core.ModCompatibilities;

public class ModCompatibilityChecker : ModSystem
{
    private readonly ModCompatibilityInfo[] _modCompatibilityInfo =
    {
        new("CalamityMod", new Version(2, 0, 3, 11), true),
        new("StarlightRiver", new Version(1, 5, 0, 2), false),
        new("InfernumMode", new Version(2, 0, 1, 3), true),
        new("FargowiltasSouls", new Version(1, 6, 9, 2), true),
        new("Fargowiltas", new Version(3, 3, 3, 4), true),
        new("ThoriumMod", new Version(1, 7, 1, 6), true),
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
            "StarlightRiver" => "Starlight River",
            "StarsAbove" => "The Stars Above",
            _ => throw new ArgumentException(internalName)
        };
    }
}