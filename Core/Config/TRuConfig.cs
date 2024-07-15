using System.ComponentModel;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace CalamityRuTranslate.Core.Config;

public class TRuConfig : ModConfig
{
    public static TRuConfig Instance = ModContent.GetInstance<TRuConfig>();
    
    public override ConfigScope Mode => ConfigScope.ClientSide;

    [Header("Font")]

    [DefaultValue(true)]
    [ReloadRequired]
    public bool NewRussianTerrariaFont;
        
    [Header("Other")]

    [DefaultValue(true)]
    public bool ColoredDamageTypes;

    [DefaultValue(true)]
    public bool ArmorSetBonusPreview;

    [DefaultValue(true)]
    [ReloadRequired]
    public bool WikithisInfo;

    [DefaultValue(false)]
    [ReloadRequired]
    public bool RandomDeathText;
    
    [DefaultValue(true)]
    [ReloadRequired]
    public bool YharonCover;
    
    [Header("LocalizationSettings")]
    
    [DefaultValue(true)]
    [ReloadRequired]
    public bool CalamityModLocalization;

    [DefaultValue(true)]
    [ReloadRequired]
    public bool FargowiltasLocalization;

    [DefaultValue(true)]
    [ReloadRequired]
    public bool FargowiltasSoulsLocalization;
    
    [DefaultValue(true)]
    [ReloadRequired]
    public bool InfernumModeLocalization;

    [DefaultValue(true)]
    [ReloadRequired]
    public bool ThoriumModLocalization;

    [DefaultValue(true)]
    [ReloadRequired]
    public bool NoxusBossLocalization;

    [DefaultValue(true)]
    [ReloadRequired]
    public bool StarsAboveLocalization;

    // [DefaultValue(true)]
    // [ReloadRequired]
    // public bool RedemptionLocalization;

    [DefaultValue(true)]
    [ReloadRequired]
    public bool VanillaLocalization;
}