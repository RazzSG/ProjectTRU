﻿using System.Collections.Generic;
using CalamityMod;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using MonoMod.Cil;
using Terraria;
using Terraria.ID;
using Item = On.Terraria.Item;

namespace CalamityRuTranslate.Vanilla
{
    public class DrawInfoAccsIL : ILEdit
    {
        public override bool Autoload() => TranslationUtils.IsRussianLanguage;

        public override void Load() => IL.Terraria.Main.DrawInfoAccs += ChangeDrawInfoAccs;

        public override void Unload() => IL.Terraria.Main.DrawInfoAccs -= ChangeDrawInfoAccs;

        private void ChangeDrawInfoAccs(ILContext il)
        {
            TranslationUtils.ILTranslate(il, 12, 24);
            TranslationUtils.ILTranslate(il, 12, 0, 3);
            TranslationUtils.ILTranslate(il, "AM", "");
            TranslationUtils.ILTranslate(il, "PM", "");
        }
    }

    public class GetNewNPCNameIL : ILEdit
    {
        public override bool Autoload() => TranslationUtils.IsRussianLanguage;

        public override void Load() => IL.Terraria.NPC.getNewNPCName += TranslationTownNpcName;

        public override void Unload() => IL.Terraria.NPC.getNewNPCName -= TranslationTownNpcName;

        private void TranslationTownNpcName(ILContext il)
        {
            TranslationUtils.ILTranslate(il, "A.N.D.Y", "Э.Н.Д.И");
            TranslationUtils.ILTranslate(il, "Abdosir", "Абдозир");
            TranslationUtils.ILTranslate(il, "Abibe", "Абиб");
            TranslationUtils.ILTranslate(il, "Abigail", "Эбигейл");
            TranslationUtils.ILTranslate(il, "Abraham", "Абрахам");
            TranslationUtils.ILTranslate(il, "Abram", "Абрам");
            TranslationUtils.ILTranslate(il, "Ada", "Ада");
            TranslationUtils.ILTranslate(il, "Adam", "Адам");
            TranslationUtils.ILTranslate(il, "Aedan", "Айдан");
            TranslationUtils.ILTranslate(il, "Agaric", "Агарик");
            TranslationUtils.ILTranslate(il, "Agnew", "Агню");
            TranslationUtils.ILTranslate(il, "Ahinadab", "Ахинадав");
            TranslationUtils.ILTranslate(il, "Ahirom", "Ахиром");
            TranslationUtils.ILTranslate(il, "Akbar", "Акбар");
            TranslationUtils.ILTranslate(il, "Alalia", "Алалия");
            TranslationUtils.ILTranslate(il, "Alalia", "Алалия", 2);
            TranslationUtils.ILTranslate(il, "Alasdair", "Аластер");
            TranslationUtils.ILTranslate(il, "Alfred", "Альфред");
            TranslationUtils.ILTranslate(il, "Alfred", "Альфред", 2);
            TranslationUtils.ILTranslate(il, "Allison", "Эллисон");
            TranslationUtils.ILTranslate(il, "Alpha", "Альфа");
            TranslationUtils.ILTranslate(il, "Alura", "Алура");
            TranslationUtils.ILTranslate(il, "Amanita", "Аманита");
            TranslationUtils.ILTranslate(il, "Amy", "Эми");
            TranslationUtils.ILTranslate(il, "Amy", "Эми", 2);
            TranslationUtils.ILTranslate(il, "Andre", "Андре");
            TranslationUtils.ILTranslate(il, "Andrew", "Эндрю");
            TranslationUtils.ILTranslate(il, "Annabel", "Аннабель");
            TranslationUtils.ILTranslate(il, "Aphraim", "Эфрем");
            TranslationUtils.ILTranslate(il, "Arback", "Арбак");
            TranslationUtils.ILTranslate(il, "Arddun", "Арддун");
            TranslationUtils.ILTranslate(il, "Ariella", "Ариэлла");
            TranslationUtils.ILTranslate(il, "Arthur", "Артур");
            TranslationUtils.ILTranslate(il, "Arwyn", "Аруин");
            TranslationUtils.ILTranslate(il, "Asher", "Эшер");
            TranslationUtils.ILTranslate(il, "Autumn", "Отум");
            TranslationUtils.ILTranslate(il, "Bailey", "Бэйли");
            TranslationUtils.ILTranslate(il, "Bambi", "Бэмби");
            TranslationUtils.ILTranslate(il, "Barney", "Барни");
            TranslationUtils.ILTranslate(il, "Bart", "Барт");
            TranslationUtils.ILTranslate(il, "Batnoam", "Батном");
            TranslationUtils.ILTranslate(il, "Bazdin", "Бэйздин");
            TranslationUtils.ILTranslate(il, "Beldin", "Бельдин");
            TranslationUtils.ILTranslate(il, "Benjamin", "Бенджамин");
            TranslationUtils.ILTranslate(il, "Berwyn", "Беруин");
            TranslationUtils.ILTranslate(il, "Beta", "Бета");
            TranslationUtils.ILTranslate(il, "Biah", "Байя");
            TranslationUtils.ILTranslate(il, "Billy Marrows", "Билли Позвоночник");
            TranslationUtils.ILTranslate(il, "Billy", "Билли");
            TranslationUtils.ILTranslate(il, "Black Beard", "Чёрная Борода");
            TranslationUtils.ILTranslate(il, "Blanton", "Блэнтон");
            TranslationUtils.ILTranslate(il, "Bobby", "Бобби");
            TranslationUtils.ILTranslate(il, "Bodashtart", "Бодаштарт");
            TranslationUtils.ILTranslate(il, "Boften", "Бофтен");
            TranslationUtils.ILTranslate(il, "Bohemas", "Богемас");
            TranslationUtils.ILTranslate(il, "Bones McGee", "Костяной Макги");
            TranslationUtils.ILTranslate(il, "Bradley", "Брэдли");
            TranslationUtils.ILTranslate(il, "Brandon", "Брэндон");
            TranslationUtils.ILTranslate(il, "Brett", "Брэтт");
            TranslationUtils.ILTranslate(il, "Bri", "Бри");
            TranslationUtils.ILTranslate(il, "Brian", "Брайан");
            TranslationUtils.ILTranslate(il, "Brianne", "Брианна");
            TranslationUtils.ILTranslate(il, "Brimst", "Бримст");
            TranslationUtils.ILTranslate(il, "Bronson", "Бронсон");
            TranslationUtils.ILTranslate(il, "Brooke", "Брук");
            TranslationUtils.ILTranslate(il, "Bruno", "Бруно");
            TranslationUtils.ILTranslate(il, "Bryce", "Брайс");
            TranslationUtils.ILTranslate(il, "Bunny", "Заинька");
            TranslationUtils.ILTranslate(il, "Caelia", "Келия");
            TranslationUtils.ILTranslate(il, "Caitlin", "Катлин");
            TranslationUtils.ILTranslate(il, "Calista", "Калиста");
            TranslationUtils.ILTranslate(il, "Calvin", "Кельвин");
            TranslationUtils.ILTranslate(il, "Candy", "Карамелька");
            TranslationUtils.ILTranslate(il, "Captain Bullywort", "Капитан Булливорт");
            TranslationUtils.ILTranslate(il, "Captain Morgan", "Капитан Морган");
            TranslationUtils.ILTranslate(il, "Captain Stoney Dirt", "Капитан Грязный Камень");
            TranslationUtils.ILTranslate(il, "Carlo", "Карло");
            TranslationUtils.ILTranslate(il, "Carly", "Карли");
            TranslationUtils.ILTranslate(il, "Carroll", "Кэрролл");
            TranslationUtils.ILTranslate(il, "Cedric", "Седрик");
            TranslationUtils.ILTranslate(il, "Celestia", "Селестия");
            TranslationUtils.ILTranslate(il, "Chanterelle", "Лисичка");
            TranslationUtils.ILTranslate(il, "Charles", "Чарльз");
            TranslationUtils.ILTranslate(il, "Cherry", "Черри");
            TranslationUtils.ILTranslate(il, "Chester", "Честер");
            TranslationUtils.ILTranslate(il, "Chryseis", "Хризис");
            TranslationUtils.ILTranslate(il, "Ci", "Си");
            TranslationUtils.ILTranslate(il, "Claire", "Клэр");
            TranslationUtils.ILTranslate(il, "Cleveland", "Кливленд");
            TranslationUtils.ILTranslate(il, "Clive", "Клайв");
            TranslationUtils.ILTranslate(il, "Cody", "Коди");
            TranslationUtils.ILTranslate(il, "Cole", "Коул");
            TranslationUtils.ILTranslate(il, "Colin", "Колин");
            TranslationUtils.ILTranslate(il, "Connor", "Коннор");
            TranslationUtils.ILTranslate(il, "Cornelia", "Корнелия");
            TranslationUtils.ILTranslate(il, "Cremini", "Шампиньон");
            TranslationUtils.ILTranslate(il, "Cynthia", "Синтия");
            TranslationUtils.ILTranslate(il, "Cyril", "Сайрил");
            TranslationUtils.ILTranslate(il, "Dalamar", "Даламар");
            TranslationUtils.ILTranslate(il, "Dalek", "Далек");
            TranslationUtils.ILTranslate(il, "Danel", "Данел");
            TranslationUtils.ILTranslate(il, "Daniel", "Дэниел");
            TranslationUtils.ILTranslate(il, "Danny", "Дэнни");
            TranslationUtils.ILTranslate(il, "Dante", "Данте");
            TranslationUtils.ILTranslate(il, "Darius", "Дарий");
            TranslationUtils.ILTranslate(il, "Darnell", "Дарнелл");
            TranslationUtils.ILTranslate(il, "Darren", "Даррен");
            TranslationUtils.ILTranslate(il, "Darryl", "Деррил");
            TranslationUtils.ILTranslate(il, "Darur", "Дарур");
            TranslationUtils.ILTranslate(il, "Darz", "Дарз");
            TranslationUtils.ILTranslate(il, "David", "Дэвид");
            TranslationUtils.ILTranslate(il, "Dawn", "Заря");
            TranslationUtils.ILTranslate(il, "Dazzle", "Очаровашка");
            TranslationUtils.ILTranslate(il, "DeAndre", "ДеАндре");
            TranslationUtils.ILTranslate(il, "Delta", "Дельта");
            TranslationUtils.ILTranslate(il, "Demetrius", "Деметрий");
            TranslationUtils.ILTranslate(il, "DeShawn", "ДеШон");
            TranslationUtils.ILTranslate(il, "Destiny", "Дестини");
            TranslationUtils.ILTranslate(il, "Dias", "Диас");
            TranslationUtils.ILTranslate(il, "Dolbere", "Долбер");
            TranslationUtils.ILTranslate(il, "Dolgen", "Долген");
            TranslationUtils.ILTranslate(il, "Dolgrim", "Долгрим");
            TranslationUtils.ILTranslate(il, "Dominique", "Доминик");
            TranslationUtils.ILTranslate(il, "Duerthen", "Дюрфен");
            TranslationUtils.ILTranslate(il, "Dulais", "Дулаш");
            TranslationUtils.ILTranslate(il, "Durim", "Дурим");
            TranslationUtils.ILTranslate(il, "Durnok", "Дурнок");
            TranslationUtils.ILTranslate(il, "Dwyer", "Дуайер");
            TranslationUtils.ILTranslate(il, "Dylan", "Дилан");
            TranslationUtils.ILTranslate(il, "Edgar", "Эдгар");
            TranslationUtils.ILTranslate(il, "Edmund", "Эдмунд");
            TranslationUtils.ILTranslate(il, "Edmund", "Эдмунд", 2);
            TranslationUtils.ILTranslate(il, "Edward", "Эдвард");
            TranslationUtils.ILTranslate(il, "Edwin", "Эдвин");
            TranslationUtils.ILTranslate(il, "Eladon", "Эладон");
            TranslationUtils.ILTranslate(il, "Ella", "Элла");
            TranslationUtils.ILTranslate(il, "Ellen", "Эллен");
            TranslationUtils.ILTranslate(il, "Elric", "Элрик");
            TranslationUtils.ILTranslate(il, "Elysia", "Элизия");
            TranslationUtils.ILTranslate(il, "Emeline", "Эмелин");
            TranslationUtils.ILTranslate(il, "Emerenta", "Эмерента");
            TranslationUtils.ILTranslate(il, "Emily", "Эмили");
            TranslationUtils.ILTranslate(il, "Emma", "Эмма");
            TranslationUtils.ILTranslate(il, "Enoki", "Опёнок");
            TranslationUtils.ILTranslate(il, "Enzo", "Энцо");
            TranslationUtils.ILTranslate(il, "Esmeralda", "Эсмеральда");
            TranslationUtils.ILTranslate(il, "Esreadel", "Эсридель");
            TranslationUtils.ILTranslate(il, "Eugene", "Юджин");
            TranslationUtils.ILTranslate(il, "Eustace", "Юстас");
            TranslationUtils.ILTranslate(il, "Evvie", "Ивви");
            TranslationUtils.ILTranslate(il, "Fahd", "Фад");
            TranslationUtils.ILTranslate(il, "Fantasia", "Фантазия");
            TranslationUtils.ILTranslate(il, "Fantasy", "Фантазёрка");
            TranslationUtils.ILTranslate(il, "Faye", "Фэй");
            TranslationUtils.ILTranslate(il, "Felicitae", "Фелисити");
            TranslationUtils.ILTranslate(il, "Fender", "Фендер");
            TranslationUtils.ILTranslate(il, "Fidelia", "Фиделия");
            TranslationUtils.ILTranslate(il, "Fikod", "Фикод");
            TranslationUtils.ILTranslate(il, "Fillmore", "Филлмор");
            TranslationUtils.ILTranslate(il, "Finn", "Финн");
            TranslationUtils.ILTranslate(il, "Fitz", "Фитц");
            TranslationUtils.ILTranslate(il, "Fizban", "Физбан");
            TranslationUtils.ILTranslate(il, "Fjell", "Фьёль");
            TranslationUtils.ILTranslate(il, "Flora", "Флора");
            TranslationUtils.ILTranslate(il, "Frank", "Фрэнк");
            TranslationUtils.ILTranslate(il, "Frederick", "Фредерик");
            TranslationUtils.ILTranslate(il, "Gallius", "Галлий");
            TranslationUtils.ILTranslate(il, "Gamma", "Гамма");
            TranslationUtils.ILTranslate(il, "Garrett", "Гарретт");
            TranslationUtils.ILTranslate(il, "Garval", "Гарвал");
            TranslationUtils.ILTranslate(il, "Gboto", "Гбото");
            TranslationUtils.ILTranslate(il, "Gearroid", "Геррод");
            TranslationUtils.ILTranslate(il, "Gilbert", "Гилберт");
            TranslationUtils.ILTranslate(il, "Gimli", "Гимли");
            TranslationUtils.ILTranslate(il, "Gimut", "Гимут");
            TranslationUtils.ILTranslate(il, "Ginger", "Джинджер");
            TranslationUtils.ILTranslate(il, "Glitter", "Блёстка");
            TranslationUtils.ILTranslate(il, "Gloomy Mays", "Мрачный Мэйс");
            TranslationUtils.ILTranslate(il, "Gnudar", "Гнудар");
            TranslationUtils.ILTranslate(il, "Graham", "Грэм");
            TranslationUtils.ILTranslate(il, "Grayson", "Грейсон");
            TranslationUtils.ILTranslate(il, "Greum", "Грюм");
            TranslationUtils.ILTranslate(il, "Grodax", "Гродакс");
            TranslationUtils.ILTranslate(il, "Grover", "Гровер");
            TranslationUtils.ILTranslate(il, "Guido", "Гвидо");
            TranslationUtils.ILTranslate(il, "Gunpowder Garry", "Пороховой Гарри");
            TranslationUtils.ILTranslate(il, "Gus", "Гас");
            TranslationUtils.ILTranslate(il, "Gwentor", "Гвентор");
            TranslationUtils.ILTranslate(il, "Hannah", "Ханна");
            TranslationUtils.ILTranslate(il, "Hannibal", "Ганнибал");
            TranslationUtils.ILTranslate(il, "Hanno", "Ганнон");
            TranslationUtils.ILTranslate(il, "Harley", "Харли");
            TranslationUtils.ILTranslate(il, "Harold", "Гарольд");
            TranslationUtils.ILTranslate(il, "Harrison", "Гаррисон");
            TranslationUtils.ILTranslate(il, "Hazel", "Хэйзел");
            TranslationUtils.ILTranslate(il, "Heather", "Хэйзер");
            TranslationUtils.ILTranslate(il, "Helen", "Хелен");
            TranslationUtils.ILTranslate(il, "Henry", "Генри");
            TranslationUtils.ILTranslate(il, "Herald", "Геральд");
            TranslationUtils.ILTranslate(il, "Herbert", "Герберт");
            TranslationUtils.ILTranslate(il, "Hirael", "Хираэль");
            TranslationUtils.ILTranslate(il, "Hiram", "Хирам");
            TranslationUtils.ILTranslate(il, "Holly", "Холли");
            TranslationUtils.ILTranslate(il, "Hope", "Хоуп");
            TranslationUtils.ILTranslate(il, "Howard", "Говард");
            TranslationUtils.ILTranslate(il, "Humphrey", "Хамфри");
            TranslationUtils.ILTranslate(il, "Iris", "Айрис");
            TranslationUtils.ILTranslate(il, "Isaac", "Айзек");
            TranslationUtils.ILTranslate(il, "Isabella", "Изабелла");
            TranslationUtils.ILTranslate(il, "Isis", "Айзис");
            TranslationUtils.ILTranslate(il, "Isis", "Айзис", 2);
            TranslationUtils.ILTranslate(il, "Ivan", "Айвен");
            TranslationUtils.ILTranslate(il, "Izzy", "Иззи");
            TranslationUtils.ILTranslate(il, "Jack Sellington", "Джек Селлингтон");
            TranslationUtils.ILTranslate(il, "Jack", "Джек");
            TranslationUtils.ILTranslate(il, "Jack", "Джек", 2);
            TranslationUtils.ILTranslate(il, "Jacob", "Джейкоб");
            TranslationUtils.ILTranslate(il, "Jake", "Джейк");
            TranslationUtils.ILTranslate(il, "Jake", "Джейк", 2);
            TranslationUtils.ILTranslate(il, "Jalen", "Джален");
            TranslationUtils.ILTranslate(il, "Jamal", "Джамал");
            TranslationUtils.ILTranslate(il, "James", "Джеймс");
            TranslationUtils.ILTranslate(il, "James T. Beard", "Джеймс Т. Борода");
            TranslationUtils.ILTranslate(il, "Jamundi", "Хамунди");
            TranslationUtils.ILTranslate(il, "Jarut", "Джарут");
            TranslationUtils.ILTranslate(il, "Jeff", "Джефф");
            TranslationUtils.ILTranslate(il, "Jeffrey", "Джеффри");
            TranslationUtils.ILTranslate(il, "Jenna", "Дженна");
            TranslationUtils.ILTranslate(il, "Jenny", "Дженни");
            TranslationUtils.ILTranslate(il, "Jey", "Джей");
            TranslationUtils.ILTranslate(il, "Jimmy", "Джимми");
            TranslationUtils.ILTranslate(il, "Joe", "Джо");
            TranslationUtils.ILTranslate(il, "Johnny", "Джонни");
            TranslationUtils.ILTranslate(il, "Joseph", "Джозеф");
            TranslationUtils.ILTranslate(il, "Judith", "Джудит");
            TranslationUtils.ILTranslate(il, "Kaitlin", "Кэтлин");
            TranslationUtils.ILTranslate(il, "Kaitlyn", "Кейтлин");
            TranslationUtils.ILTranslate(il, "Kanmi", "Канми");
            TranslationUtils.ILTranslate(il, "Kappa", "Каппа");
            TranslationUtils.ILTranslate(il, "Katelyn", "Кейтилин");
            TranslationUtils.ILTranslate(il, "Katherine", "Кейтрин");
            TranslationUtils.ILTranslate(il, "Kathryn", "Катрин");
            TranslationUtils.ILTranslate(il, "Kati", "Кати");
            TranslationUtils.ILTranslate(il, "Katie", "Кейти");
            TranslationUtils.ILTranslate(il, "Kayla", "Кайла");
            TranslationUtils.ILTranslate(il, "Kayla", "Кайла", 2);
            TranslationUtils.ILTranslate(il, "Kevin", "Кевин");
            TranslationUtils.ILTranslate(il, "Knogs", "Ногс");
            TranslationUtils.ILTranslate(il, "Knub", "Наб");
            TranslationUtils.ILTranslate(il, "Kogi-ghi", "Коги-гхи");
            TranslationUtils.ILTranslate(il, "Konah", "Кона");
            TranslationUtils.ILTranslate(il, "Korrie", "Корри");
            TranslationUtils.ILTranslate(il, "Kyle", "Кайл");
            TranslationUtils.ILTranslate(il, "Kylie", "Кайли");
            TranslationUtils.ILTranslate(il, "Lambda", "Лямбда");
            TranslationUtils.ILTranslate(il, "Lauren", "Лорен");
            TranslationUtils.ILTranslate(il, "Leila", "Лейла");
            TranslationUtils.ILTranslate(il, "Leomund", "Леомунд");
            TranslationUtils.ILTranslate(il, "Leonardo", "Леонардо");
            TranslationUtils.ILTranslate(il, "Levi", "Леви");
            TranslationUtils.ILTranslate(il, "Lexus", "Лексус");
            TranslationUtils.ILTranslate(il, "Lilly", "Лили");
            TranslationUtils.ILTranslate(il, "Lincoln", "Линкольн");
            TranslationUtils.ILTranslate(il, "Lisa", "Лиза");
            TranslationUtils.ILTranslate(il, "Llewellyn", "Ллеуэллин");
            TranslationUtils.ILTranslate(il, "Lloyd", "Ллойд");
            TranslationUtils.ILTranslate(il, "Lloyd", "Ллойд", 2);
            TranslationUtils.ILTranslate(il, "Logan", "Логан");
            TranslationUtils.ILTranslate(il, "Lola", "Лола");
            TranslationUtils.ILTranslate(il, "Lorenzo", "Лоренцо");
            TranslationUtils.ILTranslate(il, "Lorraine", "Лоррейн");
            TranslationUtils.ILTranslate(il, "Louis", "Луис");
            TranslationUtils.ILTranslate(il, "Luca", "Лука");
            TranslationUtils.ILTranslate(il, "Luciano", "Лучиано");
            TranslationUtils.ILTranslate(il, "Ludo", "Людо");
            TranslationUtils.ILTranslate(il, "Luigi", "Луиджи");
            TranslationUtils.ILTranslate(il, "Luke", "Люк");
            TranslationUtils.ILTranslate(il, "Lunette", "Люнетт");
            TranslationUtils.ILTranslate(il, "Lydia", "Лидия");
            TranslationUtils.ILTranslate(il, "Lyndon", "Линдон");
            TranslationUtils.ILTranslate(il, "Madeline", "Мэделин");
            TranslationUtils.ILTranslate(il, "Maelor", "Маэлор");
            TranslationUtils.ILTranslate(il, "Magius", "Магиус");
            TranslationUtils.ILTranslate(il, "Maitake", "Грифола");
            TranslationUtils.ILTranslate(il, "Malik", "Малик");
            TranslationUtils.ILTranslate(il, "Mandible Calavera", "Челюстной Калавера");
            TranslationUtils.ILTranslate(il, "Marco", "Марко");
            TranslationUtils.ILTranslate(il, "Mario", "Марио");
            TranslationUtils.ILTranslate(il, "Marquis", "Маркис");
            TranslationUtils.ILTranslate(il, "Marshanna", "Маршанна");
            TranslationUtils.ILTranslate(il, "Martino", "Мартино");
            TranslationUtils.ILTranslate(il, "Marty", "Марти");
            TranslationUtils.ILTranslate(il, "Matty", "Мэтти");
            TranslationUtils.ILTranslate(il, "Maurice", "Морис");
            TranslationUtils.ILTranslate(il, "Mauro", "Мауро");
            TranslationUtils.ILTranslate(il, "Maxwell", "Максвелл");
            TranslationUtils.ILTranslate(il, "McKinly", "Мак-Кинли");
            TranslationUtils.ILTranslate(il, "Meliyah", "Мелия");
            TranslationUtils.ILTranslate(il, "Mercer", "Мерсер");
            TranslationUtils.ILTranslate(il, "Meredith", "Мередит");
            TranslationUtils.ILTranslate(il, "Merlyn", "Мерлин");
            TranslationUtils.ILTranslate(il, "Mervyn", "Мервин");
            TranslationUtils.ILTranslate(il, "Mika", "Мика");
            TranslationUtils.ILTranslate(il, "Miles", "Майлз");
            TranslationUtils.ILTranslate(il, "Millard", "Миллард");
            TranslationUtils.ILTranslate(il, "Milton", "Милтон");
            TranslationUtils.ILTranslate(il, "Minerva", "Минерва");
            TranslationUtils.ILTranslate(il, "Mobart", "Мобарт");
            TranslationUtils.ILTranslate(il, "Molly", "Молли");
            TranslationUtils.ILTranslate(il, "Morel", "Сморчок");
            TranslationUtils.ILTranslate(il, "Morthal", "Морфал");
            TranslationUtils.ILTranslate(il, "Mortimer", "Мортимер");
            TranslationUtils.ILTranslate(il, "Mrunok", "Мрунок");
            TranslationUtils.ILTranslate(il, "Mu", "Мю");
            TranslationUtils.ILTranslate(il, "Muscaria", "Мухомор");
            TranslationUtils.ILTranslate(il, "Nancy", "Нэнси");
            TranslationUtils.ILTranslate(il, "Nata", "Ната");
            TranslationUtils.ILTranslate(il, "Nathan", "Нейтан");
            TranslationUtils.ILTranslate(il, "Negurk", "Негурк");
            TranslationUtils.ILTranslate(il, "Nigel", "Найджел");
            TranslationUtils.ILTranslate(il, "Niner-7", "Девятый-7");
            TranslationUtils.ILTranslate(il, "Ningauble", "Нингобль");
            TranslationUtils.ILTranslate(il, "Nissa", "Нисса");
            TranslationUtils.ILTranslate(il, "No-Eyed Wiley", "Безглазый Уайли");
            TranslationUtils.ILTranslate(il, "Norkas", "Норкас");
            TranslationUtils.ILTranslate(il, "Norsun", "Норсун");
            TranslationUtils.ILTranslate(il, "Nort", "Норт");
            TranslationUtils.ILTranslate(il, "Nu", "Ню");
            TranslationUtils.ILTranslate(il, "Nuxatk", "Нузатк");
            TranslationUtils.ILTranslate(il, "Omega", "Омега");
            TranslationUtils.ILTranslate(il, "Omicron", "Омикрон");
            TranslationUtils.ILTranslate(il, "Opuni", "Опуни");
            TranslationUtils.ILTranslate(il, "Oten", "Оутен");
            TranslationUtils.ILTranslate(il, "Ovbere", "Овбер");
            TranslationUtils.ILTranslate(il, "Paris", "Пэрис");
            TranslationUtils.ILTranslate(il, "Pearl", "Пёрл");
            TranslationUtils.ILTranslate(il, "Petra", "Петра");
            TranslationUtils.ILTranslate(il, "Phi", "Пи");
            TranslationUtils.ILTranslate(il, "Phi", "Пи", 2);
            TranslationUtils.ILTranslate(il, "Phillip", "Филлип");
            TranslationUtils.ILTranslate(il, "Philosir", "Филозир");
            TranslationUtils.ILTranslate(il, "Phoebe", "Фиби");
            TranslationUtils.ILTranslate(il, "Pip", "Пип");
            TranslationUtils.ILTranslate(il, "Porcini", "Боровик");
            TranslationUtils.ILTranslate(il, "Ragz", "Рагз");
            TranslationUtils.ILTranslate(il, "Ralph", "Ральф");
            TranslationUtils.ILTranslate(il, "Raphael", "Рафаэль");
            TranslationUtils.ILTranslate(il, "Rattles Magoo", "Гремящий Магу");
            TranslationUtils.ILTranslate(il, "Rawleigh", "Роули");
            TranslationUtils.ILTranslate(il, "Red Beard", "Рыжебородый");
            TranslationUtils.ILTranslate(il, "Reginald", "Реджинальд");
            TranslationUtils.ILTranslate(il, "Reishi", "Трутовик");
            TranslationUtils.ILTranslate(il, "Rho", "Ро");
            TranslationUtils.ILTranslate(il, "Riley", "Райли");
            TranslationUtils.ILTranslate(il, "Rodney", "Родни");
            TranslationUtils.ILTranslate(il, "Rodrick", "Родрик");
            TranslationUtils.ILTranslate(il, "Roland", "Роланд");
            TranslationUtils.ILTranslate(il, "Romeo", "Ромео");
            TranslationUtils.ILTranslate(il, "Ronald", "Рональд");
            TranslationUtils.ILTranslate(il, "Rosalva", "Розалва");
            TranslationUtils.ILTranslate(il, "Rox", "Рокс");
            TranslationUtils.ILTranslate(il, "Roxanne", "Роксана");
            TranslationUtils.ILTranslate(il, "Ruby", "Руби");
            TranslationUtils.ILTranslate(il, "Rupert", "Руперт");
            TranslationUtils.ILTranslate(il, "Rutherford", "Ратерфорд");
            TranslationUtils.ILTranslate(il, "Ryan", "Райан");
            TranslationUtils.ILTranslate(il, "Sally", "Салли");
            TranslationUtils.ILTranslate(il, "Sammy", "Сэмми");
            TranslationUtils.ILTranslate(il, "Sargon", "Саргон");
            TranslationUtils.ILTranslate(il, "Sarx", "Саркс");
            TranslationUtils.ILTranslate(il, "Savannah", "Саванна");
            TranslationUtils.ILTranslate(il, "Scarlett", "Скарлетт");
            TranslationUtils.ILTranslate(il, "Scott", "Скотт");
            TranslationUtils.ILTranslate(il, "Sebastian", "Себастьян");
            TranslationUtils.ILTranslate(il, "Selah", "Сэла");
            TranslationUtils.ILTranslate(il, "Selene", "Селена");
            TranslationUtils.ILTranslate(il, "Selina", "Селина");
            TranslationUtils.ILTranslate(il, "Seonag", "Шонаг");
            TranslationUtils.ILTranslate(il, "Seth", "Сет");
            TranslationUtils.ILTranslate(il, "Seymour", "Сеймур");
            TranslationUtils.ILTranslate(il, "Shayna", "Шайна");
            TranslationUtils.ILTranslate(il, "Shea", "Шия");
            TranslationUtils.ILTranslate(il, "Sheena", "Шина");
            TranslationUtils.ILTranslate(il, "Shiitake", "Лентинула");
            TranslationUtils.ILTranslate(il, "Shimeji", "Рядовка");
            TranslationUtils.ILTranslate(il, "Shipton", "Шиптон");
            TranslationUtils.ILTranslate(il, "Shirlena", "Ширлена");
            TranslationUtils.ILTranslate(il, "Sigma", "Сигма");
            TranslationUtils.ILTranslate(il, "Sikarbaal", "Сикарбаал");
            TranslationUtils.ILTranslate(il, "Simon", "Саймон");
            TranslationUtils.ILTranslate(il, "Skellington", "Скеллингтон");
            TranslationUtils.ILTranslate(il, "Smador", "Смадор");
            TranslationUtils.ILTranslate(il, "Sophia", "София");
            TranslationUtils.ILTranslate(il, "Sparkle", "Искорка");
            TranslationUtils.ILTranslate(il, "Spencer", "Спенсер");
            TranslationUtils.ILTranslate(il, "Star", "Звёздочка");
            TranslationUtils.ILTranslate(il, "Stazen", "Стацен");
            TranslationUtils.ILTranslate(il, "Stefano", "Стефано");
            TranslationUtils.ILTranslate(il, "Stella", "Стелла");
            TranslationUtils.ILTranslate(il, "Steve", "Стив");
            TranslationUtils.ILTranslate(il, "Stezom", "Стезом");
            TranslationUtils.ILTranslate(il, "Sugar", "Милашка");
            TranslationUtils.ILTranslate(il, "Susana", "Сюзанна");
            TranslationUtils.ILTranslate(il, "Syn-X", "Син-Х");
            TranslationUtils.ILTranslate(il, "T-3E0", "Т-3Е0");
            TranslationUtils.ILTranslate(il, "Tabnit", "Табнит");
            TranslationUtils.ILTranslate(il, "Tagar", "Тагар");
            TranslationUtils.ILTranslate(il, "Tairona", "Тайрона");
            TranslationUtils.ILTranslate(il, "Tallulah", "Таллула");
            TranslationUtils.ILTranslate(il, "Tania", "Таня");
            TranslationUtils.ILTranslate(il, "Tanner", "Таннер");
            TranslationUtils.ILTranslate(il, "Tatiana", "Татьяна");
            TranslationUtils.ILTranslate(il, "Terra", "Терра");
            TranslationUtils.ILTranslate(il, "Terrance", "Терренс");
            TranslationUtils.ILTranslate(il, "Terrell", "Террелл");
            TranslationUtils.ILTranslate(il, "Tgerd", "Тгерд");
            TranslationUtils.ILTranslate(il, "Theodore", "Теодор");
            TranslationUtils.ILTranslate(il, "Theta", "Тета");
            TranslationUtils.ILTranslate(il, "Timmy", "Тимми");
            TranslationUtils.ILTranslate(il, "Tkanus", "Тканус");
            TranslationUtils.ILTranslate(il, "Tom", "Том");
            TranslationUtils.ILTranslate(il, "Tony", "Тони");
            TranslationUtils.ILTranslate(il, "Tordak", "Тордак");
            TranslationUtils.ILTranslate(il, "Trent", "Трент");
            TranslationUtils.ILTranslate(il, "Trevon", "Тревон");
            TranslationUtils.ILTranslate(il, "Trisha", "Триша");
            TranslationUtils.ILTranslate(il, "Trixy", "Проказница");
            TranslationUtils.ILTranslate(il, "Trogem", "Трогем");
            TranslationUtils.ILTranslate(il, "Tweed", "Твид");
            TranslationUtils.ILTranslate(il, "Tyler", "Тайлер");
            TranslationUtils.ILTranslate(il, "Tyrone", "Тайрон");
            TranslationUtils.ILTranslate(il, "U'wa", "У'ва");
            TranslationUtils.ILTranslate(il, "Upsilon", "Ипсилон");
            TranslationUtils.ILTranslate(il, "Urist", "Урист");
            TranslationUtils.ILTranslate(il, "Verity", "Верити");
            TranslationUtils.ILTranslate(il, "Vivian", "Вивиан");
            TranslationUtils.ILTranslate(il, "Walter", "Уолтер");
            TranslationUtils.ILTranslate(il, "Warren", "Уоррен");
            TranslationUtils.ILTranslate(il, "Wet Beard", "Мокрая Борода");
            TranslationUtils.ILTranslate(il, "Whitney", "Уитни");
            TranslationUtils.ILTranslate(il, "Wilbur", "Уилбур");
            TranslationUtils.ILTranslate(il, "Willie", "Уилли");
            TranslationUtils.ILTranslate(il, "Willy", "Уилли");
            TranslationUtils.ILTranslate(il, "Woodrow", "Вудро");
            TranslationUtils.ILTranslate(il, "Wyatt", "Уайатт");
            TranslationUtils.ILTranslate(il, "Xanadu", "Занаду");
            TranslationUtils.ILTranslate(il, "Xanos", "Ксанос");
            TranslationUtils.ILTranslate(il, "Xavier", "Ксавьер");
            TranslationUtils.ILTranslate(il, "Xirigua", "Зиригуа");
            TranslationUtils.ILTranslate(il, "Xon", "Ксон");
            TranslationUtils.ILTranslate(il, "Xylia", "Силия");
            TranslationUtils.ILTranslate(il, "Yehomilk", "Йехомилк");
            TranslationUtils.ILTranslate(il, "Yutpan", "Ютпан");
            TranslationUtils.ILTranslate(il, "Zach", "Зак");
            TranslationUtils.ILTranslate(il, "Zelda", "Зельда");
            TranslationUtils.ILTranslate(il, "Zeta", "Дзета");
            TranslationUtils.ILTranslate(il, "Zop'a", "Зопа");
            TranslationUtils.ILTranslate(il, "Zylphia", "Зильфия");
        }
    }

    public class AffixNameIL : ILEdit
    {
        public override bool Autoload() => TranslationUtils.IsRussianLanguage && ModsCall.Calamity == null;

        public override void Load() => Item.AffixName += ItemOnAffixName;
        
        public override void Unload() => Item.AffixName -= ItemOnAffixName;
        
        private string ItemOnAffixName(Item.orig_AffixName orig, Terraria.Item self)
        {
            if (self.prefix >= Lang.prefix.Length)
                return self.Name;

            string prefix = Lang.prefix[self.prefix].Value;
            if (prefix == string.Empty)
                return self.Name;

            for (int i = 0; i < RussianPrefixOverhaul.Prefixes.Length; i++)
            {
                if (RussianPrefixOverhaul.Prefixes[i][0] == prefix)
                    return RussianPrefixOverhaul.GetGenderedPrefix(RussianPrefixOverhaul.Prefixes[i], self.type) + " " + self.Name.ToLower();
            }

            return prefix + " " + self.Name;
        }
    }
    
    public class AffixNameWithCalamityIL : ILEdit
    {
        public override bool Autoload() => TranslationUtils.IsRussianLanguage && ModsCall.Calamity != null;

        public override void Load() => Item.AffixName += ItemOnAffixName;
        
        public override void Unload() => Item.AffixName -= ItemOnAffixName;
        
        private string ItemOnAffixName(Item.orig_AffixName orig, Terraria.Item self)
        {
            string calamityEnchantment = string.Empty;
            string goblinPrefix = string.Empty;

            for (int i = 0; i < RussianPrefixOverhaul.Prefixes.Length; i++)
            {
                if (!self.IsAir && self.Calamity().AppliedEnchantment != null)
                {
                    if (RussianPrefixOverhaul.Prefixes[i][0] == self.Calamity().AppliedEnchantment?.Name)
                        calamityEnchantment = RussianPrefixOverhaul.GetGenderedPrefix(RussianPrefixOverhaul.Prefixes[i], self.type) + " ";

                    if (calamityEnchantment != string.Empty)
                        goblinPrefix = goblinPrefix.ToLower();
                }

                if (RussianPrefixOverhaul.Prefixes[i][0] == Lang.prefix[self.prefix].Value)
                    goblinPrefix = RussianPrefixOverhaul.GetGenderedPrefix(RussianPrefixOverhaul.Prefixes[i], self.type) + " ";
            }

            if (goblinPrefix == string.Empty && calamityEnchantment == string.Empty)
                return self.Name;

            return calamityEnchantment + goblinPrefix + self.Name.ToLower();
        }
    }
}