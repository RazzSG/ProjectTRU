﻿using CalamityRuTranslate.Common.Utilities;
using Microsoft.Xna.Framework;
using Terraria;
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

        // StarsAbove
        if (text.Contains("was obliterated!"))
            text = text.Replace("was obliterated!", "стирается с лица земли!");
        if (text.Contains("'s body was broken, along with their limits."))
            text = "ломает лимиты, вместе со своим телом.";
        if (text.Contains("died beyond their world."))
            text = text.Replace("died beyond their world.", "умирает за пределами родного мира.");
        if (text.Contains("was lost in space."))
            text = text.Replace("was lost in space.", "теряется в космосе.");
        if (text.Contains("drifted away from their home planet."))
            text = text.Replace("drifted away from their home planet.", "удаляется от своей родной планеты.");
        if (text.Contains("was brought to kneel beyond their world."))
            text = text.Replace("was brought to kneel beyond their world.", "вынужденно преклоняется за пределами родного мира.");
        if (text.Contains("died within another realm."))
            text = text.Replace("died within another realm.", "умирает в иной реальности.");
        if (text.Contains("crumbled under the weight of Living Dead."))
            text = text.Replace("crumbled under the weight of Living Dead.", "не выдерживает силу живого мертвеца.");
        if (text.Contains("burnt to a crisp by continuing to move during Pyretic."))
            text = text.Replace("burnt to a crisp by continuing to move during Pyretic.", "продолжает двигаться во время горячки, сгорая дотла.");
        if (text.Contains("froze to death by staying still during Deep Freeze"))
            text = text.Replace("froze to death by staying still during Deep Freeze", "остаётся неподвижным во время глубокой заморозки, замерзая до смерти.");
        if (text.Contains("couldn't handle the vacuum of space."))
            text = text.Replace("couldn't handle the vacuum of space.", "не выдерживает вакуума космоса.");
        
        // Redemption
        // if (text.Contains("experienced DOOR STUCK."))
        //     text = text.Replace("experienced DOOR STUCK.", "застревает в ДВЕРЯХ.");
        
        text = text switch
        {
            // StarsAbove
            "The expanse around you begins to contract..." => "Окружающее пространство начинает сжиматься...",
            "The Stellar Array reaches new heights!" => "Звёздный ряд достигает новых высот!",
            
            // Thorium
            "It appears to be waiting for night..." => "Похоже, оно ждёт наступления ночи...",
            "It seems to be dormant..." => "Похоже, что оно дремлет...",
            
            // Boss Checklist
            "Истинный глаз Ктулху вырвался из головы Лунный лорд!" => "Истинный глаз Ктулху вырвался из головы Лунного лорда!",
            "Истинный глаз Ктулху вырывается из Рука Лунного лорда!" => "Истинный глаз Ктулху вырывается из Руки Лунного лорда!",
            
            // Calamity
            "You give Polaris belly rubs" => "Вы гладите Полярку по животику.",
            "You give Polaris a small treat" => "Вы даёте Полярке вкусное лакомство.",
            "You tell Polaris she's a good girl" => "Вы говорите Полярке, что она хорошая девочка.",
            "You let Polaris cuddle your arm" => "Вы позволяете Полярке прижаться к вашей руке.",
            "You pet Polaris" => "Вы гладите Полярку",
            "Too much love..." => "Слишком много любви...",
            "Supreme Cirrus code attempted to crash the game. Did you do something weird?" => "Код Высшей Циррус попытался вызвать сбой игры. Вы сделали что-то странное?",
            
            // Redemption
            // "A sleeping stone appears..." => "",
            // "Nebuleus is nowhere to be found..." => "",
            // "A Shadesoul Gateway has been opened..." => "",
            // "A Shadesoul Gateway has been closed..." => "",
            // "Daerel the Wayfarer has woken up!" => "",
            // "Adam the Friendly T-Bot has woken up!" => "",
            // "Zephos the Wayfarer has woken up!" => "",
            // "A Shadesoul Gateway has faded by itself..." => "",
            // "A blobble swarm has arrived!" => "",
            // "The bomb is too close to unexplodable tiles" => "",
            // "The bomb must be activated on the surface and in the far reaches of the world" => "",
            // "The fowl legion charges in!" => "",
            _ => text
        };

        orig.Invoke(self, text, color, widthlimitinpixels);
    }
}