using System.Collections.Generic;
using System.Globalization;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using ThoriumMod.Items.ArcaneArmor;
using ThoriumMod.Items.BardItems;
using ThoriumMod.Items.BossFallenBeholder;
using ThoriumMod.Items.BossForgottenOne;
using ThoriumMod.Items.BossLich;
using ThoriumMod.Items.BossMini;
using ThoriumMod.Items.BossStarScouter;
using ThoriumMod.Items.BossThePrimordials.Aqua;
using ThoriumMod.Items.BossThePrimordials.Dream;
using ThoriumMod.Items.BossThePrimordials.Omni;
using ThoriumMod.Items.BossThePrimordials.Rhapsodist;
using ThoriumMod.Items.BossThePrimordials.Slag;
using ThoriumMod.Items.Bronze;
using ThoriumMod.Items.Coral;
using ThoriumMod.Items.Darksteel;
using ThoriumMod.Items.DD;
using ThoriumMod.Items.DemonBlood;
using ThoriumMod.Items.Depths;
using ThoriumMod.Items.Donate;
using ThoriumMod.Items.Dragon;
using ThoriumMod.Items.Dread;
using ThoriumMod.Items.EarlyMagic;
using ThoriumMod.Items.Flesh;
using ThoriumMod.Items.Geode;
using ThoriumMod.Items.Granite;
using ThoriumMod.Items.HealerItems;
using ThoriumMod.Items.Icy;
using ThoriumMod.Items.Illumite;
using ThoriumMod.Items.Lodestone;
using ThoriumMod.Items.MagicItems;
using ThoriumMod.Items.Misc;
using ThoriumMod.Items.Sandstone;
using ThoriumMod.Items.Steel;
using ThoriumMod.Items.SummonItems;
using ThoriumMod.Items.Terrarium;
using ThoriumMod.Items.Thorium;
using ThoriumMod.Items.ThrownItems;
using ThoriumMod.Items.Titan;
using ThoriumMod.Items.TransformItems;
using ThoriumMod.Items.Valadium;
using ThoriumMod.Items.Vanity;
using ThoriumMod.Utilities;

namespace CalamityRuTranslate.Mods.ThoriumMod;

public class ThoriumGlobalItem : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.Thorium != null && TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        ItemHelper.TranslateTooltip(tooltips, "SetBonus", tooltip =>
        {
            Player player = Main.player[Main.myPlayer];
            string setBonusKey = Language.GetTextValue("LegacyTooltip.48");

            if (player.armor[0].type == ModContent.ItemType<WhisperingHood>() &&
                player.armor[1].type == ModContent.ItemType<WhisperingTabard>() &&
                player.armor[2].type == ModContent.ItemType<WhisperingLeggings>())
            {
                tooltip.Text = $"{setBonusKey} Периодически порождает щупальце бездонной энергии, которое атакует ближайших врагов\nУ вас может быть до шести щупалец, а наносимый ими урон похищает у поражённого врага по 1 единице здоровья и маны";
            }
            
            if (player.armor[0].type == ItemID.WizardHat &&
                player.armor[1].type == ModContent.ItemType<AquamarineRobe>() ||
                player.armor[1].type == ModContent.ItemType<OpalRobe>())
            {
                tooltip.Text = $"{setBonusKey} Увеличивает магический шанс критического удара на 10%";
            }
            
            if (player.armor[0].type == ItemID.MagicHat &&
                player.armor[1].type == ModContent.ItemType<AquamarineRobe>() ||
                player.armor[1].type == ModContent.ItemType<OpalRobe>())
            {
                tooltip.Text = $"{setBonusKey} Увеличивает максимальный запас маны на 60";
            }
            
            if (player.armor[0].type == ModContent.ItemType<FlightMask>() &&
                player.armor[1].type == ModContent.ItemType<FlightMail>() &&
                player.armor[2].type == ModContent.ItemType<FlightBoots>())
            {
                tooltip.Text = $"{setBonusKey} Теперь вы можете кратковременно летать";
            }
            
            if (player.armor[0].type == ModContent.ItemType<YewWoodHelmet>() &&
                player.armor[1].type == ModContent.ItemType<YewWoodBreastguard>() &&
                player.armor[2].type == ModContent.ItemType<YewWoodLeggings>())
            {
                tooltip.Text = $"{setBonusKey} После четырёх не критических ударов ваша следующая стрелковая атака нанесёт мини-критический удар в 150%\nМини-критические выстрелы считаются критическими ударами для соответствующих эффектов";
            }
            
            if (player.armor[0].type == ModContent.ItemType<CriersCap>() &&
                player.armor[1].type == ModContent.ItemType<CriersSash>() &&
                player.armor[2].type == ModContent.ItemType<CriersLeggings>())
            {
                tooltip.Text = $"{setBonusKey} Симфонические усиления действуют на 3 секунды дольше";
            }
            
            if (player.armor[0].type == ModContent.ItemType<CyberPunkHeadset>() &&
                player.armor[1].type == ModContent.ItemType<CyberPunkSuit>() &&
                player.armor[2].type == ModContent.ItemType<CyberPunkLeggings>())
            {
                tooltip.Text = $"{setBonusKey} При нажатии клавиши 'Способность брони' вы переключитесь между четырьмя состояниями:\nКрасное - Вы и ближайшие союзники получаете Фиксированный урон II и Урон II\nЗелёное - Вы и ближайшие союзники получаете Скорость передвижения II и Время полёта II\nФиолетовое - Вы и ближайшие союзники получаете Максимальный запас ресурсов II и Восстановление ресурсов II\nСинее - Вы и ближайшие союзники получаете Защита II и Сопротивление урону II";
            }
            
            if (player.armor[0].type == ModContent.ItemType<JestersMask>() &&
                player.armor[1].type == ModContent.ItemType<JestersShirt>() &&
                player.armor[2].type == ModContent.ItemType<JestersLeggings>())
            {
                tooltip.Text = $"{setBonusKey} При симфонических критических ударах над головой зазвонит колокол, замедляя всех ближайших врагов на короткое время";
            }
            
            if (player.armor[0].type == ModContent.ItemType<MaestroWig>() &&
                player.armor[1].type == ModContent.ItemType<MaestroSuit>() &&
                player.armor[2].type == ModContent.ItemType<MaestroLeggings>())
            {
                tooltip.Text = $"{setBonusKey} Нажатие клавиши 'Способность брони' призывает хор играющих призрачных музыкантов\nПризраки быстро наносят урон ближайшим врагам духовыми, деревянными, струнными и ударными инструментами";
            }
            
            if (player.armor[0].type == ModContent.ItemType<MarchingBandCap>() &&
                player.armor[1].type == ModContent.ItemType<MarchingBandUniform>() &&
                player.armor[2].type == ModContent.ItemType<MarchingBandLeggings>())
            {
                tooltip.Text = $"{setBonusKey} Находясь в бою, за вами следует радуга наносящих урон симфонических символов, которые следуют за вами и оглушают врагов";
            }
            
            if (player.armor[0].type == ModContent.ItemType<NoblesHat>() &&
                player.armor[1].type == ModContent.ItemType<NoblesJerkin>() &&
                player.armor[2].type == ModContent.ItemType<NoblesLeggings>())
            {
                tooltip.Text = $"{setBonusKey} Выпадающие ноты вдохновения вдвое мощнее и ненадолго увеличивают ваш симфонический урон";
            }
            
            if (player.armor[0].type == ModContent.ItemType<OrnateHat>() &&
                player.armor[1].type == ModContent.ItemType<OrnateJerkin>() &&
                player.armor[2].type == ModContent.ItemType<OrnateLeggings>())
            {
                tooltip.Text = $"{setBonusKey} Симфонические критические удары поднимают случайное активное усилие до четвёртного уровня силы\nЭтот эффект может сработать лишь один раз в 5 секунд";
            }
            
            if (player.armor[0].type == ModContent.ItemType<ShootingStarHat>() &&
                player.armor[1].type == ModContent.ItemType<ShootingStarShirt>() &&
                player.armor[2].type == ModContent.ItemType<ShootingStarBoots>())
            {
                tooltip.Text = $"{setBonusKey} Увеличивает длительность симфонических усилений на 6 секунд\nКаждое имеющееся у вас уникальное усиление увеличивает симфонический урон на 5%\nКаждое имеющееся у вас уникальное усиление увеличивает скорость восстановления вдохновения на 2%";
            }
            
            if (player.armor[0].type == ModContent.ItemType<LichCowl>() &&
                player.armor[1].type == ModContent.ItemType<LichCarapace>() &&
                player.armor[2].type == ModContent.ItemType<LichTalon>())
            {
                tooltip.Text = $"{setBonusKey} Из убитого врага можно извлечь фрагмент души\nКоснувшись фрагмента души, значительно увеличивает скорость передвижения и метания на короткое время";
            }
            
            if (player.armor[0].type == ModContent.ItemType<TideTurnerHelmet>() &&
               player.armor[1].type == ModContent.ItemType<TideTurnerBreastplate>() &&
               player.armor[2].type == ModContent.ItemType<TideTurnerGreaves>())
            {
                tooltip.Text = $"{setBonusKey} Нажатие клавиши 'Способность брони' окутывает вас непроницаемым пузырём\nПока пузырь активен, весь получаемый урон превращается в исцеление";
            }
            
            if (player.armor[0].type == ModContent.ItemType<TideTurnersGaze>() &&
                player.armor[1].type == ModContent.ItemType<TideTurnerBreastplate>() &&
                player.armor[2].type == ModContent.ItemType<TideTurnerGreaves>())
            {
                tooltip.Text = $"{setBonusKey} При нанесении метательного урона с 20% шансом выпускает вокруг вас акватические самонаводящиеся кинжалы";
            }
            
            if (player.armor[0].type == ModContent.ItemType<DreamWeaversHelmet>() &&
                player.armor[1].type == ModContent.ItemType<DreamWeaversTabard>() &&
                player.armor[2].type == ModContent.ItemType<DreamWeaversTreads>())
            {
                tooltip.Text = $"{setBonusKey} Нажатие клавиши 'Способность брони' расходует 200 маны и искривляет саму ткань реальности\nВраги сильно замедляются и получают на 15% больше урона от всех источников\nСоюзники получают значительное увеличение скорости передвижения и атаки";
            }
            
            if (player.armor[0].type == ModContent.ItemType<DreamWeaversHood>() &&
                player.armor[1].type == ModContent.ItemType<DreamWeaversTabard>() &&
                player.armor[2].type == ModContent.ItemType<DreamWeaversTreads>())
            {
                tooltip.Text = $"{setBonusKey} Нажатие клавиши 'Способность брони' расходует 200 маны и помещает вас в состояние сна\nНаходясь во сне, исцелённые союзники на короткое время становятся неуязвимыми и избавляются от всех дебаффов";
            }
            
            if (player.armor[0].type == ModContent.ItemType<MasterArbalestHood>() &&
                player.armor[1].type == ModContent.ItemType<AssassinsGuard>() &&
                player.armor[2].type == ModContent.ItemType<AssassinsWalkers>())
            {
                tooltip.Text = $"{setBonusKey} Ваш стрелковый урон с 10% шансом полностью продублирует себя и нанесёт на 15% больше урона";
            }
            
            if (player.armor[0].type == ModContent.ItemType<MasterMarksmansScouter>() &&
                player.armor[1].type == ModContent.ItemType<AssassinsGuard>() &&
                player.armor[2].type == ModContent.ItemType<AssassinsWalkers>())
            {
                tooltip.Text = $"{setBonusKey} Ваш стрелковый урон с 5% шансом полностью уничтожит поражённую цель\nЭтот эффект можно применить к боссам только в том случае, если их максимальный запас здоровья составляет менее 5%";
            }
            
            if (player.armor[0].type == ModContent.ItemType<InspiratorsHelmet>() &&
                player.armor[1].type == ModContent.ItemType<RhapsodistChestWoofer>() &&
                player.armor[2].type == ModContent.ItemType<RhapsodistBoots>())
            {
                tooltip.Text = $"{setBonusKey} Нажатие клавиши 'Способность брони' перегружает всех ближайших союзников всеми усилениями III на 15 секунд\nИспользование этой способности требует 20 единиц вдохновения и перезаряжается в течение 1 минуты";
            }
            
            if (player.armor[0].type == ModContent.ItemType<SoloistHat>() &&
                player.armor[1].type == ModContent.ItemType<RhapsodistChestWoofer>() &&
                player.armor[2].type == ModContent.ItemType<RhapsodistBoots>())
            {
                tooltip.Text = $"{setBonusKey} Нажатие клавиши 'Способность брони' даёт бесконечное вдохновение, значительно увеличивает симфонический урон и скорость игры на инструменте\nЭтот эффект длится 10 секунд и перезаряжается в течение 1 минуты";
            }
            
            if (player.armor[0].type == ModContent.ItemType<MagmaSeersMask>() &&
                player.armor[1].type == ModContent.ItemType<PyromancerTabard>() &&
                player.armor[2].type == ModContent.ItemType<PyromancerLeggings>())
            {
                tooltip.Text = $"{setBonusKey} Весь урон, наносимый миньонами, оставляет после себя ожог, который наносит значительный постепенный урон";
            }
            
            if (player.armor[0].type == ModContent.ItemType<PyromancerCowl>() &&
                player.armor[1].type == ModContent.ItemType<PyromancerTabard>() &&
                player.armor[2].type == ModContent.ItemType<PyromancerLeggings>())
            {
                tooltip.Text = $"{setBonusKey} Ваш магический урон испепеляет и наносит урон всем ближайшим врагам";
            }
            
            if (player.armor[0].type == ModContent.ItemType<BronzeHelmet>() &&
                player.armor[1].type == ModContent.ItemType<BronzeBreastplate>() &&
                player.armor[2].type == ModContent.ItemType<BronzeGreaves>())
            {
                tooltip.Text = $"{setBonusKey} Метательный урон с 20% шансом высвобождает пронзающий удар молнии";
            }
            
            if (player.armor[0].type == ModContent.ItemType<CoralHelmet>() &&
                player.armor[1].type == ModContent.ItemType<CoralChestGuard>() &&
                player.armor[2].type == ModContent.ItemType<CoralGreaves>())
            {
                tooltip.Text = $"{setBonusKey} Лучезарный урон накапливает до 20 единиц жизненного щита, и жизненный щит больше не истощается\nИсцеление союзника передаёт ему жизненный щит";
            }
            
            if (player.armor[0].type == ModContent.ItemType<DarksteelFaceGuard>() &&
                player.armor[1].type == ModContent.ItemType<DarksteelBreastPlate>() &&
                player.armor[2].type == ModContent.ItemType<DarksteelGreaves>())
            {
                tooltip.Text = $"{setBonusKey} Ничто не остановит ваше передвижение! Нажмите дважды в нужном направлении для рывка";
            }
            
            if (player.armor[0].type == ModContent.ItemType<DemonBloodHelmet>() &&
                player.armor[1].type == ModContent.ItemType<DemonBloodBreastPlate>() &&
                player.armor[2].type == ModContent.ItemType<DemonBloodGreaves>())
            {
                tooltip.Text = $"{setBonusKey} Увеличивает максимальный запас здоровья на 100";
            }
            
            if (player.armor[0].type == ModContent.ItemType<DepthDiverHelmet>() &&
                player.armor[1].type == ModContent.ItemType<DepthDiverChestplate>() &&
                player.armor[2].type == ModContent.ItemType<DepthDiverGreaves>())
            {
                tooltip.Text = $"{setBonusKey} Вы также получаете все эффекты, исходящие от вас";
            }
            
            if (player.armor[0].type == ModContent.ItemType<NagaSkinMask>() &&
                player.armor[1].type == ModContent.ItemType<NagaSkinSuit>() &&
                player.armor[2].type == ModContent.ItemType<NagaSkinTail>())
            {
                tooltip.Text = $"{setBonusKey} Каждые 75 единиц затраченной маны значительно увеличивают ваш магический урон и скорость чтения заклинаний";
            }
            
            if (player.armor[0].type == ModContent.ItemType<TideHunterCap>() &&
                player.armor[1].type == ModContent.ItemType<TideHunterChestpiece>() &&
                player.armor[2].type == ModContent.ItemType<TideHunterLeggings>())
            {
                tooltip.Text = $"{setBonusKey} Стрелковые критические удары выпускают всплеск пены, замедляя ближайших врагов";
            }
            
            if (player.armor[0].type == ModContent.ItemType<FeralFurHead>() &&
                player.armor[1].type == ModContent.ItemType<FeralFurChest>() &&
                player.armor[2].type == ModContent.ItemType<FeralFurLegs>())
            {
                tooltip.Text = $"{setBonusKey} Выглядишь хорошо!";
            }
            
            if (player.armor[0].type == ModContent.ItemType<DragonMask>() &&
                player.armor[1].type == ModContent.ItemType<DragonBreastplate>() &&
                player.armor[2].type == ModContent.ItemType<DragonGreaves>())
            {
                tooltip.Text = $"{setBonusKey} Атаки могут высвободить взрыв драконьего пламени";
            }
            
            if (player.armor[0].type == ModContent.ItemType<DreadSkull>() &&
                player.armor[1].type == ModContent.ItemType<DreadChestPlate>() &&
                player.armor[2].type == ModContent.ItemType<DreadGreaves>())
            {
                tooltip.Text = $"{setBonusKey} Ваши ботинки вибрируют с невероятной частотой, значительно увеличивая базовую скорость передвижения\nВо время движения увеличивается урон ближнего боя и шанс критического удара";
            }
            
            if (player.armor[0].type == ModContent.ItemType<SilkHat>() &&
                player.armor[1].type == ModContent.ItemType<SilkTabard>() &&
                player.armor[2].type == ModContent.ItemType<SilkLeggings>())
            {
                tooltip.Text = $"{setBonusKey} Увеличивает магический урон на 12% пока максимальный уровень маны превышает 90%";
            }
            
            if (player.armor[0].type == ModContent.ItemType<FleshMask>() &&
                player.armor[1].type == ModContent.ItemType<FleshBody>() &&
                player.armor[2].type == ModContent.ItemType<FleshLegs>())
            {
                tooltip.Text = $"{setBonusKey} При нанесении урона из поражённых врагов с 10% шансом выпадает плоть\nСобранная плоть восстанавливает здоровье и увеличивает наносимый урон";
            }
            
            if (player.armor[0].type == ModContent.ItemType<GeodeHelmet>() &&
                player.armor[1].type == ModContent.ItemType<GeodeChestplate>() &&
                player.armor[2].type == ModContent.ItemType<GeodeGreaves>())
            {
                tooltip.Text = $"{setBonusKey} Теперь можно добывать сразу целые рудные жилы";
            }
            
            if (player.armor[0].type == ModContent.ItemType<GraniteHelmet>() &&
                player.armor[1].type == ModContent.ItemType<GraniteChestGuard>() &&
                player.armor[2].type == ModContent.ItemType<GraniteGreaves>())
            {
                tooltip.Text = $"{setBonusKey} Невосприимчивость к сильному жару и вражескому отбрасыванию, но скорость передвижения значительно снижается";
            }
            
            if (player.armor[0].type == ModContent.ItemType<BioTechHood>() &&
                player.armor[1].type == ModContent.ItemType<BioTechGarment>() &&
                player.armor[2].type == ModContent.ItemType<BioTechLeggings>())
            {
                tooltip.Text = $"{setBonusKey} Биотехнологический зонд помогает вам исцелять союзников\nИсцеляет здоровье союзника на сумму, равную вашему бонусному исцелению";
            }
            
            if (player.armor[0].type == ModContent.ItemType<BloomingCrown>() &&
                player.armor[1].type == ModContent.ItemType<BloomingTabard>() &&
                player.armor[2].type == ModContent.ItemType<BloomingLeggings>())
            {
                tooltip.Text = $"{setBonusKey} Ваши заклинания исцеления увеличивают восполнение здоровья и скорость восполнения здоровья исцеляемой цели";
            }
            
            if (player.armor[0].type == ModContent.ItemType<CelestialCrown>() &&
                player.armor[1].type == ModContent.ItemType<CelestialVestment>() &&
                player.armor[2].type == ModContent.ItemType<CelestialLeggings>())
            {
                tooltip.Text = $"{setBonusKey} Нажатие клавиши 'Способность брони' призывает вокруг курсора большую ауру, затрачивая при этом 150 маны\nСоюзники, затронутые аурой, получают увеличенный урон, сопротивление урону, защиту и восполнение здоровья\nВраги, затронутые аурой, подвергаются дебаффу «{Language.GetTextValue("Mods.ThoriumMod.Buffs.HolyGlare.DisplayName")}» и получают на 15% больше урона от всех источников";
            }
            
            if (player.armor[0].type == ModContent.ItemType<EbonHood>() &&
                player.armor[1].type == ModContent.ItemType<EbonCloak>() &&
                player.armor[2].type == ModContent.ItemType<EbonLeggings>())
            {
                tooltip.Text = $"{setBonusKey} Усиливает некоторые лучезарные атаки тёмной энергией, позволяя им принимать тёмный облик и накладывать дополнительные эффекты";
            }
            
            if (player.armor[0].type == ModContent.ItemType<FallenPaladinFaceguard>() &&
                player.armor[1].type == ModContent.ItemType<FallenPaladinCuirass>() &&
                player.armor[2].type == ModContent.ItemType<FallenPaladinGreaves>())
            {
                tooltip.Text = $"{setBonusKey} При получении урона исцеляет ближайших союзников на 15% от полученного урона";
            }
            
            if (player.armor[0].type == ModContent.ItemType<IridescentHelmet>() &&
                player.armor[1].type == ModContent.ItemType<IridescentMail>() &&
                player.armor[2].type == ModContent.ItemType<IridescentGreaves>())
            {
                tooltip.Text = $"{setBonusKey} Ваш лучезарный урон с 15% шансом выпускает ослепительную вспышку света\nВспышка исцеляет ближайших союзников на сумму, равную вашему бонусному исцелению, и накладывает на врагов дебафф «{Language.GetTextValue("BuffName.Confused")}»";
            }
            
            if (player.armor[0].type == ModContent.ItemType<LifeBinderMask>() &&
                player.armor[1].type == ModContent.ItemType<LifeBinderBreastplate>() &&
                player.armor[2].type == ModContent.ItemType<LifeBinderGreaves>())
            {
                tooltip.Text = $"{setBonusKey} Исцеляющие заклинания на короткое время увеличивают максимальный запас здоровья исцелённого игрока на 50";
            }
            
            if (player.armor[0].type == ModContent.ItemType<NoviceClericCowl>() &&
                player.armor[1].type == ModContent.ItemType<NoviceClericTabard>() &&
                player.armor[2].type == ModContent.ItemType<NoviceClericPants>())
            {
                tooltip.Text = $"{setBonusKey} Каждые 5 секунд генерируется до 3 святых крестов\nПри произнесении исцеляющих заклинаний крест расходуется вместо маны";
            }
            
            if (player.armor[0].type == ModContent.ItemType<SacredHelmet>() &&
                player.armor[1].type == ModContent.ItemType<SacredBreastplate>() &&
                player.armor[2].type == ModContent.ItemType<SacredLeggings>())
            {
                tooltip.Text = $"{setBonusKey} Исцеляющие заклинания восстанавливают дополнительно 5 единиц здоровья";
            }
            
            if (player.armor[0].type == ModContent.ItemType<TemplarsCirclet>() &&
                player.armor[1].type == ModContent.ItemType<TemplarsTabard>() &&
                player.armor[2].type == ModContent.ItemType<TemplarsLeggings>())
            {
                tooltip.Text = $"{setBonusKey} Увеличивает вашу способность к исцелению, если у союзника меньше половины здоровья";
            }
            
            if (player.armor[0].type == ModContent.ItemType<WarlockHood>() &&
                player.armor[1].type == ModContent.ItemType<WarlockGarb>() &&
                player.armor[2].type == ModContent.ItemType<WarlockLeggings>())
            {
                tooltip.Text = $"{setBonusKey} Лучезарные атаки могут сформировать до 15 теневых огоньков\nНажатие клавиши 'Способность брони' высвобождает все накопленные теневые огоньки в направлении курсора";
            }
            
            if (player.armor[0].type == ModContent.ItemType<IcyHeadgear>() &&
                player.armor[1].type == ModContent.ItemType<IcyMail>() &&
                player.armor[2].type == ModContent.ItemType<IcyGreaves>())
            {
                tooltip.Text = $"{setBonusKey} Вас окружает оледенелая аура, замораживающая врагов, которые находятся в её пределах слишком долго";
            }
            
            if (player.armor[0].type == ModContent.ItemType<IllumiteMask>() &&
                player.armor[1].type == ModContent.ItemType<IllumiteChestplate>() &&
                player.armor[2].type == ModContent.ItemType<IllumiteGreaves>())
            {
                tooltip.Text = $"{setBonusKey} Луки, пушки и пусковые установки периодически выпускают дополнительные снаряды";
            }
            
            if (player.armor[0].type == ModContent.ItemType<LodeStoneFaceGuard>() &&
                player.armor[1].type == ModContent.ItemType<LodeStoneChestGuard>() &&
                player.armor[2].type == ModContent.ItemType<LodeStoneShinGuards>())
            {
                tooltip.Text = $"{setBonusKey} Увеличивает сопротивление урону на 6% за каждые 25% потерянного здоровья\nМаксимальное сопротивление урону составляет 18% при уровне здоровья ниже 25%";
            }
            
            if (player.armor[0].type == ModContent.ItemType<CryomancersCrown>() &&
                player.armor[1].type == ModContent.ItemType<CryomancersTabard>() &&
                player.armor[2].type == ModContent.ItemType<CryomancersLeggings>())
            {
                tooltip.Text = $"{setBonusKey} Ваш магический урон замораживает врагов на две секунды";
            }
            
            if (player.armor[0].type == ModContent.ItemType<WhiteKnightMask>() &&
                player.armor[1].type == ModContent.ItemType<WhiteKnightTabard>() &&
                player.armor[2].type == ModContent.ItemType<WhiteKnightLeggings>())
            {
                tooltip.Text = $"{setBonusKey} 40% затраченной маны хранится в виде энергии, до максимума в [c/99ccff:{player.statManaMax2 * 2}] единиц\nНажатие клавиши 'Способность брони' позволяет израсходовать энергию на восстановление до [c/99ccff:{player.statManaMax2}] единиц маны и [c/bffdbd:{(int) (player.statManaMax2 * 0.1f)}] единиц здоровья за раз";
            }
            
            if (player.armor[0].type == ModContent.ItemType<ConduitHelmet>() &&
                player.armor[1].type == ModContent.ItemType<ConduitSuit>() &&
                player.armor[2].type == ModContent.ItemType<ConduitLeggings>())
            {
                tooltip.Text = $"{setBonusKey} При движении формируются до 5 неподвижных колец, каждое из которых образует жизненный щит\nКогда жизненный щит полностью заряжен, кольца заменяются энергетическим пузырём, который защищает игрока от одной атаки\nКогда пузырь блокирует атаку, в ближайших врагов выпускается электрический разряд";
            }
            
            if (player.armor[0].type == ModContent.ItemType<HallowedChapeau>() &&
                player.armor[1].type is 551 or 4900 &&
                player.armor[2].type is 552 or 4901)
            {
                tooltip.Text = $"{setBonusKey} После удара по врагу вы становитесь неуязвимым; увеличивает длительность симфонических усилений на 8 секунд";
            }
            
            if (player.armor[0].type == ModContent.ItemType<HallowedCowl>() &&
                player.armor[1].type is 551 or 4900 &&
                player.armor[2].type is 552 or 4901)
            {
                tooltip.Text = $"{setBonusKey} После удара по врагу вы становитесь неуязвимым; исцеляющие заклинания восстанавливают дополнительно 6 единиц здоровья";
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
            
            if (player.armor[0].type == ModContent.ItemType<DurasteelHelmet>() &&
                player.armor[1].type == ModContent.ItemType<DurasteelChestplate>() &&
                player.armor[2].type == ModContent.ItemType<DurasteelGreaves>())
            {
                tooltip.Text = $"{setBonusKey} Увеличивает сопротивление урону на 10%";
            }
            
            if (player.armor[0].type == ModContent.ItemType<SteelHelmet>() &&
                player.armor[1].type == ModContent.ItemType<SteelChestplate>() &&
                player.armor[2].type == ModContent.ItemType<SteelGreaves>())
            {
                tooltip.Text = $"{setBonusKey} Увеличивает сопротивление урону на 8%";
            }
            
            if (player.armor[0].type == ModContent.ItemType<AstroHelmet>() &&
                player.armor[1].type == ModContent.ItemType<AstroSuit>() &&
                player.armor[2].type == ModContent.ItemType<AstroBoots>())
            {
                tooltip.Text = $"{setBonusKey} Атаки миньонов могут вызвать выброс разрушительной плазмы";
            }
            
            if (player.armor[0].type == ModContent.ItemType<LifeBloomMask>() &&
                player.armor[1].type == ModContent.ItemType<LifeBloomMail>() &&
                player.armor[2].type == ModContent.ItemType<LifeBloomLeggings>())
            {
                tooltip.Text = $"{setBonusKey} Атаки миньонов с 25% шансом исцеляют вас\nОднако исцеление ограничено 50 единицами каждые 10 секунд";
            }
            
            if (player.armor[0].type == ModContent.ItemType<LivingWoodMask>() &&
                player.armor[1].type == ModContent.ItemType<LivingWoodChestguard>() &&
                player.armor[2].type == ModContent.ItemType<LivingWoodBoots>())
            {
                tooltip.Text = $"{setBonusKey} Увеличивает призываемое число миньонов на 1\nАвтоатаки вашего ростка живого дерева самонаводятся на врагов";
            }
            
            if (player.armor[0].type == ModContent.ItemType<SpiritTrapperHelmet>() &&
                player.armor[1].type == ModContent.ItemType<SpiritTrapperCuirass>() &&
                player.armor[2].type == ModContent.ItemType<SpiritTrapperGreaves>())
            {
                tooltip.Text = $"{setBonusKey} Увеличивает призываемое число миньонов на 1\nУбийство врагов или непрерывное нанесение урона боссам создаёт огоньки души\nПосле накопления 5 огоньков, они мгновенно поглощаются и восстанавливают 10 единиц здоровья";
            }
            
            if (player.armor[0].type == ModContent.ItemType<SpiritTrapperMask>() &&
                player.armor[1].type == ModContent.ItemType<SpiritTrapperCuirass>() &&
                player.armor[2].type == ModContent.ItemType<SpiritTrapperGreaves>())
            {
                tooltip.Text = $"{setBonusKey} Увеличивает призываемое число стражей на 1\nУбийство врагов или непрерывное нанесение урона боссам создаёт огоньки души\nПосле накопления 5 огоньков, они мгновенно поглощаются и восстанавливают 10 единиц здоровья";
            }
            
            if (player.armor[0].type == ModContent.ItemType<TerrariumHelmet>() &&
                player.armor[1].type == ModContent.ItemType<TerrariumBreastPlate>() &&
                player.armor[2].type == ModContent.ItemType<TerrariumGreaves>())
            {
                tooltips.ReplaceText("The energies of Terraria will seek to protect you when you're in combat", "Энергии Террарии будут защищать вас, когда вы находитесь в бою");
                tooltips.ReplaceText("Melee Focus: 15% increased damage reduction", "Сосредоточенность ближнего боя: увеличивает сопротивление урону на 15%");
                tooltips.ReplaceText("Ranged Focus: 15% increased firing speed", "Стрелковая сосредоточенность: увеличивает скорострельность на 15%");
                tooltips.ReplaceText("Magic Focus: Maximum mana increased by 100", "Магическая сосредоточенность: увеличивает максимальный запас маны на 100");
                tooltips.ReplaceText("Summon Focus: Increases your max number of minions by 3", "Сосредоточенность призывателя: увеличивает призываемое число миньонов на 3");
                tooltips.ReplaceText("Thrown Focus: Increases your maximum technique points by 2", "Метательная сосредоточенность: Увеличивает максимальное число очков техники на 2");
                tooltips.ReplaceText("Radiant Focus: Healing spells will heal an additional 3 life", "Лучезарная сосредоточенность: исцеляющие заклинания восстанавливают дополнительно 3 единицы здоровья");
                tooltips.ReplaceText("Symphonic Focus: Increases empowerment duration by 6 seconds", "Симфоническая сосредоточенность: увеличивает длительность усилений на 6 секунд");
                tooltips.ReplaceText("No Focus: 20% increased damage", "Нет сосредоточенности: увеличивает урон на 20%");
            }
            
            if (player.armor[0].type == ModContent.ItemType<ThoriumHelmet>() &&
                player.armor[1].type == ModContent.ItemType<ThoriumMail>() &&
                player.armor[2].type == ModContent.ItemType<ThoriumGreaves>())
            {
                tooltip.Text = $"{setBonusKey} Увеличивает урон на 10%";
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
                tooltip.Text = $"{setBonusKey} Критические удары высвобождают из космоса изумрудные вспышки\nИзумрудные вспышки наносят урон, равный 0.1% максимального здоровья цели";
            }
            
            if (player.armor[0].type == ModContent.ItemType<TitanHeadgear>() &&
                player.armor[1].type == ModContent.ItemType<TitanBreastplate>() &&
                player.armor[2].type == ModContent.ItemType<TitanGreaves>())
            {
                tooltip.Text = $"{setBonusKey} Увеличивает наносимый урон на 18%";
            }
            
            if (player.armor[0].type == ModContent.ItemType<TitanHelmet>() &&
                player.armor[1].type == ModContent.ItemType<TitanBreastplate>() &&
                player.armor[2].type == ModContent.ItemType<TitanGreaves>())
            {
                tooltip.Text = $"{setBonusKey} Увеличивает наносимый урон на 18%";
            }
            
            if (player.armor[0].type == ModContent.ItemType<TitanMask>() &&
                player.armor[1].type == ModContent.ItemType<TitanBreastplate>() &&
                player.armor[2].type == ModContent.ItemType<TitanGreaves>())
            {
                tooltip.Text = $"{setBonusKey} Увеличивает наносимый урон на 18%";
            }
            
            if (player.armor[0].type == ModContent.ItemType<ValadiumHelmet>() &&
                player.armor[1].type == ModContent.ItemType<ValadiumBreastPlate>() &&
                player.armor[2].type == ModContent.ItemType<ValadiumGreaves>())
            {
                tooltip.Text = $"{setBonusKey} Нажмите ВВЕРХ для изменения гравитации. В перевёрнутом состоянии увеличивает стрелковый урон на 15%";
            }
            
            if (player.armor[0].type == ModContent.ItemType<BlueKnightHelmet>() &&
                player.armor[1].type == ModContent.ItemType<BlueKnightArmor>() &&
                player.armor[2].type == ModContent.ItemType<BlueKnightGreaves>())
            {
                tooltip.Text = $"{setBonusKey} Выглядишь хорошо!";
            }
            
            if (player.armor[0].type == ModContent.ItemType<GlitteringHelmet>() &&
                player.armor[1].type == ModContent.ItemType<GlitteringChestplate>() &&
                player.armor[2].type == ModContent.ItemType<GlitteringGreaves>())
            {
                tooltip.Text = $"{setBonusKey} Выглядишь хорошо!";
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
                tooltips.ReplaceText("Right click to blow a larger bubble that stuns enemies or replenishes ally breath", "Нажмите ПКМ, чтобы надуть огромный пузырь, который оглушает врагов или пополняет запас воздуха союзника");
                tooltips.ReplaceText("Right click to spit a bouncing globule of blood at the cost of 4 life", "Нажмите ПКМ, чтобы выплюнуть отскакивающую каплю крови ценой 4 единиц здоровья");
                tooltips.ReplaceText("Right click to belch a volley of coins", "Нажмите ПКМ, чтобы изрыгнуть залпом монет");
                tooltips.ReplaceText("Right click to harden your carapace, giving you damage reduction and a thorns effect briefly", "");
                tooltips.ReplaceText("Right click to drop a large scale timed explosive", "Нажмите ПКМ, чтобы установить большой взрывчатый заряд с таймером");
                tooltips.ReplaceText("Allows you to use unique abilities while transformed", "Позволяет использовать уникальные способности во время превращения");
            });
            
            ItemHelper.TranslateTooltip(tooltips, "transformationText2", _ =>
            {
                tooltips.ReplaceText("Left click to dash forward, damaging an enemy in the process", "Нажмите ЛКМ, чтобы выполнить рывок вперёд, нанося урон врагам в процессе");
                tooltips.ReplaceText("Left click to spit a heavy bubble that deals increased damage to poisoned enemies", "Нажмите ЛКМ, чтобы выплюнуть тяжёлый пузырь, который наносит увеличенный урон отравленным врагам");
                tooltips.ReplaceText("Left click to spit a stream of burning lava", "Нажмите ЛКМ, чтобы выплюнуть струю раскалённой лавы");
                tooltips.ReplaceText("Left click to release a water-bound bubble stream", "Нажмите ЛКМ, чтобы запустить водяной поток из пузырей");
                tooltips.ReplaceText("Left click to fire pair of life stealing teeth", "Нажмите ЛКМ, чтобы запустить пару зубов, крадущих здоровье врагов");
                tooltips.ReplaceText("Left click to leap forward, damaging an enemy in the process", "Нажмите ЛКМ, чтобы совершить скачок вперёд и при этом нанести урон врагу");
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

        if (item.type == ModContent.ItemType<MusiciansHandbook>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "transformationText", tooltip =>
            {
                tooltip.Text = $"Ваши инструменты играют на {tooltip.Text.Split(' ')[3]} быстрее";
            });
        }
        
        if (item.type == ModContent.ItemType<TerrariumAutoharp>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "transformationText", _ =>
            {
                tooltips.ReplaceText("Variety I", "Вариативность I");
                tooltips.ReplaceText("Playing empowers players with bonus:", "Игра на инструменте даёт игрокам усиление:");
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
                    tooltip.Text = $"Игроки могут использовать врата лишь раз в {duration} {secondsSuffix}";
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
                string seconds = LocalizedText.ApplyPluralization("{^0:секунда;секунды;секунд}", healBonus);
                tooltip.Text = $"Увеличивает урон всех ближайших союзников на 20% на [c/5aff5a:{healBonus}] {seconds}";
            });
        }
        
        if (item.type == ModContent.ItemType<HolyHammer>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "HealerAmount", tooltip =>
            {
                tooltips.ReplaceText("Right click to heal all nearby allies equal to your bonus healing", "Нажмите ПКМ, чтобы исцелить всех ближайших союзников на сумму, равную вашему бонусному исцелению");
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
        
        if (item.type == ModContent.ItemType<MartyrChalice>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "HealerAmount", tooltip =>
            {
                tooltip.Text = $"Жертвует вашей жизнью, чтобы исцелить всех союзников в мире на {tooltip.Text.Split(' ')[12]} ед. здоровья";
            });
        }
        
        if (item.type == ModContent.ItemType<NecroticStaff>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "lifeCost", tooltip =>
            {
                tooltip.Text = "Использует 2.5% вашего максимального запаса здоровья";
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
        
        if (item.type == ModContent.ItemType<TwilightStaff>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Name == "UseMana", _ =>
            {
                tooltips.ReplaceText("Uses", "Использует");
                tooltips.ReplaceText("mana &", "ед. маны и");
                tooltips.ReplaceText("life", "ед. здоровья");
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
        
        if (item.type == ModContent.ItemType<LifeQuartzClaymore>() || item.type == ModContent.ItemType<BloodTransfusion>() ||
            item.type == ModContent.ItemType<LeechBolt>() || item.type == ModContent.ItemType<SpiritBendersStaff>() ||
            item.type == ModContent.ItemType<SpiritBlastWand>())
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
        
        if (item.type == ModContent.ItemType<TheGoodBook>() || item.type == ModContent.ItemType<StarRod>() ||
            item.type == ModContent.ItemType<DarkMageStaff>() || item.type == ModContent.ItemType<BalanceBloom>() ||
            item.type == ModContent.ItemType<CellReconstructor>() || item.type == ModContent.ItemType<ChiLantern>() ||
            item.type == ModContent.ItemType<CosmicFluxStaff>() || item.type == ModContent.ItemType<CrystalWish>() ||
            item.type == ModContent.ItemType<Hippocraticrossbow>() || item.type == ModContent.ItemType<BarrierGenerator>() ||
            item.type == ModContent.ItemType<BrainCoral>() || item.type == ModContent.ItemType<CelestialWand>() ||
            item.type == ModContent.ItemType<CleansingWaterPouch>() || item.type == ModContent.ItemType<CoralPurifier>() ||
            item.type == ModContent.ItemType<Cryotherapy>() || item.type == ModContent.ItemType<DivineStaff>() ||
            item.type == ModContent.ItemType<EaterOfPain>() || item.type == ModContent.ItemType<Gauze>() ||
            item.type == ModContent.ItemType<HeartWand>() || item.type == ModContent.ItemType<HoneySuckle>() ||
            item.type == ModContent.ItemType<LethalInjection>() || item.type == ModContent.ItemType<LifeAndDeath>() ||
            item.type == ModContent.ItemType<LifeEssenceApparatus>() || item.type == ModContent.ItemType<LifesGift>() ||
            item.type == ModContent.ItemType<LifeSurgeStaff>() || item.type == ModContent.ItemType<LightBurstWand>() ||
            item.type == ModContent.ItemType<MistWeaver>() || item.type == ModContent.ItemType<MolecularStabilizer>() ||
            item.type == ModContent.ItemType<PocketGuardian>() || item.type == ModContent.ItemType<Prophecy>() ||
            item.type == ModContent.ItemType<RasWhisper>() || item.type == ModContent.ItemType<RecoveryWand>() ||
            item.type == ModContent.ItemType<SacredCharge>() || item.type == ModContent.ItemType<StaffofSol>() ||
            item.type == ModContent.ItemType<SunrayStaff>() || item.type == ModContent.ItemType<Syringe>() ||
            item.type == ModContent.ItemType<TemplarsGrace>() || item.type == ModContent.ItemType<TeslaDefibrillator>() ||
            item.type == ModContent.ItemType<TheGigaNeedle>() || item.type == ModContent.ItemType<TranquilLyre>() ||
            item.type == ModContent.ItemType<TwilightStaff>())
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
                    tooltip.Text = "Лечит союзника и игрока на сумму, равную вашему бонусному исцелению";
                }
            });
        }
        
        if (item.type == ModContent.ItemType<LifeDisperser>() || item.type == ModContent.ItemType<HereticBreaker>() ||
            item.type == ModContent.ItemType<IridescentStaff>())
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "HealerAmount", tooltip =>
            {
                string[] parts = tooltip.Text.Split(' ');
                if (tooltip.Text == $"Heals ally life by {parts[4]}")
                {
                    tooltip.Text = $"Лечит союзника на {parts[4]} ед. здоровья";
                }
                
                if (tooltip.Text == "Heals ally life equal to your bonus healing")
                {
                    tooltip.Text = "Лечит союзника на сумму, равную вашему бонусному исцелению";
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
                    tooltip.Text = "Лечит союзника и игрока на сумму, равную вашему бонусному исцелению (максимум 5 единиц)";
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
                    tooltip.Text = "Лечит союзника на сумму, равную вашему бонусному исцелению (максимум 5 единиц)";
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
                    tooltip.Text = "Лечит союзника и игрока на сумму, равную вашему бонусному исцелению (максимум 4 единиц)";
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
        
        ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "CookText", tooltip =>
        {
            tooltip.Text = $"Повар, возможно, заинтересуется этим: {tooltip.Text.Split(' ')[7]} / {tooltip.Text.Split(' ')[9]}";
        });
        
        ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "BardTag", tooltip =>
        {
            tooltip.Text = "-Бард-";
        });
        
        ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "InstrumentTag", _ =>
        {
            tooltips.ReplaceText("Instrument", "инструмент");
        });
        
        ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "PrefixEmpowermentDuration", tooltip =>
        {
            tooltips.ReplaceText("s empowerment duration", "");
            string[] parts = tooltip.Text.Split(' ');
            string duration = parts[0];
            if (int.TryParse(duration, out int seconds))
            {
                string secondsSuffix = seconds is 1 or -1 ? "секунда" : "секунды";
                tooltip.Text = $"{duration} {secondsSuffix} к длительности усиления";
            }
        });
        
        ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "ThoriumMod" && l.Name == "InspirationCost", tooltip =>
        {
            string[] parts = tooltip.Text.Split(' ');
            string costValue = parts[1];
            if (int.TryParse(costValue, out int value))
            {
                string valueSuffix = LocalizedText.ApplyPluralization("{^0:очко;очка;очков}", value);
                tooltip.Text = $"Использует {costValue} {valueSuffix} вдохновения";
            }
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
        
        ItemHelper.TranslateTooltip(tooltips, l => l.Name == "ThrowerAmount", _ =>
        {
            tooltips.ReplaceText("Hold right click to store up to", "Удерживайте ПКМ, чтобы накопить до");
            tooltips.ReplaceText("needles", "игл");
        });
    }
}