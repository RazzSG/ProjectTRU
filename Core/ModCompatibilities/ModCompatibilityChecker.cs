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
        new("CalamityMod", new Version(2, 0, 4, 6), TRuConfig.Instance.CalamityModLocalization),
        new("CatalystMod", new Version(1, 1, 2, 3), TRuConfig.Instance.CatalystLocalization),
        new("Fargowiltas", new Version(3, 3, 6, 2), TRuConfig.Instance.FargowiltasLocalization),
        new("FargowiltasSouls", new Version(1, 7, 2, 14), TRuConfig.Instance.FargowiltasSoulsLocalization),
        new("InfernumMode", new Version(2, 0, 1, 18), TRuConfig.Instance.InfernumModeLocalization),
        new("NoxusBoss", new Version(1, 2, 20), TRuConfig.Instance.NoxusBossLocalization),
        new("Redemption", new Version(0, 8, 0, 4076), TRuConfig.Instance.RedemptionLocalization),
        new("SpiritReforged", new Version(0, 1, 1, 2), TRuConfig.Instance.SpiritReforgedLocalization),
        new("StarsAbove", new Version(2, 1, 5, 1), TRuConfig.Instance.StarsAboveLocalization),
        new("ThoriumMod", new Version(1, 7, 2, 3), TRuConfig.Instance.ThoriumModLocalization)
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