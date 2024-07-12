using System;

namespace CalamityRuTranslate.Mods.StarsAbove;

public partial class StarsAboveSystem
{
    public void StellarNovasStats()
    {
        if (StarsAbovePlayer.novaUIActive)
        {   
            string baseStatsFormat = "{0}: {1}\nБазовый расход энергии: {2}";
            string modStatsFormat = "\n\n{0}: {1}\nШанс крит. удара: {2}%\n{3}: {4}\nДлительность эффекта: {5}с\n{6}";
            string statType = StarsAbovePlayer.chosenStellarNova != 4 ? "Базовый урон" : "Базовая сила лечения";
            string finalStatType = StarsAbovePlayer.chosenStellarNova != 4 ? "Урон" : "Сила лечения";
            string critType = StarsAbovePlayer.chosenStellarNova != 4 ? "Критический урон" : "Сила крит. лечения";

            double finalDamage = Math.Round(StarsAbovePlayer.novaDamage * (1 + StarsAbovePlayer.novaDamageMod / 100), 0);
            float finalCritChance = (float)Math.Round(StarsAbovePlayer.novaCritChance + StarsAbovePlayer.novaCritChanceMod, 2);
            double finalCritDamage = Math.Round(StarsAbovePlayer.novaCritDamage * (1 + StarsAbovePlayer.novaCritDamageMod / 100), 0);
            float effectDuration = StarsAbovePlayer.novaEffectDuration + StarsAbovePlayer.novaEffectDurationMod;
            string energyCost = $"Расход энергии: {StarsAbovePlayer.novaGaugeMax - StarsAbovePlayer.novaChargeMod}";
            if (StarsAbovePlayer.novaGaugeMax - StarsAbovePlayer.novaChargeMod < 20)
                energyCost = "Расход энергии (мин.): 20";
            
            StarsAbovePlayer.baseStats = string.Format(baseStatsFormat, statType, StarsAbovePlayer.novaDamage, StarsAbovePlayer.novaGaugeMax);
            StarsAbovePlayer.modStats = string.Format(modStatsFormat, finalStatType, finalDamage, finalCritChance, critType, finalCritDamage, effectDuration, energyCost);
        }
    }
}