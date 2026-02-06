using System;
using System.Collections.Generic;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using Terraria;
using Terraria.ModLoader;
using Terraria.UI;

namespace CalamityRuTranslate.Core.ModCompatibilities;

[Autoload(Side = ModSide.Client)]
public class ModCompatibilityChecker : ModSystem
{
    public UserInterface CompatibilityUIManager;
    public ModCompatibilityUI ModCompatibilityUI { get; private set; }
    
    private readonly ModCompatibilityInfo[] _modCompatibilityInfo =
    [
        new("CalamityMod", new Version(2, 1), TRuConfig.Instance.CalamityModLocalization),
        new("CatalystMod", new Version(1, 1, 4), TRuConfig.Instance.CatalystLocalization),
        new("Fargowiltas", new Version(3, 3, 6, 5), TRuConfig.Instance.FargowiltasLocalization),
        new("FargowiltasSouls", new Version(1, 7, 3, 6), TRuConfig.Instance.FargowiltasSoulsLocalization),
        new("InfernumMode", new Version(2, 0, 1, 22), TRuConfig.Instance.InfernumModeLocalization),
        new("NoxusBoss", new Version(1, 2, 30), TRuConfig.Instance.NoxusBossLocalization),
        new("Redemption", new Version(0, 8, 0, 4110), TRuConfig.Instance.RedemptionLocalization),
        new("SpiritReforged", new Version(0, 1, 2, 5), TRuConfig.Instance.SpiritReforgedLocalization),
        new("StarsAbove", new Version(2, 1, 8, 1), TRuConfig.Instance.StarsAboveLocalization),
        new("ThoriumMod", new Version(1, 7, 2, 5), TRuConfig.Instance.ThoriumModLocalization)
    ];

    public override bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public override void Load()
    {
        CompatibilityUIManager = new UserInterface();
        ModCompatibilityUI = new ModCompatibilityUI();
        ModCompatibilityUI.Activate();
    }

    public override void OnWorldLoad()
    {
        ValidateModVersions();
    }

    public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers) {
        int mouseTextIndex = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Mouse Text"));
        if (mouseTextIndex != -1) {
            layers.Insert(mouseTextIndex, new LegacyGameInterfaceLayer("Project tRU: ModCompatibilityUI", delegate
                {
                    if (CompatibilityUIManager?.CurrentState != null) {
                        CompatibilityUIManager.Update(Main._drawInterfaceGameTime);
                        ModCompatibilityUI.Draw(Main.spriteBatch);
                    }
                    return true;
                }, InterfaceScaleType.UI));
        }
    }

    private void ValidateModVersions()
    {
        foreach (ModCompatibilityInfo compatibilityInfo in _modCompatibilityInfo)
        {
            ModLoader.TryGetMod(compatibilityInfo.InternalName, out Mod modInstance);
            if (modInstance != null && modInstance.Version < compatibilityInfo.ExpectedVersion && compatibilityInfo.ModLocalization)
            {
                CompatibilityUIManager?.SetState(ModCompatibilityUI);
                
                string currentWarningMessage = CreateVersionWarningMessage(modInstance.DisplayName, modInstance.Version, compatibilityInfo.ExpectedVersion);
                ModCompatibilityUI.SetWarningText(currentWarningMessage);
                ModCompatibilityUI.ModToUpdate = modInstance.DisplayName;
                break;
            }
        }
    }
    
    private string CreateVersionWarningMessage(string modName, Version currentModVersion, Version expectedModVersion)
    {
        return $"У вас установлена старая версия [c/FFF783:{modName}]. Ваша текущая версия: [c/FF0000:{currentModVersion}]. Для корректной работы русификатора рекомендуется обновить [c/FFF783:{modName}] до версии [c/00FF09:{expectedModVersion}].";
    }
}