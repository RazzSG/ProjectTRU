﻿using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode;

public class InfenumModeCombatText : ContentTranslation, ICombatText
{
    public override bool IsTranslationEnabled => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override float Priority => 1f;
    
    public void CombatTextTranslation()
    {
        for (int i = 0; i < 100; i++)
        {
            if (Main.combatText[i].active)
            {
                Main.combatText[i].text = Main.combatText[i].text switch
                {
                    "You can weave through the clefs if you manipulate her movement well!" => LangHelper.GetText("InfernumMode.CombatTexts.1"),
                    "The meteors all split in the same way; use this to your advantage!" => LangHelper.GetText("InfernumMode.CombatTexts.2"),
                    "The Exo-Twins are magnificently in-sync, try finding a rythem to outsmart them!" => LangHelper.GetText("InfernumMode.CombatTexts.3"),
                    "If you can't handle dodging at high speeds, try baiting it into circling you!" => LangHelper.GetText("InfernumMode.CombatTexts.4"),
                    "Best to keep close during these Exo Overload attacks, otherwise you may have trouble keeping up with the spin!" => LangHelper.GetText("InfernumMode.CombatTexts.5"),
                    "Ares' has one hell of a supercomputer, those arms are super predictive! Maybe you can use that to your advantage?" => LangHelper.GetText("InfernumMode.CombatTexts.6"),
                    "Stay somewhat close, otherwise you may be caught off guard!" => LangHelper.GetText("InfernumMode.CombatTexts.7"),
                    "That serpent is really fast! Good mobility will be important to defeat it!" => LangHelper.GetText("InfernumMode.CombatTexts.8"),
                    "Stay away from those energy fields! Being too close to them will hurt you!" => LangHelper.GetText("InfernumMode.CombatTexts.9"),
                    "Going in a tight circular pattern helps with the attacker guardian's spears!" => LangHelper.GetText("InfernumMode.CombatTexts.10"),
                    "The Brain of Cthulhu uses a lot of prediction and deception in its attacks, so play extra smart!" => LangHelper.GetText("InfernumMode.CombatTexts.11"),
                    "The Brain is going to try to decieve you with various mind games, keep your eyes on the real one!" => LangHelper.GetText("InfernumMode.CombatTexts.12"),
                    "Try not to move too much at the start of the battle. Finding a good spot and staying near it helps a lot!" => LangHelper.GetText("InfernumMode.CombatTexts.13"),
                    "Most of the Void's attacks require fast maneuvering to evade. Be sure to pay attention to any projectiles on-screen!" => LangHelper.GetText("InfernumMode.CombatTexts.14"),
                    "Crabulon will only launch spores every 3rd jump, better keep count!" => LangHelper.GetText("InfernumMode.CombatTexts.15"),
                    "Try focusing on those Crab Shrooms. They'll overwhelm you if you leave them alone!" => LangHelper.GetText("InfernumMode.CombatTexts.16"),
                    "There isnt Mushroom for the three of us, and I can tell who won the roullete." => LangHelper.GetText("InfernumMode.CombatTexts.17"),
                    "Move as little as possible while it's above you. That should calm down its spastic jittering!" => LangHelper.GetText("InfernumMode.CombatTexts.18"),
                    "Watch for the gaps in the icicles around Cryogen, they're a great indicator of where a safe spot is!" => LangHelper.GetText("InfernumMode.CombatTexts.19"),
                    "That guy was quite a lunatic, You might want extra mobility!" => LangHelper.GetText("InfernumMode.CombatTexts.20"),
                    "Deerclops' are Myopic, so they will force you to stay close, dont let them corner you!" => LangHelper.GetText("InfernumMode.CombatTexts.21"),
                    "The Deerclops will follow a set pattern, learn it to gain the upper hand!" => LangHelper.GetText("InfernumMode.CombatTexts.22"),
                    "Deer god..." => LangHelper.GetText("InfernumMode.CombatTexts.23"),
                    "The Scourge usually roars when it's about to whip up a sandstorm, get to high grounds!" => LangHelper.GetText("InfernumMode.CombatTexts.24"),
                    "A Hook may prove useful to quickly get out of the Scourge's mandibles!" => LangHelper.GetText("InfernumMode.CombatTexts.25"),
                    "I loath sand, its grainy and itchy and sticks to every part of my feet." => LangHelper.GetText("InfernumMode.CombatTexts.26"),
                    "You better have dessert for me after this..." => LangHelper.GetText("InfernumMode.CombatTexts.27"),
                    "The more you hurt it, the more probes it will spawn. Don't bite off more than you can chew!" => LangHelper.GetText("InfernumMode.CombatTexts.28"),
                    "A dashing accessory would be reeaaaally helpful here..." => LangHelper.GetText("InfernumMode.CombatTexts.29"),
                    "Being able to face it head on with a ram sounds like a good idea, don't you think?" => LangHelper.GetText("InfernumMode.CombatTexts.30"),
                    "The fight against the Dragonfolly is very chaotic and fast paced. Good mobility and reaction time help a lot!" => LangHelper.GetText("InfernumMode.CombatTexts.31"),
                    "Those large red lightning pillars can be negated by flying below them!" => LangHelper.GetText("InfernumMode.CombatTexts.32"),
                    "Many layered platforms can help greatly to avoid the exploding Cursed Flames!" => LangHelper.GetText("InfernumMode.CombatTexts.33"),
                    "A dash and a hook can greatly help with reacting to the Eaters bursts of speed!" => LangHelper.GetText("InfernumMode.CombatTexts.34"),
                    "I guess it eats more than just worlds." => LangHelper.GetText("InfernumMode.CombatTexts.35"),
                    "Watch out for those teeth bombs! The teeth spew away from the bomb's landing, try staying close!" => LangHelper.GetText("InfernumMode.CombatTexts.36"),
                    "Investing in a hook or high mobility could prove great to dodge the Eye of Cthulhu's Charges!" => LangHelper.GetText("InfernumMode.CombatTexts.37"),
                    "Eye can't believe you died to that." => LangHelper.GetText("InfernumMode.CombatTexts.38"),
                    "Golem's eye color will change depending on it's attack. Keep your own eyes peeled!" => LangHelper.GetText("InfernumMode.CombatTexts.39"),
                    "This is the time you would want to learn the opponents moves, use their tells to get the upper hand!" => LangHelper.GetText("InfernumMode.CombatTexts.40"),
                    "Try to push his Rain Charge away by running towards the Hive Mind, this can help keep your arena clean!" => LangHelper.GetText("InfernumMode.CombatTexts.41"),
                    "The Hive Mind begins its next attack early if you attack it; wait until it's on cooldown before you shoot!" => LangHelper.GetText("InfernumMode.CombatTexts.42"),
                    "That didn't work, but dont worry! Hive got a plan!" => LangHelper.GetText("InfernumMode.CombatTexts.43"),
                    "I would make a snarky comment right now, but I probably should Mind my own business..." => LangHelper.GetText("InfernumMode.CombatTexts.44"),
                    "Try to learn King Slime's jump pattern! It could help you plan your next move better." => LangHelper.GetText("InfernumMode.CombatTexts.45"),
                    "With a jump that high, I wonder if you could duck beneath him?" => LangHelper.GetText("InfernumMode.CombatTexts.46"),
                    "Quite a sticky situation you had to deal with..." => LangHelper.GetText("InfernumMode.CombatTexts.47"),
                    "Those eyeballs perform attacks that require a lot of weaving! Make sure to not panic when they happen!" => LangHelper.GetText("InfernumMode.CombatTexts.48"),
                    "Squib emoji" => LangHelper.GetText("InfernumMode.CombatTexts.49"),
                    "Be sure to remember if any sharkrons or tooth balls appear, so that their remains don't surprise you later!" => LangHelper.GetText("InfernumMode.CombatTexts.50"),
                    "Movement speed is gonna matter a lot against that fish!" => LangHelper.GetText("InfernumMode.CombatTexts.51"),
                    "Try to keep a counter in the last phase. The Old Duke will teleport, charge seven times, and then repeat." => LangHelper.GetText("InfernumMode.CombatTexts.52"),
                    "Are you really sure you don't want to use a dash for that fish?" => LangHelper.GetText("InfernumMode.CombatTexts.53"),
                    "A dashing accessory would be reeaaally helpful here..." => LangHelper.GetText("InfernumMode.CombatTexts.54"),
                    "Perhaps a long platform or two could help avoid some of the attacks?" => LangHelper.GetText("InfernumMode.CombatTexts.55"),
                    "The Hive spews out a ton of lingering ichor, so space management is key!" => LangHelper.GetText("InfernumMode.CombatTexts.56"),
                    "A dash of sorts helps a lot with the spinning ring attack, since it lets you quickly reach the opening!" => LangHelper.GetText("InfernumMode.CombatTexts.57"),
                    "If one of the Polterghast's legs turn red, quickly back away; it's going to swipe at you and release accelerating projectiles!" => LangHelper.GetText("InfernumMode.CombatTexts.58"),
                    "Don't worry about hooking to the walls or anything like that. Providence provides you with unlimited flight time!" => LangHelper.GetText("InfernumMode.CombatTexts.59"),
                    "Those Honey Shots sure are bouncy, don't move too fast else they will splatter everywhere!" => LangHelper.GetText("InfernumMode.CombatTexts.60"),
                    "Getting rid of those extra hornets should be your top priority!" => LangHelper.GetText("InfernumMode.CombatTexts.61"),
                    "I can't Bee-lieve that, totally uncalled for!" => LangHelper.GetText("InfernumMode.CombatTexts.62"),
                    "Oof, that mustve Stung..." => LangHelper.GetText("InfernumMode.CombatTexts.63"),
                    "Keep your feet working! This gelatinous queen will stop at nothing to crush her foes!" => LangHelper.GetText("InfernumMode.CombatTexts.64"),
                    "Short hops may help better than trying to fly away from all the crystal shrapnel!" => LangHelper.GetText("InfernumMode.CombatTexts.65"),
                    "Some of Ravager's attacks reward you for staying close. Try not to run away!" => LangHelper.GetText("InfernumMode.CombatTexts.66"),
                    "Contrary to what you may think, running into the shadowflame walls will not work, take it slow!" => LangHelper.GetText("InfernumMode.CombatTexts.67"),
                    "Don't panic when Skeletron does his barrages of hand fireballs! Just jump and stay calm!" => LangHelper.GetText("InfernumMode.CombatTexts.68"),
                    "Geeettttttt DUNKED ON!!!" => LangHelper.GetText("InfernumMode.CombatTexts.69"),
                    "They dont seem very intelligent, maybe you could trick them to jump higher if you do aswell?" => LangHelper.GetText("InfernumMode.CombatTexts.70"),
                    "Dont let all the projectiles intimidate you, be very cautious with your movement!" => LangHelper.GetText("InfernumMode.CombatTexts.71"),
                    "Having trouble dodging during the spin? Three can play at that game, Spin!" => LangHelper.GetText("InfernumMode.CombatTexts.72"),
                    "Try to not move too far away when the Weaver spins in place, so you can see the bolts before they accelerate too much!" => LangHelper.GetText("InfernumMode.CombatTexts.73"),
                    "Do you want my Witch's hat? Matching her atire could be fun..." => LangHelper.GetText("InfernumMode.CombatTexts.74"),
                    "Oh my, so many lasers... better keep on the move!" => LangHelper.GetText("InfernumMode.CombatTexts.75"),
                    "Be sure to run the opposite direction!" => LangHelper.GetText("InfernumMode.CombatTexts.76"),
                    "AND IF I SHOULD DIE BEFORE YOU CONTINUEE, YOU SHALL HAV-... Wait, you died? Come on, I was on a roll here!" => LangHelper.GetText("InfernumMode.CombatTexts.77"),
                    "It seems as if it is manipulating telelocational magic, your Rod of Discord is of no use here!" => LangHelper.GetText("InfernumMode.CombatTexts.78"),
                    "Home stretch! Do the same as you did before!" => LangHelper.GetText("InfernumMode.CombatTexts.79"),
                    "The Scourge will stop at nothing to snack on you! Stay on the move!" => LangHelper.GetText("InfernumMode.CombatTexts.80"),
                    "Those meteorites fall ahead of you. Try baiting them for a little more breathing room!" => LangHelper.GetText("InfernumMode.CombatTexts.81"),
                    "That thing seems to have shed its outer shell. Brace yourself, it's going to be a lot faster now!" => LangHelper.GetText("InfernumMode.CombatTexts.82"),
                    "Don't forget about that rubble! It will rain down from above!" => LangHelper.GetText("InfernumMode.CombatTexts.83"),
                    "Don't panic while trying to evade the bolts!" => LangHelper.GetText("InfernumMode.CombatTexts.84"),
                    "Stay near the center of your arena if you can. Those thorns are really good at cornering you!" => LangHelper.GetText("InfernumMode.CombatTexts.85"),
                    "The beam predicts your position, try baiting it into shooting away from you!" => LangHelper.GetText("InfernumMode.CombatTexts.86"),
                    "It seems like she's going to give it all she has! Brace yourself!" => LangHelper.GetText("InfernumMode.CombatTexts.87"),
                    "Try and move as precisely as possible here; you don't want to waste arena space!" => LangHelper.GetText("InfernumMode.CombatTexts.88"),
                    "This is the Void's last stand! Try not to get sucked in, and weave through the energy bolts!" => LangHelper.GetText("InfernumMode.CombatTexts.89"),
                    "Lightning is going to aim ahead of you! Try to bait it!" => LangHelper.GetText("InfernumMode.CombatTexts.90"),
                    "Try to get between those lines, before the ice barrages explode!" => LangHelper.GetText("InfernumMode.CombatTexts.91"),
                    "Prepare for it's final stand! Watch for red laser telegraphs and prepare to dash to safety!" => LangHelper.GetText("InfernumMode.CombatTexts.92"),
                    "Don't feel intimidated, face fear in the eyes and dash directly into the Devourer's maw!" => LangHelper.GetText("InfernumMode.CombatTexts.93"),
                    "Oh man, theres so many lasers! Slow and precise movements seem like your best bet here..." => LangHelper.GetText("InfernumMode.CombatTexts.94"),
                    "If a certain starting combo isnt working too well, maybe experiment with another one?" => LangHelper.GetText("InfernumMode.CombatTexts.95"),
                    "Better choose well!" => LangHelper.GetText("InfernumMode.CombatTexts.96"),
                    "Static bolts seem to be flying towards you! Be wary of them, and don't get trapped by the lightning telegraphs!" => LangHelper.GetText("InfernumMode.CombatTexts.97"),
                    "Keep track of where the long charge stops! You might get swept up by a tidal wave!" => LangHelper.GetText("InfernumMode.CombatTexts.98"),
                    "Try your best to weave through the razorblades and brace youself!" => LangHelper.GetText("InfernumMode.CombatTexts.99"),
                    "Seems like they are combining efforts, beware!" => LangHelper.GetText("InfernumMode.CombatTexts.100"),
                    "You're gonna have a bad time..." => LangHelper.GetText("InfernumMode.CombatTexts.101"),
                    "It's still going?!" => LangHelper.GetText("InfernumMode.CombatTexts.102"),
                    "The ninja shoots more shurikens the farther you are, so don't go too far!" => LangHelper.GetText("InfernumMode.CombatTexts.103"),
                    "Home stretch! try focusing on yourself more than the boss!" => LangHelper.GetText("InfernumMode.CombatTexts.104"),
                    "They're working together now! Anahita will take the advantage to hurl homing icicles at you!" => LangHelper.GetText("InfernumMode.CombatTexts.105"),
                    "The Moon Lord seems angry! Try to dodge the side projectiles, and don't touch that black hole!" => LangHelper.GetText("InfernumMode.CombatTexts.106"),
                    "Brace yourself! A barrage of slow bolts are going to be released!" => LangHelper.GetText("InfernumMode.CombatTexts.107"),
                    "Staying calm and still will help dodge the slow projectiles!" => LangHelper.GetText("InfernumMode.CombatTexts.108"),
                    "Those drones are building a jail around you, destroying one will give you an opening!" => LangHelper.GetText("InfernumMode.CombatTexts.109"),
                    "Destroy those builder drones before the whole jungle goes kablooey!" => LangHelper.GetText("InfernumMode.CombatTexts.110"),
                    "Plantera isn't keeping anything back, watch out!" => LangHelper.GetText("InfernumMode.CombatTexts.111"),
                    "Manage those clouds carefully. You'll need to weave through them to find the gap in her tentacles!" => LangHelper.GetText("InfernumMode.CombatTexts.112"),
                    "Polterghast's spirits have been released! But they don't seem very happy with us..." => LangHelper.GetText("InfernumMode.CombatTexts.113"),
                    "Those blue tesla mines are going to explode into gas; take cover!" => LangHelper.GetText("InfernumMode.CombatTexts.114"),
                    "Pay attention to where you move. Try to stay in one spot so that those bombs aren't all over the arena!" => LangHelper.GetText("InfernumMode.CombatTexts.115"),
                    "Don't move around too quickly! Small but quick horizontal movements are important for evading those crystals!" => LangHelper.GetText("InfernumMode.CombatTexts.116"),
                    "Pay attention to where you move. You don't want Providence to fire her lasers when near a wall!" => LangHelper.GetText("InfernumMode.CombatTexts.117"),
                    "Watch out, he might try to trick you at the end!" => LangHelper.GetText("InfernumMode.CombatTexts.118"),
                    "Those bombs will explode into kunai that fly towards you. Be careful!" => LangHelper.GetText("InfernumMode.CombatTexts.119"),
                    "The Weaver has shed its exterior. It will now move far faster!" => LangHelper.GetText("InfernumMode.CombatTexts.120"),
                    "The Weaver seems to be creating a bunch of clouds above you! Try to weave through the resulting bolts as they fall!" => LangHelper.GetText("InfernumMode.CombatTexts.121"),
                    "So many skulls, but it appears they aren't focused directly at you! Try going inbetween!" => LangHelper.GetText("InfernumMode.CombatTexts.122"),
                    "Calamitas' is laying exploding brimstone magic with every charge, try to direct them away from a safe location!" => LangHelper.GetText("InfernumMode.CombatTexts.123"),
                    "Dont feel overwhelmed by all the projectiles, keep your cool during this flaming match!" => LangHelper.GetText("InfernumMode.CombatTexts.124"),
                    "Even when all hell breaks loose, stay focused on your dodging!" => LangHelper.GetText("InfernumMode.CombatTexts.125"),
                    "Don't fret, face fear in the eyes and dash directly into Thanatos' face-plates!" => LangHelper.GetText("InfernumMode.CombatTexts.126"),
                    "Watch out, that last twin is gonna hit you with everything it's got! Don't let up!" => LangHelper.GetText("InfernumMode.CombatTexts.127"),
                    "Better stay near the edges of the arena during those carpet bomb flames, That should keep them out of the way!" => LangHelper.GetText("InfernumMode.CombatTexts.128"),
                    "This speed is crazy! Make sure you know when it starts; you might get jumpscared!" => LangHelper.GetText("InfernumMode.CombatTexts.129"),
                    "Don't let the flashbang faze you! Keep your eyes peeled for where the embers are!" => LangHelper.GetText("InfernumMode.CombatTexts.130"),
                    "Yharon's burning some serious energy now! Stay focused!" => LangHelper.GetText("InfernumMode.CombatTexts.131"),
                    _ => Main.combatText[i].text
                };
            }
        }
    }
}