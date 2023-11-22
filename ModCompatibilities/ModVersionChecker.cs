using System;
using CalamityRuTranslate.Common.Utilities;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ModCompatibilities;

public class ModVersionChecker : ILoadable
{
    private readonly ModInfo[] _modInfo =
    {
        new("CalamityMod", new Version(2, 0, 3, 6), true),
        new("StarlightRiver", new Version(1, 5, 0, 2), false),
        new("InfernumMode", new Version(1, 9, 33), true),
        new("FargowiltasSouls", new Version(1, 6, 1, 2), true),
        new("Fargowiltas", new Version(3, 2, 1, 2), true),
        new("StarsAbove", new Version(1, 5, 0, 4), false),
        new("ThoriumMod", new Version(1, 7, 1, 3), true),
    };

    public bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }
    
    public void Load(Mod mod)
    {
        foreach (ModInfo modInfo in _modInfo)
        {
            if (ModLoader.TryGetMod(modInfo.InternalName, out Mod modInstance) && modInstance.Version != modInfo.ExpectedVersion && modInfo.ShouldCheckVersion)
            {
                throw new ModVersionException(GetModNameException(modInfo.InternalName), modInstance.Version, modInfo.ExpectedVersion);
            }
        }
    }

    public void Unload()
    {
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