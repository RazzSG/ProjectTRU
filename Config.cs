﻿using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace CalamityRuTranslate
{
    [Label("Config")]
    public class Config : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;
        public override void OnLoaded() => CalamityRuTranslate.TRuConfig = this;

        [Header("Шрифт")]
        [Label("Шрифт Comic Sans MS")]
        [Tooltip("Если вам не нравится новый шрифт который предлагает русификатор\nи вы хотите играть со своим, вы можете его отключить\nТребуется перезагрузка мода")]
        [DefaultValue(true)]
        [ReloadRequired]
        public bool NewRussianTerrariaFont { get; set; }
    }
}