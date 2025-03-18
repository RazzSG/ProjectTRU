using CalamityRuTranslate.Common.Utilities;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.UI.Chat;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;

public class AddNewMessagePatch : ILoadable
{
    private string PlayerName => Main.player[Main.myPlayer].name;
    
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
        if (text == $"{PlayerName} was somehow impaled by a pillar of crystals.")
            text = $"Игрок {PlayerName} был загадочным образом пронзён кристальной колонной.";
        
        if (text == $"{PlayerName} was repelled by celestial forces.")
            text = $"Игрок {PlayerName} был отброшен неземными силами.";
        
        if (text == $"{PlayerName} was violently pricked by roses.")
            text = $"Игрок {PlayerName} был жестоко пронзён розами.";
        
        // Fargo
        if (text.Contains("A new item has been unlocked in"))
        {
            text = text.Replace("A new item has been unlocked in", "В магазине НИПа");
            text = text.Replace("'s shop!", "появился новый предмет!");
        }
        
        if (text == $"Battle Cry activated for {PlayerName}!")
            text = $"Боевой клич активирован для игрока {PlayerName}!";
        
        if (text == $"Battle Cry deactivated for {PlayerName}!")
            text = $"Боевой клич деактивирован для игрока {PlayerName}!";
        
        if (text == $"Calming Cry activated for {PlayerName}.")
            text = $"Умиротворяющий клич активирован для игрока {PlayerName}.";
        
        if (text == $"Calming Cry deactivated for {PlayerName}.")
            text = $"Умиротворяющий клич деактивирован для игрока {PlayerName}.";

        // StarsAbove
        if (text == $"{PlayerName} was obliterated!")
            text = $"Игрок {PlayerName} был стёрт с лица земли!";
        
        if (text == $"{PlayerName}'s body was broken, along with their limits.")
            text = $"Игрок {PlayerName} сломал лимиты вместе c телом.";
        
        if (text == $"{PlayerName} died beyond their world.")
            text = $"Игрок {PlayerName} погиб за пределами своего мира.";
        
        if (text == $"{PlayerName} was lost in space.")
            text = $"Игрок {PlayerName} потерялся в космосе.";
        
        if (text == $"{PlayerName} drifted away from their home planet.")
            text = $"Игрок {PlayerName} отдалился от своей родной планеты.";
        
        if (text == $"{PlayerName} was brought to kneel beyond their world.")
            text = $"Игрок {PlayerName} был вынужден преклонить колени за пределами своего мира.";
        
        if (text == $"{PlayerName} died within another realm.")
            text = $"Игрок {PlayerName} погиб в иной реальности.";
            
        if (text == $"{PlayerName} crumbled under the weight of Living Dead.")
            text = $"Игрок {PlayerName} не выдержал тяжести живого мертвеца.";
            
        if (text == $"{PlayerName} burnt to a crisp by continuing to move during Pyretic.")
            text = $"Игрок {PlayerName}, продолжая двигаться во время горячки, сгорел дотла.";
            
        if (text == $"{PlayerName} froze to death by staying still during Deep Freeze")
            text = $"Игрок {PlayerName}, оставаясь неподвижным во время глубокой заморозки, замёрз насмерть.";

        if (text == $"{PlayerName} couldn't handle the vacuum of space.")
            text = $"Игрок {PlayerName} не смог выдержать вакуум космоса.";
        
        // Redemption
        if (text == $"{PlayerName} experienced DOOR STUCK.")
            text = $"{PlayerName} застрял в ДВЕРЯХ.";
        
        text = text switch
        {
            // StarsAbove
            "The expanse around you begins to contract..." => "Окружающее пространство начинает сжиматься...",
            "The Stellar Array reaches new heights!" => "Звёздный ряд достигает новых высот!",
            
            // Boss Checklist
            "Истинный глаз Ктулху вырвался из головы Лунный лорд!" => "Истинный глаз Ктулху вырвался из головы Лунного лорда!",
            "Истинный глаз Ктулху вырывается из Рука Лунного лорда!" => "Истинный глаз Ктулху вырывается из Руки Лунного лорда!",
            
            // Calamity
            "You give Polaris belly rubs" => "Вы гладите Полярку по животику.",
            "You give Polaris a small treat" => "Вы даёте Полярке вкусное лакомство.",
            "You tell Polaris she's a good girl" => "Вы говорите Полярке, что она хорошая девочка.",
            "You let Polaris cuddle your arm" => "Вы позволяете Полярке прижаться к вашей руке.",
            "You pet Polaris" => "Вы гладите Полярку.",
            "Too much love..." => "Слишком много любви...",
            "Supreme Cirrus code attempted to crash the game. Did you do something weird?" => "Код Высшей Циррус попытался вызвать сбой игры. Вы сделали что-то странное?",
            "Spawn point removed!" => "Точка воскрешения удалена!",
            "Spawn point set!" => "Точка воскрешения задана!",
            
            // Fargo
            "Journey mode is now enabled!" => "Мир переключён в режим Путешествия!",
            "Normal mode is now enabled!" => "Мир переключён в обычный режим!",
            "Expert mode is now enabled!" => "Мир переключён в режим Эксперта!",
            "Master mode is now enabled!" => "Мир переключён в режим Мастера!",
            "The invaders have left!" => "Вторженцы отступили!",
            "The Pumpkin Moon is lowering..." => "Тыквенная луна заходит за горизонт...",
            "The Frost Moon is lowering..." => "Морозная луна заходит за горизонт...",
            "A solar eclipse is not happening!" => "Солнечное затмение не наступило!",
            "The blood moon is descending..." => "Кровавая луна опускается за горизонт...",
            "The wind has ended!" => "Ветер стих!",
            "The Old One's Army is leaving!" => "Армия Древних отступила!",
            "The sandstorm has ended!" => "Песчаная буря стихла!",
            "Celestial creatures are not invading!" => "Неземные существа не атакуют!",
            "The rain has ended!" => "Дождь прекратился!",
            "The wind begins howling." => "Начинает завывать ветер.",
            "A sandstorm has begun." => "Начинается песчаная буря.",
            "Lantern Night rate increased!" => "Шанс на ночь фонарей увеличен!",
            "Lantern Night rate restored to default." => "Шанс на ночь фонарей возвращён к изначальному.",
            "The Celestial Pillars have awoken!" => "Неземные башни пробудились!",
            "Rain clouds cover the sky." => "Тучи затягивают небо.",
            
            // Redemption
            "A sleeping stone appears..." => "Появляются дремлющие валуны...",
            "A Shadesoul Gateway has been opened..." => "Врата пустой души распахнулись...",
            "A Shadesoul Gateway has been closed..." => "Врата пустой души закрылись...",
            "A Shadesoul Gateway has faded by itself..." => "Врата пустой души исчезли сами собой...",
            "The fowl legion charges in!" => "Кудах-легион идёт в наступление!",
            _ => text
        };

        orig.Invoke(self, text, color, widthlimitinpixels);
    }
}