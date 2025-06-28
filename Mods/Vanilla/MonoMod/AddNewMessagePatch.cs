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
        text = text.Replace("was somehow impaled by a pillar of crystals.", "был загадочным образом пронзён кристальной колонной.");
        text = text.Replace("was repelled by celestial forces.", "был отброшен неземными силами.");
        text = text.Replace("was violently pricked by roses.", "был жестоко пронзён розами.");
        
        // Fargo
        if (text.Contains("A new item has been unlocked in"))
        {
            text = text.Replace("A new item has been unlocked in", "В магазине НИПа");
            text = text.Replace("'s shop!", "появился новый предмет!");
        }
        
        text = text.Replace("Battle Cry activated for", "Боевой клич активирован для игрока");
        text = text.Replace("Battle Cry deactivated for", "Боевой клич деактивирован для игрока");
        text = text.Replace("Calming Cry activated for", "Умиротворяющий клич активирован для игрока");
        text = text.Replace("Calming Cry deactivated for", "Умиротворяющий клич деактивирован для игрока");

        // StarsAbove
        text = text.Replace("was obliterated!", "был стёрт с лица земли!");
        text = text.Replace("'s body was broken, along with their limits.", " сломал лимиты вместе c телом.");
        text = text.Replace("died beyond their world.", "погиб за пределами своего мира.");
        text = text.Replace("was lost in space.", "потерялся в космосе.");
        text = text.Replace("drifted away from their home planet.", "отдалился от своей родной планеты.");
        text = text.Replace("was brought to kneel beyond their world.", "был вынужден преклонить колени за пределами своего мира.");
        text = text.Replace("died within another realm.", "погиб в иной реальности.");
        text = text.Replace("crumbled under the weight of Living Dead.", "не выдержал тяжести живого мертвеца.");
        text = text.Replace("burnt to a crisp by continuing to move during Pyretic.", ", продолжая двигаться во время горячки, сгорел дотла.");
        text = text.Replace("froze to death by staying still during Deep Freeze", ", оставаясь неподвижным во время глубокой заморозки, замёрз насмерть.");
        text = text.Replace("couldn't handle the vacuum of space.", "не смог выдержать вакуум космоса.");
        
        // Redemption
        text = text.Replace("experienced DOOR STUCK.", "застрял в ДВЕРЯХ.");
        
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
            "The invaders have left!" => "Вторженцы отступают!",
            "The Pumpkin Moon is lowering..." => "Тыквенная луна заходит за горизонт...",
            "The Frost Moon is lowering..." => "Морозная луна заходит за горизонт...",
            "A solar eclipse is not happening!" => "Солнечное затмение прекращается!",
            "The blood moon is descending..." => "Кровавая луна заходит за горизонт...",
            "The wind has ended!" => "Ветер стих!",
            "The Old One's Army is leaving!" => "Армия Древних отступает!",
            "The sandstorm has ended!" => "Песчаная буря стихла!",
            "Celestial creatures are not invading!" => "Неземные создания отступают!",
            "The rain has ended!" => "Дождь прекратился!",
            "The wind begins howling." => "Поднимается сильный ветер.",
            "A sandstorm has begun." => "Началась песчаная буря.",
            "Lantern Night rate increased!" => "Шанс на ночь фонарей увеличен!",
            "Lantern Night rate restored to default." => "Шанс на ночь фонарей возвращён к изначальному.",
            "The Celestial Pillars have awoken!" => "Неземные башни пробудились!",
            "Rain clouds cover the sky." => "Дождевые тучи затягивают небо.",
            
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