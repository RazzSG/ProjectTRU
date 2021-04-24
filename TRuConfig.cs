﻿using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace CalamityRuTranslate
{
    [Label("Конфигурация")]
    public class TRuConfig : ModConfig
    {
        public static TRuConfig Instance { get; set; }
        
        public override void OnLoaded() => Instance = this;
        
        public override ConfigScope Mode => ConfigScope.ClientSide;
        
        public override bool AcceptClientChanges(ModConfig pendingConfig, int whoAmI, ref string message) => true;

        [Header("Шрифт")]
        [Label("Шрифт JetBrains Mono")]
        [Tooltip("Если вам не нравится новый шрифт который предлагает русификатор\nи вы хотите играть со своим, вы можете его отключить")]
        [DefaultValue(true)]
        [ReloadRequired]
        public bool NewRussianTerrariaFont;
        
        [Header("Прочее")]

        [Label("Thorium")]
        [DefaultValue(true)]
        [ReloadRequired]
        public bool ThoriumTranslation;

        [Label("Новый ванильный перевод")]
        [Tooltip("Если вам не нравится новый ванильный перевод\nи вы привыкли играть со стандартным, вы можете его отключить")]
        [DefaultValue(true)]
        [ReloadRequired]
        public bool NewVanillaTranslation;

        [Label("Цветной тип урона")]
        [Tooltip("Если вам не нравится цветные типы урона на оружиях, вы можете это отключить")]
        [DefaultValue(true)]
        public bool ColoredDamageTypes;
        
        [Label("Описание механики скрытности Каламити")]
        [Tooltip("Показывает текст бонуса скрытности на комплектах брони разбойника")]
        [DefaultValue(true)]
        public bool CalamityStealthDescription;
    }
}