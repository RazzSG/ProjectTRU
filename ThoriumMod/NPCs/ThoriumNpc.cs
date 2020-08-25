﻿using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ThoriumMod.NPCs
{
	internal class ThoriumNpc
	{
		public static void Setup()
		{
			Npc();
		}
		
		private static void Npc()
		{
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			
			thorium.GetNPC("RockBoulderMimic").DisplayName.AddTranslation(GameCulture.Russian, "Булыжник");
			thorium.GetNPC("MoltenBoulderMimic").DisplayName.AddTranslation(GameCulture.Russian, "Булыжник");
			thorium.GetNPC("DesertBoulderMimic").DisplayName.AddTranslation(GameCulture.Russian, "Булыжник");
			thorium.GetNPC("IceBoulderMimic").DisplayName.AddTranslation(GameCulture.Russian, "Булыжник");
			thorium.GetNPC("Illusionist").DisplayName.AddTranslation(GameCulture.Russian, "Иллюзионист");
			thorium.GetNPC("IllusionistBolt").DisplayName.AddTranslation(GameCulture.Russian, "Иллюзорное стекло");
			thorium.GetNPC("IllusionistDecoy").DisplayName.AddTranslation(GameCulture.Russian, "Иллюзионист");
			thorium.GetNPC("IllusionistMirror").DisplayName.AddTranslation(GameCulture.Russian, "Зеркало иллюзиониста");
			thorium.GetNPC("IllusionistSpawn").DisplayName.AddTranslation(GameCulture.Russian, "Причудливое зеркало");
			thorium.GetNPC("JungleBoulderMimic").DisplayName.AddTranslation(GameCulture.Russian, "Булыжник");
			thorium.GetNPC("AggroDummy").DisplayName.AddTranslation(GameCulture.Russian, "Злобный манекен");
			thorium.GetNPC("AncientArcher").DisplayName.AddTranslation(GameCulture.Russian, "Древний лучник");
			thorium.GetNPC("AncientCharger").DisplayName.AddTranslation(GameCulture.Russian, "Древний набрасыватель");
			thorium.GetNPC("AncientPhalanx").DisplayName.AddTranslation(GameCulture.Russian, "Древний воин");
			thorium.GetNPC("ArmyAnt").DisplayName.AddTranslation(GameCulture.Russian, "Муравей-военный");
			thorium.GetNPC("AstroBeetle").DisplayName.AddTranslation(GameCulture.Russian, "Космический жук");
			thorium.GetNPC("BabyBaliNpc").DisplayName.AddTranslation(GameCulture.Russian, "Майна");
			thorium.GetNPC("BabySpider").DisplayName.AddTranslation(GameCulture.Russian, "Паук-малыш");
			thorium.GetNPC("BabySpiderWall").DisplayName.AddTranslation(GameCulture.Russian, "Паук-малыш");
			thorium.GetNPC("BatOutaHell").DisplayName.AddTranslation(GameCulture.Russian, "Летучая мышь из Ада");
			thorium.GetNPC("BigBone").DisplayName.AddTranslation(GameCulture.Russian, "Большой скелет");
			thorium.GetNPC("Biter").DisplayName.AddTranslation(GameCulture.Russian, "Кусатель");
			thorium.GetNPC("Blacksmith").DisplayName.AddTranslation(GameCulture.Russian, "Кузнец");
			thorium.GetNPC("BlackWidow").DisplayName.AddTranslation(GameCulture.Russian, "Чёрная вдова");
			thorium.GetNPC("BlackWidowWall").DisplayName.AddTranslation(GameCulture.Russian, "Чёрная вдова");
			thorium.GetNPC("Blister").DisplayName.AddTranslation(GameCulture.Russian, "Волдырь");
			thorium.GetNPC("BlisterPod").DisplayName.AddTranslation(GameCulture.Russian, "Вскочивший волдырь");
			thorium.GetNPC("BloomMahoganyEnt").DisplayName.AddTranslation(GameCulture.Russian, "Энт из красного дерева");
			thorium.GetNPC("BoneFlayer").DisplayName.AddTranslation(GameCulture.Russian, "Костяной живодёр");
			thorium.GetNPC("BrownRecluse").DisplayName.AddTranslation(GameCulture.Russian, "Коричневый отшельник");
			thorium.GetNPC("BrownRecluseBaby").DisplayName.AddTranslation(GameCulture.Russian, "Отшельник-малыш");
			thorium.GetNPC("BrownRecluseBabyWall").DisplayName.AddTranslation(GameCulture.Russian, "Отшельник-малыш");
			thorium.GetNPC("BrownRecluseWall").DisplayName.AddTranslation(GameCulture.Russian, "Коричневый отшельник");
			thorium.GetNPC("BulletAnt").DisplayName.AddTranslation(GameCulture.Russian, "Муравей-пуля");
			thorium.GetNPC("ChilledCannon").DisplayName.AddTranslation(GameCulture.Russian, "Ледовая пушка");
			thorium.GetNPC("ChilledSpitter").DisplayName.AddTranslation(GameCulture.Russian, "Ледовый плевун");
			thorium.GetNPC("Clot").DisplayName.AddTranslation(GameCulture.Russian, "Тромб");
			thorium.GetNPC("Cobbler").DisplayName.AddTranslation(GameCulture.Russian, "Сапожник");
			thorium.GetNPC("CoinBagCopper").DisplayName.AddTranslation(GameCulture.Russian, "Мешок с медными монетами");
			thorium.GetNPC("CoinBagGold").DisplayName.AddTranslation(GameCulture.Russian, "Мешок с золотыми монетами");
			thorium.GetNPC("CoinBagSilver").DisplayName.AddTranslation(GameCulture.Russian, "Мешок с серебряными монетами");
			thorium.GetNPC("Coldling").DisplayName.AddTranslation(GameCulture.Russian, "Холдлинг");
			thorium.GetNPC("ConfusedZombie").DisplayName.AddTranslation(GameCulture.Russian, "Растерянный зомби");
			thorium.GetNPC("Cook").DisplayName.AddTranslation(GameCulture.Russian, "Повар");
			thorium.GetNPC("Coolmera").DisplayName.AddTranslation(GameCulture.Russian, "Холдмера");
			thorium.GetNPC("CrimipedeBody").DisplayName.AddTranslation(GameCulture.Russian, "Кровоножка");
			thorium.GetNPC("CrimipedeHead").DisplayName.AddTranslation(GameCulture.Russian, "Кровоножка");
			thorium.GetNPC("CrimipedeTail").DisplayName.AddTranslation(GameCulture.Russian, "Кровоножка");
			thorium.GetNPC("DarksteelKnight").DisplayName.AddTranslation(GameCulture.Russian, "Тёмный рыцарь");
			thorium.GetNPC("DesertTraveler").DisplayName.AddTranslation(GameCulture.Russian, "Служитель пустыни");
			thorium.GetNPC("DissonanceSeer").DisplayName.AddTranslation(GameCulture.Russian, "Провидец диссонанса");
			thorium.GetNPC("Diverman").DisplayName.AddTranslation(GameCulture.Russian, "Водолаз");
			thorium.GetNPC("Druid").DisplayName.AddTranslation(GameCulture.Russian, "Друид");
			thorium.GetNPC("DummyEnemy").DisplayName.AddTranslation(GameCulture.Russian, "Манекен-противник");
			thorium.GetNPC("EarthenBat").DisplayName.AddTranslation(GameCulture.Russian, "Земляная летучая мышь");
			thorium.GetNPC("EarthenGolem").DisplayName.AddTranslation(GameCulture.Russian, "Земляной голем");
			thorium.GetNPC("EpiDermon").DisplayName.AddTranslation(GameCulture.Russian, "Кожный демон");
			thorium.GetNPC("FesteringSprinter").DisplayName.AddTranslation(GameCulture.Russian, "Гнойный бегун");
			thorium.GetNPC("FesteringWalker").DisplayName.AddTranslation(GameCulture.Russian, "Гнойный ходок");
			thorium.GetNPC("FireAnt").DisplayName.AddTranslation(GameCulture.Russian, "Муравей-военный");
			thorium.GetNPC("FlamekinCaster").DisplayName.AddTranslation(GameCulture.Russian, "Огнерождённый маг");
			thorium.GetNPC("FlyingBioMass").DisplayName.AddTranslation(GameCulture.Russian, "Летающая био-масса");
			thorium.GetNPC("Freezer").DisplayName.AddTranslation(GameCulture.Russian, "Замороз");
			thorium.GetNPC("FrostFang").DisplayName.AddTranslation(GameCulture.Russian, "Морозный клык");
			thorium.GetNPC("FrostFangWall").DisplayName.AddTranslation(GameCulture.Russian, "Морозный клык");
			thorium.GetNPC("FrostWormBody").DisplayName.AddTranslation(GameCulture.Russian, "Морозный червь");
			thorium.GetNPC("FrostWormHead").DisplayName.AddTranslation(GameCulture.Russian, "Морозный червь");
			thorium.GetNPC("FrostWormTail").DisplayName.AddTranslation(GameCulture.Russian, "Морозный червь");
			thorium.GetNPC("FrostyWisp").DisplayName.AddTranslation(GameCulture.Russian, "Морозный висп");
			thorium.GetNPC("FrozenFace").DisplayName.AddTranslation(GameCulture.Russian, "Заледенелый лицемонстр");
			thorium.GetNPC("FrozenGross").DisplayName.AddTranslation(GameCulture.Russian, "Заледенелый поганец");
			thorium.GetNPC("GelatinousCube").DisplayName.AddTranslation(GameCulture.Russian, "Желатиновый куб");
			thorium.GetNPC("GelatinousSludge").DisplayName.AddTranslation(GameCulture.Russian, "Шлак");
			thorium.GetNPC("GildedBat").DisplayName.AddTranslation(GameCulture.Russian, "Позолоченная летучая мышь");
			thorium.GetNPC("GildedLycan").DisplayName.AddTranslation(GameCulture.Russian, "Позолоченный ликан");
			thorium.GetNPC("GildedSlime").DisplayName.AddTranslation(GameCulture.Russian, "Позолоченный слизень");
			thorium.GetNPC("GildedSlimeMini").DisplayName.AddTranslation(GameCulture.Russian, "Позолоченный слизнячок");
			thorium.GetNPC("GlitteringGolem").DisplayName.AddTranslation(GameCulture.Russian, "Сверкающий голем");
			thorium.GetNPC("Gnome1").DisplayName.AddTranslation(GameCulture.Russian, "Гном");
			thorium.GetNPC("Gnome2").DisplayName.AddTranslation(GameCulture.Russian, "Гном");
			thorium.GetNPC("Gnome3").DisplayName.AddTranslation(GameCulture.Russian, "Гном");
			thorium.GetNPC("Gnome4").DisplayName.AddTranslation(GameCulture.Russian, "Гном");
			thorium.GetNPC("Gnomes").DisplayName.AddTranslation(GameCulture.Russian, "Банда гномов");
			thorium.GetNPC("GoblinDrummer").DisplayName.AddTranslation(GameCulture.Russian, "Гоблин-барабанщик");
			thorium.GetNPC("GoblinSpiritGuide").DisplayName.AddTranslation(GameCulture.Russian, "Гоблин, проводник духов");
			thorium.GetNPC("GoblinTrapper").DisplayName.AddTranslation(GameCulture.Russian, "Гоблин-охотник");
			thorium.GetNPC("GoldDuck").DisplayName.AddTranslation(GameCulture.Russian, "Золотая утка");
			thorium.GetNPC("GoldDuck1").DisplayName.AddTranslation(GameCulture.Russian, "Золотая утка");
			thorium.GetNPC("GraniteEradicator").DisplayName.AddTranslation(GameCulture.Russian, "Гранитный ликвидатор");
			thorium.GetNPC("GraniteFusedSlime").DisplayName.AddTranslation(GameCulture.Russian, "Зараженный гранитом слизень");
			thorium.GetNPC("GraniteSurger").DisplayName.AddTranslation(GameCulture.Russian, "Гранитный всплеск");
			thorium.GetNPC("HellBringerMimic").DisplayName.AddTranslation(GameCulture.Russian, "Адский подражатель");
			thorium.GetNPC("HoppingSpider").DisplayName.AddTranslation(GameCulture.Russian, "Паук-попрыгун");
			thorium.GetNPC("HorrificCharger").DisplayName.AddTranslation(GameCulture.Russian, "Ужасающий набрасыватель");
			thorium.GetNPC("InfernalHound").DisplayName.AddTranslation(GameCulture.Russian, "Инфернальная гончая");
			thorium.GetNPC("Invader").DisplayName.AddTranslation(GameCulture.Russian, "Враждебный вторженец");
			thorium.GetNPC("LihzardMimic").DisplayName.AddTranslation(GameCulture.Russian, "Храмовый подражатель");
			thorium.GetNPC("LihzardPotMimic1").DisplayName.AddTranslation(GameCulture.Russian, "Храмовый горшок");
			thorium.GetNPC("LihzardPotMimic2").DisplayName.AddTranslation(GameCulture.Russian, "Храмовый горшок");
			thorium.GetNPC("LifeCrystalMimic").DisplayName.AddTranslation(GameCulture.Russian, "Кристалл жизни-подражатель");
			thorium.GetNPC("LivingHemorage").DisplayName.AddTranslation(GameCulture.Russian, "Кровоизлияние");
			thorium.GetNPC("LostProbe").DisplayName.AddTranslation(GameCulture.Russian, "Потерявшийся зонд");
			thorium.GetNPC("Lycan").DisplayName.AddTranslation(GameCulture.Russian, "Ликан");
			thorium.GetNPC("MahoganyEnt").DisplayName.AddTranslation(GameCulture.Russian, "Энт из красного дерева");
			thorium.GetNPC("MoltenMortar").DisplayName.AddTranslation(GameCulture.Russian, "Раскаленная мортира");
			thorium.GetNPC("MossWasp").DisplayName.AddTranslation(GameCulture.Russian, "Мшистая оса");
			thorium.GetNPC("MudMan").DisplayName.AddTranslation(GameCulture.Russian, "Грязевой человек");
			thorium.GetNPC("MyceliumMimic").DisplayName.AddTranslation(GameCulture.Russian, "Грибной подражатель");
			thorium.GetNPC("NecroPot").DisplayName.AddTranslation(GameCulture.Russian, "Некротический горшок");
			thorium.GetNPC("Nestling").DisplayName.AddTranslation(GameCulture.Russian, "Птенец");
			thorium.GetNPC("Phantom").DisplayName.AddTranslation(GameCulture.Russian, "Le Fantôme");
			thorium.GetNPC("RagingMinotaur").DisplayName.AddTranslation(GameCulture.Russian, "Яростный минотавр");
			thorium.GetNPC("ScissorStalker").DisplayName.AddTranslation(GameCulture.Russian, "Преследователь с ножницами");
			thorium.GetNPC("SeaShantySinger").DisplayName.AddTranslation(GameCulture.Russian, "Просоленный бард");
			thorium.GetNPC("ShadowflameRevenant").DisplayName.AddTranslation(GameCulture.Russian, "Дух теневого пламени");
			thorium.GetNPC("Shambler").DisplayName.AddTranslation(GameCulture.Russian, "Бродяга");
			thorium.GetNPC("SnowBall").DisplayName.AddTranslation(GameCulture.Russian, "Снежный шар");
			thorium.GetNPC("SnowEater").DisplayName.AddTranslation(GameCulture.Russian, "Пожиратель снега");
			thorium.GetNPC("SnowSinga").DisplayName.AddTranslation(GameCulture.Russian, "Снеговик-певец");
			thorium.GetNPC("SolarPriest").DisplayName.AddTranslation(GameCulture.Russian, "Жрица солнца");
			thorium.GetNPC("SoulCorrupter").DisplayName.AddTranslation(GameCulture.Russian, "Искажатель душ");
			thorium.GetNPC("SpaceSlime").DisplayName.AddTranslation(GameCulture.Russian, "Космический слизень");
			thorium.GetNPC("Spectrumite").DisplayName.AddTranslation(GameCulture.Russian, "Спектрумит");
			thorium.GetNPC("Spiritualist").DisplayName.AddTranslation(GameCulture.Russian, "Спиритуалист");
			thorium.GetNPC("StrangeBulb").DisplayName.AddTranslation(GameCulture.Russian, "Странный бутон");
			thorium.GetNPC("Tarantula").DisplayName.AddTranslation(GameCulture.Russian, "Тарантул");
			thorium.GetNPC("TarantulaWall").DisplayName.AddTranslation(GameCulture.Russian, "Тарантул");
			thorium.GetNPC("TheInnocent").DisplayName.AddTranslation(GameCulture.Russian, "Невинный");
			thorium.GetNPC("TheStarved").DisplayName.AddTranslation(GameCulture.Russian, "Изголодавший");
			thorium.GetNPC("Tracker").DisplayName.AddTranslation(GameCulture.Russian, "Охотник");
			thorium.GetNPC("UFO").DisplayName.AddTranslation(GameCulture.Russian, "Н.Л.О.");
			thorium.GetNPC("UnderworldPot1").DisplayName.AddTranslation(GameCulture.Russian, "Адский горшок");
			thorium.GetNPC("UnderworldPot2").DisplayName.AddTranslation(GameCulture.Russian, "Адский горшок");
			thorium.GetNPC("VileFloater").DisplayName.AddTranslation(GameCulture.Russian, "Парящий нечестивец");
			thorium.GetNPC("WeaponMaster").DisplayName.AddTranslation(GameCulture.Russian, "Мастер оружия");
			thorium.GetNPC("WindElemental").DisplayName.AddTranslation(GameCulture.Russian, "Элементаль ветра");
			thorium.GetNPC("Viscount").DisplayName.AddTranslation(GameCulture.Russian, "Виконт");
			thorium.GetNPC("ViscountBaby").DisplayName.AddTranslation(GameCulture.Russian, "Кусака");
			thorium.GetNPC("EnemyBeholder").DisplayName.AddTranslation(GameCulture.Russian, "Созерцатель");
			thorium.GetNPC("FallenDeathBeholder").DisplayName.AddTranslation(GameCulture.Russian, "Козникс, падший Созерцатель");
			thorium.GetNPC("FallenDeathBeholder2").DisplayName.AddTranslation(GameCulture.Russian, "Козникс, падший Созерцатель");
			thorium.GetNPC("BlizzardBat").DisplayName.AddTranslation(GameCulture.Russian, "Снежная летучая мышь");
			thorium.GetNPC("BoreanHopper").DisplayName.AddTranslation(GameCulture.Russian, "Арктический прыгун");
			thorium.GetNPC("BoreanMyte1").DisplayName.AddTranslation(GameCulture.Russian, "Арктический клещ");
			thorium.GetNPC("BoreanStrider").DisplayName.AddTranslation(GameCulture.Russian, "Арктический страйдер");
			thorium.GetNPC("BoreanStriderPopped").DisplayName.AddTranslation(GameCulture.Russian, "Арктический страйдер");
			thorium.GetNPC("FrostBurnt").DisplayName.AddTranslation(GameCulture.Russian, "Обожжённый морозом");
			thorium.GetNPC("FrostBurntFlayer").DisplayName.AddTranslation(GameCulture.Russian, "Обожжённый морозом");
			thorium.GetNPC("SnowElemental").DisplayName.AddTranslation(GameCulture.Russian, "Элементаль снега");
			thorium.GetNPC("SnowyOwl").DisplayName.AddTranslation(GameCulture.Russian, "Снежный филин");
			thorium.GetNPC("Abomination").DisplayName.AddTranslation(GameCulture.Russian, "Мерзость");
			thorium.GetNPC("BloodDrop").DisplayName.AddTranslation(GameCulture.Russian, "Кровавая капля");
			thorium.GetNPC("GorgedEye").DisplayName.AddTranslation(GameCulture.Russian, "Насытившийся глаз");
			thorium.GetNPC("GraveLimb").DisplayName.AddTranslation(GameCulture.Russian, "Могильная конечность");
			thorium.GetNPC("ImpaledZombie").DisplayName.AddTranslation(GameCulture.Russian, "Пронзенный зомби");
			thorium.GetNPC("Maggot").DisplayName.AddTranslation(GameCulture.Russian, "Изголодавшаяся личинка");
			thorium.GetNPC("NecroticImbuer").DisplayName.AddTranslation(GameCulture.Russian, "Некротический заклинатель");
			thorium.GetNPC("PatchWerk").DisplayName.AddTranslation(GameCulture.Russian, "Лоскутик");
			thorium.GetNPC("SeveredLegs").DisplayName.AddTranslation(GameCulture.Russian, "Отрубленные ноги");
			thorium.GetNPC("Shade").DisplayName.AddTranslation(GameCulture.Russian, "Удушающая тень");
			thorium.GetNPC("Warg").DisplayName.AddTranslation(GameCulture.Russian, "Жаждущий крови варг");
			thorium.GetNPC("CorpseBloom").DisplayName.AddTranslation(GameCulture.Russian, "Трупоцвет");
			thorium.GetNPC("CorpsePetal").DisplayName.AddTranslation(GameCulture.Russian, "Лепесток трупоцвета");
			thorium.GetNPC("CorpseWeed").DisplayName.AddTranslation(GameCulture.Russian, "Трупный побег");
			thorium.GetNPC("BuriedSpawn").DisplayName.AddTranslation(GameCulture.Russian, "Причудливая горная порода");
			thorium.GetNPC("BuriedVolley").DisplayName.AddTranslation(GameCulture.Russian, "Магический всплеск");
			thorium.GetNPC("TheBuriedWarrior").DisplayName.AddTranslation(GameCulture.Russian, "Погребенный чемпион");
			thorium.GetNPC("TheBuriedWarrior1").DisplayName.AddTranslation(GameCulture.Russian, "Павший чемпион");
			thorium.GetNPC("TheBuriedWarrior2").DisplayName.AddTranslation(GameCulture.Russian, "Павший чемпион");
			thorium.GetNPC("BlueHag").DisplayName.AddTranslation(GameCulture.Russian, "Карга");
			thorium.GetNPC("CyanHag").DisplayName.AddTranslation(GameCulture.Russian, "Карга");
			thorium.GetNPC("GreenHag").DisplayName.AddTranslation(GameCulture.Russian, "Карга");
			thorium.GetNPC("RedHag").DisplayName.AddTranslation(GameCulture.Russian, "Карга");
			thorium.GetNPC("AbyssalAngler").DisplayName.AddTranslation(GameCulture.Russian, "Золотая монета?");
			thorium.GetNPC("AbyssalAngler2").DisplayName.AddTranslation(GameCulture.Russian, "Глубинный удильщик");
			thorium.GetNPC("AbyssalSpawn").DisplayName.AddTranslation(GameCulture.Russian, "Порождение глубин");
			thorium.GetNPC("Abyssion").DisplayName.AddTranslation(GameCulture.Russian, "Абиссион, Забытый");
			thorium.GetNPC("AbyssionCracked").DisplayName.AddTranslation(GameCulture.Russian, "Абиссион, Забытый");
			thorium.GetNPC("AbyssionReleased").DisplayName.AddTranslation(GameCulture.Russian, "Абиссион, Забытый");
			thorium.GetNPC("AquaticHallucination").DisplayName.AddTranslation(GameCulture.Russian, "Морская иллюзия");
			thorium.GetNPC("Barracuda").DisplayName.AddTranslation(GameCulture.Russian, "Барракуда");
			thorium.GetNPC("Blobfish").DisplayName.AddTranslation(GameCulture.Russian, "Рыба-капля");
			thorium.GetNPC("Blowfish").DisplayName.AddTranslation(GameCulture.Russian, "Рыба фугу");
			thorium.GetNPC("CrownofThorns").DisplayName.AddTranslation(GameCulture.Russian, "Терновый венец");
			thorium.GetNPC("DepthMimic").DisplayName.AddTranslation(GameCulture.Russian, "Глубинный подражатель");
			thorium.GetNPC("EelBody").DisplayName.AddTranslation(GameCulture.Russian, "Электрический угорь");
			thorium.GetNPC("EelHead").DisplayName.AddTranslation(GameCulture.Russian, "Электрический угорь");
			thorium.GetNPC("EelTail").DisplayName.AddTranslation(GameCulture.Russian, "Электрический угорь");
			thorium.GetNPC("FeedingFrenzy").DisplayName.AddTranslation(GameCulture.Russian, "Френзи");
			thorium.GetNPC("FeedingFrenzy2").DisplayName.AddTranslation(GameCulture.Russian, "Френзи");
			thorium.GetNPC("GigaClam").DisplayName.AddTranslation(GameCulture.Russian, "Большая ракушка");
			thorium.GetNPC("Globee").DisplayName.AddTranslation(GameCulture.Russian, "Глоби");
			thorium.GetNPC("Hammerhead").DisplayName.AddTranslation(GameCulture.Russian, "Акула-молот");
			thorium.GetNPC("Kraken").DisplayName.AddTranslation(GameCulture.Russian, "Кракен");
			thorium.GetNPC("ManofWar").DisplayName.AddTranslation(GameCulture.Russian, "Физалия");
			thorium.GetNPC("MorayBody").DisplayName.AddTranslation(GameCulture.Russian, "Мурена");
			thorium.GetNPC("MorayHead").DisplayName.AddTranslation(GameCulture.Russian, "Мурена");
			thorium.GetNPC("MorayTail").DisplayName.AddTranslation(GameCulture.Russian, "Мурена");
			thorium.GetNPC("Octopus").DisplayName.AddTranslation(GameCulture.Russian, "Осьминог");
			thorium.GetNPC("PutridSerpent").DisplayName.AddTranslation(GameCulture.Russian, "Порченный змей");
			thorium.GetNPC("Sharptooth").DisplayName.AddTranslation(GameCulture.Russian, "Зубастик");
			thorium.GetNPC("VampireSquid").DisplayName.AddTranslation(GameCulture.Russian, "Адский вампир");
			thorium.GetNPC("Whale").DisplayName.AddTranslation(GameCulture.Russian, "Кит");
			thorium.GetNPC("AngerSpirit").DisplayName.AddTranslation(GameCulture.Russian, "Нестабильная Ярость");
			thorium.GetNPC("Aquaius").DisplayName.AddTranslation(GameCulture.Russian, "Акваус, бесконечный Прилив");
			thorium.GetNPC("Aquaius2").DisplayName.AddTranslation(GameCulture.Russian, "Акваус, убывающая Волна");
			thorium.GetNPC("AquaiusBubble").DisplayName.AddTranslation(GameCulture.Russian, "Пузырь Аквауса");
			thorium.GetNPC("AquaiusBubblePrime").DisplayName.AddTranslation(GameCulture.Russian, "Ядро пузыря");
			thorium.GetNPC("AquaTitan").DisplayName.AddTranslation(GameCulture.Russian, "Ревенант: Отчаяние");
			thorium.GetNPC("BoundlessEntity").DisplayName.AddTranslation(GameCulture.Russian, "Необозримая сущность");
			thorium.GetNPC("DeathTitan").DisplayName.AddTranslation(GameCulture.Russian, "Ревенант: Ужас");
			thorium.GetNPC("DespairSpirit").DisplayName.AddTranslation(GameCulture.Russian, "Внутреннее отчаяние");
			thorium.GetNPC("DreadSpirit").DisplayName.AddTranslation(GameCulture.Russian, "Надвигающийся ужас");
			thorium.GetNPC("OmegaSigil").DisplayName.AddTranslation(GameCulture.Russian, "Омега-печать");
			thorium.GetNPC("Omnicide").DisplayName.AddTranslation(GameCulture.Russian, "Омницид, осквернитель Жизни");
			thorium.GetNPC("RealityBreaker").DisplayName.AddTranslation(GameCulture.Russian, "Погибающая реальность, Рагнарёк");
			thorium.GetNPC("SlagFury").DisplayName.AddTranslation(GameCulture.Russian, "Шлаковый яростень, изначальное пламя");
			thorium.GetNPC("SlagTitan").DisplayName.AddTranslation(GameCulture.Russian, "Ревенант: Ярость");
			thorium.GetNPC("EncroachingEnergy").DisplayName.AddTranslation(GameCulture.Russian, "Враждебная энергия");
			thorium.GetNPC("EnergyBarrier").DisplayName.AddTranslation(GameCulture.Russian, "Энергетический барьер");
			thorium.GetNPC("EnergyCanduit").DisplayName.AddTranslation(GameCulture.Russian, "Энергетический источник");
			thorium.GetNPC("GraniteEnergy").DisplayName.AddTranslation(GameCulture.Russian, "Энергетическая амальгама");
			thorium.GetNPC("GraniteEnergyStorm").DisplayName.AddTranslation(GameCulture.Russian, "Гранитный энергетический шторм");
			thorium.GetNPC("GraniteSpawn").DisplayName.AddTranslation(GameCulture.Russian, "Нестабильная энергетическая аномалия");
			thorium.GetNPC("Lich").DisplayName.AddTranslation(GameCulture.Russian, "Лич");
			thorium.GetNPC("LichHeadless").DisplayName.AddTranslation(GameCulture.Russian, "Лич");
			thorium.GetNPC("ThousandSoulPhalactry").DisplayName.AddTranslation(GameCulture.Russian, "Крестраж тысячи душ");
			thorium.GetNPC("DistractJelly").DisplayName.AddTranslation(GameCulture.Russian, "Отвлекающая медуза");
			thorium.GetNPC("QueenJelly").DisplayName.AddTranslation(GameCulture.Russian, "Королева медуз");
			thorium.GetNPC("SpittingJelly").DisplayName.AddTranslation(GameCulture.Russian, "Слюнявая медуза");
			thorium.GetNPC("ZealousJelly").DisplayName.AddTranslation(GameCulture.Russian, "Ревностная медуза");
			thorium.GetNPC("BioCore").DisplayName.AddTranslation(GameCulture.Russian, "Био-ядро");
			thorium.GetNPC("CryoCore").DisplayName.AddTranslation(GameCulture.Russian, "Крио-ядро");
			thorium.GetNPC("PyroCore").DisplayName.AddTranslation(GameCulture.Russian, "Пиро-ядро");
			thorium.GetNPC("ThePrimeScouter").DisplayName.AddTranslation(GameCulture.Russian, "Звёздный разведчик");
			thorium.GetNPC("Hatchling").DisplayName.AddTranslation(GameCulture.Russian, "Дитя шторма");
			thorium.GetNPC("TheGrandThunderBirdv2").DisplayName.AddTranslation(GameCulture.Russian, "Великая гром-птица");
		}
	}
}
