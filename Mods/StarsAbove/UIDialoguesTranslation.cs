// using System;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core;
// using StarsAbove;
// using Terraria;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.TheStarsAbove;
//
// [JITWhenModsEnabled("StarsAbove")]
// public class UIDialoguesTranslation : ContentTranslation, ILoadableContent
// {
//     public override bool IsTranslationEnabled => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override float Priority => 1f;
//
//     private static StarsAbovePlayer StarsAbovePlayer => Main.LocalPlayer.GetModPlayer<StarsAbovePlayer>();
//
//     private static string StarfarerMenuDialogue
//     {
//         get => Main.LocalPlayer.GetModPlayer<StarsAbovePlayer>().starfarerMenuDialogue;
//         set => Main.LocalPlayer.GetModPlayer<StarsAbovePlayer>().starfarerMenuDialogue = value;
//     }
//
//     private static string Description
//     {
//         get => Main.LocalPlayer.GetModPlayer<StarsAbovePlayer>().description;
//         set => Main.LocalPlayer.GetModPlayer<StarsAbovePlayer>().description = value;
//     }
//
//     private static string PassiveTitle
//     {
//         get => Main.LocalPlayer.GetModPlayer<StarsAbovePlayer>().passiveTitle;
//         set => Main.LocalPlayer.GetModPlayer<StarsAbovePlayer>().passiveTitle = value;
//     }
//
//     private static string NovaDialogue
//     {
//         get => Main.LocalPlayer.GetModPlayer<StarsAbovePlayer>().novaDialogue;
//         set => Main.LocalPlayer.GetModPlayer<StarsAbovePlayer>().novaDialogue = value;
//     }
//
//     private static string AbilitySubName
//     {
//         get => Main.LocalPlayer.GetModPlayer<StarsAbovePlayer>().abilitySubName;
//         set => Main.LocalPlayer.GetModPlayer<StarsAbovePlayer>().abilitySubName = value;
//     }
//
//     private static string AbilityName
//     {
//         get => Main.LocalPlayer.GetModPlayer<StarsAbovePlayer>().abilityName;
//         set => Main.LocalPlayer.GetModPlayer<StarsAbovePlayer>().abilityName = value;
//     }
//
//     private static string AbilityDescription
//     {
//         get => Main.LocalPlayer.GetModPlayer<StarsAbovePlayer>().abilityDescription;
//         set => Main.LocalPlayer.GetModPlayer<StarsAbovePlayer>().abilityDescription = value;
//     }
//
//     private static string StarfarerBonus
//     {
//         get => Main.LocalPlayer.GetModPlayer<StarsAbovePlayer>().starfarerBonus;
//         set => Main.LocalPlayer.GetModPlayer<StarsAbovePlayer>().starfarerBonus = value;
//     }
//
//     private static string PromptDialogue
//     {
//         get => Main.LocalPlayer.GetModPlayer<StarsAbovePlayer>().promptDialogue;
//         set => Main.LocalPlayer.GetModPlayer<StarsAbovePlayer>().promptDialogue = value;
//     }
//
//     public void LoadContent()
//     {
//         if (StarfarerMenuDialogue is "What's up? Need something?")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.1");
//         if (StarfarerMenuDialogue is "Do you need something?")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.2");
//         if (StarfarerMenuDialogue is "Let me guess.. You need my help?\nWell, it IS why I'm here.")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.3");
//         if (StarfarerMenuDialogue is "You need my help, right?\nOf course- anything you need.\n")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.4");
//         if (StarfarerMenuDialogue is "Do you need my help?\nI just assumed, you know, because..\nNever mind.")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.5");
//         if (StarfarerMenuDialogue is "You rang?")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.6");
//         if (StarfarerMenuDialogue is "Did something come up?")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.7");
//         if (StarfarerMenuDialogue.Equals($"Hey, {Main.LocalPlayer.name}. Looks like you need my help?"))
//             StarfarerMenuDialogue = string.Format(LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.8"),
//                 Main.LocalPlayer.name);
//         if (StarfarerMenuDialogue.Equals($"{Main.LocalPlayer.name}.. I'm assuming you need my help?"))
//             StarfarerMenuDialogue = string.Format(LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.9"),
//                 Main.LocalPlayer.name);
//         if (StarfarerMenuDialogue is "Right. Let's get started.\nWhat do you need?")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.10");
//         if (StarfarerMenuDialogue is "Hmm... What do you need?")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.11");
//         if (StarfarerMenuDialogue is "Okay, what do you need?")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.12");
//         if (StarfarerMenuDialogue is "Uh, aren't we still in combat?")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.13");
//         if (StarfarerMenuDialogue is "I kind of feel like something else\nneeds your attention right now...")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.14");
//         if (StarfarerMenuDialogue is
//             "Right.. What do you want to read about?\nDialogue is sorted into 3 groups: idle, boss,\nand weapon. Cycle through and choose the one\nyou want.")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.15");
//         if (StarfarerMenuDialogue is
//             "Okay, what do you want to read about?\nThe dialogues are sorted into 3 groups:\nidle, boss, and weapon. Feel free to choose\nwhich one you want to view.")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.16");
//         if (StarfarerMenuDialogue is "Changed your mind?")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.17");
//         if (StarfarerMenuDialogue is "Did you have other plans?")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.18");
//         if (StarfarerMenuDialogue is "Is that everything?")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.19");
//         if (StarfarerMenuDialogue is "Have you done what you needed to?")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.20");
//         if (StarfarerMenuDialogue is "Okay, finished?")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.21");
//         if (StarfarerMenuDialogue is "Finished?")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.22");
//         if (StarfarerMenuDialogue is "Done already?")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.23");
//         if (StarfarerMenuDialogue is "Was that all?")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.24");
//         if (StarfarerMenuDialogue is
//             "This is the Archive. Just in case you didn't get\neverything I said, you can read it here. I know, \nyou just can't get enough of my analysis, right?\nYou can also get items you lost, like Essences.")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.25");
//         if (StarfarerMenuDialogue is
//             "This is the Archive. If you ever find yourself\nneeding me to repeat what I've said about\nsomething, it's here. Additionally, if you lost\nsomething like an Essence, you can reacquire it.")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.26");
//         if (StarfarerMenuDialogue is "Looks like this isn't implemented yet.\n\n\n")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.27");
//         if (StarfarerMenuDialogue is "It seems this isn't quite implemented yet.\n\n\n")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.28");
//         if (StarfarerMenuDialogue is "We can't use this yet.")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.29");
//         if (StarfarerMenuDialogue is "We haven't unlocked this yet.")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.30");
//         if (StarfarerMenuDialogue is
//             "This is the Stellar Nova Menu. You can check\nout Stellar Nova stats, swap it for another\none, or equip Stellar Prisms to change what\nthey can do.\n")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.31");
//         if (StarfarerMenuDialogue is
//             "This is the Stellar Nova Menu. You can peruse\nStellar Novas, swap between them, or you can\nequip Stellar Prisms to change what effects\nStellar Novas have.\n")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.32");
//         if (StarfarerMenuDialogue is
//             "I'd love to let you modify the Stellar Array,\nbut we should probably deal with THAT first.\nCome on, you know what I mean!!\n\n")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.33");
//         if (StarfarerMenuDialogue is
//             "I know you'd like to modify the Stellar Array,\nbut there's a much more pressing matter\nat hand... You ARE aware of this, right?\n\n")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.34");
//         if (StarfarerMenuDialogue is
//             "You can access the Stellar Array from here.\nWe can equip passive abilities here, staying\nmindful of the max cost, as well as changing\nthe damage type of Aspected Weapons.\n")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.35");
//         if (StarfarerMenuDialogue is
//             "This is the Stellar Array. You can equip\npassive abilities here, as long as the total\ncost doesn't exceed the maximum. Also, this\nis where you configure Aspected Weapon type.\n")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.36");
//         if (StarfarerMenuDialogue is
//             "If you have any Starfarer Attire for me,\nhere's the place to put it.\nIt'll be pretty helpful for me, and you\nby association!\nAnd hey- style equals skill!")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.37");
//         if (StarfarerMenuDialogue is
//             "You can place Starfarer Attire here.\nIt'll provide me with some helpful boons\nto assist you better.\nI know your fashion sense is... unique,\nso at least try and spare me?")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.38");
//         if (StarfarerMenuDialogue is
//             "I'll wear the Starfarer Attire here\nover the Armor Slot. It's called a vanity slot,\nor so I'm told.\n\n")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.39");
//         if (StarfarerMenuDialogue is
//             "This is the vanity slot for Starfarer Attire.\nAnything placed here will be worn above the\narmor set.\n\n")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.40");
//         if (StarfarerMenuDialogue is "Okay, that's the Stellar Array taken care of.\nAnything else you needed?")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.41");
//         if (StarfarerMenuDialogue is "Good, the Stellar Array has been changed.\nNext on the list is...")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.42");
//         if (StarfarerMenuDialogue is "I see you've finished your changes with the\nStellar Array. Perfect.")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.43");
//         if (StarfarerMenuDialogue is "You're done with the Stellar Array?\nGreat. Anything else?")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.44");
//         if (StarfarerMenuDialogue is
//             "The Stellar Array's done updating. That's all\nfor now, unless you had something else\nin mind?")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.45");
//         if (StarfarerMenuDialogue is
//             "Okay, the Stellar Array is changed.\nHave you finished what you sought\nto achieve?")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.46");
//         if (StarfarerMenuDialogue is "What's next on the list?")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.47");
//         if (StarfarerMenuDialogue is "Okay, the Stellar Nova changes went through.\nWhat will you do next?")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.48");
//         if (StarfarerMenuDialogue is "The Stellar Nova has been updated.\nWhat's next?")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.49");
//         if (StarfarerMenuDialogue is "Finished modifying the Stellar Nova? Great.\n")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.50");
//         if (StarfarerMenuDialogue is "Stellar Nova changes are confirmed. Great.\nIs there anything else you needed?")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.51");
//         if (StarfarerMenuDialogue is "Okay, we've changed the Stellar Nova around.\nDo you have anything else in mind?")
//             StarfarerMenuDialogue = LangHelper.GetText("StarsAbove.UI.StarfarerMenuDialogue.52");
//
//         if (Description is
//             "Asphodene, the [c/6ECDFA:Astral Starfarer]. Bold and energetic, she focuses on [c/FAC16E:flashy, powerful attacks].")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.1");
//         if (Description is
//             "Eridani, the [c/D06EFA:Umbral Starfarer]. A reserved tactician, she [c/FAC16E:flourishes through deep complexity.]")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.2");
//         if (Description is "Confirm your selection.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.3");
//         if (Description is "Reset your selection.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.4");
//         if (Description is "[c/9D9D9D:Locked: Defeat the Eye of Cthulhu]")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.5");
//         if (Description is
//             "When struck, gain 10% of your Max HP as defense for 2 seconds (20 second cooldown.)\nAdditionally, gain 20 mana upon activation, and 20% damage increase for the duration of the shield.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.6");
//         if (Description is "[c/9D9D9D:Locked: Obtain an Aspected Weapon]")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.7");
//         if (Description is "If the weapon's type has changed, the weapon deals 10% less damage when active.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.8");
//         if (Description is "If the weapon's type has changed, the weapon deals 10% less damage when active.\n")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.9");
//         if (Description is "Aspected Weapon damage type is saved even after re-entering the world.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.10");
//         if (Description is "[c/9D9D9D:Locked: Defeat Nalhaun, the Burnished King]")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.11");
//         if (Description is
//             "After 12 kills without leaving combat, gain 5% extra attack damage and 30% faster attack speed.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.12");
//         if (Description is "[c/9D9D9D:Locked: Defeat the Queen Bee]")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.13");
//         if (Description is "3% chance to take 0 damage from an attack. Gain 25% movement speed.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.14");
//         if (Description is "[c/9D9D9D:Locked: Defeat the Eater of Worlds or Brain of Cthulhu]")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.15");
//         if (Description is
//             "Gain 6 defense. Take 30 less damage from attacks that deal over 100 damage.\nBelow 100 HP, take 20% less damage from all attacks, independent of other defense calculations.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.16");
//         if (Description is "[c/9D9D9D:Locked: Defeat the Moon Lord]")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.17");
//         if (Description is
//             "All projectiles and melee attacks inflict Starblight on a critical strike.\nGain Lifesteal on foes inflicted with Starblight. Healing is capped at 5 HP per second.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.18");
//         if (Description is "[c/9D9D9D:Locked: Defeat Arbitration in Expert Mode]")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.19");
//         if (Description is
//             "Landing a critical strike will cause foes to explode, taking half the original damage.\nAdditionally, damaging snowflakes will spew from the target, spreading the damage. 4 second cooldown.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.20");
//         if (Description is "[c/9D9D9D:Locked: Defeat Penthesilea, the Witch of Ink]")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.21");
//         if (Description is "Consume 5 mana when hitting a foe with an attack to deal 8% extra damage.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.22");
//         if (Description is "[c/9D9D9D:Locked: Defeat Skeletron]")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.23");
//         if (Description is
//             "After not taking damage for 12 seconds, gain 10% increased damage, 25 defense,\nknockback resistance, and Health Regeneration. Buffs are lost on hit.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.24");
//         if (Description is "[c/9D9D9D:Locked: Defeat the Ice Queen]")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.25");
//         if (Description is
//             "Gain bonus attack and defense proportional to Max HP divided by 20.\nTaking damage inflicts 'Null Radiance' which reduces outgoing damage by half for 6 seconds.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.26");
//         if (Description is "[c/9D9D9D:Locked: Defeat the Lunatic Cultist in Expert Mode]")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.27");
//         if (Description is
//             "Critical strike rate is increased based on current Mana divided by 20.\nLanding a critical strike grants 5% of the damage dealt as Mana. (Max 5 per hit)")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.28");
//         if (Description is "[c/9D9D9D:Locked: Defeat the Wall of Flesh]")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.29");
//         if (Description is
//             "Gain 150 extra Maximum HP and powerful health regeneration.\nDefense is halved below 200 HP.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.30");
//         if (Description is "[c/9D9D9D:Locked: Defeat any Mechanical Boss]")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.31");
//         if (Description is
//             "When below 100 HP, gain 50% increased damage and all attacks burn foes.\nAdditionally, these effects will temporarily ignore the HP threshold for 3 seconds after taking damage.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.32");
//         if (Description is "[c/9D9D9D:Locked: Defeat the Warrior of Light]")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.33");
//         if (Description is
//             "Half of Max Mana is added to Max HP. At 500 HP or above, gain 10 defense, 5% damage, and\n5 Stellar Nova Energy Regeneration.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.34");
//         if (Description is "[c/9D9D9D:Locked: Defeat all Mechanical bosses]")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.35");
//         if (Description is
//             "1/10th of current Mana is added to Defense.\nGain 15 Stellar Nova Energy Regeneration above 200 Mana.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.36");
//         if (Description is "[c/9D9D9D:Locked: Defeat Plantera]")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.37");
//         if (Description is
//             "When Mana drops below 40, gain 150 Mana and all attacks critically strike for 4 seconds. 25 second cooldown.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.38");
//         if (Description is "[c/9D9D9D:Locked: Defeat all bosses from The Stars Above except the final boss]")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.39");
//         if (Description is
//             "Critical strikes roll critical strike chance again.\nIf the attack was critical again, increases damage by 50% and roll one more time.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.40");
//         if (Description is "[c/9D9D9D:Locked: Defeat Golem in Expert Mode]")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.41");
//         if (Description is
//             "Critical strikes hit again for 10% of the original damage as true damage (Will not kill.)\nFoes below 20% HP or who are Stunned will take 30% damage instead.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.42");
//         if (Description is
//             "[c/9D9D9D:Locked: Defeat all bosses from The Stars Above except the final boss in Expert Mode]")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.43");
//         if (Description is "Aspected Damage Type changes will now apply to all weapons.\n")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.44");
//         if (Description is "[c/9D9D9D:Locked: Defeat all Terraria bosses and the Warrior of Light in Expert Mode]")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.45");
//         if (Description is
//             "Doubles the recharge rate of Stellar Nova Energy.\nStellar Nova Energy does not deplete out of combat.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.46");
//         if (Description is
//             "[c/9D9D9D:Locked: Defeat all Terraria bosses and all bosses from The Stars Above except the final boss]")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.47");
//         if (Description is
//             "Every 8 seconds, swap between Ebb (drastic Mana drain) and Flow (infinite Mana Regeneration)\nAdditionally, gain 40% increased damage and 20% increased attack speed during Flow.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.48");
//         if (Description is "[c/9D9D9D:Locked: Defeat the Slime King in Expert Mode]")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.49");
//         if (Description is
//             "When ammo is consumed, gain 8 mana, 10% increased damage, and Movement Speed for half a second.\n2 second cooldown.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.50");
//         if (Description is "[c/9D9D9D:Locked: Defeat Pumpking]")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.51");
//         if (Description is
//             "Survive most fatal damage for 10 seconds, but if HP is not healed above 150 when the buff ends,\nyou will die. (4 minute cooldown) You need 200+ Max HP to confirm this ability.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.52");
//         if (Description is "[c/9D9D9D:Locked: Defeat all Terraria bosses]")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.53");
//         if (Description is
//             "At 500 HP or above, all applicable outgoing damage is doubled.\nDeal 10% less damage below 500 HP, increased by 10% for each 100 HP.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.54");
//         if (Description is "[c/9D9D9D:Locked: Defeat the Moon Lord in Expert Mode]")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.55");
//         if (Description is
//             "Taking over 200 damage at once will instead heal you for that amount and grant 5 seconds of Invincibility. \nAdditionally, all nearby non-boss enemies will be Stunned for 5 seconds. 2 minute cooldown.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.56");
//         if (Description is
//             "You can change the effects of Stellar Novas by affixing\nStellar Prisms here. Tier 3 Prisms only work in this slot.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.57");
//         if (Description is
//             "You can change the effects of Stellar Novas by affixing\nStellar Prisms here. Duplicates don't count!")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.58");
//         if (Description is
//             "You can change the effects of Stellar Novas by affixing\nStellar Prisms here. Duplicate Prisms don't stack effects.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.59");
//         if (Description is
//             "This Affix slot is reserved for special Stellar Prisms that\nchange a specific ability entirely.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.60");
//         if (Description is "Finished modifying the Stellar Nova?")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.61");
//         if (Description is "Are you finished modifying the Stellar Nova..?")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.62");
//         if (Description is "Would you like to deselect the current Stellar Nova?")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.63");
//         if (Description is "We can reset the Stellar Nova, if you'd like.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.64");
//         if (Description is "This is Theofania Inanis, a general use Stellar Nova\nthat applies a powerful debuff.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.65");
//         if (Description is "We don't have access to this yet.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.66");
//         if (Description is "This is Theofania Inanis: a general Stellar Nova that\ncan apply a powerful debuff.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.67");
//         if (Description is "We can't use this yet.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.68");
//         if (Description is
//             "Ars Laevateinn. If you've ever wanted to clear an area fast,\nthis is the Stellar Nova for that.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.69");
//         if (Description is
//             "We don't have access to this yet.\nI feel we must defeat a certain monarch to get this.\nBut who...?")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.70");
//         if (Description is
//             "This Stellar Nova, Ars Laevateinn, focuses on doing\nlarge amounts of damage in a specified area.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.71");
//         if (Description is
//             "We can't use this yet.\nSomething tells me we must defeat a 'regal' enemy to obtain this.\nBut who is this individual..?")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.72");
//         if (Description is
//             "A powerful counter-attack, Kiwami Ryuken. Time it right,\nand your foes will be dropped instantly.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.73");
//         if (Description is "We don't have access to this yet.\nWe must vanquish a true evil...")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.74");
//         if (Description is
//             "A powerful counterattack: Kiwami Ryuken. You can deal\nenormous amounts of damage quickly if timed properly.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.75");
//         if (Description is "We can't use this yet.\nI feel we must defeat a true evil...")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.76");
//         if (Description is
//             "An influential support Nova, the Garden of Avalon will\ngrant powerful healing and invincibility.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.77");
//         if (Description is "We don't have access to this yet.\nWe need to defeat a strong enough magic user...")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.78");
//         if (Description is
//             "This Stellar Nova will grant powerful healing over\ntime as well as a brief window of invincibility.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.79");
//         if (Description is "We can't use this yet.\nWe need to defeat a powerful magical entity.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.80");
//         if (Description is
//             "With this Stellar Nova, you can imbue your attacks directly,\noverwriting their stats as well as gaining a new burst attack.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.81");
//         if (Description is "We don't have access to this yet.\nWe have to defeat a foe with spatial powers.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.82");
//         if (Description is
//             "This Stellar Nova will allow you to change the stats of\nyour weapons as well as gain a new special attack.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.83");
//         if (Description is "We can't use this yet.\nWe have to defeat a foe with spatial powers.")
//             Description = LangHelper.GetText("StarsAbove.UI.Description.84");
//
//         if (PassiveTitle is "[c/C2BDFF:Tier 1] [c/FFEED1:'Starshield']")
//             PassiveTitle = LangHelper.GetText("StarsAbove.UI.PassiveTitle.1");
//         if (PassiveTitle is "Change the held Aspected Weapon to [c/FFAB4D:Melee Damage].")
//             PassiveTitle = LangHelper.GetText("StarsAbove.UI.PassiveTitle.2");
//         if (PassiveTitle is "Change the held Aspected Weapon to [c/707070:Rogue Damage].")
//             PassiveTitle = LangHelper.GetText("StarsAbove.UI.PassiveTitle.3");
//         if (PassiveTitle is "Change the held Aspected Weapon to [c/EF4DFF:Magic Damage].")
//             PassiveTitle = LangHelper.GetText("StarsAbove.UI.PassiveTitle.4");
//         if (PassiveTitle is "Change the held Aspected Weapon to [c/4DFF5B:Ranged Damage].")
//             PassiveTitle = LangHelper.GetText("StarsAbove.UI.PassiveTitle.5");
//         if (PassiveTitle is "Change the held Aspected Weapon to [c/00CDFF:Summon Damage].")
//             PassiveTitle = LangHelper.GetText("StarsAbove.UI.PassiveTitle.6");
//         if (PassiveTitle is "[c/C2BDFF:Tier 1] [c/FFEED1:'Butcher's Dozen']")
//             PassiveTitle = LangHelper.GetText("StarsAbove.UI.PassiveTitle.7");
//         if (PassiveTitle is "[c/C2BDFF:Tier 1] [c/FFEED1:'Evasion Mastery'] ")
//             PassiveTitle = LangHelper.GetText("StarsAbove.UI.PassiveTitle.8");
//         if (PassiveTitle is "[c/C2BDFF:Tier 1] [c/FFEED1:'Iron Will'] ")
//             PassiveTitle = LangHelper.GetText("StarsAbove.UI.PassiveTitle.9");
//         if (PassiveTitle is "[c/C2BDFF:Tier 1] [c/FFEED1:'Umbral Entropy'] ")
//             PassiveTitle = LangHelper.GetText("StarsAbove.UI.PassiveTitle.10");
//         if (PassiveTitle is "[c/C2BDFF:Tier 1] [c/FFEED1:'Flash Freeze'] ")
//             PassiveTitle = LangHelper.GetText("StarsAbove.UI.PassiveTitle.11");
//         if (PassiveTitle is "[c/C2BDFF:Tier 1] [c/FFEED1:'Mystic Forging']")
//             PassiveTitle = LangHelper.GetText("StarsAbove.UI.PassiveTitle.12");
//         if (PassiveTitle is "[c/C2BDFF:Tier 1] [c/FFEED1:'Inner Alchemy']")
//             PassiveTitle = LangHelper.GetText("StarsAbove.UI.PassiveTitle.13");
//         if (PassiveTitle is "[c/C2BDFF:Tier 1] [c/FFEED1:'Hikari']")
//             PassiveTitle = LangHelper.GetText("StarsAbove.UI.PassiveTitle.14");
//         if (PassiveTitle is "[c/C2BDFF:Tier 1] [c/FFEED1:'Celestial Evanesence']")
//             PassiveTitle = LangHelper.GetText("StarsAbove.UI.PassiveTitle.15");
//         if (PassiveTitle is "[c/9C4FFF:Tier 2] [c/FFD792:'Healthy Confidence']")
//             PassiveTitle = LangHelper.GetText("StarsAbove.UI.PassiveTitle.16");
//         if (PassiveTitle is "[c/9C4FFF:Tier 2] [c/FFD792:'Infernal End']")
//             PassiveTitle = LangHelper.GetText("StarsAbove.UI.PassiveTitle.17");
//         if (PassiveTitle is "[c/9C4FFF:Tier 2] [c/FFD792:'Avatar of Light']")
//             PassiveTitle = LangHelper.GetText("StarsAbove.UI.PassiveTitle.18");
//         if (PassiveTitle is "[c/9C4FFF:Tier 2] [c/FFD792:'Astral Mantle']")
//             PassiveTitle = LangHelper.GetText("StarsAbove.UI.PassiveTitle.19");
//         if (PassiveTitle is "[c/9C4FFF:Tier 2] [c/FFD792:'Afterburner']")
//             PassiveTitle = LangHelper.GetText("StarsAbove.UI.PassiveTitle.20");
//         if (PassiveTitle is "[c/9C4FFF:Tier 2] [c/FFD792:'Spatial Stratagem']")
//             PassiveTitle = LangHelper.GetText("StarsAbove.UI.PassiveTitle.21");
//         if (PassiveTitle is "[c/9C4FFF:Tier 2] [c/FFD792:'Weakness Exploit']")
//             PassiveTitle = LangHelper.GetText("StarsAbove.UI.PassiveTitle.22");
//         if (PassiveTitle is "[c/9C4FFF:Tier 2] [c/FFD792:'Aprismatism']")
//             PassiveTitle = LangHelper.GetText("StarsAbove.UI.PassiveTitle.23");
//         if (PassiveTitle is "[c/D82BFF:Tier 3] [c/FFC258:'Unbridled Radiance']")
//             PassiveTitle = LangHelper.GetText("StarsAbove.UI.PassiveTitle.24");
//         if (PassiveTitle is "[c/D82BFF:Tier 3] [c/FFC258:'Between the Boundary']")
//             PassiveTitle = LangHelper.GetText("StarsAbove.UI.PassiveTitle.25");
//         if (PassiveTitle is "[c/C2BDFF:Tier 1] [c/FFEED1:'Cyclic Hunter']")
//             PassiveTitle = LangHelper.GetText("StarsAbove.UI.PassiveTitle.26");
//         if (PassiveTitle is "[c/C2BDFF:Tier 1] [c/FFEED1:'Living Dead']")
//             PassiveTitle = LangHelper.GetText("StarsAbove.UI.PassiveTitle.27");
//         if (PassiveTitle is "[c/D82BFF:Tier 3] [c/FFC258:'Beyond Infinity']")
//             PassiveTitle = LangHelper.GetText("StarsAbove.UI.PassiveTitle.28");
//         if (PassiveTitle is "[c/D82BFF:Tier 3] [c/FFC258:'Key Of Chronology']")
//             PassiveTitle = LangHelper.GetText("StarsAbove.UI.PassiveTitle.29");
//
//         if (NovaDialogue is "Now it's my turn!")
//             NovaDialogue = LangHelper.GetText("StarsAbove.UI.NovaDialogue.1");
//         if (NovaDialogue is "I will take the place\nof entropy!")
//             NovaDialogue = LangHelper.GetText("StarsAbove.UI.NovaDialogue.2");
//         if (NovaDialogue is "Come forth,\nblazing blade!")
//             NovaDialogue = LangHelper.GetText("StarsAbove.UI.NovaDialogue.3");
//         if (NovaDialogue is "This is what you\ndeserve.")
//             NovaDialogue = LangHelper.GetText("StarsAbove.UI.NovaDialogue.4");
//         if (NovaDialogue is "Don't worry;\nI'll heal you.")
//             NovaDialogue = LangHelper.GetText("StarsAbove.UI.NovaDialogue.5");
//         if (NovaDialogue is "The power of the\ncosmos!")
//             NovaDialogue = LangHelper.GetText("StarsAbove.UI.NovaDialogue.6");
//         if (NovaDialogue is "I'm not about to\nstop here.")
//             NovaDialogue = LangHelper.GetText("StarsAbove.UI.NovaDialogue.7");
//         if (NovaDialogue is "I'll reduce you to\nstardust!")
//             NovaDialogue = LangHelper.GetText("StarsAbove.UI.NovaDialogue.8");
//         if (NovaDialogue is "Let's finish this!\n")
//             NovaDialogue = LangHelper.GetText("StarsAbove.UI.NovaDialogue.9");
//         if (NovaDialogue is "Don't underestimate\nme.")
//             NovaDialogue = LangHelper.GetText("StarsAbove.UI.NovaDialogue.10");
//         if (NovaDialogue is "Time to finish\nthis.")
//             NovaDialogue = LangHelper.GetText("StarsAbove.UI.NovaDialogue.11");
//         if (NovaDialogue is "I am NOT\nlosing to you.")
//             NovaDialogue = LangHelper.GetText("StarsAbove.UI.NovaDialogue.12");
//         if (NovaDialogue is "I've been waiting\nfor this.")
//             NovaDialogue = LangHelper.GetText("StarsAbove.UI.NovaDialogue.13");
//         if (NovaDialogue is "You've made a\nfatal mistake.")
//             NovaDialogue = LangHelper.GetText("StarsAbove.UI.NovaDialogue.14");
//         if (NovaDialogue is "Let's get the upper\nhand.")
//             NovaDialogue = LangHelper.GetText("StarsAbove.UI.NovaDialogue.15");
//         if (NovaDialogue is "Our victory was\nnever in question.")
//             NovaDialogue = LangHelper.GetText("StarsAbove.UI.NovaDialogue.16");
//         if (NovaDialogue is "The time of parting\nhas come.")
//             NovaDialogue = LangHelper.GetText("StarsAbove.UI.NovaDialogue.17");
//         if (NovaDialogue is "Go back to where\nyou belong.")
//             NovaDialogue = LangHelper.GetText("StarsAbove.UI.NovaDialogue.18");
//         if (NovaDialogue is "I won't lose.\nNot now, not ever.")
//             NovaDialogue = LangHelper.GetText("StarsAbove.UI.NovaDialogue.19");
//
//
//         foreach (IdleArchiveListing idleArchive in StarsAbovePlayer.IdleArchiveList)
//         {
//             if (idleArchive.Name is "Default Idle Dialogue")
//                 idleArchive.Name = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.Name.1");
//             if (idleArchive.Name is "Idle Conversation 1")
//                 idleArchive.Name = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.Name.2");
//             if (idleArchive.Name is "Idle Conversation 2")
//                 idleArchive.Name = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.Name.3");
//             if (idleArchive.Name is "Idle Conversation 3")
//                 idleArchive.Name = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.Name.4");
//             if (idleArchive.Name is "Idle Conversation 4")
//                 idleArchive.Name = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.Name.5");
//             if (idleArchive.Name is "Idle Conversation 5")
//                 idleArchive.Name = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.Name.6");
//             if (idleArchive.Name is "Idle Conversation 6")
//                 idleArchive.Name = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.Name.7");
//             if (idleArchive.Name is "Idle Conversation 7")
//                 idleArchive.Name = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.Name.8");
//             if (idleArchive.Name is "Idle Conversation 8")
//                 idleArchive.Name = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.Name.9");
//             if (idleArchive.Name is "Idle Conversation 9")
//                 idleArchive.Name = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.Name.10");
//             if (idleArchive.Name is "Idle Conversation 10")
//                 idleArchive.Name = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.Name.11");
//             if (idleArchive.Name is "Idle Conversation 11")
//                 idleArchive.Name = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.Name.12");
//             if (idleArchive.Name is "Idle Conversation 12")
//                 idleArchive.Name = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.Name.13");
//             if (idleArchive.Name is "Idle Conversation 13")
//                 idleArchive.Name = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.Name.14");
//             if (idleArchive.Name is "Idle Conversation 14")
//                 idleArchive.Name = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.Name.15");
//             if (idleArchive.Name is "Idle Conversation 15")
//                 idleArchive.Name = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.Name.16");
//             if (idleArchive.Name is "Idle Conversation 16")
//                 idleArchive.Name = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.Name.17");
//             if (idleArchive.Name is "Idle Conversation 17")
//                 idleArchive.Name = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.Name.18");
//             if (idleArchive.Name is "Idle Conversation 18")
//                 idleArchive.Name = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.Name.19");
//             if (idleArchive.Name is "'A World Shrouded in Light'")
//                 idleArchive.Name = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.Name.20");
//             if (idleArchive.Name is "Entering the Observatory")
//                 idleArchive.Name = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.Name.21");
//             if (idleArchive.Name is "Explaining Cosmic Voyages")
//                 idleArchive.Name = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.Name.22");
//             if (idleArchive.Name is "Idle in the Observatory")
//                 idleArchive.Name = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.Name.23");
//             if (idleArchive.Name is "Idle in Space")
//                 idleArchive.Name = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.Name.24");
//
//             if (idleArchive.ListInformation is
//                 "This dialogue appears when you've already seen the normal idle dialogue recently.")
//                 idleArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.ListInformation.1");
//             if (idleArchive.ListInformation is "Pre Hardmode idle dialogue.")
//                 idleArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.ListInformation.2");
//             if (idleArchive.ListInformation is "Hardmode idle dialogue.")
//                 idleArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.ListInformation.3");
//             if (idleArchive.ListInformation is "Idle dialogue during Light Everlasting.")
//                 idleArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.ListInformation.4");
//             if (idleArchive.ListInformation is "Dialogue on the Observatory Hyperborea.")
//                 idleArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.ListInformation.5");
//             if (idleArchive.ListInformation is "An explanation of the mechanics of Cosmic Voyages.")
//                 idleArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.ListInformation.6");
//             if (idleArchive.ListInformation is "Neutral dialogue within the Observatory Hyperborea.")
//                 idleArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.ListInformation.7");
//             if (idleArchive.ListInformation is "Neutral dialogue when on a normal-type Cosmic Voyage. Unused.")
//                 idleArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.ListInformation.8");
//
//             if (idleArchive.UnlockConditions is "Enter Hardmode")
//                 idleArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.UnlockConditions.1");
//             if (idleArchive.UnlockConditions is "Unlocked after witnessing Light Everlasting for the first time.")
//                 idleArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.UnlockConditions.2");
//             if (idleArchive.UnlockConditions is
//                 "Unlocked after entering the Observatory Hyperborea for the first time.")
//                 idleArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.IdleArchiveList.UnlockConditions.3");
//         }
//
//         foreach (BossArchiveListing bossArchive in StarsAbovePlayer.BossArchiveList)
//         {
//             if (bossArchive.Name is "Slime King Dethroned")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.1");
//             if (bossArchive.Name is "Eye of Cthulhu Pierced")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.2");
//             if (bossArchive.Name is "Worldly Evil Sanctified")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.3");
//             if (bossArchive.Name is "Queen Bee Exterminated")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.4");
//             if (bossArchive.Name is "Skeletron Buried")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.5");
//             if (bossArchive.Name is "Deerclops Extinct")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.6");
//             if (bossArchive.Name is "Wall of Flesh Purged")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.7");
//             if (bossArchive.Name is "Queen Slime Overthrown")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.8");
//             if (bossArchive.Name is "The Twins Scrapped")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.9");
//             if (bossArchive.Name is "The Destroyer Deleted")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.10");
//             if (bossArchive.Name is "Skeletron Prime Erased")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.11");
//             if (bossArchive.Name is "All Mechanical Bosses Rended")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.12");
//             if (bossArchive.Name is "Plantera Uprooted")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.13");
//             if (bossArchive.Name is "Golem Deactivated")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.14");
//             if (bossArchive.Name is "Duke Fishron Hunted")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.15");
//             if (bossArchive.Name is "Empress of Light Dimmed")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.16");
//             if (bossArchive.Name is "Lunatic Cultist Crucified")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.17");
//             if (bossArchive.Name is "Moon Lord Defeated")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.18");
//             if (bossArchive.Name is "Terraria's Hero")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.19");
//             if (bossArchive.Name is "Hero of the Realm")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.20");
//             if (bossArchive.Name is "Perseus's Appeal: The Burnished King")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.21");
//             if (bossArchive.Name is "Perseus's Appeal: The Witch of Ink")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.22");
//             if (bossArchive.Name is "Perseus's Appeal: The Arbiter")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.23");
//             if (bossArchive.Name is "Perseus's Appeal: The Warrior of Light")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.24");
//             if (bossArchive.Name is "Vagrant of Space and Time Challenged")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.25");
//             if (bossArchive.Name is "Nalhaun Kneeled")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.26");
//             if (bossArchive.Name is "Penthesilea Washed")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.27");
//             if (bossArchive.Name is "Arbitration Purified")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.28");
//             if (bossArchive.Name is "Warrior of Light Vanquished")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.29");
//             if (bossArchive.Name is "The First Starfarer Defeated")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.30");
//             if (bossArchive.Name is "Desert Scourge Defeated")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.31");
//             if (bossArchive.Name is "Crabulon Defeated")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.32");
//             if (bossArchive.Name is "Hive Mind Defeated")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.33");
//             if (bossArchive.Name is "Perforators Defeated")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.34");
//             if (bossArchive.Name is "Slime God Defeated")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.35");
//             if (bossArchive.Name is "Cryogen Defeated")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.36");
//             if (bossArchive.Name is "Aquatic Scourge Defeated")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.37");
//             if (bossArchive.Name is "Brimstone Elemental Defeated")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.38");
//             if (bossArchive.Name is "Calamitas's Clone Defeated")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.39");
//             if (bossArchive.Name is "Leviathan Defeated")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.40");
//             if (bossArchive.Name is "Astrum Aureus Defeated")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.41");
//             if (bossArchive.Name is "Plaguebringer Goliath")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.42");
//             if (bossArchive.Name is "Ravager Defeated")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.43");
//             if (bossArchive.Name is "Astrum Deus Defeated")
//                 bossArchive.Name = LangHelper.GetText("StarsAbove.UI.BossArchiveList.Name.44");
//
//             if (bossArchive.ListInformation is "Unlocked after defeating King Slime.")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.1");
//             if (bossArchive.ListInformation is "Unlocked after defeating Eye of Cthulhu.")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.2");
//             if (bossArchive.ListInformation is "Unlocked after defeating the Corruption/Crimson boss.")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.3");
//             if (bossArchive.ListInformation is "Unlocked after defeating Queen Bee.")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.4");
//             if (bossArchive.ListInformation is "Unlocked after defeating Skeletron.")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.5");
//             if (bossArchive.ListInformation is "Unlocked after defeating Deerclops.")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.6");
//             if (bossArchive.ListInformation is "Unlocked after defeating the Wall of Flesh.")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.7");
//             if (bossArchive.ListInformation is "Unlocked after defeating Queen Slime")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.8");
//             if (bossArchive.ListInformation is "Unlocked after defeating the Twins.")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.9");
//             if (bossArchive.ListInformation is "Unlocked after defeating the Destroyer.")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.10");
//             if (bossArchive.ListInformation is "Unlocked after defeating Skeletron Prime.")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.11");
//             if (bossArchive.ListInformation is "Unlocked after defeating all of the Mechanical Bosses.")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.12");
//             if (bossArchive.ListInformation is "Unlocked after defeating Plantera.")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.13");
//             if (bossArchive.ListInformation is "Unlocked after defeating Golem.")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.14");
//             if (bossArchive.ListInformation is "Unlocked after defeating Duke Fishron.")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.15");
//             if (bossArchive.ListInformation is "Unlocked after defeating the Empress of Light.")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.16");
//             if (bossArchive.ListInformation is "Unlocked after defeating the Lunatic Cultist.")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.17");
//             if (bossArchive.ListInformation is "Unlocked after defeating the Moon Lord.")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.18");
//             if (bossArchive.ListInformation is
//                 "Unlocked after defeating all vanilla Terraria bosses. Grants an Essence.")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.19");
//             if (bossArchive.ListInformation is
//                 "Unlocked after defeating all vanilla Terraria bosses, and cleansing the world of Light Everlasting. Grants an Essence.")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.20");
//             if (bossArchive.ListInformation is "Grants the item to summon the Burnished King.")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.21");
//             if (bossArchive.ListInformation is "Grants the item to summon the Witch of Ink")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.22");
//             if (bossArchive.ListInformation is "Grants the item to summon Arbitration.")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.23");
//             if (bossArchive.ListInformation is "Grants the item to summon the Warrior of Light.")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.24");
//             if (bossArchive.ListInformation is "Unlocked after 'defeating' the Vagrant of Space and Time.")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.25");
//             if (bossArchive.ListInformation is
//                 "Unlocked after defeating Nalhaun, the Burnished King. Grants a material needed for confronting the final boss.")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.26");
//             if (bossArchive.ListInformation is
//                 "Unlocked after defeating Penthesilea, the Witch of Ink. Grants a material needed for confronting the final boss.")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.27");
//             if (bossArchive.ListInformation is
//                 "Unlocked after defeating Arbitration. Grants a material needed for confronting the final boss.")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.28");
//             if (bossArchive.ListInformation is
//                 "Unlocked after defeating the Warrior of Light. Grants a material needed for confronting the final boss.")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.29");
//             if (bossArchive.ListInformation is
//                 "Unlocked after defeating Tsukiyomi, the First Starfarer. Grants an item used for crafting.")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.30");
//             if (bossArchive.ListInformation is "Unlocked after defeating the Desert Scourge")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.31");
//             if (bossArchive.ListInformation is "Unlocked after defeating Crabulon")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.32");
//             if (bossArchive.ListInformation is "Unlocked after defeating the Hive Mind")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.33");
//             if (bossArchive.ListInformation is "Unlocked after defeating the Perforators")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.34");
//             if (bossArchive.ListInformation is "Unlocked after defeating the Slime God")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.35");
//             if (bossArchive.ListInformation is "Unlocked after defeating Cryogen")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.36");
//             if (bossArchive.ListInformation is "Unlocked after defeating the Aquatic Scourge")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.37");
//             if (bossArchive.ListInformation is "Unlocked after defeating the Brimstone Elemental")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.38");
//             if (bossArchive.ListInformation is "Unlocked after defeating Calamitas's Clone")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.39");
//             if (bossArchive.ListInformation is "Unlocked after defeating the Leviathan")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.40");
//             if (bossArchive.ListInformation is "Unlocked after defeating Astrum Aureus")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.41");
//             if (bossArchive.ListInformation is "Unlocked after defeating the Plaguebringer Goliath")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.42");
//             if (bossArchive.ListInformation is "Unlocked after defeating the Ravager")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.43");
//             if (bossArchive.ListInformation is "Unlocked after defeating Astrum Deus")
//                 bossArchive.ListInformation = LangHelper.GetText("StarsAbove.UI.BossArchiveList.ListInformation.44");
//
//             if (bossArchive.UnlockConditions is "Defeat King Slime.")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.1");
//             if (bossArchive.UnlockConditions is "Defeat Eye of Cthulhu.")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.2");
//             if (bossArchive.UnlockConditions is "Defeat the world's Corruption/Crimson boss.")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.3");
//             if (bossArchive.UnlockConditions is "Defeat Queen Bee.")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.4");
//             if (bossArchive.UnlockConditions is "Defeat Skeletron.")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.5");
//             if (bossArchive.UnlockConditions is "Defeat Deerclops.")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.6");
//             if (bossArchive.UnlockConditions is "Defeat the Wall of Flesh.")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.7");
//             if (bossArchive.UnlockConditions is "Defeat Queen Slime")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.8");
//             if (bossArchive.UnlockConditions is "Defeat the Twins.")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.9");
//             if (bossArchive.UnlockConditions is "Defeat the Destroyer.")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.10");
//             if (bossArchive.UnlockConditions is "Defeat Skeletron Prime.")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.11");
//             if (bossArchive.UnlockConditions is "Defeat all of the Mechanical Bosses.")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.12");
//             if (bossArchive.UnlockConditions is "Defeat Plantera.")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.13");
//             if (bossArchive.UnlockConditions is "Defeat Golem.")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.14");
//             if (bossArchive.UnlockConditions is "Defeat Duke Fishron.")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.15");
//             if (bossArchive.UnlockConditions is "Defeat the Empress of Light.")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.16");
//             if (bossArchive.UnlockConditions is "Defeat the Lunatic Cultist.")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.17");
//             if (bossArchive.UnlockConditions is "Defeat the Moon Lord.")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.18");
//             if (bossArchive.UnlockConditions is "Defeat all vanilla bosses.")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.19");
//             if (bossArchive.UnlockConditions is "Defeat all vanilla bosses and the Warrior of Light in Expert Mode.")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.20");
//             if (bossArchive.UnlockConditions is "Defeat the Vagrant of Space and Time.")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.21");
//             if (bossArchive.UnlockConditions is "Defeat Nalhaun, the Burnished King.")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.22");
//             if (bossArchive.UnlockConditions is "Defeat Penthesilea, the Witch of Ink.")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.23");
//             if (bossArchive.UnlockConditions is "Defeat Arbitration.")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.24");
//             if (bossArchive.UnlockConditions is "Defeat the Warrior of Light.")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.25");
//             if (bossArchive.UnlockConditions is "Defeat ???")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.26");
//             if (bossArchive.UnlockConditions is "Defeat the Desert Scourge")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.27");
//             if (bossArchive.UnlockConditions is "Defeat Crabulon")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.28");
//             if (bossArchive.UnlockConditions is "Defeat the Hive Mind")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.29");
//             if (bossArchive.UnlockConditions is "Defeat the Perforators")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.30");
//             if (bossArchive.UnlockConditions is "Defeat the Slime God")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.31");
//             if (bossArchive.UnlockConditions is "Defeat Cryogen")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.32");
//             if (bossArchive.UnlockConditions is "Defeat the Aquatic Scourge")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.33");
//             if (bossArchive.UnlockConditions is "Defeat the Brimstone Elemental")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.34");
//             if (bossArchive.UnlockConditions is "Defeat Calamitas")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.35");
//             if (bossArchive.UnlockConditions is "Defeat the Leviathan")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.36");
//             if (bossArchive.UnlockConditions is "Defeat Astrum Aureus")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.37");
//             if (bossArchive.UnlockConditions is "Defeat the Plaguebringer Goliath")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.38");
//             if (bossArchive.UnlockConditions is "Defeat the Ravager")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.39");
//             if (bossArchive.UnlockConditions is "Defeat Astrum Deus")
//                 bossArchive.UnlockConditions = LangHelper.GetText("StarsAbove.UI.BossArchiveList.UnlockConditions.40");
//         }
//
//         if (AbilitySubName is "No Stellar Nova has been selected.")
//             AbilitySubName = LangHelper.GetText("StarsAbove.UI.AbilitySubName.1");
//         if (AbilitySubName is "[c/C2BDFF:Limitless Starry Void]")
//             AbilitySubName = LangHelper.GetText("StarsAbove.UI.AbilitySubName.2");
//         if (AbilitySubName is "[c/F19559:Shine True, O Burning Bright Star]")
//             AbilitySubName = LangHelper.GetText("StarsAbove.UI.AbilitySubName.3");
//         if (AbilitySubName is "[c/36BDEC:Unbridled Essence of the Dragon's Fist]")
//             AbilitySubName = LangHelper.GetText("StarsAbove.UI.AbilitySubName.4");
//         if (AbilitySubName is "[c/ECB3FC:The Forever-Sealed Utopia]")
//             AbilitySubName = LangHelper.GetText("StarsAbove.UI.AbilitySubName.5");
//         if (AbilitySubName is "[c/00FF93:The Moment a Planet is Born]")
//             AbilitySubName = LangHelper.GetText("StarsAbove.UI.AbilitySubName.6");
//
//         if (AbilityName is "Theofania Inanis")
//             AbilityName = LangHelper.GetText("StarsAbove.UI.AbilityName.1");
//         if (AbilityName is "Ars Laevateinn")
//             AbilityName = LangHelper.GetText("StarsAbove.UI.AbilityName.2");
//         if (AbilityName is "Kiwami Ryuken")
//             AbilityName = LangHelper.GetText("StarsAbove.UI.AbilityName.3");
//         if (AbilityName is "Garden of Avalon")
//             AbilityName = LangHelper.GetText("StarsAbove.UI.AbilityName.4");
//         if (AbilityName is "Edin Genesis Quasar")
//             AbilityName = LangHelper.GetText("StarsAbove.UI.AbilityName.5");
//
//         if (AbilityDescription is
//             "Conjure a colossal blade to cleave foes in twain. After casting, you will be able to re-cast\nTheofania Inanis for 10 seconds at no additional cost. Striking foes with Theofania Inanis\nwill inflict Void Atrophy, dealing powerful damage over time. The second cast of\nTheofania Inanis will double the potency of Void Atrophy, if applicable.\nThis debuff lasts for 30 seconds. If the attack crits, refund a portion of consumed \nStellar Nova Energy. Each cast does 50% of Stellar Nova damage.")
//             AbilityDescription = LangHelper.GetText("StarsAbove.UI.AbilityDescription.1");
//         if (AbilityDescription is
//             "Wield a blazing greatsword to return foes to ashes. Casting Ars Laevataeinn will mark\na colossal region around you with infernal flames. Ars Laevateinn will pulse damage\nfive times in the specified region, dealing 1/5th of the total damage with each hit.\nDuring this time, you will be granted 'Surtr's Twilight.' While this buff is active,\nall attacks will Burn foes for 8 seconds. If Burned foes are struck by Ars Laevateinn,\nthey will take a small portion of Stellar Nova damage as extra damage.")
//             AbilityDescription = LangHelper.GetText("StarsAbove.UI.AbilityDescription.2");
//         if (AbilityDescription is
//             "Upon activation of Kiwami Ryuken, you will have a one-second window to take\ndamage from a foe, becoming invincible in the process. If hit, a counterattack will\ntrigger, dealing incredible damage in close proximity, aimed at your cursor.\nYou will be unable to execute the counterattack if the foe is further than melee\nrange, but damage will still be negated. You will be refunded 50% of the Stellar Nova\nenergy cost if you are not hit during Kiwami Ryuken.")
//             AbilityDescription = LangHelper.GetText("StarsAbove.UI.AbilityDescription.3");
//         if (AbilityDescription is
//             "Call forth the Garden of Avalon, infusing the world with radiant energy.\nGrant powerful Health and Mana regeneration periodically for 8 seconds,\nscaling with Stellar Nova Damage. Gain Invincibility for 2 seconds.\nIf the cast would be critical, gain Health, modified by Stellar Nova crit modifiers.\nAdditionally, upon a critical cast, gain the buff 'Solemn Aegis' for 15 seconds,\nwhich negates one hit of damage independently of Invincibility.")
//             AbilityDescription = LangHelper.GetText("StarsAbove.UI.AbilityDescription.4");
//         if (AbilityDescription is
//             "Upon cast, become immobile and invincible temporarily. Gain 'Astarte Driver' for 25\nseconds. Astarte Driver grants infinite flight and three Cosmic Charges. ALL attacks\nwhile Astarte Driver is active will inherit the stats of the Stellar Nova.\nPressing the Starfarer Action Key with a Cosmic Charge available will launch a \nbarrage of spatial projectiles (2 second use cooldown.) After activating Astarte\nDriver's stat-changing effect, the target will be immune for a very short period.")
//             AbilityDescription = LangHelper.GetText("StarsAbove.UI.AbilityDescription.5");
//
//         if (StarfarerBonus is
//             "You may re-cast Theofania Inanis again to a total of 3 times, dealing 25% damage.\nThis cast does not inflict Void Atrophy, nor does it strengthen it.")
//             StarfarerBonus = LangHelper.GetText("StarsAbove.UI.StarfarerBonus.1");
//         if (StarfarerBonus is
//             "The second hit of Theofania Inanis does not strengthen Void Atrophy, but increases self\ndamage output by 400% for 5 seconds.")
//             StarfarerBonus = LangHelper.GetText("StarsAbove.UI.StarfarerBonus.2");
//         if (StarfarerBonus is
//             "Burning foes take extra damage. If the attack was a critical hit,\nburning foes take even more damage.")
//             StarfarerBonus = LangHelper.GetText("StarsAbove.UI.StarfarerBonus.3");
//         if (StarfarerBonus is
//             "Surtr's Twilight will additionally grant a 10% attack buff.\nGain Mana Regeneration while Surtr's Twilight is active.\n")
//             StarfarerBonus = LangHelper.GetText("StarsAbove.UI.StarfarerBonus.4");
//         if (StarfarerBonus is
//             "The counterattack will always deal critical damage below half health.\nRestore 5 Stellar Nova Energy upon triggering the counterattack.")
//             StarfarerBonus = LangHelper.GetText("StarsAbove.UI.StarfarerBonus.5");
//         if (StarfarerBonus is
//             "Heal 40 health and mana upon triggering the counterattack.\n10 extra Stellar Nova energy will be refunded on failure.\n")
//             StarfarerBonus = LangHelper.GetText("StarsAbove.UI.StarfarerBonus.6");
//         if (StarfarerBonus is
//             "Invincibility lasts for 4 seconds instead of 2.\nInstantly heal 100 HP upon casting Garden of Avalon.")
//             StarfarerBonus = LangHelper.GetText("StarsAbove.UI.StarfarerBonus.7");
//         if (StarfarerBonus is
//             "Gain an extra buff on cast: Dreamlike Charisma. (Can not stack.)\nDreamlike Charisma increases damage by 16%, doubled above 100 Mana.\n")
//             StarfarerBonus = LangHelper.GetText("StarsAbove.UI.StarfarerBonus.8");
//         if (StarfarerBonus ==
//             $"Critical hits do an additional {StarsAbovePlayer.baseNovaDamageAdd / 10} damage in Astarte Driver.\nYou will gain a Cosmic Charge after defeating a foe with a critical hit. (Max 5 charges.)")
//             StarfarerBonus = string.Format(LangHelper.GetText("StarsAbove.UI.StarfarerBonus.9"),
//                 StarsAbovePlayer.baseNovaDamageAdd / 10);
//         if (StarfarerBonus ==
//             $"Astarte Driver attacks will execute any foe below {StarsAbovePlayer.baseNovaDamageAdd / 10} HP.\nGain 1 second of Invincibility when a Cosmic Charge is expended.\n")
//             StarfarerBonus = string.Format(LangHelper.GetText("StarsAbove.UI.StarfarerBonus.10"),
//                 StarsAbovePlayer.baseNovaDamageAdd / 10);
//
//         if (StarsAbovePlayer.chosenStellarNova == 1)
//             StarsAbovePlayer.baseStats = string.Format(LangHelper.GetText("StarsAbove.UI.BaseStats.1"),
//                 StarsAbovePlayer.novaDamage, StarsAbovePlayer.novaGaugeMax,
//                 Math.Round(StarsAbovePlayer.novaDamage * (1.0 + StarsAbovePlayer.novaDamageMod), 5),
//                 StarsAbovePlayer.novaCritChance + StarsAbovePlayer.novaCritChanceMod,
//                 Math.Round(StarsAbovePlayer.novaCritDamage * (1.0 + StarsAbovePlayer.novaCritDamageMod), 5),
//                 StarsAbovePlayer.novaGaugeMax - StarsAbovePlayer.novaChargeMod);
//         if (StarsAbovePlayer.chosenStellarNova == 2)
//             StarsAbovePlayer.baseStats = string.Format(LangHelper.GetText("StarsAbove.UI.BaseStats.2"),
//                 StarsAbovePlayer.novaDamage, StarsAbovePlayer.novaGaugeMax,
//                 Math.Round(StarsAbovePlayer.novaDamage * (1.0 + StarsAbovePlayer.novaDamageMod), 5),
//                 StarsAbovePlayer.novaCritChance + StarsAbovePlayer.novaCritChanceMod,
//                 Math.Round(StarsAbovePlayer.novaCritDamage * (1.0 + StarsAbovePlayer.novaCritDamageMod), 5),
//                 StarsAbovePlayer.novaGaugeMax - StarsAbovePlayer.novaChargeMod);
//         if (StarsAbovePlayer.chosenStellarNova == 3)
//             StarsAbovePlayer.baseStats = string.Format(LangHelper.GetText("StarsAbove.UI.BaseStats.3"),
//                 StarsAbovePlayer.novaDamage, StarsAbovePlayer.novaGaugeMax,
//                 Math.Round(StarsAbovePlayer.novaDamage * (1.0 + StarsAbovePlayer.novaDamageMod), 5),
//                 StarsAbovePlayer.novaCritChance + StarsAbovePlayer.novaCritChanceMod,
//                 Math.Round(StarsAbovePlayer.novaCritDamage * (1.0 + StarsAbovePlayer.novaCritDamageMod), 5),
//                 StarsAbovePlayer.novaGaugeMax - StarsAbovePlayer.novaChargeMod);
//         if (StarsAbovePlayer.chosenStellarNova == 4)
//             StarsAbovePlayer.baseStats = string.Format(LangHelper.GetText("StarsAbove.UI.BaseStats.4"),
//                 StarsAbovePlayer.novaDamage, StarsAbovePlayer.novaGaugeMax,
//                 Math.Round(StarsAbovePlayer.novaDamage * (1.0 + StarsAbovePlayer.novaDamageMod), 5),
//                 StarsAbovePlayer.novaCritChance + StarsAbovePlayer.novaCritChanceMod,
//                 Math.Round(StarsAbovePlayer.novaCritDamage * (1.0 + StarsAbovePlayer.novaCritDamageMod), 5),
//                 StarsAbovePlayer.novaGaugeMax - StarsAbovePlayer.novaChargeMod);
//         if (StarsAbovePlayer.chosenStellarNova == 5)
//             StarsAbovePlayer.baseStats = string.Format(LangHelper.GetText("StarsAbove.UI.BaseStats.5"),
//                 StarsAbovePlayer.novaDamage, StarsAbovePlayer.novaGaugeMax,
//                 Math.Round(StarsAbovePlayer.novaDamage * (1.0 + StarsAbovePlayer.novaDamageMod), 5),
//                 StarsAbovePlayer.novaCritChance + StarsAbovePlayer.novaCritChanceMod,
//                 Math.Round(StarsAbovePlayer.novaCritDamage * (1.0 + StarsAbovePlayer.novaCritDamageMod), 5),
//                 StarsAbovePlayer.novaGaugeMax - StarsAbovePlayer.novaChargeMod);
//
//         if (PromptDialogue is "You've come to defeat me. Isn't that right?\nYou can't even notice your own hypocrisy.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.1");
//         if (PromptDialogue is "The only reason you fight is to get\nstronger.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.2");
//         if (PromptDialogue is "Your mission was to save people.\nI don't even think you care.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.3");
//         if (PromptDialogue is "Do you really call yourself a hero?\nI think it's time to fix that.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.4");
//         if (PromptDialogue is "She's lost her mind completely...!\nI can feel immense power.. prepare yourself!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.5");
//         if (PromptDialogue is "Quickly, to me! Stand on the blue\ntiles and I'll shield you!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.6");
//         if (PromptDialogue == $"{Main.LocalPlayer.name}, come to me quickly!\nI'll shield you on the purple tiles!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.7");
//         if (PromptDialogue is "Yeah.. That's poison. I'll send you a get well card.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.8");
//         if (PromptDialogue is "It looks like your defenses are lowered! Be careful.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.9");
//         if (PromptDialogue is "You've been silenced! Magic is out of the question.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.10");
//         if (PromptDialogue is "I think you've been cursed. That's.. not good.\nYou aren't able to use anything for now.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.11");
//         if (PromptDialogue is "You've been frozen!\n")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.12");
//         if (PromptDialogue is "You're burning up! Or freezing? \n..It hurts regardless!\n")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.13");
//         if (PromptDialogue is "Ew. It looks like you're covered in webs..\n")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.14");
//         if (PromptDialogue is "You've been petrified! How does that even work?\n")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.15");
//         if (PromptDialogue is "You're standing on something REALLY hot.\n")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.16");
//         if (PromptDialogue is "You're dying- and quickly. Get out of there!\n")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.17");
//         if (PromptDialogue is "That's probably not good.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.18");
//         if (PromptDialogue is "I think you're about to drown..")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.19");
//         if (PromptDialogue is "You're losing a LOT of blood. Yikes.\nYou can't regenerate health any more.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.20");
//         if (PromptDialogue is "[You can't make out the words.]\n")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.21");
//         if (PromptDialogue is "Whoops..")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.22");
//         if (PromptDialogue is "Sorry, little guy.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.23");
//         if (PromptDialogue is "Oops.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.24");
//         if (PromptDialogue is "That's one down.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.25");
//         if (PromptDialogue is "One more defeated!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.26");
//         if (PromptDialogue is "That takes care of that.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.27");
//         if (PromptDialogue is "Another one down.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.28");
//         if (PromptDialogue is "You're great at this!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.29");
//         if (PromptDialogue is "Nice work. That's one down.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.30");
//         if (PromptDialogue is "There it goes!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.31");
//         if (PromptDialogue is "That'll teach em!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.32");
//         if (PromptDialogue is "That'll show them!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.33");
//         if (PromptDialogue is "Don't mess with us!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.34");
//         if (PromptDialogue is "Easy!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.35");
//         if (PromptDialogue is "Didn't even break a sweat.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.36");
//         if (PromptDialogue is "That was so easy!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.37");
//         if (PromptDialogue is "Enough of that one.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.38");
//         if (PromptDialogue is "An easy victory.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.39");
//         if (PromptDialogue is "Right, that's that.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.40");
//         if (PromptDialogue is "How could we ever lose?")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.41");
//         if (PromptDialogue is "It's over.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.42");
//         if (PromptDialogue is "No more of that.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.43");
//         if (PromptDialogue is "A good encounter.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.44");
//         if (PromptDialogue is "That was close..")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.45");
//         if (PromptDialogue is "That was almost really bad.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.46");
//         if (PromptDialogue is "Thank goodness we killed it in time.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.47");
//         if (PromptDialogue is "Finally. You got it!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.48");
//         if (PromptDialogue is "And that takes care of that one.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.49");
//         if (PromptDialogue is "That was a strong one.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.50");
//         if (PromptDialogue is "A decisive crit!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.51");
//         if (PromptDialogue is "They felt that one!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.52");
//         if (PromptDialogue is "A perfectly-timed attack.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.53");
//         if (PromptDialogue is "Nice, you hit their weak spot.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.54");
//         if (PromptDialogue is "A critical hit..!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.55");
//         if (PromptDialogue is "Well struck. That was definitely critical.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.56");
//         if (PromptDialogue is "Wow. I felt that one..")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.57");
//         if (PromptDialogue is "That's.. not good.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.58");
//         if (PromptDialogue is "Ouch...")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.59");
//         if (PromptDialogue is "That wasn't good at all..")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.60");
//         if (PromptDialogue is "You should probably heal after that one.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.61");
//         if (PromptDialogue is "Barely a scratch.. right?")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.62");
//         if (PromptDialogue is "That wasn't supposed to happen..")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.63");
//         if (PromptDialogue is "I don't think you can walk that one off.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.64");
//         if (PromptDialogue is "....Ouch.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.65");
//         if (PromptDialogue is "A powerful foe approaches!\nWe aren't going to lose this.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.66");
//         if (PromptDialogue is "An incredibly strong foe draws near!\nLet's give them a fight to remember!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.67");
//         if (PromptDialogue is "A strong foe draws near.\nIt's time to fight.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.68");
//         if (PromptDialogue is "Right. No more games.\nA powerful foe is approaching.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.69");
//         if (PromptDialogue == $"{Main.LocalPlayer.name}, danger approaches!\nI've been itching for a fight!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.70");
//         if (PromptDialogue is "The.. eyeball.. approaches. Watch yourself- it's a big one.\nIt gets stronger when it's on its last legs, I think.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.71");
//         if (PromptDialogue is "It's the lord of the slimes!\nI think it has a teleportation-like ability..")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.72");
//         if (PromptDialogue is "A colossal worm!\nWatch where it emerges; it'll try and hit your blind spots!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.73");
//         if (PromptDialogue is "This thing is trying to attack your mind directly..!\nDon't be fooled by the mirages!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.74");
//         if (PromptDialogue is "Watch out.. the Queen Bee is awake!\nMake sure to dodge the horizontal charges!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.75");
//         if (PromptDialogue is "Don't underestimate this monster!\nStay away from his skull and arms!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.76");
//         if (PromptDialogue is "That thing is massive!\nIf you can, try and build a path to fight it on.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.77");
//         if (PromptDialogue is "There's two giant eyeballs coming your way! Let's see...\nThe red one will shoot at you, and the green one charges.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.78");
//         if (PromptDialogue is "What in the world is that thing? A deer?\nIt's only got one eye... aim for it!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.79");
//         if (PromptDialogue is "It's another colossal slime!\nIt looks like it's going to summon some minions!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.80");
//         if (PromptDialogue is "A Hallow-aspected foe has appeared!\nMaybe leave the butterfly alone next time...?")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.81");
//         if (PromptDialogue is "A giant mechanical worm.. What can we do..?\nHow about trying to attack multiple parts of it at once?")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.82");
//         if (PromptDialogue is "It's a more advanced version of Skeletron..\nTry going for the arms first, instead of the head.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.83");
//         if (PromptDialogue is "Plantera is awake! Be mindful of its vines.\nIt would be great to have a huge arena to fight it in.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.84");
//         if (PromptDialogue is "An ancient mechanical monster..\nWatch out for the traps in the temple while fighting it.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.85");
//         if (PromptDialogue is "You reeled in something crazy!\nSomething tells me you should stay near the sea!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.86");
//         if (PromptDialogue is "It's one of those Lunatic Cultists..\nStop them before they unleash a calamity..!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.87");
//         if (PromptDialogue is "I can't believe it.. it's the Moon Lord!\nThis is the final battle! We have to win this!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.88");
//         if (PromptDialogue is "The Warrior of Light approaches..\nWhen he breaks his limits, prepare yourself!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.89");
//         if (PromptDialogue is "Something about this foe seems familiar...\nAttacks won't work; just survive for as long as you can!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.90");
//         if (PromptDialogue is "Don't underestimate this foe..!\nKeep grabbing the stolen lifeforce he's taking from you!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.91");
//         if (PromptDialogue is "This witch attacks with paint!\nMind what color you're doused in!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.92");
//         if (PromptDialogue is "This thing changes its attack patterns!\nTake note of its stances, or else!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.93");
//         if (PromptDialogue is "There's something coming from below, and fast!\nPrepare yourself.. this is one strong worm!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.94");
//         if (PromptDialogue is "It's a massive moving mass of mycelium..\nLet's take out the trash!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.95");
//         if (PromptDialogue is "A corrupted beast draws near!\nKill its minions quickly, lest it overwhelm you!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.96");
//         if (PromptDialogue is "What in the world is that thing?\nAim for that disgusting Hive before it's too late!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.97");
//         if (PromptDialogue is "So this is the source of all the world's slimes.\nDon't get hasty; I'm certain those slimes will split when hurt!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.98");
//         if (PromptDialogue is "Something is strange about this thing, but I don't know what.\nDon't get frozen... but you could probably already tell.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.99");
//         if (PromptDialogue is "Hey, it's the Desert Scourge- but not so dried up!\nWe've seen one before, how bad could this one be?")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.100");
//         if (PromptDialogue is "It's a giant sea serpent! Hang on...\nThis thing is SERIOUSLY dangerous!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.101");
//         if (PromptDialogue is "The flames have brought forth a demonic spirit!\nTake care to watch your footing, lest you succumb to lava!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.102");
//         if (PromptDialogue is "This thing... it's a herald of destruction..\nYou know what devestation it can bring. Don't lose..!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.103");
//         if (PromptDialogue is "...It's Anahita again.\nAre you going to challenge the Leviathan?")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.104");
//         if (PromptDialogue is "...Do you hear that?\nWhatever it is.. it sounds really dangerous.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.105");
//         if (PromptDialogue is "That demon of the sea is fighting back!\nI hope you're ready for this...")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.106");
//         if (PromptDialogue is "Whoa. This thing is enormous!!\nWho knew she had this up her sleeve..?")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.107");
//         if (PromptDialogue is "The Astral Infection has corrupted whatever this was.\nDon't underestimate it. The Infection can do anything...")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.108");
//         if (PromptDialogue is "Oh, great.. a giant robotic bug. It kind of looks like the\nQueen Bee, so try and remember her attacks!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.109");
//         if (PromptDialogue is "This is.. an amalgamation of flesh and machinery..\nAbove everything, try and stay away from it!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.110");
//         if (PromptDialogue == $"This is.. a descendant of a cosmic god!\n{Main.LocalPlayer.name}, don't get reckless!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.111");
//         if (PromptDialogue is "Something's reacting to the Profaned\nShard! Prepare for a fight!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.112");
//         if (PromptDialogue is "You've summoned a draconic monster..!\nIt looks to be incredibly quick!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.113");
//         if (PromptDialogue is "The fiery god of both light and dark descends..\nNo way we're losing to this thing!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.114");
//         if (PromptDialogue is "A spatial worm is approaching!\nDon't get careless.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.115");
//         if (PromptDialogue is "That rune has summoned some sort of..\nvoid entity..?")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.116");
//         if (PromptDialogue is "Someone.. or something.. is approaching.\nIt can shapeshift at will! Get ready!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.117");
//         if (PromptDialogue is "Something's awake. The Dungeon's volatile\nspirits have coalesed...")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.118");
//         if (PromptDialogue is "The acid ocean has spat out a monster!\nWait until it gets tired to strike!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.119");
//         if (PromptDialogue is "The Devourer of Gods has arrived!\nFight! Fight with all your strength!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.120");
//         if (PromptDialogue is "Yharim's loyal beast, in the flesh..!\nLet's send this tyrant down a peg!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.121");
//         if (PromptDialogue is "Huh? Where's it going?\nWe were in the middle of something!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.122");
//         if (PromptDialogue is "We bow to no one!\nLet's bring this witch down!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.123");
//         if (PromptDialogue is "This is Yharim's loyal scientist.\nHis knowledge is nigh-infinite.. Stay cautious.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.124");
//         if (PromptDialogue is "Twin mechanical eyes- incredibly powerful.\nDon't get overwhelmed..!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.125");
//         if (PromptDialogue is "The very earth trembles before this foe.\nDraedon's toys have become stronger...")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.126");
//         if (PromptDialogue == $"Heads up, {Main.LocalPlayer.name}!\nThat machine is blotting out the sky!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.127");
//         if (PromptDialogue is "Whoa, look at this thing... what a go-getter! Oh, right- strategy.\nIt looks like you can disable some attacks by hitting certain spots, so try that.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.128");
//         if (PromptDialogue is "Aww, this pint-sized witch wants a fight? Alright then!\nIt looks like you'll be barraged with debuffs- Get the heals ready.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.129");
//         if (PromptDialogue is "Hah? Just look at this muppet... thinking he's better than us or something!\nGive him a good whallop!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.130");
//         if (PromptDialogue is "Let's get this show started!\nHe'll be attacking with the power of worldly invaders, if you remember those!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.131");
//         if (PromptDialogue is "If I had a nickel for times you've thrown voodoo dolls into lava... Never mind.\nMutant's super upset, super strong, and super coming straight for you.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.132");
//         if (PromptDialogue is "A lightning bird is approaching!\nIt's not too powerful, but don't get careless.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.133");
//         if (PromptDialogue is "Hey. Doesn't that jellyfish look a little too big?\nWhatever its issue is, it's coming this way!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.134");
//         if (PromptDialogue is "Ugh, what is that thing? A vampire?\nQuick, find some silver! Or is that werewolves..?")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.135");
//         if (PromptDialogue is "Looks like the granite has woken up..?\nTime to bury it where it belongs.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.136");
//         if (PromptDialogue is "This gladiator looks stronger than the others.\nLet's give it a fight to remember!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.137");
//         if (PromptDialogue is "It's an alien spaceship!\nIt looks like it'll be stronger on low HP!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.138");
//         if (PromptDialogue is "Watch yourself.. looks like a Borean Strider\nis nearby.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.139");
//         if (PromptDialogue is "Looks like a Beholder's reacted with the Void Lens.\nLet's stab it in its big ugly eye..!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.140");
//         if (PromptDialogue is "The Grim Harvest Sigil has summoned a powerful foe.\nI don't know what else you expected!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.141");
//         if (PromptDialogue is "The Abyssal Shadows are converging!\nI sense powerful dark magic from this sea creature..")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.142");
//         if (PromptDialogue is "The elements themselves are on the hunt.\nLet's show them a thing or two!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.143");
//         if (PromptDialogue is "It's sweltering here.\nDeserts will be the same wherever you are, I guess.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.144");
//         if (PromptDialogue is "So this is the Jungle. Take care when exploring.\nAh, but make sure to explore everything!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.145");
//         if (PromptDialogue is "Well, it's the ocean.\n...Did you want me to say something else? It's an ocean.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.146");
//         if (PromptDialogue is "Isn't it nice up here? \n")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.147");
//         if (PromptDialogue is "The Underworld, huh? Interesting.\nThis goes without saying, but it's incredibly dangerous here.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.148");
//         if (PromptDialogue is "The world is being corrupted away here.\nLet's not tarry.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.149");
//         if (PromptDialogue is "The ground here feels like flesh.\nI feel like we shouldn't stay long- but that's obvious..")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.150");
//         if (PromptDialogue is "It's snow! I've been always fond of snow.\nThe water-based kind, of course.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.151");
//         if (PromptDialogue is "It's the Hallow, the stuff of legend! Awesome!\nEverything here wants to kill us, though. Bummer.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.152");
//         if (PromptDialogue is "Whoa! This place is funky.\nYou don't see these mushrooms every day.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.153");
//         if (PromptDialogue is "There's a skele-ton of enemies here!\nDon't you enjoy a little danger? I sure do.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.154");
//         if (PromptDialogue is "So this is the meteor impact we heard.\nI bet we can make some crazy stuff with a meteorite.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.155");
//         if (PromptDialogue is "This is.. the Brimstone Crag.\nSomething dreadful happened here.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.156");
//         if (PromptDialogue is "So this is the Astral Infection.\nI've read about it, but actually seeing it...")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.157");
//         if (PromptDialogue is "Wow.. This place is quite unique.\nI can't quite explain.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.158");
//         if (PromptDialogue is "Whatever was done to this place is irreversible.\nThis ocean has been stained red with blood.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.159");
//         if (PromptDialogue is "You're entering the true depths of the ocean.\nI hope you realize how dangerous this is!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.160");
//         if (PromptDialogue is "This cavern seems to be made of\nhard granite.. Curious.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.161");
//         if (PromptDialogue is "This cave exhudes royalty.\nPerhaps it has to do with the abundance of marble.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.162");
//         if (PromptDialogue is "This is a deep part of the ocean.\nTake care you don't drown...")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.163");
//         if (PromptDialogue is "Looks like it started raining.\nHopefully this doesn't put a damper on things.. heh.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.164");
//         if (PromptDialogue is "It's a blizzard!\nDon't get frostbite, now. That'd be embarassing.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.165");
//         if (PromptDialogue is "A sandstorm has kicked up.\nIt gets everywhere, so be careful.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.166");
//         if (PromptDialogue is "Time and space bend to my will!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.167");
//         if (PromptDialogue is "Not on my watch!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.168");
//         if (PromptDialogue is "Turn back the clock..!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.169");
//         if (PromptDialogue is "By your undying rage..!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.170");
//         if (PromptDialogue is "It's just a flesh wound.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.171");
//         if (PromptDialogue is "Embrace the abyss! Set yourself free!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.172");
//         if (PromptDialogue is "No one will escape!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.173");
//         if (PromptDialogue is "Like lambs to slaughter!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.174");
//         if (PromptDialogue is "Butcher them!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.175");
//         if (PromptDialogue is "Let's show them our power.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.176");
//         if (PromptDialogue is "I'm ready to unleash my power!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.177");
//         if (PromptDialogue is "I'm ready to use the Stellar Nova!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.178");
//         if (PromptDialogue is "OK. Done charging- let's go.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.179");
//         if (PromptDialogue is "Just tell me when.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.180");
//         if (PromptDialogue is "Here we go.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.181");
//         if (PromptDialogue is "You've made it to the Observatory!\nSo, what do you think?")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.182");
//         if (PromptDialogue is "Looks like you've arrived. \nThese are asteroids of interest- let's do some exploring.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.183");
//         if (PromptDialogue is "We've made it. This planet is strange..\nThe surface has been wiped clean... What happened?")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.184");
//         if (PromptDialogue is "She was so close all along...\nUse the Mnemonic Sigil on the arena's center to begin.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.185");
//         if (PromptDialogue is "It looks like we can't explore this yet...\nMaybe next time.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.186");
//         if (PromptDialogue is "You've come to defeat me. Isn't that right?\nYou can't even notice your own hypocrisy.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.187");
//         if (PromptDialogue is "The only reason you fight is to get\nstronger.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.188");
//         if (PromptDialogue is "Your mission was to save people.\nI don't even think you care.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.189");
//         if (PromptDialogue is "Do you really call yourself a hero?\nI think it's time to fix that.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.190");
//         if (PromptDialogue is "This isn't right.. She isn't herself!\nPrepare yourself... she's not done yet..!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.191");
//         if (PromptDialogue == $"Quickly, {Main.LocalPlayer.name}! I'll shield you\nwhen you stand on the blue tiles..!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.192");
//         if (PromptDialogue is "Quickly, stand on the purple tiles!\nI'll protect you from this attack!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.193");
//         if (PromptDialogue is "Uhh.. you're looking a little sick.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.194");
//         if (PromptDialogue is "The Ichor is dampening your defenses. Watch out.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.195");
//         if (PromptDialogue is "You've been silenced.. No magic for now.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.196");
//         if (PromptDialogue is "That looks to me like a curse.. You can't use anything right now.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.197");
//         if (PromptDialogue is "That doesn't look good. You're frozen solid.\n")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.198");
//         if (PromptDialogue is "You've been inflicted with Frostburn! That's.. confusing.\n")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.199");
//         if (PromptDialogue is "Yuck- you've been rendered immobile by webs.\n")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.200");
//         if (PromptDialogue is "You've been petrified..\n")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.201");
//         if (PromptDialogue is "You're taking damage from a hot surface!\n")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.202");
//         if (PromptDialogue is "You're dying fast. Find a way out of there.\n")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.203");
//         if (PromptDialogue is "Ouch. That's probably not good.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.204");
//         if (PromptDialogue is "You need some air, quick.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.205");
//         if (PromptDialogue is "That's a lot of blood..\nYou aren't regenerating health now, that's for sure.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.206");
//         if (PromptDialogue is "Whoops.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.207");
//         if (PromptDialogue is "Did you mean to do that?")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.208");
//         if (PromptDialogue is "Sorry, little one.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.209");
//         if (PromptDialogue is "Good work.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.210");
//         if (PromptDialogue is "That's another one down.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.211");
//         if (PromptDialogue is "Well fought.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.212");
//         if (PromptDialogue is "You're pretty good at this.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.213");
//         if (PromptDialogue is "Nice work.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.214");
//         if (PromptDialogue is "They'll never beat us.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.215");
//         if (PromptDialogue is "You've defeated it.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.216");
//         if (PromptDialogue is "That'll show them.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.217");
//         if (PromptDialogue is "A good fight.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.218");
//         if (PromptDialogue is "Easy.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.219");
//         if (PromptDialogue is "No sweat.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.220");
//         if (PromptDialogue is "Wasn't even a problem.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.221");
//         if (PromptDialogue is "We got that taken care of.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.222");
//         if (PromptDialogue is "Good going.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.223");
//         if (PromptDialogue is "That was a little close for comfort..")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.224");
//         if (PromptDialogue is "That's over with, but we're still in trouble.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.225");
//         if (PromptDialogue is "That was close.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.226");
//         if (PromptDialogue is "Finally. It's defeated.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.227");
//         if (PromptDialogue is "You bested it, finally. Good job.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.228");
//         if (PromptDialogue is "What a powerful foe...")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.229");
//         if (PromptDialogue is "Perfect attack!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.230");
//         if (PromptDialogue is "A critical hit!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.231");
//         if (PromptDialogue is "Expertly done.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.232");
//         if (PromptDialogue is "That was great!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.233");
//         if (PromptDialogue is "A decisive blow.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.234");
//         if (PromptDialogue is "Ouch. That looked like it hurt.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.235");
//         if (PromptDialogue is "Are you alright?")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.236");
//         if (PromptDialogue is "That doesn't look good.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.237");
//         if (PromptDialogue is "This could be going better..")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.238");
//         if (PromptDialogue is "Oww..")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.239");
//         if (PromptDialogue is "Yikes.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.240");
//         if (PromptDialogue is "This is.. bad..")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.241");
//         if (PromptDialogue is "That is.. not good.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.242");
//         if (PromptDialogue is "They'll pay for that..")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.243");
//         if (PromptDialogue is "A powerful foe approaches.\nLet's send it back to where it belongs.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.244");
//         if (PromptDialogue is "I can sense powerful energy approaching.\nReady or not, it's time for a fight.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.245");
//         if (PromptDialogue is "A strong opponent draws near.\nPrepare yourself.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.246");
//         if (PromptDialogue == $"{Main.LocalPlayer.name}, stay alert.\nSomething powerful is on its way.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.247");
//         if (PromptDialogue == $"{Main.LocalPlayer.name}, danger approaches.\nWe will show no mercy.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.248");
//         if (PromptDialogue is "Here it comes. Whatever it is, it's dangerous.\nTake extra care when it's weak; it'll be forced into a frenzy.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.249");
//         if (PromptDialogue is "That's a.. giant slime.\nIt seems to be able to move really quickly. Watch for that.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.250");
//         if (PromptDialogue is "This must be the Eater of Worlds.\nIt'll try and suprise you from below.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.251");
//         if (PromptDialogue is "Watch out. It's trying to attack your mind itself.\nPay close attention to the mirages.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.252");
//         if (PromptDialogue is "That giant bee is attacking!\nDon't get caught in the honey!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.253");
//         if (PromptDialogue is "The Clothier has turned into.. this..\nStay away from its skull and arms.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.254");
//         if (PromptDialogue is "This thing is incredibly strong..\nWhatever you do, keep running..!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.255");
//         if (PromptDialogue is "The Eye of Cthulhu is back? Wait, there's two of them..!\nTry and focus one at a time!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.256");
//         if (PromptDialogue is "It's a cyclops... wait.. It has antlers...\nIs it a deer? Is it both..?")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.257");
//         if (PromptDialogue is "Looks to be another type of gigantic slime.\nI have a feeling it'll use minions to do its bidding.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.258");
//         if (PromptDialogue is "Something dangerous stirs in the Hallow...\nIt looks to draw overwhelming power during the daytime!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.259");
//         if (PromptDialogue is "The Destroyer approaches..\nLet's try using area-of-effect attacks against it.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.260");
//         if (PromptDialogue is "Skeletron is back, and better than ever!\nTry prioritizing the appendages first.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.261");
//         if (PromptDialogue is "The menace of the Jungle is attacking..!\nDon't get stuck on your surroundings!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.262");
//         if (PromptDialogue is "The Lizhard's beast is awake!\nMind the Jungle Temple's traps during this fight.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.263");
//         if (PromptDialogue is "You've reeled in a dangerous foe!\nStay near the sea lest it become enraged!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.264");
//         if (PromptDialogue is "It's a Lunatic Cultist..\nYou have to defeat them before they can summon calamity!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.265");
//         if (PromptDialogue is "The Moon Lord.. We come face to face with a god.\nWe have to win this! There's no other option!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.266");
//         if (PromptDialogue is "The Warrior of Light approaches..\nHis Limit Breaks are incredibly strong!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.267");
//         if (PromptDialogue is "Something about this foe seems familiar...\nYour attacks won't work; just try and survive!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.268");
//         if (PromptDialogue is "Don't underestimate this king of eld!\nTake back the lifeforce he's stealing!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.269");
//         if (PromptDialogue is "She's covering you with paint.\nTake careful note of your color!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.270");
//         if (PromptDialogue is "It seems to be able to swap forms!\nTry to memorize its attacks..!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.271");
//         if (PromptDialogue is "Something's tunneling in the sand..!\nTry and get off the ground!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.272");
//         if (PromptDialogue is "A mycelium beast, huh?\nIt's spewing mushrooms everywhere...")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.273");
//         if (PromptDialogue is "The corruption has spewed out a new beast.\nLook out for its barrage of minions.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.274");
//         if (PromptDialogue is "Flesh beasts draw near..!\nFocus your attention on the Hive!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.275");
//         if (PromptDialogue is "This huge amalgamate draws from the world's evils!\nKilling one slime will empower the other!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.276");
//         if (PromptDialogue is "This foe radiates mystic ice.\nStay away from it- those icy spikes are not for show.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.277");
//         if (PromptDialogue is "The Desert Scourge makes a return...\nI knew it- This was what it once was.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.278");
//         if (PromptDialogue is "A colossal serpent makes its way towards us..\nIt may overwhelm you.. don't get reckless.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.279");
//         if (PromptDialogue is "That Charred Idol has summoned a flaming spirit..\nIt can teleport everywhere- don't lose track of it.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.280");
//         if (PromptDialogue is "Calamitas.. With a name like that, it begs respect.\nWe've seen what it can do. You musn't lose this fight.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.281");
//         if (PromptDialogue is "It's Anahita singing again.\nDo you want to fight her once more?")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.282");
//         if (PromptDialogue == $"...Hey, {Main.LocalPlayer.name}. Can you hear that?\nThere's something singing in the ocean...")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.283");
//         if (PromptDialogue is "Ah.. It looks like you've angered her.\nI hope you're prepared for a fight..")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.284");
//         if (PromptDialogue is "What in the world.. It's massive!\nTake caution; the playing field has changed!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.285");
//         if (PromptDialogue is "It's a mechanical beast, but it's been corrupted\nby the Astral Infection. Stay cautious.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.286");
//         if (PromptDialogue is "Ugh. It's a disgusting bug, but now it has artillery.\nWhen it gets wounded, those missiles will likely detonate.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.287");
//         if (PromptDialogue is "Yuck. It's a huge pile of flesh and bones.\nFrom what I can tell, getting too close will end you fast.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.288");
//         if (PromptDialogue is "This is a descendant of a cosmic god!\nWe can't lose to something like this!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.289");
//         if (PromptDialogue is "The Profaned Shard has summoned something!\nPrepare for a fight!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.290");
//         if (PromptDialogue is "Hey, those pheromones..\nLooks like it attracted a feral beast.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.291");
//         if (PromptDialogue is "A deity of light and darkness approaches!.\nWe musn't lose this..!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.292");
//         if (PromptDialogue is "Something just entered the upper atmosphere!\nBrace for impact!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.293");
//         if (PromptDialogue is "Wait. I sense something from the Dungeon's\ndepths. Prepare yourself for a fight!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.294");
//         if (PromptDialogue is "A demon is approaching..! Watch out!\nWhatever it wants, it'll kill you for it!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.295");
//         if (PromptDialogue is "The ghosts of the dungeon.. They're fusing\ntogether! Prepare yourself!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.296");
//         if (PromptDialogue is "Something descends from the acid rain!\nIt's looking for a fight!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.297");
//         if (PromptDialogue is "The Devourer of Gods has appeared!\nYou must give this battle your all!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.298");
//         if (PromptDialogue is "The Jungle Dragon roars.\nLet's throw a wrench in Yharim's plans.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.299");
//         if (PromptDialogue is "Where's it going?\nWere we.. not strong enough?")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.300");
//         if (PromptDialogue == $"No way.. Its power is ineffable.\n{Main.LocalPlayer.name}.. We have to win this!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.301");
//         if (PromptDialogue is "Draedon is here... Be mindful of his tactics.\nHis knowledge spans the world over.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.302");
//         if (PromptDialogue is "Stay sharp. Multiple foes detected.\nDraedon's inventions are on the move.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.303");
//         if (PromptDialogue is "Quick- find higher ground!\nA colossal mechanical serpent draws near!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.304");
//         if (PromptDialogue is "A being of the apocalypse has appeared.\nIt wields destruction in all its appendages!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.305");
//         if (PromptDialogue is "...Never mind the absurdity of the giant mechanical squirrel.\nFocus on attacking its head and arms to stop its most dangerous attacks.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.306");
//         if (PromptDialogue is "Huh? She looks weak, but she's actually kind of powerful...\nIf you get hit, you'll be slammed with debuffs; keep your healing ready.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.307");
//         if (PromptDialogue is "Who does this guy think he is, wielding celestial power all willy-nilly?\nNot to mention... Ugh- I don't have to spell it out, do I?")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.308");
//         if (PromptDialogue is "Well, no time like the present.\nHis arsenal revolves around invader events- we've seen our share of those.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.309");
//         if (PromptDialogue is "Oh, you just HAD to throw that thing into lava, did you?\nWell, good luck, because Mutant is pissed. Didn't see that coming- wait, I did.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.310");
//         if (PromptDialogue is "The Storm Flare has called something down!\nHmm? It looks to be lightning-aspected.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.311");
//         if (PromptDialogue is "Some sort of jellyfish monster is approaching.\nIt looks like there's someone trapped inside..?")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.312");
//         if (PromptDialogue is "It's a giant vampire bat!\nMind yourself...")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.313");
//         if (PromptDialogue is "The cavern's energy has congealed into a monster!\nWhat in the world..?")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.314");
//         if (PromptDialogue is "A knight has arisen from the marble cave!\nLook out- it's prepared to fight!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.315");
//         if (PromptDialogue is "Do you see that..? It looks like a giant\nsnow spider! Let's kill it quickly..")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.316");
//         if (PromptDialogue is "A Beholder..? Don't get reckless..\nThese foes are incredibly fearsome!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.317");
//         if (PromptDialogue is "That sigil you used.. I can sense an undead\nbeast approaching! Get ready for a fight!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.318");
//         if (PromptDialogue is "The Abyssal Shadows are converging..!\nThis sea monster holds dominion over dark magic!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.319");
//         if (PromptDialogue is "Primordial energy is forming all around you..\nThe elements themselves are on the attack!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.320");
//         if (PromptDialogue is "It's a desert. Seriously..\nI'm no fan of heat- and it's hot.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.321");
//         if (PromptDialogue is "This verdant environment must be the Jungle.\nThis place is dangerous, but also rewarding.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.322");
//         if (PromptDialogue is "You're nearing the limit of breathable air.\nI do not recommend burning up in the atmosphere. Don't ask.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.323");
//         if (PromptDialogue is "So this is the place where the dead rest.\nLet's see what we can find.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.324");
//         if (PromptDialogue is "It's the ocean...\nWe can't cross it, so best leave it be.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.325");
//         if (PromptDialogue is "I can feel the evil aura radiating from this place.\nI wouldn't mind leaving as soon as possible.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.326");
//         if (PromptDialogue is "This place is.. disgusting.\nLet's not stay longer than we have to.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.327");
//         if (PromptDialogue is "It's a typical boreal forest.\nNot that I dislike snowy places.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.328");
//         if (PromptDialogue is "We've stepped straight into fairytale land.\nIt would be prettier if everything here wasn't hostile.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.329");
//         if (PromptDialogue is "Giant glowing mushrooms.. It feels rather.. welcoming?\nWe should take some back home, just in case.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.330");
//         if (PromptDialogue is "I can feel traps everywhere.\nStrong weapons are buried here as well. Stay ready.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.331");
//         if (PromptDialogue is "So this is the meteor impact we heard.\nWonder what you can make out of it..?")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.332");
//         if (PromptDialogue is "The Brimstone Crag..\nI can feel the horrors of the past..")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.333");
//         if (PromptDialogue is "This is the Astral Infection.\nA subject I'm all too familiar with...")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.334");
//         if (PromptDialogue is "This place is quite beautiful.\nWho knew it would be under the desert..?")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.335");
//         if (PromptDialogue is "This was once a pleasant coastline.\nWhat happened here..?")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.336");
//         if (PromptDialogue is "You've decided to breach the ocean's depths.\nPlease consider how dangerous this really is..")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.337");
//         if (PromptDialogue is "This cavern seems to be all granite.\nSome rouge spirits have made their home here.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.338");
//         if (PromptDialogue is "So this is a Marble Cavern.\nPerhaps we can use the material to build?")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.339");
//         if (PromptDialogue is "We're very deep in the ocean.\nThese waters are trouble, I can tell that much.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.340");
//         if (PromptDialogue is "It's raining.\nHopefully nothing important gets too wet.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.341");
//         if (PromptDialogue is "Looks like it's a blizzard.\n'Cold' doesn't begin to cover it.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.342");
//         if (PromptDialogue is "A sandstorm has kicked up.\nMind your eyes.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.343");
//         if (PromptDialogue is "Let's try that again, shall we?")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.344");
//         if (PromptDialogue is "Chronal reversal complete..!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.345");
//         if (PromptDialogue is "March forth, and keep fighting!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.346");
//         if (PromptDialogue is "We're not about to stop here!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.347");
//         if (PromptDialogue is "They'll all fall before us.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.348");
//         if (PromptDialogue is "We'll finish them all off!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.349");
//         if (PromptDialogue is "I'm ready when you are.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.350");
//         if (PromptDialogue is "The Stellar Nova is ready!")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.351");
//         if (PromptDialogue is "I'm ready. Are you?")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.352");
//         if (PromptDialogue is "Let's do this.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.353");
//         if (PromptDialogue is "Let's find an opening.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.354");
//         if (PromptDialogue is "Celestial coordinates established.\nWelcome to the Observatory Hyperborea.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.355");
//         if (PromptDialogue is "We've made it.\nThese are asteroids of interest. Let's look around.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.356");
//         if (PromptDialogue is "This is it. An entire planet that's devoid of color?\nThe surface looks like it was wiped away somehow...")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.357");
//         if (PromptDialogue is "She was here the whole time...?\nWell.. I'm ready when you are. Use the Sigil in the middle.")
//             PromptDialogue = LangHelper.GetText("StarsAbove.UI.PromptDialogue.358");
//     }
//
//     public void UnloadContent() { }
// }