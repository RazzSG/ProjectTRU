using System.Collections.Generic;
using System.Globalization;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using ThoriumMod.Items;
using ThoriumMod.Items.ArcaneArmor;
using ThoriumMod.Items.BardItems;
using ThoriumMod.Items.BossFallenBeholder;
using ThoriumMod.Items.BossLich;
using ThoriumMod.Items.BossThePrimordials.Aqua;
using ThoriumMod.Items.Bronze;
using ThoriumMod.Items.Donate;
using ThoriumMod.Items.HealerItems;
using ThoriumMod.Items.Misc;
using ThoriumMod.Items.Sandstone;
using ThoriumMod.Items.ThrownItems;
using ThoriumMod.Items.TransformItems;
using ThoriumMod.Utilities;

namespace CalamityRuTranslate.Mods.ThoriumMod;

public class ThoriumGlobalItem : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.Thorium != null && TRuConfig.Instance.ThoriumModLocalization && TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        ItemHelper.TranslateTooltip(tooltips, "SetBonus", tooltip =>
        {
            Player player = Main.player[Main.myPlayer];
            string setBonusKey = Language.GetTextValue("LegacyTooltip.48");

            if (player.armor[0].type == ModContent.ItemType<FlightMask>() &&
                player.armor[1].type == ModContent.ItemType<FlightMail>() &&
                player.armor[2].type == ModContent.ItemType<FlightBoots>())
            {
                tooltip.Text = $"{setBonusKey} Позволяет кратковременно летать";
            }
            
            if (player.armor[0].type == ModContent.ItemType<LichCowl>() &&
                player.armor[1].type == ModContent.ItemType<LichCarapace>() &&
                player.armor[2].type == ModContent.ItemType<LichTalon>())
            {
                tooltip.Text = $"{setBonusKey} Из убитого врага можно извлечь фрагмент души\nКоснувшись фрагмента души, вы значительно увеличиваете скорость передвижения и метания на короткое время";
            }
            
            if (player.armor[0].type == ModContent.ItemType<TideTurnersGaze>() &&
                player.armor[1].type == ModContent.ItemType<TideTurnerBreastplate>() &&
                player.armor[2].type == ModContent.ItemType<TideTurnerGreaves>())
            {
                tooltip.Text = $"{setBonusKey} При нанесении метательного урона с 20% шансом вокруг вас выпускаются акватические самонаводящиеся кинжалы";
            }
            
            if (player.armor[0].type == ModContent.ItemType<BronzeHelmet>() &&
                player.armor[1].type == ModContent.ItemType<BronzeBreastplate>() &&
                player.armor[2].type == ModContent.ItemType<BronzeGreaves>())
            {
                tooltip.Text = $"{setBonusKey} Метательный урон с 20% шансом высвобождает пронзающий удар молнии";
            }
            
            if (player.armor[0].type == ModContent.ItemType<HallowedGuise>() &&
                player.armor[1].type is 551 or 4900 &&
                player.armor[2].type is 552 or 4901)
            {
                tooltip.Text = $"{setBonusKey} После удара по врагу вы становитесь неуязвимым; увеличивает максимальное число очков техники на 2";
            }
            
            if (player.armor[0].type == ModContent.ItemType<SandStoneHelmet>() &&
                player.armor[1].type == ModContent.ItemType<SandStoneMail>() &&
                player.armor[2].type == ModContent.ItemType<SandStoneGreaves>())
            {
                tooltip.Text = $"{setBonusKey} Пустынные ветра дают песчаный двойной прыжок";
            }
            
            if (player.armor[0].type == ModContent.ItemType<FungusHat>() &&
                player.armor[1].type == ModContent.ItemType<FungusGuard>() &&
                player.armor[2].type == ModContent.ItemType<FungusLeggings>())
            {
                tooltip.Text = $"{setBonusKey} Увеличивает урон по заражённым мицелием врагам на 10%\nПри нанесении урона врагам, заражённым мицелием, метательная скорость атаки временно увеличивается на 10%";
            }
            
            if (player.armor[0].type == ModContent.ItemType<PlagueDoctorsMask>() &&
                player.armor[1].type == ModContent.ItemType<PlagueDoctorsGarb>() &&
                player.armor[2].type == ModContent.ItemType<PlagueDoctorsLeggings>())
            {
                tooltip.Text = $"{setBonusKey} Чумной газ рассеивается в воздухе вдвое медленнее, а чумные реактивы наносят на 20% больше урона";
            }
            
            if (player.armor[0].type == ModContent.ItemType<ShadeMasterMask>() &&
                player.armor[1].type == ModContent.ItemType<ShadeMasterGarb>() &&
                player.armor[2].type == ModContent.ItemType<ShadeMasterTreads>())
            {
                tooltip.Text = $"{setBonusKey} До 50% полученного урона распределяется равномерно в течение 10 секунд";
            }
            
            if (player.armor[0].type == ModContent.ItemType<WhiteDwarfMask>() &&
                player.armor[1].type == ModContent.ItemType<WhiteDwarfGuard>() &&
                player.armor[2].type == ModContent.ItemType<WhiteDwarfGreaves>())
            {
                tooltip.Text = $"{setBonusKey} Критические удары высвобождают из космоса изумрудные вспышки\nИзумрудные вспышки наносят урон, равный 0.1% от максимального здоровья цели";
            }
        });

        if (item.type == ModContent.ItemType<SoulLink>())
        {
            ItemHelper.TranslateTooltip(tooltips, "TransformationTag2", tooltip =>
            {
                tooltip.Text = "-Раннее тестирование-";
            });
            
            ItemHelper.TranslateTooltip(tooltips, "transformationText", _ =>
            {
                tooltips.ReplaceText("Right click to throw a volley of acorns", "Нажмите ПКМ, чтобы бросить залп жёлудей");
                tooltips.ReplaceText("Right click to release a toxic haze on either side of you", "Нажмите ПКМ, чтобы создать ядовитый дым с обеих сторон от вас");
                tooltips.ReplaceText("Right click to leave a trail of burning napalm", "Нажмите ПКМ, чтобы оставить след из горящего напалма");
                tooltips.ReplaceText("Right click to blow a larger bubble that stuns enemies or replenishes ally breath", "Нажмите ПКМ, чтобы надуть огромный пузырь, который оглушает врагов или восстанавливает запас воздуха союзника");
                tooltips.ReplaceText("Right click to spit a bouncing globule of blood at the cost of 4 life", "Нажмите ПКМ, чтобы выплюнуть отскакивающую каплю крови за 4 единицы здоровья");
                tooltips.ReplaceText("Right click to belch a volley of coins", "Нажмите ПКМ, чтобы изрыгнуть залп монет");
                tooltips.ReplaceText("Right click to harden your carapace, giving you damage reduction and a thorns effect briefly", "Нажмите ПКМ, чтобы укрепить свой панцирь, временно увеличив сопротивление урону и добавив эффект шипов");
                tooltips.ReplaceText("Right click to drop a large scale timed explosive", "Нажмите ПКМ, чтобы установить большой взрывчатый заряд с таймером");
                tooltips.ReplaceText("Allows you to use unique abilities while transformed", "Позволяет использовать уникальные способности после превращения");
            });
            
            ItemHelper.TranslateTooltip(tooltips, "transformationText2", _ =>
            {
                tooltips.ReplaceText("Left click to dash forward, damaging an enemy in the process", "Нажмите ЛКМ, чтобы выполнить рывок вперёд, нанося урон врагу в процессе");
                tooltips.ReplaceText("Left click to spit a heavy bubble that deals increased damage to poisoned enemies", "Нажмите ЛКМ, чтобы выплюнуть тяжёлый пузырь, который наносит увеличенный урон отравленным врагам");
                tooltips.ReplaceText("Left click to spit a stream of burning lava", "Нажмите ЛКМ, чтобы выплюнуть струю раскалённой лавы");
                tooltips.ReplaceText("Left click to release a water-bound bubble stream", "Нажмите ЛКМ, чтобы выпустить водяной поток пузырей");
                tooltips.ReplaceText("Left click to fire pair of life stealing teeth", "Нажмите ЛКМ, чтобы выпустить пару зубов, крадущих здоровье");
                tooltips.ReplaceText("Left click to leap forward, damaging an enemy in the process", "Нажмите ЛКМ, чтобы прыгнуть вперёд, нанося урон врагу в процессе");
                tooltips.ReplaceText("Left click to release a storm of venomous beetle needles", "Нажмите ЛКМ, чтобы выпустить шквал ядовитых жучьих игл");
                tooltips.ReplaceText("Left click to place a timed explosive that boosts you upwards", "Нажмите ЛКМ, чтобы разместить взрывчатку с таймером, которая запустит вас вверх");
            });
            
            ItemHelper.TranslateTooltip(tooltips, "transformationText3", _ =>
            {
                tooltips.ReplaceText("15 symbiotic damage", "15 ед. симбиотического урона");
                tooltips.ReplaceText("12 symbiotic damage", "12 ед. симбиотического урона");
                tooltips.ReplaceText("10 symbiotic damage", "10 ед. симбиотического урона");
                tooltips.ReplaceText("50 symbiotic damage", "50 ед. симбиотического урона");
                tooltips.ReplaceText("38 symbiotic damage", "38 ед. симбиотического урона");
                tooltips.ReplaceText("65 symbiotic damage", "65 ед. симбиотического урона");
            });
        }
        
        if (item.type == ModContent.ItemType<VoidPlanter>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "Healing", tooltip =>
            {
                tooltips.ReplaceText($"Heals player life equal to {tooltip.Text.Split(' ')[5]} of the last damage they took", $"Восстанавливает здоровье игрока в размере {tooltip.Text.Split(' ')[5]} от последнего полученного им урона");
                tooltips.ReplaceText("Max", "максимум");
            });
        }
        
        if (item.type == ModContent.ItemType<DarkGate>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "HealerAmount", tooltip =>
            {
                string[] parts = tooltip.Text.Split(' ');
                string duration = parts[^2];
                if (double.TryParse(duration.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double seconds))
                {
                    string secondsSuffix = seconds >= 5 ? "секунд" : "секунды";
                    tooltip.Text = $"Игроки могут использовать врата не чаще одного раза в {duration} {secondsSuffix}";
                }
                
                if (tooltip.Text == $"Heals ally and player life by {parts[6]}")
                {
                    tooltip.Text = $"Лечит союзника и игрока на {parts[6]} ед. здоровья";
                }
            });
        }
        
        if (item.type == ModContent.ItemType<DreamMegaphone>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "HealerAmount", tooltip =>
            {
                int healBonus = 10 + 4 * Main.LocalPlayer.GetThoriumPlayer().healBonus;
                string seconds = LocalizedText.ApplyPluralization("{^0:секунду;секунды;секунд}", healBonus);
                tooltip.Text = $"Увеличивает урон всех ближайших союзников на 20% на [c/5aff5a:{healBonus}] {seconds}";
            });
        }
        
        if (item.type == ModContent.ItemType<HolyHammer>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "HealerAmount", tooltip =>
            {
                tooltips.ReplaceText("Right click to heal all nearby allies equal to your bonus healing", "Нажмите ПКМ, чтобы исцелить всех ближайших союзников на величину, равную вашему бонусному исцелению");
                tooltips.ReplaceText($"Right click to heal all nearby allies by {tooltip.Text.Split(' ')[8]} life", $"Нажмите ПКМ, чтобы исцелить всех ближайших союзников на {tooltip.Text.Split(' ')[8]} ед. здоровья");
                tooltips.ReplaceText("Max", "максимум");
            });
        }
        
        if (item.type == ModContent.ItemType<LadyLight>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "CritChance", tooltip =>
            {
                tooltip.Text = "5% шанс критического удара";
            });
        }
        
        if (item.type == ModContent.ItemType<SmitingHammer>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "HealerAmount", tooltip =>
            {
                tooltips.ReplaceText("Right click to heal all nearby allies equal to the weapon's holy charges at twice the mana cost", "Нажмите ПКМ, чтобы исцелить всех ближайших союзников на величину зарядов святости оружия при двойном расходе маны");
                tooltips.ReplaceText($"Right click to heal all nearby allies by {tooltip.Text.Split(' ')[8]} life at twice the mana cost", $"Нажмите ПКМ, чтобы исцелить всех ближайших союзников на {tooltip.Text.Split(' ')[8]} ед. здоровья при двойном расходе маны");
                tooltips.ReplaceText("Right click to heal all nearby allies by 20 life (Max) at twice the mana cost", "Нажмите ПКМ, чтобы исцелить всех ближайших союзников на 20 ед. здоровья (максимум) при двойном расходе маны");
            });
        }
        
        if (item.type == ModContent.ItemType<BloomingWand>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "HealerAmount", tooltip =>
            {
                tooltip.Text = $"Лечит союзника на {tooltip.Text.Split(' ')[1]} ед. здоровья в течение 5 секунд";
            });
        }
        
        if (item.type == ModContent.ItemType<GraniteIonStaff>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "HealerAmount", tooltip =>
            {
                tooltip.Text = $"Оберегает союзника, давая ему от {tooltip.Text.Split(' ')[4]} до 50 единиц жизненного щита";
            });
        }
        
        if (item.type == ModContent.ItemType<LargePopcorn>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "HealerAmount", _ =>
            {
                tooltips.ReplaceText("Heals ally and player life by 1", "Лечит союзника и игрока на 1 ед. здоровья");
                tooltips.ReplaceText("Popcorn does not apply on heal effects when consumed", "Попкорн не влияет на эффекты исцеления при его употреблении");
                tooltips.ReplaceText($"Throws out ({3 + Main.LocalPlayer.GetThoriumPlayer().healBonus}) eatable popcorn kernels", $"Бросает ({3 + Main.LocalPlayer.GetThoriumPlayer().healBonus}) съедобных зёрен попкорна");
                tooltips.ReplaceText($"Up to ({(3 + Main.LocalPlayer.GetThoriumPlayer().healBonus) * 3}) kernels may be out at once", $"Одновременно может быть брошено до ({(3 + Main.LocalPlayer.GetThoriumPlayer().healBonus) * 3}) зёрен попкорна");
            });
        }
        
        if (item.type == ModContent.ItemType<Recuperate>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "HealerAmount", tooltip =>
            {
                tooltip.Text = $"Удерживайте фолиант, преобразовывая {tooltip.Text.Split(' ')[4]} ед. маны в {tooltip.Text.Split(' ')[7]} ед. здоровья каждую секунду";
            });
        }
        
        if (item.type == ModContent.ItemType<Renew>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "HealerAmount", tooltip =>
            {
                tooltip.Text = $"Мгновенно восстанавливает {tooltip.Text.Split(' ')[2]} ед. здоровья";
            });
        }
        
        if (item.type == ModContent.ItemType<RodofAesculapius>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "HealerAmount", tooltip =>
            {
                tooltip.Text = $"Каждую секунду восстанавливает здоровье союзника на {tooltip.Text.Split(' ')[4]} ед.";
            });
        }
        
        if (item.type == ModContent.ItemType<SnackLantern>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "HealerAmount", tooltip =>
            {
                tooltip.Text = $"После взрыва лечит всех ближайших союзников на {tooltip.Text.Split(' ')[8]} ед. здоровья";
            });
        }
        
        if (item.type == ModContent.ItemType<WarForger>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "HealerAmount", tooltip =>
            {
                tooltip.Text = $"Оберегает союзника и игрока, давая им от {tooltip.Text.Split(' ')[6]} до 25 единиц жизненного щита";
            });
        }
        
        if (item.type == ModContent.ItemType<BoneGrip>() || item.type == ModContent.ItemType<MagnetoGrip>() || item.type == ModContent.ItemType<PaddedGrip>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "DisplayAmount", tooltip =>
            {
                int startIndex = tooltip.Text.LastIndexOf(':') + 1;
                int endIndex = tooltip.Text.LastIndexOf(' ');
                string duplicatesStr = tooltip.Text.Substring(startIndex, endIndex - startIndex);
                if (int.TryParse(duplicatesStr, out int value))
                {
                    string color = (new Color(250, 210, 45) * (Main.mouseTextColor / 255f)).Hex3();
                    string items = LocalizedText.ApplyPluralization("{^0:предмет;предмета;предметов}", value);
                    tooltip.Text = $"Продублировано: [c/{color}:{duplicatesStr} {items}]";
                }
            });
        }
        
        if (item.type == ModContent.ItemType<MusicPlayerDamage>() || item.type == ModContent.ItemType<TunePlayerDamage>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Name == "Tooltip0", _ =>
            {
                tooltips.ReplaceText("медный", "медных");
            });
        }
        
        if (item.type == ModContent.ItemType<MusicPlayerDamageReduction>() || item.type == ModContent.ItemType<TunePlayerDamageReduction>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Name == "Tooltip0", _ =>
            {
                tooltips.ReplaceText("струнный", "струнных");
            });
        }
        
        if (item.type == ModContent.ItemType<MusicPlayerLifeRegen>() || item.type == ModContent.ItemType<TunePlayerLifeRegen>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Name == "Tooltip0", _ =>
            {
                tooltips.ReplaceText("духовой", "духовых");
            });
        }
        
        if (item.type == ModContent.ItemType<MusicPlayerMovementSpeed>() || item.type == ModContent.ItemType<TunePlayerMovementSpeed>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Name == "Tooltip0", _ =>
            {
                tooltips.ReplaceText("ударный", "ударных");
            });
        }
        
        if (item.ModItem is ThoriumItem thoriumItem)
        {
            if (thoriumItem.healType == HealType.LifeSteal)
            {
                ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "HealerAmount", tooltip =>
                {
                    string[] parts = tooltip.Text.Split(' ');
                    if (tooltip.Text == $"Steals {parts[1]} life")
                    {
                        tooltip.Text = $"Крадёт {parts[1]} ед. здоровья";
                    }
                });
            }

            if (thoriumItem.healType == HealType.Ally)
            {
                ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "HealerAmount", tooltip =>
                {
                    string[] parts = tooltip.Text.Split(' ');
                    if (tooltip.Text == $"Heals ally life by {parts[4]}")
                    {
                        tooltip.Text = $"Лечит союзника на {parts[4]} ед. здоровья";
                    }
                });
            }
        }
        
        if (item.type == ModContent.ItemType<ValhallasDescent>() || item.type == ModContent.ItemType<DivineLotus>() ||
            item.type == ModContent.ItemType<HolyStaff>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "HealerAmount", tooltip =>
            {
                string[] parts = tooltip.Text.Split(' ');
                if (tooltip.Text == $"Heals ally and player life by {parts[6]}")
                {
                    tooltip.Text = $"Лечит союзника и игрока на {parts[6]} ед. здоровья";
                }
            });
        }
        
        if (item.type == ModContent.ItemType<HeavenlyCloudScepter>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "HealerAmount", tooltip =>
            {
                string[] parts = tooltip.Text.Split(' ');
                if (tooltip.Text == $"Heals ally and player life by {parts[6]}")
                {
                    tooltip.Text = $"Лечит союзника и игрока на {parts[6]} ед. здоровья";
                }
                
                if (tooltip.Text == "Heals ally and player life equal to your bonus healing")
                {
                    tooltip.Text = "Лечит союзника и игрока на величину, равную вашему бонусному исцелению";
                }
            });
        }
        
        if (item.type == ModContent.ItemType<LifeDisperser>() || item.type == ModContent.ItemType<HereticBreaker>() ||
            item.type == ModContent.ItemType<IridescentStaff>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "HealerAmount", tooltip =>
            {
                if (tooltip.Text == "Heals ally life equal to your bonus healing")
                {
                    tooltip.Text = "Лечит союзника на величину, равную вашему бонусному исцелению";
                }
            });
        }
        
        if (item.type == ModContent.ItemType<LifePulseStaff>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "HealerAmount", tooltip =>
            {
                string[] parts = tooltip.Text.Split(' ');
                if (tooltip.Text == "Heals ally and player life equal to your bonus healing (5 Max)")
                {
                    tooltip.Text = "Лечит союзника и игрока на величину, равную вашему бонусному исцелению (максимум 5 единиц)";
                }
                
                if (tooltip.Text == $"Heals ally and player life by {parts[6]} (5 Max)")
                {
                    tooltip.Text = $"Лечит союзника и игрока на {parts[6]} ед. здоровья (максимум 5 единиц)";
                }
                
                if (tooltip.Text == $"Heals ally and player life by {parts[6]} (Max)")
                {
                    tooltip.Text = $"Лечит союзника и игрока на {parts[6]} ед. здоровья (максимум)";
                }
            });
        }
        
        if (item.type == ModContent.ItemType<LilCherubsWand>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "HealerAmount", tooltip =>
            {
                string[] parts = tooltip.Text.Split(' ');
                if (tooltip.Text == "Heals ally life equal to your bonus healing (5 Max)")
                {
                    tooltip.Text = "Лечит союзника на величину, равную вашему бонусному исцелению (максимум 5 единиц)";
                }
                
                if (tooltip.Text == $"Heals ally life by {parts[4]} (5 Max)")
                {
                    tooltip.Text = $"Лечит союзника на {parts[4]} ед. здоровья (максимум 5 единиц)";
                }
                
                if (tooltip.Text == $"Heals ally life by {parts[4]} (Max)")
                {
                    tooltip.Text = $"Лечит союзника на {parts[4]} ед. здоровья (максимум)";
                }
            });
        }
        
        if (item.type == ModContent.ItemType<RottenCod>() || item.type == ModContent.ItemType<SacredBludgeon>() ||
            item.type == ModContent.ItemType<TemplarJudgment>() || item.type == ModContent.ItemType<TheEffuser>() ||
            item.type == ModContent.ItemType<TheStalker>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "HealerAmount", tooltip =>
            {
                string[] parts = tooltip.Text.Split(' ');
                if (tooltip.Text == "Heals ally and player life equal to your bonus healing (4 Max)")
                {
                    tooltip.Text = "Лечит союзника и игрока на величину, равную вашему бонусному исцелению (максимум 4 единицы)";
                }
                
                if (tooltip.Text == $"Heals ally and player life by {parts[6]} (4 Max)")
                {
                    tooltip.Text = $"Лечит союзника и игрока на {parts[6]} ед. здоровья (максимум 4 единицы)";
                }
                
                if (tooltip.Text == $"Heals ally and player life by {parts[6]} (Max)")
                {
                    tooltip.Text = $"Лечит союзника и игрока на {parts[6]} ед. здоровья (максимум)";
                }
            });
        }
        
        ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "AccessoryDamage", _ =>
        {
            tooltips.ReplaceText("basic damage", "ед. базового урона");
        });
        
        ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "RealityTag", tooltip =>
        {
            tooltip.Text = "-Разрушитель реальности-";
        });
        
        ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "TransformationTag", tooltip =>
        {
            tooltip.Text = "-Превращение-";
        });
        
        ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "ThrowerTag", tooltip =>
        {
            tooltip.Text = "-Метатель-";
        });
        
        ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "HealerTag", tooltip =>
        {
            tooltip.Text = "-Целитель-";
        });
        
        ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "ScytheSoulCharge", tooltip =>
        {
            string[] parts = tooltip.Text.Split(' ');
            string scytheSoulCharge = parts[1];
            if (int.TryParse(scytheSoulCharge, out int value))
            {
                string valueSuffix = LocalizedText.ApplyPluralization("{^0:эссенцию;эссенции}", value);
                tooltip.Text = $"Даёт {scytheSoulCharge} {valueSuffix} души при прямом попадании";
            }
        });
        
        ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "ThrowerAmount", _ =>
        {
            tooltips.ReplaceText("Hold right click to store up to", "Удерживайте ПКМ, чтобы накопить до");
            tooltips.ReplaceText("needles", "игл");
        });
    }
}