using System.Collections.Generic;
using CalamityMod;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod;

public partial class CalamityModGlobalItem
{
    public void VanillaItemsTranslation(Item item, List<TooltipLine> tooltips)
    {
        ItemHelper.TranslateTooltip(tooltips, "Knockback", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.CobaltSword => tooltip.Text.Replace("Decreases enemy defense by 25% on hit\nThis effect lasts for 10 seconds", "Снижает защиту врага на 25% при ударе\nЭтот эффект длится 10 секунд"),
                ItemID.CobaltNaginata => tooltip.Text.Replace("Decreases enemy defense by 25% on hit\nThis effect lasts for 10 seconds", "Снижает защиту врага на 25% при ударе\nЭтот эффект длится 10 секунд"),
                ItemID.PalladiumSword => tooltip.Text.Replace("Increases natural life regen on hit", "Увеличивает естественную регенерацию здоровья при ударе"),
                ItemID.PalladiumPike => tooltip.Text.Replace("Increases natural life regen on hit", "Увеличивает естественную регенерацию здоровья при ударе"),
                ItemID.MythrilSword => tooltip.Text.Replace("Decreases enemy contact damage by 10% on hit\nThis effect lasts for 10 seconds", "Снижает контактный урон врага на 10% при ударе\nЭтот эффект длится 10 секунд"),
                ItemID.MythrilHalberd => tooltip.Text.Replace("Decreases enemy contact damage by 10% on hit\nThis effect lasts for 10 seconds", "Снижает контактный урон врага на 10% при ударе\nЭтот эффект длится 10 секунд"),
                ItemID.OrichalcumSword => tooltip.Text.Replace("Increases how frequently the Orichalcum set bonus triggers on hit", "При нанесении удара увеличивает частоту срабатывания бонуса орихалкового комплекта"),
                ItemID.OrichalcumHalberd => tooltip.Text.Replace("Increases how frequently the Orichalcum set bonus triggers on hit", "При нанесении удара увеличивает частоту срабатывания бонуса орихалкового комплекта"),
                ItemID.AdamantiteGlaive => tooltip.Text.Replace("Slows enemies on hit", "Замедляет врагов при ударе"),
                ItemID.TitaniumTrident => tooltip.Text.Replace("Deals increased damage to enemies with high knockback resistance", "Наносит увеличенный урон врагам с высоким сопротивлением к отбрасыванию"),
                ItemID.CandyCaneSword => tooltip.Text.Replace("Heals you on hit", "Исцеляет при ударе"),
                ItemID.FruitcakeChakram => tooltip.Text.Replace("Heals you on hit", "Исцеляет при ударе"),
                ItemID.StylistKilLaKillScissorsIWish => tooltip.Text.Replace("Ignores 100% of enemy defense", "Игнорирует 100% защиты врага"),
                ItemID.BluePhasesaber => tooltip.Text.Replace("Ignores 100% of enemy defense", "Игнорирует 100% защиты врага"),
                ItemID.RedPhasesaber => tooltip.Text.Replace("Ignores 100% of enemy defense", "Игнорирует 100% защиты врага"),
                ItemID.GreenPhasesaber => tooltip.Text.Replace("Ignores 100% of enemy defense", "Игнорирует 100% защиты врага"),
                ItemID.PurplePhasesaber => tooltip.Text.Replace("Ignores 100% of enemy defense", "Игнорирует 100% защиты врага"),
                ItemID.WhitePhasesaber => tooltip.Text.Replace("Ignores 100% of enemy defense", "Игнорирует 100% защиты врага"),
                ItemID.YellowPhasesaber => tooltip.Text.Replace("Ignores 100% of enemy defense", "Игнорирует 100% защиты врага"),
                ItemID.OrangePhasesaber => tooltip.Text.Replace("Ignores 100% of enemy defense", "Игнорирует 100% защиты врага"),
                ItemID.BoneSword => tooltip.Text.Replace("Ignores 50% of enemy defense", "Игнорирует 50% защиты врага"),
                ItemID.BreakerBlade => tooltip.Text.Replace("Ignores 50% of enemy defense", "Игнорирует 50% защиты врага"),
                ItemID.FalconBlade => tooltip.Text.Replace("Holding this item grants +20% increased movement speed", $"Держа в руках этот предмет, увеличивает скорость передвижения на 20%"),
                _ => tooltip.Text
            };
        });

        if (item.accessory)
        {
            ItemHelper.TranslateTooltip(tooltips, "PrefixAccDefense", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("damage reduction", "к сопротивлению урону");
            });
            
            ItemHelper.TranslateTooltip(tooltips, "PrefixAccCritChance", tooltip =>
            {
                tooltip.Text = tooltip.Text.Replace("+0.05 luck", "+0.05 к удаче");
            });
        }
        
        if (item.master)
        {
            ItemHelper.TranslateTooltip(tooltips, "Master", _ =>
            {
                tooltips.ReplaceText("Мастер or Revengeance", "Мастер или Месть");
            });
        }
        
        ItemHelper.TranslateTooltip(tooltips, "Tooltip0", tooltip =>
        {
            if (CalamityConfig.Instance.EarlyHardmodeProgressionRework)
            {
                tooltip.Text = item.type switch
                {
                    ItemID.Pwnhammer => $"{Language.GetTextValue("ItemTooltip.Pwnhammer")}\nДемонические алтари при разрушении теперь дают эссенции ночи, вместо генерации руды\nХардмодная руда теперь генерируется после первой победы над механическими боссами",
                    ItemID.Hammush => $"{Language.GetTextValue("ItemTooltip.Hammush")}\nДемонические алтари при разрушении теперь дают эссенции ночи, вместо генерации руды\nХардмодная руда теперь генерируется после первой победы над механическими боссами",
                    _ => tooltip.Text
                };
            }

            tooltip.Text = item.type switch
            {
                ItemID.SlimeGun => $"{Language.GetTextValue("ItemTooltip.SlimeGun")}\nПокрытые слизью враги получают больше урона от огненных дебаффов",
                ItemID.GelBalloon => "Бросает смесь из слизи и сверкающих кристаллов\nПокрытые слизью враги получают больше урона от огненных дебаффов",
                ItemID.FleshKnuckles => $"{Language.GetTextValue("ItemTooltip.FleshKnuckles")}\nУвеличивает максимальный запас здоровья на 45",
                ItemID.HeroShield => "Даёт невосприимчивость к отбрасыванию\nУвеличивает максимальный запас здоровья на 45",
                ItemID.BerserkerGlove => "Увеличивает отбрасывание ближнего боя\nУвеличивает максимальный запас здоровья на 45",
                ItemID.WarmthPotion => $"{Language.GetTextValue("ItemTooltip.WarmthPotion")}\nЗначительно снижает длительность дебаффов «{Language.GetTextValue("BuffName.Chilled")}», «{Language.GetTextValue("BuffName.Frozen")}» и «{Language.GetTextValue("Mods.CalamityMod.Buffs.GlacialState.DisplayName")}»",
                ItemID.ArcheryPotion => "Увеличивает скорость стрел на 20% и урон стрел на 5%",
                ItemID.IronskinPotion => $"Увеличивает защиту на {tooltip.Text.Split(' ')[3]}",
                ItemID.SwiftnessPotion => Language.GetTextValue("ItemTooltip.SwiftnessPotion").Replace("25", "15"),
                ItemID.HandWarmer => $"{Language.GetTextValue("ItemTooltip.HandWarmer")}\nОбеспечивает увеличенной регенерацией, если надет снежный комплект",
                ItemID.DD2ElderCrystal => $"{Language.GetTextValue("ItemTooltip.DD2ElderCrystal")}\nПосле размещения, вы можете нажать ПКМ по кристаллу, чтобы пропустить волны и увеличить скорость появления вторженцев",
                ItemID.DD2BetsyBow => "Стреляет разделяющимися стрелами",
                ItemID.Abeemination => "Призывает королеву пчёл при использовании в джунглях\nВходит в ярость за пределами подземных джунглей\nНе расходуется",
                ItemID.BloodySpine => "Призывает Мозг Ктулху при использовании в багрянце\nВходит в ярость за пределами подземного багрянца\nНе расходуется",
                ItemID.ClothierVoodooDoll => $"{Language.GetTextValue("ItemTooltip.ClothierVoodooDoll")}\nПока экипирован, призывает Скелетрона в ночное время, когда портной убит\nВходит в ярость во время дня",
                ItemID.DeerThing => "Призывает Циклопа-оленя при использовании в снегах или льдах\nНе расходуется",
                ItemID.GuideVoodooDoll => $"{Language.GetTextValue("ItemTooltip.GuideVoodooDoll")}\nПризывает Стену плоти, если бросить в лаву преисподней, пока гид жив",
                ItemID.LihzahrdPowerCell => "Используется на алтаре яхщеров для призыва Голема\nВходит в ярость за пределами Храма джунглей",
                ItemID.MechanicalEye => "Призывает Близнецов при использовании в ночное время\nВходит в ярость во время дня\nНе расходуется",
                ItemID.MechanicalSkull => "Призывает Скелетрона Прайма при использовании в ночное время\nВходит в ярость во время дня\nНе расходуется",
                ItemID.MechanicalWorm => "Призывает Уничтожителя при использовании в ночное время\nВходит в ярость во время дня\nНе расходуется",
                ItemID.SuspiciousLookingEye => "Призывает Глаз Ктулху при использовании в ночное время\nВходит в ярость во время дня\nНе расходуется",
                ItemID.QueenSlimeCrystal => "Призывает Королеву слизней при использовании в освящении\nНе расходуется",
                ItemID.WormFood => "Призывает Пожирателя миров при использовании в искажении\nВходит в ярость за пределами подземного искажения\nНе расходуется",
                ItemID.BlackBelt => "Даёт способность уклоняться от атак\nУклонение не срабатывает против атак, которые наносят менее 5% урона от максимального запаса здоровья\nПерезарядка уклонения составляет от 15 до 90 секунд в зависимости от урона атаки, от которой вы уклонились\nЭта перезарядка распространяется на все другие уклонения и отражения",
                ItemID.BrainOfConfusion => "Даёт способность уклоняться от атак\nУклонение не срабатывает против атак, которые наносят менее 5% урона от максимального запаса здоровья\nПерезарядка уклонения составляет от 15 до 90 секунд в зависимости от урона атаки, от которой вы уклонились\nЭта перезарядка распространяется на все другие уклонения и отражения",
                ItemID.CrimsonHeart => $"{Language.GetTextValue("ItemTooltip.CrimsonHeart")}\nОбеспечивает небольшим количеством света в бездне",
                ItemID.ShadowOrb => $"{Language.GetTextValue("ItemTooltip.ShadowOrb")}\nОбеспечивает небольшим количеством света в бездне",
                ItemID.MagicLantern => $"{Language.GetTextValue("ItemTooltip.MagicLantern")}\nОбеспечивает небольшим количеством света в бездне",
                ItemID.JellyfishNecklace => $"{Language.GetTextValue("ItemTooltip.JellyfishNecklace")}\nОбеспечивает небольшим количеством света в бездне",
                ItemID.MiningHelmet => $"{Language.GetTextValue("ItemTooltip.MiningHelmet")}\nОбеспечивает небольшим количеством света в бездне",
                ItemID.UltrabrightHelmet => "Улучшает видение и освещает территорию вокруг персонажа\nОбеспечивает небольшим количеством света в бездне",
                ItemID.FairyBell => $"{Language.GetTextValue("ItemTooltip.FairyBell")}\nОбеспечивает умеренным количеством света в бездне",
                ItemID.DD2PetGhost => $"{Language.GetTextValue("ItemTooltip.DD2PetGhost")}\nОбеспечивает умеренным количеством света в бездне",
                ItemID.WispinaBottle => $"{Language.GetTextValue("ItemTooltip.WispinaBottle")}\nОбеспечивает большим количеством света в бездне",
                ItemID.PumpkingPetItem => "Призывает одержимый светильник Джека\nОбеспечивает большим количеством света в бездне",
                ItemID.GolemPetItem => "Призывает игрушечного голема, освещающего путь\nОбеспечивает большим количеством света в бездне",
                ItemID.FairyQueenPetItem => "Призывает освещающую принцессу-фею\nОбеспечивает большим количеством света в бездне",
                ItemID.DivingHelmet => $"{Language.GetTextValue("ItemTooltip.DivingHelmet")}\nУмеренно увеличивает запас воздуха в бездне",
                ItemID.NeptunesShell => $"{Language.GetTextValue("ItemTooltip.NeptunesShell")}\nЗначительно увеличивает запас воздуха в бездне",
                ItemID.MoonShell => $"{Language.GetTextValue("ItemTooltip.MoonShell")}\nЗначительно увеличивает запас воздуха в бездне",
                ItemID.FlaskofCursedFlames => $"Ближние и разбойные атаки, а также хлысты накладывают дебафф «{Language.GetTextValue("BuffName.CursedInferno")}»",
                ItemID.FlaskofFire => $"Ближние и разбойные атаки, а также хлысты накладывают дебафф «{Language.GetTextValue("BuffName.OnFire")}»",
                ItemID.FlaskofGold => $"Ближние и разбойные атаки, а также хлысты накладывают дебафф «{Language.GetTextValue("BuffName.Midas")}»",
                ItemID.FlaskofIchor => $"Ближние и разбойные атаки, а также хлысты накладывают дебафф «{Language.GetTextValue("BuffName.Ichor")}»",
                ItemID.FlaskofNanites => $"Ближние и разбойные атаки, а также хлысты накладывают дебафф «{Language.GetTextValue("BuffName.Confused")}»",
                ItemID.FlaskofParty => "Все атаки разбрасывают конфетти",
                ItemID.FlaskofPoison => $"Ближние и разбойные атаки, а также хлысты накладывают дебафф «{Language.GetTextValue("BuffName.Poisoned")}»",
                ItemID.FlaskofVenom => $"Ближние и разбойные атаки, а также хлысты накладывают дебафф «{Language.GetTextValue("BuffName.Venom")}»",
                ItemID.AncientChisel => "Увеличивает скорость добычи на 15%",
                ItemID.FrozenTurtleShell => Language.GetTextValue("ItemTooltip.FrozenTurtleShell").Replace("25", "15"),
                ItemID.Ale => "Увеличивает урон ближнего боя на 10%, но снижает защиту на 5%\nСчитается алкоголем для алкогольного отравления\nУпотребление более трёх разных алкогольных напитков может негативно сказаться на вашей печени",
                ItemID.Sake => "Увеличивает урон ближнего боя на 10%, но снижает защиту на 5%\nСчитается алкоголем для алкогольного отравления\nУпотребление более трёх разных алкогольных напитков может негативно сказаться на вашей печени",
                ItemID.CelestialStone => "Незначительно увеличивает урон,",
                ItemID.ArcaneFlower => "Снижает расход маны на 12%",
                ItemID.ManaCloak => "Снижает расход маны на 12%",
                ItemID.MagnetFlower => "Снижает расход маны на 10%",
                ItemID.Magiluminescence => "Увеличивает ускорение и торможение на 75%\nУвеличивает скорость передвижения на 15%. Этот бонус распространяется на аксессуары ботинок",
                ItemID.EmpressFlightBooster => "Увеличивает время полёта крыльев на 25%",
                ItemID.MagicQuiver => "Увеличивает урон от стрел на 5% и значительно увеличивает скорость стрел",
                ItemID.MoltenQuiver => "Увеличивает урон от стрел на 7% и значительно увеличивает скорость стрел",
                ItemID.MagicPowerPotion => Language.GetTextValue("ItemTooltip.MagicPowerPotion").Replace("20", "10"),
                ItemID.FeatherfallPotion => $"{Language.GetTextValue("ItemTooltip.FeatherfallPotion")}\nОтключает все виды восстановления времени полёта в воздухе",
                ItemID.MagicHat => "Увеличивает магический шанс критического удара на 6%",
                ItemID.TitanGlove => "Увеличивает отбрасывание ближнего боя\nУвеличивает истинный урон ближнего боя на 10%",
                ItemID.PowerGlove => "Увеличивает отбрасывание ближнего боя\nУвеличивает истинный урон ближнего боя на 10%",
                ItemID.ObsidianSkull => $"Даёт невосприимчивость к дебаффам «{Language.GetTextValue("BuffName.Burning")}» и «{Language.GetTextValue("BuffName.OnFire")}»",
                ItemID.AnkhShield => $"Даёт невосприимчивость к отбрасыванию и дебаффам «{Language.GetTextValue("BuffName.Burning")}» и «{Language.GetTextValue("BuffName.OnFire")}»",
                ItemID.ObsidianSkullRose => $"Даёт невосприимчивость к дебаффам «{Language.GetTextValue("BuffName.Burning")}» и «{Language.GetTextValue("BuffName.OnFire")}»",
                ItemID.MoltenCharm => $"Даёт невосприимчивость к дебаффам «{Language.GetTextValue("BuffName.Burning")}» и «{Language.GetTextValue("BuffName.OnFire")}»",
                ItemID.YoyoBag => $"{Language.GetTextValue("ItemTooltip.YoyoBag")}\nВторое йо-йо наносит на 50% меньше урона",
                ItemID.YoYoGlove => $"{Language.GetTextValue("ItemTooltip.YoYoGlove")}\nВторое йо-йо наносит на 50% меньше урона",
                ItemID.CopperHelmet => "Увеличивает урон на 5%",
                ItemID.CopperChainmail => "Увеличивает шанс критического удара на 3%",
                ItemID.CopperGreaves => "Увеличивает скорость передвижения на 5%",
                ItemID.TinHelmet => "Увеличивает шанс критического удара на 3%",
                ItemID.TinChainmail => "Увеличивает регенерацию здоровья на 0.5",
                ItemID.TinGreaves => "Увеличивает скорость передвижения на 5%",
                ItemID.IronHelmet => "Увеличивает сопротивление урону на 3%",
                ItemID.AncientIronHelmet => "Увеличивает сопротивление урону на 3%",
                ItemID.IronChainmail => "Увеличивает сопротивление урону на 3%",
                ItemID.IronGreaves => "Увеличивает сопротивление урону на 3%",
                ItemID.LeadHelmet => "Увеличивает сопротивление урону на 2%",
                ItemID.LeadChainmail => "Увеличивает сопротивление урону на 2%",
                ItemID.LeadGreaves => "Увеличивает сопротивление урону на 2%",
                ItemID.SilverHelmet => "Увеличивает шанс критического удара на 5%",
                ItemID.SilverChainmail => "Увеличивает регенерацию здоровья на 1",
                ItemID.SilverGreaves => "Увеличивает скорость передвижения на 8%",
                ItemID.TungstenHelmet => "Увеличивает урон на 7%",
                ItemID.TungstenChainmail => "Увеличивает регенерацию здоровья на 0.5",
                ItemID.TungstenGreaves => "Увеличивает скорость передвижения на 8%",
                ItemID.GoldHelmet => "Увеличивает урон на 6%",
                ItemID.AncientGoldHelmet => "Увеличивает урон на 6%",
                ItemID.GoldChainmail => "Увеличивает сопротивление урону на 5%",
                ItemID.GoldGreaves => "Увеличивает скорость передвижения на 10%",
                ItemID.PlatinumHelmet => "Увеличивает урон на 6%",
                ItemID.PlatinumChainmail => "Увеличивает шанс критического удара на 3%",
                ItemID.PlatinumGreaves => "Увеличивает скорость передвижения на 10%",
                ItemID.CrimsonHelmet => "Увеличивает урон на 6%\nУвеличивает регенерацию здоровья на 0.5",
                ItemID.CrimsonScalemail => "Увеличивает урон на 6%\nУвеличивает регенерацию здоровья на 1",
                ItemID.CrimsonGreaves => "Увеличивает урон на 6%\nУвеличивает регенерацию здоровья на 0.5",
                ItemID.CobaltHat => "Увеличивает максимальный запас маны на 60",
                ItemID.PalladiumBreastplate => "Увеличивает урон на 5%",
                ItemID.PalladiumLeggings => "Увеличивает урон на 5%",
                ItemID.MythrilHood => "Увеличивает максимальный запас маны на 80",
                ItemID.OrichalcumBreastplate => Language.GetTextValue("ItemTooltip.OrichalcumBreastplate").Replace("6", "10"),
                ItemID.AdamantiteHeadgear => "Увеличивает максимальный запас маны на 100",
                ItemID.SquireGreatHelm => "Увеличивает призываемое число стражей на 1 и регенерацию здоровья на 2",
                ItemID.SquirePlating => Language.GetTextValue("ItemTooltip.SquirePlating").Replace("15", "10"),
                ItemID.SquireGreaves => "Увеличивает урон призывателя и шанс критического удара ближнего боя на 5%\nУвеличивает скорость передвижения на 15%",
                ItemID.MonkBrows => Language.GetTextValue("ItemTooltip.MonkBrows").Replace("20", "10"),
                ItemID.MonkShirt => Language.GetTextValue("ItemTooltip.MonkShirt").Replace("20", "10"),
                ItemID.MonkPants => "Увеличивает урон призывателя и шанс критического удара ближнего боя на 5%",
                ItemID.HuntressJerkin => "Увеличивает урон призывателя и стрелковый урон на 10%\nДаёт 10% шанс не использовать боеприпасы",
                ItemID.ApprenticeTrousers => "Увеличивает урон призывателя и магический шанс критического удара на 5%\nУвеличивает скорость передвижения на 20%",
                ItemID.SquireAltShirt => "Увеличивает урон призывателя на 30% и регенерацию здоровья на 4",
                ItemID.SquireAltPants => "Увеличивает урон призывателя и шанс критического удара ближнего боя на 10%",
                ItemID.MonkAltHead => "Увеличивает призываемое число стражей на 2\nУвеличивает урон призывателя и ближнего боя на 10%",
                ItemID.MonkAltShirt => "Увеличивает урон призывателя и скорость атаки ближнего боя на 10%",
                ItemID.MonkAltPants => "Увеличивает урон призывателя и шанс критического удара ближнего боя на 10%",
                ItemID.HuntressAltShirt => Language.GetTextValue("ItemTooltip.HuntressAltShirt").Replace("25", "15"),
                ItemID.ApprenticeAltPants => "Увеличивает урон призывателя и магический шанс критического удара на 10%",
                ItemID.SlimeCrown => $"{Language.GetTextValue("ItemTooltip.SlimeCrown")}\nНе расходуется",
                ItemID.BloodMoonStarter => "Вызывает кровавую луну\nНе расходуется",
                ItemID.GoblinBattleStandard => $"{Language.GetTextValue("ItemTooltip.GoblinBattleStandard")}\nНе расходуется",
                ItemID.PirateMap => $"{Language.GetTextValue("ItemTooltip.PirateMap")}\nНе расходуется",
                ItemID.SnowGlobe => $"{Language.GetTextValue("ItemTooltip.SnowGlobe")}\nНе расходуется",
                ItemID.NaughtyPresent => $"{Language.GetTextValue("ItemTooltip.NaughtyPresent")}\nНе расходуется",
                ItemID.PumpkinMoonMedallion => $"{Language.GetTextValue("ItemTooltip.PumpkinMoonMedallion")}\nНе расходуется",
                ItemID.SolarTablet => $"{Language.GetTextValue("ItemTooltip.SolarTablet")}\nНе расходуется",
                ItemID.CelestialSigil => $"{Language.GetTextValue("ItemTooltip.CelestialSigil")}\nНе расходуется",
                ItemID.GoldPickaxe => "Способна добывать демонит, багротан, метеорит, морскую призму и кристалл морской призмы",
                ItemID.PlatinumPickaxe => "Способна добывать демонит, багротан, метеорит, морскую призму и кристалл морской призмы",
                ItemID.Picksaw => $"{Language.GetTextValue("ItemTooltip.Picksaw")}\nСпособна добывать магматит, расположенный в бездне",
                ItemID.DeathSickle => $"Накладывает дебафф «{Language.GetTextValue("Mods.CalamityMod.Buffs.WhisperingDeath.DisplayName")}» при ударе",
                ItemID.RifleScope => "Увеличивает дальность обзора для огнестрельного оружия (нажмите ПКМ, чтобы отдалить)",
                ItemID.SniperScope => "Увеличивает дальность обзора для огнестрельного оружия (нажмите ПКМ, чтобы отдалить)\nЭффект прицела можно переключать с помощью настроек видимости",
                ItemID.ReconScope => "Увеличивает дальность обзора для огнестрельного оружия (нажмите ПКМ, чтобы отдалить)\nЭффект прицела можно переключать с помощью настроек видимости",
                ItemID.FlameWakerBoots => $"Увеличивает весь урон накладываемых игроком огненных дебаффов на 25%\nВсе атаки, включая миньонов, накладывают дебафф «{Language.GetTextValue("BuffName.OnFire")}»\n{Language.GetTextValue("ItemTooltip.FlameWakerBoots")}",
                ItemID.Campfire => "Увеличивает регенерацию здоровья на 0.5 рядом с костром",
                ItemID.CursedCampfire => "Увеличивает регенерацию здоровья на 0.5 рядом с костром",
                ItemID.DemonCampfire => "Увеличивает регенерацию здоровья на 0.5 рядом с костром",
                ItemID.FrozenCampfire => "Увеличивает регенерацию здоровья на 0.5 рядом с костром",
                ItemID.IchorCampfire => "Увеличивает регенерацию здоровья на 0.5 рядом с костром",
                ItemID.RainbowCampfire => "Увеличивает регенерацию здоровья на 0.5 рядом с костром",
                ItemID.UltraBrightCampfire => "Увеличивает регенерацию здоровья на 0.5 рядом с костром",
                ItemID.BoneCampfire => "Увеличивает регенерацию здоровья на 0.5 рядом с костром",
                ItemID.DesertCampfire => "Увеличивает регенерацию здоровья на 0.5 рядом с костром",
                ItemID.CoralCampfire => "Увеличивает регенерацию здоровья на 0.5 рядом с костром",
                ItemID.CorruptCampfire => "Увеличивает регенерацию здоровья на 0.5 рядом с костром",
                ItemID.CrimsonCampfire => "Увеличивает регенерацию здоровья на 0.5 рядом с костром",
                ItemID.HallowedCampfire => "Увеличивает регенерацию здоровья на 0.5 рядом с костром",
                ItemID.JungleCampfire => "Увеличивает регенерацию здоровья на 0.5 рядом с костром",
                ItemID.MushroomCampfire => "Увеличивает регенерацию здоровья на 0.5 рядом с костром",
                ItemID.ShimmerCampfire => "Увеличивает регенерацию здоровья на 0.5 рядом с костром",
                ItemID.HeartLantern => "Увеличивает регенерацию здоровья на 1, когда расположен рядом",
                ItemID.BottledHoney => "Увеличивает регенерацию здоровья на 1 на короткое время\nДополнительно увеличивает регенерацию здороовья на 1, если на вас наложен дебафф, наносящий урон",
                ItemID.ShinyStone => "Увеличивает регенерацию здоровья на 2 и ускоряет естественную регенерацию здоровья, когда вы стоите на месте",
                ItemID.BandofRegeneration => "Увеличивает регенерацию здоровья на 1",
                ItemID.CharmofMyths => "Увеличивает регенерацию здоровья на 1 и снижает перезарядку лечебных зелий на 25%",
                ItemID.RegenerationPotion => "Увеличивает регенерацию здоровья на 2",
                ItemID.SoulDrain => $"{Language.GetTextValue("ItemTooltip.SoulDrain")}\nУвеличивает регенерацию здоровья на 1.5 и ускоряет естественную регенерацию здоровья\nВысасывание здоровья суммируется в зависимости от количества поражённых врагов",
                ItemID.AegisCrystal => "Навсегда увеличивает естественную регенерацию здоровья",
                _ => tooltip.Text
            };
        });
        
        ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.GladiatorHelmet => "5 ед. защиты\nУвеличивает разбойный урон на 3%",
                ItemID.GladiatorBreastplate => "6 ед. защиты\nУвеличивает разбойный шанс критического удара на 3",
                ItemID.GladiatorLeggings => "5 ед. защиты\nУвеличивает скорость снарядов разбойника на 3%",
                _ => tooltip.Text
            };
        });
        
        ItemHelper.TranslateTooltip(tooltips, "Tooltip1", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.AnkhShield => $"Даёт невосприимчивость к большинству дебаффов, включая «{Language.GetTextValue("BuffName.WindPushed")}»",
                ItemID.MasterNinjaGear => "Даёт способность уклоняться от атак\nУклонение имеет 90 секунд перезарядки и распространяется на все другие уклонения и отражения",
                ItemID.JellyfishDivingGear => "Создаёт очень тусклый свет, который становится ярче под водой\nОбеспечивает небольшим количеством света в бездне",
                ItemID.Magiluminescence => "Освещает при ношении\nОбеспечивает небольшим количеством света в бездне",
                ItemID.SuspiciousLookingTentacle => "Обеспечивает большим количеством света в бездне\n'Нет, эта тентакля не затем, зачем ты думаешь...'",
                ItemID.ArcticDivingGear => "Увеличивает подвижность на льду\nОбеспечивает небольшим количеством света в бездне\nУмеренно увеличивает запас воздуха в бездне",
                ItemID.FrozenShield => "Окружает панцирем, если ваше здоровье ниже 50%, который увеличивает сопротивление урону на 25%",
                ItemID.MoonStone => "шанс критического удара, регенерацию здоровья",
                ItemID.SunStone => "шанс критического удара, регенерацию здоровья",
                ItemID.EmpressFlightBooster => "Увеличивает скорость передвижения и прыжка на 10% и ускорение на 10%",
                ItemID.SniperScope => "Увеличивает стрелковый урон и шанс критического удара на 7%",
                ItemID.BerserkerGlove => "Увеличивает истинный урон ближнего боя на 10%",
                ItemID.FireGauntlet => "Увеличивает урон ближнего боя на 14%\nУвеличивает скорость атаки ближнего боя на 14%; не суммируется с предыдущим улучшением\nУвеличивает истинный урон ближнего боя на 10%",
                ItemID.ObsidianHorseshoe => $"Даёт невосприимчивость к дебаффам «{Language.GetTextValue("BuffName.Burning")}» и «{Language.GetTextValue("BuffName.OnFire")}»",
                ItemID.ObsidianShield => $"Даёт невосприимчивость к дебаффам «{Language.GetTextValue("BuffName.Burning")}» и «{Language.GetTextValue("BuffName.OnFire")}»",
                ItemID.ObsidianWaterWalkingBoots => $"Даёт невосприимчивость к дебаффам «{Language.GetTextValue("BuffName.Burning")}» и «{Language.GetTextValue("BuffName.OnFire")}»",
                ItemID.LavaWaders => $"Даёт невосприимчивость к дебаффам «{Language.GetTextValue("BuffName.Burning")}» и «{Language.GetTextValue("BuffName.OnFire")}» и 7 секунд невосприимчивости к лаве",
                ItemID.LavaSkull => $"Даёт невосприимчивость к дебаффам «{Language.GetTextValue("BuffName.Burning")}» и «{Language.GetTextValue("BuffName.OnFire")}»",
                ItemID.MoltenSkullRose => $"Даёт невосприимчивость к дебаффам «{Language.GetTextValue("BuffName.Burning")}» и «{Language.GetTextValue("BuffName.OnFire")}»",
                ItemID.HellfireTreads => $"Позволяет очень быстро бегать и даёт невосприимчивость к дебаффу «{Language.GetTextValue("BuffName.OnFire")}»",
                ItemID.Gi => "Увеличивает скорость прыжка и передвижения на 10%",
                ItemID.MonkPants => "Увеличивает скорость передвижения на 20%",
                ItemID.RodofDiscord => $"Вызывает «{Language.GetTextValue("BuffName.ChaosState")}»\nТелепортация невозможна, пока активен дебафф «{Language.GetTextValue("BuffName.ChaosState")}»",
                ItemID.PowerGlove => "Увеличивает скорость атаки ближнего боя на 10%; не суммируется с предыдущим улучшением",
                ItemID.MechanicalGlove => "Увеличивает урон ближнего боя на 12%\nУвеличивает скорость атаки ближнего боя на 12%; не суммируется с предыдущим улучшением\nУвеличивает истинный урон ближнего боя на 10%",
                ItemID.RifleScope => "Эффект прицела можно переключать с помощью настроек видимости",
                ItemID.HamBat => "Побеждённые враги временно увеличивают регенерацию здоровья на 3",
                ItemID.SolarFlareHelmet => "Увеличивает регенерацию здоровья на 1",
                ItemID.SolarFlareBreastplate => "Увеличивает регенерацию здоровья на 1",
                ItemID.SolarFlareLeggings => "Увеличивает регенерацию здоровья на 1",
                _ => tooltip.Text
            };
        });
        
        ItemHelper.TranslateTooltip(tooltips, "BuffTime", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.ShinePotion => "Длительность действия эффекта: 10 мин.\nОбеспечивает умеренным количеством света в бездне",
                ItemID.GillsPotion => "Длительность действия эффекта: 4 мин.\nЗначительно увеличивает запас воздуха в бездне",
                _ => tooltip.Text
            };
        });
        
        ItemHelper.TranslateTooltip(tooltips, "NeedsBait", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.GoldenFishingRod => $"{Language.GetTextValue("GameUI.BaitRequired")}\nЛеска никогда не порвётся",
                _ => tooltip.Text
            };
        });
        
        ItemHelper.TranslateTooltip(tooltips, "HealLife", tooltip =>
        {
            tooltips.ReplaceText("Restores", "Восстанавливает");
            tooltips.ReplaceText("life", "ед. здоровья");
            
            tooltip.Text = item.type switch
            {
                _ => tooltip.Text
            };
        });
        
        ItemHelper.TranslateTooltip(tooltips, "Consumable", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.TruffleWorm => $"{Language.GetTextValue("LegacyTooltip.35")}\nПризывает Герцога Рыброна при использовании в качестве наживки в океане\nВходит в ярость за пределами океана",
                _ => tooltip.Text
            };
        });
        
        ItemHelper.TranslateTooltip(tooltips, "Tooltip4", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.CelestialShell => $"защиту, скорость добычи и отбрасывание призывателя\nУмеренно увеличивает запас воздуха в бездне\nСнижает урон от дебаффов «{Language.GetTextValue("Mods.CalamityMod.Buffs.Nightwither.DisplayName")}» и «{Language.GetTextValue("Mods.CalamityMod.Buffs.HolyFlames.DisplayName")}»",
                _ => tooltip.Text
            };
        });
        
        ItemHelper.TranslateTooltip(tooltips, "Tooltip2", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.FairyBoots => "На траве, по которой прошлись, начинают расти цветы\nФеи появляются на поверхности в любое время и гораздо чаще\nНаходящиеся поблизости феи увеличивают регенерацию здоровья на 2, защиту на 10 и скорость передвижения на 10%\nФеи невосприимчивы к урону и больше не улетают",
                ItemID.MoonStone => $"защиту, скорость добычи и отбрасывание призывателя\nСнижает урон от дебаффа «{Language.GetTextValue("Mods.CalamityMod.Buffs.Nightwither.DisplayName")}»",
                ItemID.SunStone => $"защиту, скорость добычи и отбрасывание призывателя\nСнижает урон от дебаффа «{Language.GetTextValue("Mods.CalamityMod.Buffs.HolyFlames.DisplayName")}»",
                ItemID.CelestialStone => $"защиту, скорость добычи и отбрасывание призывателя\nСнижает урон от дебаффов «{Language.GetTextValue("Mods.CalamityMod.Buffs.Nightwither.DisplayName")}» и «{Language.GetTextValue("Mods.CalamityMod.Buffs.HolyFlames.DisplayName")}»",
                ItemID.CelestialShell => "Незначительно увеличивает урон,",
                ItemID.MoltenQuiver => $"Поджигает деревянные стрелы и все стрелы накладывают дебафф «{Language.GetTextValue("BuffName.OnFire3")}»",
                ItemID.HellfireTreads => $"Оставляет за вами огненный след\nУвеличивает весь урон накладываемых игроком огненных дебаффов на 50%; не суммируется с предыдущим улучшением\nВсе атаки, включая миньонов, накладывают дебафф «{Language.GetTextValue("BuffName.OnFire3")}»",
                ItemID.ArcaneFlower => $"Враги реже выбирают вас в качестве цели\nУвеличивает магический урон на 5%",
                _ => tooltip.Text
            };
        });
        
        ItemHelper.TranslateTooltip(tooltips, "Tooltip3", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.TerrasparkBoots => $"Даёт невосприимчивость к огненным блокам и 7 секунд невосприимчивости к лаве\nДаёт невосприимчивость к дебаффу «{Language.GetTextValue("BuffName.OnFire")}»",
                _ => tooltip.Text
            };
        });
        
        ItemHelper.TranslateTooltip(tooltips, "UseMana", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                _ => tooltip.Text
            };
        });
        
        ItemHelper.TranslateTooltip(tooltips, "Material", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.Tombstone => $"{Language.GetTextValue("LegacyTooltip.36")}\n13 любых надгробий превращают окружающую область в кладбище\nНа кладбище появляются новые предметы для продажи и рецепты",
                ItemID.GraveMarker => $"{Language.GetTextValue("LegacyTooltip.36")}\n13 любых надгробий превращают окружающую область в кладбище\nНа кладбище появляются новые предметы для продажи и рецепты",
                ItemID.CrossGraveMarker => $"{Language.GetTextValue("LegacyTooltip.36")}\n13 любых надгробий превращают окружающую область в кладбище\nНа кладбище появляются новые предметы для продажи и рецепты",
                ItemID.Headstone => $"{Language.GetTextValue("LegacyTooltip.36")}\n13 любых надгробий превращают окружающую область в кладбище\nНа кладбище появляются новые предметы для продажи и рецепты",
                ItemID.Gravestone => $"{Language.GetTextValue("LegacyTooltip.36")}\n13 любых надгробий превращают окружающую область в кладбище\nНа кладбище появляются новые предметы для продажи и рецепты",
                ItemID.Obelisk => $"{Language.GetTextValue("LegacyTooltip.36")}\n13 любых надгробий превращают окружающую область в кладбище\nНа кладбище появляются новые предметы для продажи и рецепты",
                ItemID.RichGravestone1 => $"{Language.GetTextValue("LegacyTooltip.36")}\n13 любых надгробий превращают окружающую область в кладбище\nНа кладбище появляются новые предметы для продажи и рецепты",
                ItemID.RichGravestone2 => $"{Language.GetTextValue("LegacyTooltip.36")}\n13 любых надгробий превращают окружающую область в кладбище\nНа кладбище появляются новые предметы для продажи и рецепты",
                ItemID.RichGravestone3 => $"{Language.GetTextValue("LegacyTooltip.36")}\n13 любых надгробий превращают окружающую область в кладбище\nНа кладбище появляются новые предметы для продажи и рецепты",
                ItemID.RichGravestone4 => $"{Language.GetTextValue("LegacyTooltip.36")}\n13 любых надгробий превращают окружающую область в кладбище\nНа кладбище появляются новые предметы для продажи и рецепты",
                ItemID.RichGravestone5 => $"{Language.GetTextValue("LegacyTooltip.36")}\n13 любых надгробий превращают окружающую область в кладбище\nНа кладбище появляются новые предметы для продажи и рецепты",
                ItemID.AdamantiteSword => tooltip.Text.Replace("Slows enemies on hit", "Замедляет врагов при ударе"),
                ItemID.TitaniumSword => tooltip.Text.Replace("Deals increased damage to enemies with high knockback resistance", "Наносит увеличенный урон врагам с высоким сопротивлением к отбрасыванию"),
                ItemID.Excalibur => tooltip.Text.Replace("Deals double damage to enemies above 75% life", "Наносит двойной урон врагам с уровнем здоровья выше 75%"),
                ItemID.Gungnir => tooltip.Text.Replace("Deals double damage to enemies above 75% life", "Наносит двойной урон врагам с уровнем здоровья выше 75%"),
                ItemID.TrueExcalibur => tooltip.Text.Replace("Deals double damage to enemies above 75% life", "Наносит двойной урон врагам с уровнем здоровья выше 75%"),
                ItemID.BluePhaseblade => tooltip.Text.Replace("Ignores 100% of enemy defense", "Игнорирует 100% защиты врага"),
                ItemID.RedPhaseblade => tooltip.Text.Replace("Ignores 100% of enemy defense", "Игнорирует 100% защиты врага"),
                ItemID.GreenPhaseblade => tooltip.Text.Replace("Ignores 100% of enemy defense", "Игнорирует 100% защиты врага"),
                ItemID.PurplePhaseblade => tooltip.Text.Replace("Ignores 100% of enemy defense", "Игнорирует 100% защиты врага"),
                ItemID.WhitePhaseblade => tooltip.Text.Replace("Ignores 100% of enemy defense", "Игнорирует 100% защиты врага"),
                ItemID.YellowPhaseblade => tooltip.Text.Replace("Ignores 100% of enemy defense", "Игнорирует 100% защиты врага"),
                ItemID.OrangePhaseblade => tooltip.Text.Replace("Ignores 100% of enemy defense", "Игнорирует 100% защиты врага"),
                ItemID.AntlionClaw => tooltip.Text.Replace("Ignores 50% of enemy defense", "Игнорирует 50% защиты врага"),
                ItemID.SolarFlarePickaxe => tooltip.Text.Replace("Can mine Uelibloom Ore", "Способна добывать цветонит"),
                ItemID.VortexPickaxe => tooltip.Text.Replace("Can mine Uelibloom Ore", "Способна добывать цветонит"),
                ItemID.NebulaPickaxe => tooltip.Text.Replace("Can mine Uelibloom Ore", "Способна добывать цветонит"),
                ItemID.StardustPickaxe => tooltip.Text.Replace("Can mine Uelibloom Ore", "Способна добывать цветонит"),
                _ => tooltip.Text
            };
        });
        
        ItemHelper.TranslateTooltip(tooltips, "TileBoost", tooltip =>
        {
            tooltip.Text = item.type switch
            {
                ItemID.SolarFlareDrill => tooltip.Text.Replace("Can mine Uelibloom Ore", "Способен добывать цветонит"),
                ItemID.VortexDrill => tooltip.Text.Replace("Can mine Uelibloom Ore", "Способен добывать цветонит"),
                ItemID.NebulaDrill => tooltip.Text.Replace("Can mine Uelibloom Ore", "Способен добывать цветонит"),
                ItemID.StardustDrill => tooltip.Text.Replace("Can mine Uelibloom Ore", "Способен добывать цветонит"),
                _ => tooltip.Text
            };
        });
        
        ItemHelper.TranslateTooltip(tooltips, "Equipable", tooltip =>
        {
            if (item.type is ItemID.GrapplingHook or ItemID.AmethystHook or ItemID.SquirrelHook or ItemID.TopazHook
                or ItemID.SapphireHook or ItemID.EmeraldHook or ItemID.RubyHook or ItemID.AmberHook
                or ItemID.DiamondHook or ItemID.WebSlinger or ItemID.SkeletronHand or ItemID.SlimeHook
                or ItemID.FishHook or ItemID.IvyWhip or ItemID.BatHook or ItemID.CandyCaneHook or ItemID.DualHook
                or ItemID.WormHook or ItemID.TendonHook or ItemID.IlluminantHook or ItemID.ThornHook
                or ItemID.AntiGravityHook or ItemID.SpookyHook or ItemID.ChristmasHook or ItemID.LunarHook
                or ItemID.StaticHook or ItemID.QueenSlimeHook)
            {
                tooltip.Text = tooltip.Text
                    .Replace("Reach", "Дальность")
                    .Replace("tiles", "блоков")
                    .Replace("Launch Velocity", "Скорость вылета")
                    .Replace("Reelback Velocity", "Скорость возврата")
                    .Replace("Pull Velocity", "Скорость притягивания");
            }
        });
    }
}