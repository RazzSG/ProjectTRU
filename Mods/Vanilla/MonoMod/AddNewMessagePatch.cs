using CalamityRuTranslate.Common.Utilities;
using Microsoft.Xna.Framework;
using Terraria.GameContent.UI.Chat;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;

public class AddNewMessagePatch : ILoadable
{
    public bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public void Load(Mod mod)
    {
        On_RemadeChatMonitor.AddNewMessage += On_RemadeChatMonitorOnAddNewMessage;
    }

    public void Unload()
    {
        On_RemadeChatMonitor.AddNewMessage -= On_RemadeChatMonitorOnAddNewMessage;
    }
    
    private void On_RemadeChatMonitorOnAddNewMessage(On_RemadeChatMonitor.orig_AddNewMessage orig, RemadeChatMonitor self, string text, Color color, int widthlimitinpixels)
    {
        // Fargo
        if (text.Contains("Battle Cry activated for"))
            text = text.Replace("Battle Cry activated for" , "Боевой клич активирован для");
        if (text.Contains("Battle Cry deactivated for"))
            text = text.Replace("Battle Cry deactivated for", "Боевой клич деактивирован для");
        if (text.Contains("Calming Cry activated for"))
            text = text.Replace("Calming Cry activated for", "Умиротворяющий клич активирован для");
        if (text.Contains("Calming Cry deactivated for"))
            text = text.Replace("Calming Cry deactivated for", "Умиротворяющий клич деактивирован для");
        if (text.Contains("Killed:"))
            text = text.Replace("Killed", "Убито");
        if (text.Contains("Total:"))
            text = text.Replace("Total", "Всего");
        // Infernum
        if (text.Contains("was somehow impaled by a pillar of crystals."))
            text = text.Replace("was somehow impaled by a pillar of crystals.", "неведомым образом пронзается кристальной колонной.");
        if (text.Contains("was blown up."))
            text = text.Replace("was blown up.", "взрывается.");
        if (text.Contains("could not withstand the red lightning."))
            text = text.Replace("could not withstand the red lightning.", "не выдерживает красной молнии.");
        if (text.Contains("was incinerated by ungodly fire."))
            text = text.Replace("was incinerated by ungodly fire.", "сгорает осквернённым огнём.");
        if (text.Contains("went mad."))
            text = text.Replace("went mad.", "сходит с ума.");
        if (text.Contains("was repelled by celestial forces."))
            text = text.Replace("was repelled by celestial forces.", "отбрасывается неземными силами.");
        if (text.Contains("was violently pricked by roses."))
            text = text.Replace("was violently pricked by roses.", "яростно закалывается розами.");
        if (text.Contains("Profaned Garden location"))
        {
            text = text.Replace("Profaned Garden location moved from", "Положение осквернённого сада перемещено с");
            text = text.Replace("Profaned Garden location reverted to", "Положение осквернённого сада возвращено на");
            text = text.Replace("from", "с");
            text = text.Replace("to", "на");
        }

        text = text switch
        {
            // Fargo
            "The invaders have left!" => "Вторженцы отступили!",
            "The Pumpkin Moon is lowering..." => "Заходит тыквенная луна...",
            "The Frost Moon is lowering..." => "Заходит морозная луна...",
            "A solar eclipse is not happening!" => "Солнечное затмение не происходит!",
            "The blood moon is descending..." => "Кровавая луна опускается за горизонт...",
            "The wind has ended!" => "Ветер утих!",
            "The Old One's Army is leaving!" => "Армия Древних отступила!",
            "The sandstorm has ended!" => "Песчаная буря утихла!",
            "Celestial creatures are not invading!" => "Неземные сущности не атакуют!",
            "The rain has ended!" => "Дождь прекратился!",
            "Queen Bee has awoken!" => "Королева пчёл пробудилась!",
            "Medusa has awoken!" => "Медуза пробудилась!",
            "Undead Miner has awoken!" => "Нежить-шахтёр пробудился!",
            "Ogre has awoken!" => "Огр пробудился!",
            "Betsy has awoken!" => "Бэтси пробудилась!",
            "Dreadnautilus has awoken!" => "Дреднаутилус пробудился!",
            "Blood Eel has awoken!" => "Кровавый угорь пробудился!",
            "Moon Lord has awoken!" => "Лунный лорд пробудился!",
            "Wyvern has awoken!" => "Виверна пробудилась!",
            "Clown has awoken!" => "Клоун пробудился!",
            "Ice Golem has awoken!" => "Ледяной голем пробудился!",
            "Corrupt Mimic has awoken!" => "Искажённый мимик пробудился!",
            "Crimson Mimic has awoken!" => "Багряный мимик пробудился!",
            "Lunatic Cultist has awoken!" => "Культист-лунатик пробудился!",
            "Deerclops has awoken!" => "Циклоп-олень пробудился!",
            "Red Devil has awoken!" => "Красный дьявол пробудился!",
            "Rainbow Slime has awoken!" => "Радужный слизень пробудился!",
            "Doctor Bones has awoken!" => "Доктор Бонс пробудился!",
            "Everscream has awoken!" => "Вечнокричащая ель пробудилась!",
            "Sand Elemental has awoken!" => "Песчаный элементаль пробудился!",
            "Dark Mage has awoken!" => "Тёмный маг пробудился!",
            "Gnome has awoken!" => "Гном пробудился!",
            "Goblin Scout has awoken!" => "Гоблин-разведчик пробудился!",
            "Golden Slime has awoken!" => "Золотой слизень пробудился!",
            "Brain of Cthulhu has awoken!" => "Мозг Ктулху пробудился!",
            "Paladin has awoken!" => "Паладин пробудился!",
            "Hallowed Mimic has awoken!" => "Освящённый мимик пробудился!",
            "Headless Horseman has awoken!" => "Всадник без головы пробудился!",
            "Nymph has awoken!" => "Нимфа пробудилась!",
            "Hemogoblin Shark has awoken!" => "Акула-гемогоблин пробудилась!",
            "Tim has awoken!" => "Тим пробудился!",
            "Ice Queen has awoken!" => "Ледяная королева пробудилась!",
            "Queen Slime has awoken!" => "Королева слизней пробудилась!",
            "Santa-NK1 has awoken!" => "Санта-NK1 пробудился!",
            "Eater of Worlds has awoken!" => "Пожиратель миров пробудился!",
            "Digger has awoken!" => "Землекоп пробудился!",
            "Giant Worm has awoken!" => "Гигантский червь пробудился!",
            "Duke Fishron has awoken!" => "Герцог рыброн пробудился!",
            "Dungeon Guardian has awoken!" => "Страж темницы пробудился!",
            "Skeletron has awoken!" => "Скелетрон пробудился!",
            "Pumpking has awoken!" => "Тыквенный король пробудился!",
            "Mimic has awoken!" => "Мимик пробудился!",
            "Eye of Cthulhu has awoken!" => "Глаз Ктулху пробудился!",
            "Mourning Wood has awoken!" => "Плакучий древень пробудился!",
            "Dungeon Slime has awoken!" => "Слизень Темницы пробудился!",
            "King Slime has awoken!" => "Король слизней пробудился!",
            "Goblin Summoner has awoken!" => "Гоблин-чернокнижник пробудился!",
            "Rune Wizard has awoken!" => "Руномант пробудился!",
            "Empress of Light has awoken!" => "Императрица света пробудилась!",
            "Flying Dutchman has awoken!" => "Летучий голландец пробудился!",
            "Plantera has awoken!" => "Плантера пробудилась!",
            "Pirate Captain has awoken!" => "Капитан пиратов пробудился!",
            "Pinky has awoken!" => "Пинки пробудился!",
            "Nailhead has awoken!" => "Гвоздеголовый пробудился!",
            "Bone Lee has awoken!" => "Костюс Ли пробудился!",
            "Jungle Mimic has awoken!" => "Мимик джунглей пробудился!",
            "Mothron has awoken!" => "Мотрон пробудилась!",
            "Moth has awoken!" => "Мотылёк пробудился!",
            "The Destroyer has awoken!" => "Уничтожитель пробудился!",
            "Skeletron Prime has awoken!" => "Скелетрон Прайм пробудился!",
            "Martian Saucer has awoken!" => "Марсианская тарелка пробудилась!",
            "Golem has awoken!" => "Голем пробудился!",
            "The Celestial Pillars have awoken!" => "Неземные башни пробудились!",
            "The Twins have awoken!" => "Близнецы пробудились!",
            "Every boss has awoken!" => "Все боссы пробудились!",
            "Several bosses have awoken!" => "Несколько боссов пробудились!",
            "The wind begins howling." => "Начинает завывать ветер.",
            "The jungle beats as one!" => "Джунгли бьются как единое целое!",
            "A sandstorm has begun." => "Начинается песчаная буря.",
            "A deafening buzz pierces through you!" => "Оглушающее жужжание пронзает ваши уши!",
            "The real Old One's Army is attacking!" => "Истинная армия Древних атакует!",
            "Rain clouds cover the sky." => "Тучи закрывают небо.",
            "Lantern Night rate restored to default." => "Шанс на ночь фонарей сброшен к изначальному.",
            "The ground shifts with formulated precision!" => "Земля под вашими ногами раздвигается с удивительной точностью!",
            "Lantern Night rate increased!" => "Шанс на ночь фонарей увеличен!",
            "A fortress of flesh arises from the depths!" => "Крепость плоти возникает из глубин!",
            "A legion of glowing iris sing a dreadful song!" => "Полчища светящихся глаз поют зловещую песню!",
            "Welcome to the true slime rain!" => "Добро пожаловать в истинный слизнепад!",
            "A great clammering of bones rises from the dungeon!" => "Огромные груды костей восстают из Темницы!",
            "A sickly chill envelops the world!" => "Мир окутывает мерзкий холод!",
            "Welcome to the truer slime rain!" => "Добро пожаловать в истинно верный слизнепад!",
            "The Pumpkin Moon fades away!" => "Тыквенная луна исчезает!",
            "The Pumpkin Moon is rising..." => "Восходит тыквенная луна...",
            "Wave: 15: Everything" => "Волна 15: Все",
            "The pirates have calmed down!" => "Пираты успокаиваются!",
            "The wind whispers of death's approach!" => "Ветер шепчет о приближающейся смерти!",
            "The martians have calmed down!" => "Марсиане успокаиваются!",
            "Ancient automatons come crashing down!" => "На вас обрушиваются древние автоматоны!",
            "The goblins have calmed down!" => "Гоблины успокаиваются!",
            "The Frost Moon fades away!" => "Морозная луна исчезает!",
            "The Frost Moon is rising..." => "Восходит морозная луна...",
            "Wave: 20: Everything" => "Волна 20: Все",
            "The ocean swells with ferocious pigs!" => "Океан наполняется свирепыми свиньями!",
            "Countless eyes pierce the veil staring in your direction!" => "Вы ощущаете на себе бесчисленные взгляды!",
            "Bullet heaven is descending!" => "Пулевой рай снисходит!",
            "The planet trembles from the core!" => "Вся планета дрожит!",
            "The Constant takes over!" => "Константа берёт своё!",
            "You feel like you're in a library!" => "Вы чувствуете, словно находитесь в библиотеке!",
            "Defeaning chants fill your ears!" => "Оглушающие песнопения заполняют ваши уши!",
            "You feel dumb among so many brains!" => "Количество мозгов вокруг заставляет вас чувствовать себя тупым!",
            "Betsy has been defeated!" => "Бэтси побеждена!",
            "A new item has been unlocked in Deviantt's shop!" => "В магазине Девиантт появился новый предмет!",
            "A new item has been unlocked in Abominationn's shop!" => "В магазине Мерзостти появился новый предмет!",
            "The swarm has been defeated!" => "Орда побеждена!",
            
            // StarsAbove
            // "The Spatial Disk begins to resonate. Left click to interact." => "Пространственный диск резонирует. Нажмите ЛКМ для взаимодействия.",
            // "Nalhaun, the Burnished King appears!" => "Налхан, Воронёный король появляется!",
            // "Magical energy coalesces around you..." => "Вокруг вас сгущается магическая энергия...",
            // "Penthesilea, The Witch of Ink draws near!" => "Пентесилея, Ведьма чернил, нарисовалась поблизости!",
            // "The world shudders in anticipation..." => "Мир содрогается в ожидании...",
            // "Arbitration descends!" => "Арбитраж снисходит!",
            // "You have been judged..." => "Вас осудили",
            // "You've been colored with ink!" => "Вас раскрасили чернилами!",
            // "Time and space begin to crumble, their laws forsaken!" => "Время и пространство начинают распадаться, их законы забыты!",
            // "The expanse around you begins to contract..." => "Окружающее пространство начинает сжиматься...",
            // "Two demons, locked in conflict, appear at your sides." => "",
            // "You fall to the Witch of Ink..." => "Вы пали перед Ведьмой чернил...",
            // "The Garden of Avalon stifles your healing!" => "Сад Авалона подавляет ваше исцеление!",
            // "Penth is protected by a shield of frost!" => "Пентесилея защищена щитом мороза!",
            // "Overwhelming power surrounds you..." => "Вокруг вас кипит сила...",
            // "You feel the next attack is truly unsurvivable!" => "Вы чуствуете, что следующую атаку невозможно пережить!",
            // "The Warrior Of Light has won..." => "",
            // "The Warrior of Light is transcending his limits!" => "",
            // "The fabric of this world begins to fray!" => "",
            // "Your final days have arrived..." => "",
            // "The Stellar Array reaches new heights!" => "",
            
            // Thorium
            "It appears to be waiting for night..." => "Похоже, оно ждёт наступления ночи...",
            "It seems to be dormant..." => "Похоже, что оно дремлет...",
            _ => text
        };

        orig.Invoke(self, text, color, widthlimitinpixels);
    }
}