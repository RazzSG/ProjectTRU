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
        // Infernum
        if (text.Contains("was somehow impaled by a pillar of crystals."))
            text = text.Replace("was somehow impaled by a pillar of crystals.", "неведомым образом пронзается кристальной колонной.");
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
            
            // Boss Checklist
            "Истинный глаз Ктулху вырвался из головы Лунный лорд!" => "Истинный глаз Ктулху вырвался из головы Лунного лорда!",
            "Истинный глаз Ктулху вырывается из Рука Лунного лорда!" => "Истинный глаз Ктулху вырывается из Руки Лунного лорда!",
            _ => text
        };

        orig.Invoke(self, text, color, widthlimitinpixels);
    }
}