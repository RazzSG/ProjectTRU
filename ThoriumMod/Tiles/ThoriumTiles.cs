﻿using CalamityRuTranslate.Mods.ThoriumMod;
using Microsoft.Xna.Framework;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.ThoriumMod.Tiles
{
	internal class ThoriumTiles
	{
		public static void Setup()
		{
			Tiles();
		}
		
		private static void Tiles()
		{
			ModTile tile = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("Altar"));
			ModTranslation altar = tile.CreateMapEntryName();
			altar.AddTranslation(GameCulture.Russian, "Алтарь");
			tile.AddMapEntry(new Color(155, 125, 100), altar);
			
			ModTile tile2 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("Aquaite"));
			ModTranslation aquaite = tile2.CreateMapEntryName();
			aquaite.AddTranslation(GameCulture.Russian, "Аквайт");
			tile2.AddMapEntry(new Color(0, 130, 255), aquaite);
			
			ModTile tile3 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("AquaticDepthsBanner"));
			ModTranslation aquaticDepthsBanner = tile3.CreateMapEntryName();
			aquaticDepthsBanner.AddTranslation(GameCulture.Russian, "Знамя");
			tile3.AddMapEntry(new Color(13, 88, 130), aquaticDepthsBanner);
			
			ModTile tile4 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("AquaticDepthsBiomeChest"));
			ModTranslation aquaticDepthsBiomeChest = tile4.CreateMapEntryName();
			aquaticDepthsBiomeChest.AddTranslation(GameCulture.Russian, "Акватический глубинный сундук");
			tile4.AddMapEntry(new Color(174, 129, 92), aquaticDepthsBiomeChest);
			
			ModTile tile5 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("AquaticDepthsBiomeChest"));
			ModTranslation aquaticDepthsBiomeChestLocked = tile5.CreateMapEntryName(tile5.Name + "_Locked");
			aquaticDepthsBiomeChestLocked.AddTranslation(GameCulture.Russian, "Закрытый акватический глубинный сундук");
			tile5.AddMapEntry(new Color(174, 129, 92), aquaticDepthsBiomeChestLocked);
			
			ModTile tile6 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("ArcaneArmorFabricator"));
			ModTranslation arcaneArmorFabricator = tile6.CreateMapEntryName();
			arcaneArmorFabricator.AddTranslation(GameCulture.Russian, "Изготовитель мистических доспехов");
			tile6.AddMapEntry(new Color(150, 150, 150), arcaneArmorFabricator);
			
			ModTile tile7 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("BloodAltar"));
			ModTranslation bloodAltar = tile7.CreateMapEntryName();
			bloodAltar.AddTranslation(GameCulture.Russian, "Кровавый алтарь");
			tile7.AddMapEntry(new Color(100, 100, 100), bloodAltar);
			
			ModTile tile8 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("BloodSplatterTile"));
			ModTranslation bloodSplatterTile = tile8.CreateMapEntryName();
			bloodSplatterTile.AddTranslation(GameCulture.Russian, "Кровавое пятно");
			tile8.AddMapEntry(new Color(175, 135, 125), bloodSplatterTile);
			
			ModTile tile9 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("ChessBlock"));
			ModTranslation chessBlock = tile9.CreateMapEntryName();
			chessBlock.AddTranslation(GameCulture.Russian, "Блок шахмат");
			tile9.AddMapEntry(new Color(80, 80, 80), chessBlock);
			
			ModTile tile10 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("CookTiles1"));
			ModTranslation cookTiles = tile10.CreateMapEntryName();
			cookTiles.AddTranslation(GameCulture.Russian, "Еда");
			tile10.AddMapEntry(new Color(200, 170, 125), cookTiles);
			
			ModTile tile11 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("CookTiles2"));
			ModTranslation cookTiles2 = tile11.CreateMapEntryName();
			cookTiles2.AddTranslation(GameCulture.Russian, "Еда");
			tile11.AddMapEntry(new Color(200, 170, 125), cookTiles2);
			
			ModTile tile12 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("CookTiles3"));
			ModTranslation cookTiles3 = tile12.CreateMapEntryName();
			cookTiles3.AddTranslation(GameCulture.Russian, "Еда");
			tile12.AddMapEntry(new Color(200, 170, 125), cookTiles3);
			
			ModTile tile123 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("CursedBlock"));
			ModTranslation cursedBlock = tile123.CreateMapEntryName();
			cursedBlock.AddTranslation(GameCulture.Russian, "Проклятый блок");
			tile123.AddMapEntry(new Color(240, 200, 200), cursedBlock);
			
			ModTile tile124 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("CursedChest"));
			ModTranslation cursedChest = tile124.CreateMapEntryName();
			cursedChest.AddTranslation(GameCulture.Russian, "Проклятый сундук");
			tile124.AddMapEntry(new Color(174, 129, 92), cursedChest);
			
			ModTile tile13 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("DepthChestTile"));
			ModTranslation depthChestTile = tile13.CreateMapEntryName();
			depthChestTile.AddTranslation(GameCulture.Russian, "Глубинный сундук");
			tile13.AddMapEntry(new Color(58, 177, 236), depthChestTile);
			
			ModTile tile14 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("DepthsAmber"));
			ModTranslation depthsAmber = tile14.CreateMapEntryName();
			depthsAmber.AddTranslation(GameCulture.Russian, "Янтарь");
			tile14.AddMapEntry(new Color(180, 130, 75), depthsAmber);
			
			ModTile tile15 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("DepthsAmethyst"));
			ModTranslation depthsAmethyst = tile15.CreateMapEntryName();
			depthsAmethyst.AddTranslation(GameCulture.Russian, "Аметист");
			tile15.AddMapEntry(new Color(140, 58, 166), depthsAmethyst);
			
			ModTile tile16 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("DepthsDiamond"));
			ModTranslation depthsDiamond = tile16.CreateMapEntryName();
			depthsDiamond.AddTranslation(GameCulture.Russian, "Алмаз");
			tile16.AddMapEntry(new Color(125, 191, 197), depthsDiamond);
			
			ModTile tile17 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("DepthsEmerald"));
			ModTranslation depthsEmerald = tile17.CreateMapEntryName();
			depthsEmerald.AddTranslation(GameCulture.Russian, "Изумруд");
			tile17.AddMapEntry(new Color(56, 150, 97), depthsEmerald);
			
			ModTile tile18 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("DepthsOnyx"));
			ModTranslation depthsOnyx = tile18.CreateMapEntryName();
			depthsOnyx.AddTranslation(GameCulture.Russian, "Оникс");
			tile18.AddMapEntry(new Color(45, 30, 45), depthsOnyx);
			
			ModTile tile19 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("DepthsOpal"));
			ModTranslation depthsOpal = tile19.CreateMapEntryName();
			depthsOpal.AddTranslation(GameCulture.Russian, "Опал");
			tile19.AddMapEntry(new Color(255, 102, 255), depthsOpal);
			
			ModTile tile20 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("DepthsRuby"));
			ModTranslation depthsRuby = tile20.CreateMapEntryName();
			depthsRuby.AddTranslation(GameCulture.Russian, "Рубин");
			tile20.AddMapEntry(new Color(196, 96, 114), depthsRuby);
			
			ModTile tile21 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("DepthsSapphire"));
			ModTranslation depthsSapphire = tile21.CreateMapEntryName();
			depthsSapphire.AddTranslation(GameCulture.Russian, "Сапфир");
			tile21.AddMapEntry(new Color(110, 140, 182), depthsSapphire);
			
			ModTile tile22 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("DepthsTopaz"));
			ModTranslation depthsTopaz = tile22.CreateMapEntryName();
			depthsTopaz.AddTranslation(GameCulture.Russian, "Топаз");
			tile22.AddMapEntry(new Color(160, 118, 58), depthsTopaz);
			
			ModTile tile23 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("DesertBiomeChest"));
			ModTranslation desertBiomeChest = tile23.CreateMapEntryName();
			desertBiomeChest.AddTranslation(GameCulture.Russian, "Пустынный сундук");
			tile23.AddMapEntry(new Color(174, 129, 92), desertBiomeChest);
			
			ModTile tile24 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("DesertBiomeChest"));
			ModTranslation desertBiomeChestLocked = tile24.CreateMapEntryName(tile24.Name + "_Locked");
			desertBiomeChestLocked.AddTranslation(GameCulture.Russian, "Закрытый пустынный сундук");
			tile24.AddMapEntry(new Color(174, 129, 92), desertBiomeChestLocked);
			
			ModTile tile25 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureBathtub"));
			ModTranslation furnitureBathtub = tile25.CreateMapEntryName();
			furnitureBathtub.AddTranslation(GameCulture.Russian, "Ванна");
			tile25.AddMapEntry(new Color(144, 147, 144), furnitureBathtub);
			
			ModTile tile26 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureBed"));
			ModTranslation furnitureBed = tile26.CreateMapEntryName();
			furnitureBed.AddTranslation(GameCulture.Russian, "Кровать");
			tile26.AddMapEntry(new Color(191, 142, 111), furnitureBed);
			
			ModTile tile27 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureBookcase"));
			ModTranslation furnitureBookcase = tile27.CreateMapEntryName();
			furnitureBookcase.AddTranslation(GameCulture.Russian, "Книжный шкаф");
			tile27.AddMapEntry(new Color(191, 142, 111), furnitureBookcase);
			
			ModTile tile28 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureCandelabra"));
			ModTranslation furnitureCandelabra = tile28.CreateMapEntryName();
			furnitureCandelabra.AddTranslation(GameCulture.Russian, "Канделябр");
			tile28.AddMapEntry(new Color(253, 221, 3), furnitureCandelabra);
			
			ModTile tile29 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureCandle"));
			ModTranslation furnitureCandle = tile29.CreateMapEntryName();
			furnitureCandle.AddTranslation(GameCulture.Russian, "Свеча");
			tile29.AddMapEntry(new Color(253, 221, 3), furnitureCandle);
			
			ModTile tile30 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureChair"));
			ModTranslation furnitureChair = tile30.CreateMapEntryName();
			furnitureChair.AddTranslation(GameCulture.Russian, "Стул");
			tile30.AddMapEntry(new Color(191, 142, 111), furnitureChair);
			
			ModTile tile31 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureChandelier"));
			ModTranslation furnitureChandelier = tile31.CreateMapEntryName();
			furnitureChandelier.AddTranslation(GameCulture.Russian, "Люстра");
			tile31.AddMapEntry(new Color(235, 166, 135), furnitureChandelier);
			
			ModTile tile32 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureClock"));
			ModTranslation furnitureClock = tile32.CreateMapEntryName();
			furnitureClock.AddTranslation(GameCulture.Russian, "Дедушкины часы");
			tile32.AddMapEntry(new Color(191, 142, 111), furnitureClock);
			
			ModTile tile125 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureCup"));
			ModTranslation furnitureCup = tile125.CreateMapEntryName();
			furnitureCup.AddTranslation(GameCulture.Russian, "Чашка");
			tile125.AddMapEntry(new Color(144, 147, 144), furnitureCup);
			
			ModTile tile33 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureDoorClosed"));
			ModTranslation furnitureDoorClosed = tile33.CreateMapEntryName();
			furnitureDoorClosed.AddTranslation(GameCulture.Russian, "Дверь");
			tile33.AddMapEntry(new Color(119, 105, 79), furnitureDoorClosed);
			
			ModTile tile34 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureDoorOpen"));
			ModTranslation furnitureDoorOpen = tile34.CreateMapEntryName();
			furnitureDoorOpen.AddTranslation(GameCulture.Russian, "Дверь");
			tile34.AddMapEntry(new Color(119, 105, 79), furnitureDoorOpen);
			
			ModTile tile35 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureDresser"));
			ModTranslation furnitureDresserThorium = tile35.CreateMapEntryName(tile35.Name + "_Thorium");
			furnitureDresserThorium.AddTranslation(GameCulture.Russian, "Ториевый комод");
			tile35.AddMapEntry(new Color(191, 142, 111), furnitureDresserThorium);
			
			ModTile tile36 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureDresser"));
			ModTranslation furnitureDresserYew = tile36.CreateMapEntryName(tile36.Name + "_Yew");
			furnitureDresserYew.AddTranslation(GameCulture.Russian, "Тисовый комод");
			tile36.AddMapEntry(new Color(191, 142, 111), furnitureDresserYew);
			
			ModTile tile37 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureDresser"));
			ModTranslation furnitureDresserMarine = tile37.CreateMapEntryName(tile37.Name + "_Marine");
			furnitureDresserMarine.AddTranslation(GameCulture.Russian, "Морской комод");
			tile37.AddMapEntry(new Color(191, 142, 111), furnitureDresserMarine);
			
			ModTile tile38 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureDresser"));
			ModTranslation furnitureDresserLodestone = tile38.CreateMapEntryName(tile38.Name + "_Lodestone");
			furnitureDresserLodestone.AddTranslation(GameCulture.Russian, "Магнетитовый комод");
			tile38.AddMapEntry(new Color(191, 142, 111), furnitureDresserLodestone);
			
			ModTile tile39 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureDresser"));
			ModTranslation furnitureDresserPermafrost = tile39.CreateMapEntryName(tile39.Name + "_Permafrost");
			furnitureDresserPermafrost.AddTranslation(GameCulture.Russian, "Комод вечной мерзлоты");
			tile39.AddMapEntry(new Color(191, 142, 111), furnitureDresserPermafrost);
			
			ModTile tile40 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureDresser"));
			ModTranslation furnitureDresserPlate = tile40.CreateMapEntryName(tile40.Name + "_Plate");
			furnitureDresserPlate.AddTranslation(GameCulture.Russian, "Пластинчатый комод");
			tile40.AddMapEntry(new Color(191, 142, 111), furnitureDresserPlate);
			
			ModTile tile41 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureDresser"));
			ModTranslation furnitureDresserScarlet = tile41.CreateMapEntryName(tile41.Name + "_Scarlet");
			furnitureDresserScarlet.AddTranslation(GameCulture.Russian, "Кровавый комод");
			tile41.AddMapEntry(new Color(191, 142, 111), furnitureDresserScarlet);
			
			ModTile tile42 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureDresser"));
			ModTranslation furnitureDresserOrnate = tile42.CreateMapEntryName(tile42.Name + "_Ornate");
			furnitureDresserOrnate.AddTranslation(GameCulture.Russian, "Изысканный комод");
			tile42.AddMapEntry(new Color(191, 142, 111), furnitureDresserOrnate);
			
			ModTile tile126 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureDresser"));
			ModTranslation furnitureDresserValadium = tile126.CreateMapEntryName(tile42.Name + "_Valadium");
			furnitureDresserValadium.AddTranslation(GameCulture.Russian, "Валадиумный комод");
			tile126.AddMapEntry(new Color(191, 142, 111), furnitureDresserValadium);
			
			ModTile tile127 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureDresser"));
			ModTranslation furnitureDresserCursed = tile127.CreateMapEntryName(tile42.Name + "_Cursed");
			furnitureDresserCursed.AddTranslation(GameCulture.Russian, "Проклятый комод");
			tile127.AddMapEntry(new Color(191, 142, 111), furnitureDresserCursed);
			
			ModTile tile128 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureDresser"));
			ModTranslation furnitureDresserShady = tile128.CreateMapEntryName(tile42.Name + "_Shady");
			furnitureDresserShady.AddTranslation(GameCulture.Russian, "Теневой комод");
			tile128.AddMapEntry(new Color(191, 142, 111), furnitureDresserShady);
			
			ModTile tile129 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureDresser"));
			ModTranslation furnitureDresserNaga = tile129.CreateMapEntryName(tile42.Name + "_Naga");
			furnitureDresserNaga.AddTranslation(GameCulture.Russian, "Нага-комод");
			tile129.AddMapEntry(new Color(191, 142, 111), furnitureDresserNaga);
			
			ModTile tile400 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureDresser"));
			ModTranslation furnitureDresserBloodstained = tile400.CreateMapEntryName(tile400.Name + "_Bloodstained");
			furnitureDresserBloodstained.AddTranslation(GameCulture.Russian, "Окровавленный комод");
			tile400.AddMapEntry(new Color(191, 142, 111), furnitureDresserBloodstained);
			
			ModTile tile43 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureLamp"));
			ModTranslation furnitureLamp = tile43.CreateMapEntryName();
			furnitureLamp.AddTranslation(GameCulture.Russian, "Лампа");
			tile43.AddMapEntry(new Color(253, 221, 3), furnitureLamp);
			
			ModTile tile44 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureLantern"));
			ModTranslation furnitureLantern = tile44.CreateMapEntryName();
			furnitureLantern.AddTranslation(GameCulture.Russian, "Фонарь");
			tile44.AddMapEntry(new Color(251, 235, 127), furnitureLantern);
			
			ModTile tile45 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureMusicBox"));
			ModTranslation furnitureMusicBox = tile45.CreateMapEntryName();
			furnitureMusicBox.AddTranslation(GameCulture.Russian, "Музыкальная шкатулка");
			tile45.AddMapEntry(new Color(191, 142, 111), furnitureMusicBox);
			
			ModTile tile46 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurniturePiano"));
			ModTranslation furniturePiano = tile46.CreateMapEntryName();
			furniturePiano.AddTranslation(GameCulture.Russian, "Пианино");
			tile46.AddMapEntry(new Color(191, 142, 111), furniturePiano);
			
			ModTile tile47 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureSink"));
			ModTranslation furnitureSink = tile47.CreateMapEntryName();
			furnitureSink.AddTranslation(GameCulture.Russian, "Раковина");
			tile47.AddMapEntry(new Color(191, 142, 111), furnitureSink);
			
			ModTile tile48 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureSofa"));
			ModTranslation furnitureSofa = tile48.CreateMapEntryName();
			furnitureSofa.AddTranslation(GameCulture.Russian, "Скамья");
			tile48.AddMapEntry(new Color(191, 142, 111), furnitureSofa);
			
			ModTile tile49 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureTable"));
			ModTranslation furnitureTable = tile49.CreateMapEntryName();
			furnitureTable.AddTranslation(GameCulture.Russian, "Стол");
			tile49.AddMapEntry(new Color(191, 142, 111), furnitureTable);
			
			ModTile tile130 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureToilet"));
			ModTranslation furnitureToilet = tile130.CreateMapEntryName();
			furnitureToilet.AddTranslation(GameCulture.Russian, "Стул");
			tile130.AddMapEntry(new Color(191, 142, 111), furnitureToilet);
			
			ModTile tile50 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("FurnitureWorkbench"));
			ModTranslation furnitureWorkbench = tile50.CreateMapEntryName();
			furnitureWorkbench.AddTranslation(GameCulture.Russian, "Верстак");
			tile50.AddMapEntry(new Color(191, 142, 111), furnitureWorkbench);
			
			ModTile tile51 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("GingerbreadBlock"));
			ModTranslation gingerbreadBlock = tile51.CreateMapEntryName();
			gingerbreadBlock.AddTranslation(GameCulture.Russian, "Пряничный блок");
			tile51.AddMapEntry(new Color(240, 220, 200), gingerbreadBlock);
			
			ModTile tile52 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("GrayDPainting"));
			ModTranslation grayDPainting = tile52.CreateMapEntryName();
			grayDPainting.AddTranslation(GameCulture.Russian, "Картина");
			tile52.AddMapEntry(new Color(90, 50, 30), grayDPainting);
			
			ModTile tile53 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("GrimPedestal"));
			ModTranslation grimPedestal = tile53.CreateMapEntryName();
			grimPedestal.AddTranslation(GameCulture.Russian, "Мрачный пьедестал");
			tile53.AddMapEntry(new Color(214, 127, 133), grimPedestal);
			
			ModTile tile54 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("GrimPedestal"));
			ModTranslation grimPedestalCrimson = tile54.CreateMapEntryName(tile54.Name + "_Crimson");
			grimPedestalCrimson.AddTranslation(GameCulture.Russian, "Мрачный пьедестал");
			tile54.AddMapEntry(new Color(214, 127, 133), grimPedestalCrimson);
			
			ModTile tile55 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("OrnateChest"));
			ModTranslation ornateChest = tile55.CreateMapEntryName();
			ornateChest.AddTranslation(GameCulture.Russian, "Изысканный сундук");
			tile55.AddMapEntry(new Color(145, 95, 115), ornateChest);
			
			ModTile tile56 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("IllumiteChunk"));
			ModTranslation illumiteChunk = tile56.CreateMapEntryName();
			illumiteChunk.AddTranslation(GameCulture.Russian, "Иллюмит");
			tile56.AddMapEntry(new Color(255, 51, 153), illumiteChunk);
			
			ModTile tile57 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("JungleFlower1"));
			ModTranslation jungleFlower = tile57.CreateMapEntryName();
			jungleFlower.AddTranslation(GameCulture.Russian, "Цветок джунглей");
			tile57.AddMapEntry(new Color(255, 75, 150), jungleFlower);
			
			ModTile tile58 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("JungleFlower2"));
			ModTranslation jungleFlower2 = tile58.CreateMapEntryName();
			jungleFlower2.AddTranslation(GameCulture.Russian, "Цветок джунглей");
			tile58.AddMapEntry(new Color(255, 75, 150), jungleFlower2);
			
			ModTile tile59 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("JungleFlower3"));
			ModTranslation jungleFlower3 = tile59.CreateMapEntryName();
			jungleFlower3.AddTranslation(GameCulture.Russian, "Цветок джунглей");
			tile59.AddMapEntry(new Color(255, 75, 150), jungleFlower3);
			
			ModTile tile60 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("JungleFlower4"));
			ModTranslation jungleFlower4 = tile60.CreateMapEntryName();
			jungleFlower4.AddTranslation(GameCulture.Russian, "Цветок джунглей");
			tile60.AddMapEntry(new Color(255, 75, 150), jungleFlower4);
			
			ModTile tile61 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("LargeCoral"));
			ModTranslation largeCoral = tile61.CreateMapEntryName();
			largeCoral.AddTranslation(GameCulture.Russian, "Коралл");
			tile61.AddMapEntry(new Color(245, 133, 191), largeCoral);
			
			ModTile tile62 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("LifeCrystal"));
			ModTranslation lifeCrystal = tile62.CreateMapEntryName();
			lifeCrystal.AddTranslation(GameCulture.Russian, "Кристалл жизни");
			tile62.AddMapEntry(new Color(174, 24, 69), lifeCrystal);
			
			ModTile tile63 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("LifeQuartz"));
			ModTranslation lifeQuartz = tile63.CreateMapEntryName();
			lifeQuartz.AddTranslation(GameCulture.Russian, "Кварц жизни");
			tile63.AddMapEntry(new Color(255, 56, 115), lifeQuartz);
			
			ModTile tile64 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("LivingLeafBush"));
			ModTranslation livingLeafBush = tile64.CreateMapEntryName();
			livingLeafBush.AddTranslation(GameCulture.Russian, "Живой кустарник");
			tile64.AddMapEntry(new Color(140, 205, 115), livingLeafBush);
			
			ModTile tile65 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("LodeStone"));
			ModTranslation lodeStone = tile65.CreateMapEntryName();
			lodeStone.AddTranslation(GameCulture.Russian, "Магнетит");
			tile65.AddMapEntry(new Color(150, 95, 75), lodeStone);
			
			ModTile tile66 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("LodestoneChest"));
			ModTranslation lodestoneChest = tile66.CreateMapEntryName();
			lodestoneChest.AddTranslation(GameCulture.Russian, "Магнетитовый сундук");
			tile66.AddMapEntry(new Color(85, 70, 60), lodestoneChest);
			
			ModTile tile67 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("MagmaOre"));
			ModTranslation magmaOre = tile67.CreateMapEntryName();
			magmaOre.AddTranslation(GameCulture.Russian, "Магмовая руда");
			tile67.AddMapEntry(new Color(255, 125, 0), magmaOre);
			
			ModTile tile68 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("MarineChest"));
			ModTranslation marineChest = tile68.CreateMapEntryName();
			marineChest.AddTranslation(GameCulture.Russian, "Морской сундук");
			tile68.AddMapEntry(new Color(100, 140, 165), marineChest);
			
			ModTile tile69 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("MediciteBrick"));
			ModTranslation mediciteBrick = tile69.CreateMapEntryName();
			mediciteBrick.AddTranslation(GameCulture.Russian, "Медицитовый кирпич");
			tile69.AddMapEntry(new Color(140, 90, 90), mediciteBrick);
			
			ModTile tile70 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("MistletoeTile"));
			ModTranslation mistletoeTile = tile70.CreateMapEntryName();
			mistletoeTile.AddTranslation(GameCulture.Russian, "Омела");
			tile70.AddMapEntry(new Color(27, 109, 69), mistletoeTile);
			
			ModTile tile71 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("MonsterBannerCave"));
			ModTranslation monsterBannerCave = tile71.CreateMapEntryName();
			monsterBannerCave.AddTranslation(GameCulture.Russian, "Знамя");
			tile71.AddMapEntry(new Color(13, 88, 130), monsterBannerCave);
			
			ModTile tile72 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("MonsterBannerJungle"));
			ModTranslation monsterBannerJungle = tile72.CreateMapEntryName();
			monsterBannerJungle.AddTranslation(GameCulture.Russian, "Знамя");
			tile72.AddMapEntry(new Color(13, 88, 130), monsterBannerJungle);
			
			ModTile tile73 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("MonsterBannerSky"));
			ModTranslation monsterBannerSky = tile73.CreateMapEntryName();
			monsterBannerSky.AddTranslation(GameCulture.Russian, "Знамя");
			tile73.AddMapEntry(new Color(13, 88, 130), monsterBannerSky);
			
			ModTile tile74 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("MonsterBannerSpider"));
			ModTranslation monsterBannerSpider = tile74.CreateMapEntryName();
			monsterBannerSpider.AddTranslation(GameCulture.Russian, "Знамя");
			tile74.AddMapEntry(new Color(13, 88, 130), monsterBannerSpider);
			
			ModTile tile131 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("NagaChest"));
			ModTranslation nagaChest = tile131.CreateMapEntryName();
			nagaChest.AddTranslation(GameCulture.Russian, "Нага-сундук");
			tile131.AddMapEntry(new Color(174, 129, 92), nagaChest);
			
			ModTile tile75 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("OceanCrystal"));
			ModTranslation oceanCrystal = tile75.CreateMapEntryName();
			oceanCrystal.AddTranslation(GameCulture.Russian, "Акватический кристалл");
			tile75.AddMapEntry(new Color(150, 235, 235), oceanCrystal);
			
			ModTile tile76 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("Onyx"));
			ModTranslation onyx = tile76.CreateMapEntryName();
			onyx.AddTranslation(GameCulture.Russian, "Оникс");
			tile76.AddMapEntry(new Color(45, 30, 45), onyx);
			
			ModTile tile77 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("OnyxTorch"));
			ModTranslation onyxTorch = tile77.CreateMapEntryName();
			onyxTorch.AddTranslation(GameCulture.Russian, "Факел");
			tile77.AddMapEntry(new Color(200, 200, 200), onyxTorch);
			
			ModTile tile78 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("Opal"));
			ModTranslation opal = tile78.CreateMapEntryName();
			opal.AddTranslation(GameCulture.Russian, "Опал");
			tile78.AddMapEntry(new Color(255, 102, 255), opal);
			
			ModTile tile79 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("OpalTorch"));
			ModTranslation opalTorch = tile79.CreateMapEntryName();
			opalTorch.AddTranslation(GameCulture.Russian, "Факел");
			tile79.AddMapEntry(new Color(200, 200, 200), opalTorch);
			
			ModTile tile80 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("PaintTileHuge"));
			ModTranslation paintTileHuge = tile80.CreateMapEntryName();
			paintTileHuge.AddTranslation(GameCulture.Russian, "Картина");
			tile80.AddMapEntry(new Color(90, 50, 30), paintTileHuge);
			
			ModTile tile81 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("PaintTileLarge"));
			ModTranslation paintTileLarge = tile81.CreateMapEntryName();
			paintTileLarge.AddTranslation(GameCulture.Russian, "Картина");
			tile81.AddMapEntry(new Color(90, 50, 30), paintTileLarge);
			
			ModTile tile82 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("PaintTileMedium"));
			ModTranslation paintTileMedium = tile82.CreateMapEntryName();
			paintTileMedium.AddTranslation(GameCulture.Russian, "Картина");
			tile82.AddMapEntry(new Color(90, 50, 30), paintTileMedium);
			
			ModTile tile83 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("PaintTileSmall"));
			ModTranslation paintTileSmall = tile83.CreateMapEntryName();
			paintTileSmall.AddTranslation(GameCulture.Russian, "Картина");
			tile83.AddMapEntry(new Color(90, 50, 30), paintTileSmall);
			
			ModTile tile84 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("PaintTileTall"));
			ModTranslation paintTileTall = tile84.CreateMapEntryName();
			paintTileTall.AddTranslation(GameCulture.Russian, "Картина");
			tile84.AddMapEntry(new Color(90, 50, 30), paintTileTall);
			
			ModTile tile85 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("PearlStone"));
			ModTranslation pearlStone = tile85.CreateMapEntryName();
			pearlStone.AddTranslation(GameCulture.Russian, "Жемчуг");
			tile85.AddMapEntry(new Color(153, 255, 204), pearlStone);
			
			ModTile tile86 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("PermafrostChest"));
			ModTranslation permafrostChest = tile86.CreateMapEntryName();
			permafrostChest.AddTranslation(GameCulture.Russian, "Сундук вечной мерзлоты");
			tile86.AddMapEntry(new Color(100, 100, 150), permafrostChest);
			
			ModTile tile87 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("PlacedGem"));
			ModTranslation placedGemOpal = tile87.CreateMapEntryName("Opal");
			placedGemOpal.AddTranslation(GameCulture.Russian, "Опал");
			tile87.AddMapEntry(new Color(255, 147, 255), placedGemOpal);
			
			ModTile tile88 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("PlacedGem"));
			ModTranslation placedGemOnyx = tile88.CreateMapEntryName("Onyx");
			placedGemOnyx.AddTranslation(GameCulture.Russian, "Оникс");
			tile88.AddMapEntry(new Color(45, 20, 45), placedGemOnyx);
			
			ModTile tile89 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("PlacedGem"));
			ModTranslation placedGemPearl = tile89.CreateMapEntryName("Pearl");
			placedGemPearl.AddTranslation(GameCulture.Russian, "Жемчуг");
			tile89.AddMapEntry(new Color(153, 255, 204), placedGemPearl);
			
			ModTile tile90 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("PlateChest"));
			ModTranslation plateChest = tile90.CreateMapEntryName();
			plateChest.AddTranslation(GameCulture.Russian, "Пластинчатый сундук");
			tile90.AddMapEntry(new Color(150, 150, 150), plateChest);
			
			ModTile tile91 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("RecipeCatalog"));
			ModTranslation recipeCatalog = tile91.CreateMapEntryName();
			recipeCatalog.AddTranslation(GameCulture.Russian, "Последний подарок гида");
			tile91.AddMapEntry(new Color(51, 255, 153), recipeCatalog);
			
			ModTile tile92 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("SakuraSapling"));
			ModTranslation sakuraSapling = tile92.CreateMapEntryName();
			sakuraSapling.AddTranslation(GameCulture.Russian, "Саженец");
			tile92.AddMapEntry(new Color(200, 170, 150), sakuraSapling);
			
			ModTile tile93 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("ScarletChest"));
			ModTranslation scarletChest = tile93.CreateMapEntryName();
			scarletChest.AddTranslation(GameCulture.Russian, "Кровавый сундук");
			tile93.AddMapEntry(new Color(180, 0, 0), scarletChest);
			
			ModTile tile132 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("ShadyChest"));
			ModTranslation shadyChest = tile132.CreateMapEntryName();
			shadyChest.AddTranslation(GameCulture.Russian, "Теневой сундук");
			tile132.AddMapEntry(new Color(174, 129, 92), shadyChest);
			
			ModTile tile94 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("SmoothCoal"));
			ModTranslation smoothCoal = tile94.CreateMapEntryName();
			smoothCoal.AddTranslation(GameCulture.Russian, "Гладкий уголь");
			tile94.AddMapEntry(new Color(40, 40, 40), smoothCoal);
			
			ModTile tile95 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("SoulForge"));
			ModTranslation soulForge = tile95.CreateMapEntryName();
			soulForge.AddTranslation(GameCulture.Russian, "Кузня душ");
			tile95.AddMapEntry(new Color(0, 102, 255), soulForge);
			
			ModTile tile96 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("SpookySapling"));
			ModTranslation spookySapling = tile96.CreateMapEntryName();
			spookySapling.AddTranslation(GameCulture.Russian, "Саженец");
			tile96.AddMapEntry(new Color(200, 170, 150), spookySapling);
			
			ModTile tile97 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("StrangeCrate"));
			ModTranslation strangeCrate = tile97.CreateMapEntryName();
			strangeCrate.AddTranslation(GameCulture.Russian, "Ящик");
			tile97.AddMapEntry(new Color(160, 120, 92), strangeCrate);
			
			ModTile tile98 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("StrangePlatingTile"));
			ModTranslation strangePlatingTile = tile98.CreateMapEntryName();
			strangePlatingTile.AddTranslation(GameCulture.Russian, "Пластинчатая плита");
			tile98.AddMapEntry(new Color(180, 180, 180), strangePlatingTile);
			
			ModTile tile99 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("SugarCookieBlock"));
			ModTranslation sugarCookieBlock = tile99.CreateMapEntryName();
			sugarCookieBlock.AddTranslation(GameCulture.Russian, "Блок сахарного печенья");
			tile99.AddMapEntry(new Color(240, 220, 200), sugarCookieBlock);
			
			ModTile tile100 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("SynthGold"));
			ModTranslation synthGold = tile100.CreateMapEntryName();
			synthGold.AddTranslation(GameCulture.Russian, "Золото");
			tile100.AddMapEntry(new Color(204, 204, 0), synthGold);
			
			ModTile tile101 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("SynthPlatinum"));
			ModTranslation synthPlatinum = tile101.CreateMapEntryName();
			synthPlatinum.AddTranslation(GameCulture.Russian, "Платина");
			tile101.AddMapEntry(new Color(210, 210, 210), synthPlatinum);
			
			ModTile tile102 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("ThoriumAnvil"));
			ModTranslation thoriumAnvil = tile102.CreateMapEntryName();
			thoriumAnvil.AddTranslation(GameCulture.Russian, "Ториевая наковальня");
			tile102.AddMapEntry(new Color(80, 200, 200), thoriumAnvil);
			
			ModTile tile103 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("ThoriumChest"));
			ModTranslation thoriumChest = tile103.CreateMapEntryName();
			thoriumChest.AddTranslation(GameCulture.Russian, "Ториевый сундук");
			tile103.AddMapEntry(new Color(80, 200, 200), thoriumChest);
			
			ModTile tile104 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("ThoriumOre"));
			ModTranslation thoriumOre = tile104.CreateMapEntryName();
			thoriumOre.AddTranslation(GameCulture.Russian, "Торий");
			tile104.AddMapEntry(new Color(51, 255, 255), thoriumOre);
			
			ModTile tile105 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("TrackerBoardTile"));
			ModTranslation trackerBoardTile = tile105.CreateMapEntryName();
			trackerBoardTile.AddTranslation(GameCulture.Russian, "Доска охотника");
			tile105.AddMapEntry(new Color(90, 50, 30), trackerBoardTile);
			
			ModTile tile106 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("TrappedChests"));
			ModTranslation aquaticDepthsBiomeChestTrapped = tile106.CreateMapEntryName("AquaticDepthsBiomeChest_Trapped");
			aquaticDepthsBiomeChestTrapped.AddTranslation(GameCulture.Russian, "Акватический глубинный сундук");
			tile106.AddMapEntry(new Color(174, 129, 92), aquaticDepthsBiomeChestTrapped);
			
			ModTile tile107 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("TrappedChests"));
			ModTranslation depthChestTileTrapped = tile107.CreateMapEntryName("DepthChestTile_Trapped");
			depthChestTileTrapped.AddTranslation(GameCulture.Russian, "Глубинный сундук");
			tile107.AddMapEntry(new Color(58, 177, 236), depthChestTileTrapped);
			
			ModTile tile108 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("TrappedChests"));
			ModTranslation desertBiomeChestTrapped = tile108.CreateMapEntryName("DesertBiomeChest_Trapped");
			desertBiomeChestTrapped.AddTranslation(GameCulture.Russian, "Пустынный сундук");
			tile108.AddMapEntry(new Color(174, 129, 92), desertBiomeChestTrapped);
			
			ModTile tile109 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("TrappedChests"));
			ModTranslation marineChestTrapped = tile109.CreateMapEntryName("MarineChest_Trapped");
			marineChestTrapped.AddTranslation(GameCulture.Russian, "Морской сундук");
			tile109.AddMapEntry(new Color(174, 129, 92), marineChestTrapped);
			
			ModTile tile110 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("TrappedChests"));
			ModTranslation scarletChestTrapped = tile110.CreateMapEntryName("ScarletChest_Trapped");
			scarletChestTrapped.AddTranslation(GameCulture.Russian, "Кровавый сундук");
			tile110.AddMapEntry(new Color(180, 0, 0), scarletChestTrapped);
			
			ModTile tile111 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("TrappedChests"));
			ModTranslation thoriumChestTrapped = tile111.CreateMapEntryName("ThoriumChest_Trapped");
			thoriumChestTrapped.AddTranslation(GameCulture.Russian, "Ториевый сундук");
			tile111.AddMapEntry(new Color(174, 129, 92), thoriumChestTrapped);
			
			ModTile tile112 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("TrappedChests"));
			ModTranslation underworldChestTrapped = tile112.CreateMapEntryName("UnderworldChest_Trapped");
			underworldChestTrapped.AddTranslation(GameCulture.Russian, "Адский сундук");
			tile112.AddMapEntry(new Color(174, 129, 92), underworldChestTrapped);
			
			ModTile tile113 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("TrappedChests"));
			ModTranslation yewChestTrapped = tile113.CreateMapEntryName("YewChest_Trapped");
			yewChestTrapped.AddTranslation(GameCulture.Russian, "Тисовый сундук");
			tile113.AddMapEntry(new Color(174, 129, 92), yewChestTrapped);
			
			ModTile tile114 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("TrappedChests"));
			ModTranslation permafrostChestTrapped = tile114.CreateMapEntryName("PermafrostChest_Trapped");
			permafrostChestTrapped.AddTranslation(GameCulture.Russian, "Сундук вечной мерзлоты");
			tile114.AddMapEntry(new Color(174, 129, 92), permafrostChestTrapped);
			
			ModTile tile115 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("TrappedChests"));
			ModTranslation plateChestTrapped = tile115.CreateMapEntryName("PlateChest_Trapped");
			plateChestTrapped.AddTranslation(GameCulture.Russian, "Пластинчатый сундук");
			tile115.AddMapEntry(new Color(174, 129, 92), plateChestTrapped);
			
			ModTile tile116 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("TrappedChests"));
			ModTranslation lodestoneChestTrapped = tile116.CreateMapEntryName("LodestoneChest_Trapped");
			lodestoneChestTrapped.AddTranslation(GameCulture.Russian, "Магнетитовый сундук");
			tile116.AddMapEntry(new Color(174, 129, 92), lodestoneChestTrapped);
			
			ModTile tile133 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("TrappedChests"));
			ModTranslation ornateChestTrapped = tile133.CreateMapEntryName("OrnateChest_Trapped");
			ornateChestTrapped.AddTranslation(GameCulture.Russian, "Изысканный сундук");
			tile133.AddMapEntry(new Color(174, 129, 92), ornateChestTrapped);
			
			ModTile tile134 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("TrappedChests"));
			ModTranslation valadiumChestTrapped = tile134.CreateMapEntryName("ValadiumChest_Trapped");
			valadiumChestTrapped.AddTranslation(GameCulture.Russian, "Валадиумовый сундук");
			tile134.AddMapEntry(new Color(174, 129, 92), valadiumChestTrapped);
			
			ModTile tile135 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("TrappedChests"));
			ModTranslation cursedChestTrapped = tile135.CreateMapEntryName("CursedChest_Trapped");
			cursedChestTrapped.AddTranslation(GameCulture.Russian, "Проклятый сундук");
			tile135.AddMapEntry(new Color(174, 129, 92), cursedChestTrapped);
			
			ModTile tile136 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("TrappedChests"));
			ModTranslation shadyChestTrapped = tile136.CreateMapEntryName("ShadyChest_Trapped");
			shadyChestTrapped.AddTranslation(GameCulture.Russian, "Теневой сундук");
			tile136.AddMapEntry(new Color(174, 129, 92), shadyChestTrapped);
			
			ModTile tile137 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("TrappedChests"));
			ModTranslation nagaChestTrapped = tile137.CreateMapEntryName("NagaChest_Trapped");
			nagaChestTrapped.AddTranslation(GameCulture.Russian, "Нага-сундук");
			tile137.AddMapEntry(new Color(174, 129, 92), nagaChestTrapped);
			
			ModTile tile401 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("TrappedChests"));
			ModTranslation bloodstainedChestTrapped = tile401.CreateMapEntryName("BloodstainedChest_Trapped");
			bloodstainedChestTrapped.AddTranslation(GameCulture.Russian, "Окровавленный сундук");
			tile401.AddMapEntry(new Color(174, 129, 92), bloodstainedChestTrapped);
			
			ModTile tile117 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("Trophies"));
			ModTranslation trophies = tile117.CreateMapEntryName();
			trophies.AddTranslation(GameCulture.Russian, "Трофей");
			tile117.AddMapEntry(new Color(120, 85, 60), trophies);
			
			ModTile tile118 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("UnderworldChest"));
			ModTranslation underworldChest = tile118.CreateMapEntryName();
			underworldChest.AddTranslation(GameCulture.Russian, "Адский сундук");
			tile118.AddMapEntry(new Color(174, 129, 92), underworldChest);
			
			ModTile tile119 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("UnderworldChest"));
			ModTranslation underworldChestLocked = tile119.CreateMapEntryName(tile119.Name + "_Locked");
			underworldChestLocked.AddTranslation(GameCulture.Russian, "Закрытый адский сундук");
			tile119.AddMapEntry(new Color(174, 129, 92), underworldChestLocked);
			
			ModTile tile138 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("ValadiumChest"));
			ModTranslation valadiumChest = tile138.CreateMapEntryName();
			valadiumChest.AddTranslation(GameCulture.Russian, "Валадиумовый сундук");
			tile138.AddMapEntry(new Color(174, 129, 92), valadiumChest);
			
			ModTile tile120 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("ValadiumChunk"));
			ModTranslation valadiumChunk = tile120.CreateMapEntryName();
			valadiumChunk.AddTranslation(GameCulture.Russian, "Валадиум");
			tile120.AddMapEntry(new Color(153, 51, 255), valadiumChunk);
			
			ModTile tile121 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("YewChest"));
			ModTranslation yewChest = tile121.CreateMapEntryName();
			yewChest.AddTranslation(GameCulture.Russian, "Тисовый сундук");
			tile121.AddMapEntry(new Color(100, 75, 50), yewChest);
			
			ModTile tile122 = TileLoader.GetTile(CoreThoriumTranslation.ThoriumMod.TileType("YewSapling"));
			ModTranslation yewSapling = tile122.CreateMapEntryName();
			yewSapling.AddTranslation(GameCulture.Russian, "Саженец");
			tile122.AddMapEntry(new Color(200, 170, 150), yewSapling);
		}
	}
}
