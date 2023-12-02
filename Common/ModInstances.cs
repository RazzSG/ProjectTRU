﻿using Terraria.ModLoader;

namespace CalamityRuTranslate.Common;

public static class ModInstances
{
    public static Mod Calamity => ModLoader.TryGetMod("CalamityMod", out Mod calamity) ? calamity : null;
    public static Mod Thorium => ModLoader.TryGetMod("ThoriumMod", out Mod thorium) ? thorium : null;
    public static Mod Fargowiltas => ModLoader.TryGetMod("Fargowiltas", out Mod fargowiltas) ? fargowiltas : null;
    public static Mod FargowiltasSouls => ModLoader.TryGetMod("FargowiltasSouls", out Mod fargowiltasSouls) ? fargowiltasSouls : null;
    public static Mod Spirit => ModLoader.TryGetMod("SpiritMod", out Mod spirit) ? spirit : null;
    public static Mod Census => ModLoader.TryGetMod("Census", out Mod census) ? census : null;
    public static Mod BossChecklist => ModLoader.TryGetMod("BossChecklist", out Mod bossChecklist) ? bossChecklist : null;
    public static Mod StarsAbove => ModLoader.TryGetMod("StarsAbove", out Mod starsAbove) ? starsAbove : null;
    public static Mod Wikithis => ModLoader.TryGetMod("Wikithis", out Mod wikithis) ? wikithis : null;
    public static Mod Infernum => ModLoader.TryGetMod("InfernumMode", out Mod infernum) ? infernum : null;
    public static Mod TModLoader => ModLoader.TryGetMod("ModLoader", out Mod tMod) ? tMod : null;
    public static Mod StarlightRiver => ModLoader.TryGetMod("StarlightRiver", out Mod slr) ? slr : null;
    public static Mod CalamityModMusic => ModLoader.TryGetMod("CalamityModMusic", out Mod calamityModMusic) ? calamityModMusic : null;
}