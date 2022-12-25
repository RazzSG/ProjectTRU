﻿using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Content;

public class TRuPlayer : ModPlayer
{
    public static string RandomDeathText;

    public override void Kill(double damage, int hitDirection, bool pvp, PlayerDeathReason damageSource)
    {
        string[] deathText = { Lang.inter[38].Value, "Skill Issue", "Потрачено", "Ай больно в ноге, бл*", "Неудачник, хи-хи-хи", "Повезёт в следующий раз (нет)", "Удали игру", "Геншин тебя уже заждался", "Здесь может быть ваша реклама", "По..и...те мы в ...вале" };
        RandomDeathText = Utils.SelectRandom(Main.rand, deathText);
    }
}