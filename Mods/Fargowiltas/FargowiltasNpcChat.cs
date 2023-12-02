using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Fargowiltas.NPCs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas;

public class FargowiltasNpcChat : GlobalNPC
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.Fargowiltas != null && TranslationHelper.IsRussianLanguage;
    }

    public override void GetChat(NPC npc, ref string chat)
    {
        string GetNPCName(int type) => Main.npc[NPC.FindFirstNPC(type)].GivenName;
        
        if (npc.type == ModContent.NPCType<Abominationn>())
        {
            chat = chat switch
            {
                "Where'd I get my scythe from? Ask me later." => TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.1").ToString(),
                "Where'd I get my scythe from? You'll figure it out." => TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.2").ToString(),
                "I have defeated everything in this land... nothing can beat me." => TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.3").ToString(),
                "Have you ever had a weapon stuck to your hand? It's not very handy." => TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.4").ToString(),
                "What happened to Yoramur? No idea who you're talking about." => TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.5").ToString(),
                "You wish you could dress like me? Ha! Actually yea.. you can." => TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.6").ToString(),
                "You ever read the ancient classics, I love all the fighting in them." => TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.7").ToString(),
                "I'm a world class poet, ever read my piece about impending doom?" => TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.8").ToString(),
                "You want swarm summons? Maybe next year." => TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.9").ToString(),
                "Like my wings? Thanks, the thing I got them from didn't like it much." => TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.10").ToString(),
                "Heroism has no place in this world, instead let's just play ping pong." => TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.11").ToString(),
                "Why are you looking at me like that? Your fashion sense isn't going to be winning you any awards either." => TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.12").ToString(),
                "No, you can't have my hat." => TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.13").ToString(),
                "Embrace suffering... Wait what do you mean that's already taken?" => TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.14").ToString(),
                "Your attempt to exploit my anger is admirable, but I cannot be angered." => TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.15").ToString(),
                "Is it really a crime if everyone else does it." => TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.16").ToString(),
                "Inflicting suffering upon others is the most amusing thing there is." => TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.17").ToString(),
                "Irony is the best kind of humor, isn't that ironic?" => TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.18").ToString(),
                "I like Cat... What do you mean who's Cat?" => TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.19").ToString(),
                "Check the wiki if you need anything, the kirb is slowly getting it up to par." => TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.20").ToString(),
                "I've heard tales of a legendary Diver... Anyway what was that about a giant jellyfish?" => TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.21").ToString(),
                "Overloaded events...? Yeah, they're pretty cool." => TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.22").ToString(),
                "It's not like I don't enjoy your company, but can you buy something?" => TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.23").ToString(),
                "I have slain one thousand humans! Huh? You're a human? There's so much blood on your hands.." => TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.24").ToString(),
                "You really defeated me... not bad. Now do it again without getting hit. Oh, and Copper Shortsword only." => TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.29").ToString(),
                "I hope all these graves lying around don't belong to you." => TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.30").ToString(),
                "What nostalgic armor you're wearing... No, it doesn't fit on me anymore. And its battery takes too long to charge." => TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.32").ToString(),
                _ => chat
            };
        
            if (NPC.AnyNPCs(NPCID.Mechanic))
            {
                if (chat == $"Can you please ask {GetNPCName(NPCID.Mechanic)} to stop touching my laser arm please.")
                {
                    chat = TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.27").WithFormatArgs(GetNPCName(NPCID.Mechanic)).ToString();
                }
            }

            if (NPC.AnyNPCs(ModContent.NPCType<Mutant>()))
            {
                if (chat == "He turned into a squirrel. Funniest thing I've ever seen.")
                {
                    chat = TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.25").ToString();
                }
            }
        }

        if (npc.type == ModContent.NPCType<Mutant>())
        {
            chat = chat switch
            {
                "Savagery, barbarism, bloodthirst, that's what I like seeing in people." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.1").ToString(),
                "The stronger you get, the more stuff I sell. Makes sense, right?" => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.2").ToString(),
                "There's something all of you have that I don't... Death perception, I think it's called?" => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.3").ToString(),
                "It would be pretty cool if I sold a summon for myself..." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.4").ToString(),
                "The only way to get stronger is to keep buying from me and in bulk too!" => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.5").ToString(),
                "Why are you looking at me like that, all I did was eat an apple." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.6").ToString(),
                "Don't bother with anyone else, all you'll ever need is right here." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.7").ToString(),
                "You're lucky I'm on your side." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.8").ToString(),
                "Thanks for the house, I guess." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.9").ToString(),
                "Why yes I would love a ham and swiss sandwich." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.10").ToString(),
                "Should I start wearing clothes? ...Nah." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.11").ToString(),
                "It's not like I can actually use all the gold you're spending." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.12").ToString(),
                "Violence for violence is the law of the beast." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.13").ToString(),
                "Those guys really need to get more creative. All of their first bosses are desert themed!" => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.14").ToString(),
                "You say you want to know how a Mutant and Abominationn are brothers? You're better off not knowing." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.15").ToString(),
                "I'm all you need for a calamity." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.16").ToString(),
                "Everything shall bow before me! ...after you make this purchase." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.17").ToString(),
                "It's clear that I'm helping you out, but uh.. what's in this for me? A house you say? I eat zombies for breakfast." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.18").ToString(),
                "Can I jump? No, I don't have something called a 'spacebar'." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.19").ToString(),
                "Got your nose, I needed one to replace mine." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.20").ToString(),
                "What's a Terry?" => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.21").ToString(),
                "Why do so many creatures carry around a weird looking blue doll? The world may never know." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.22").ToString(),
                "Impending doom approaches. ...If you don't buy anything of course." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.23").ToString(),
                "I've heard of a '3rd dimension', I wonder what that looks like." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.24").ToString(),
                "Boy don't I look fabulous today." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.25").ToString(),
                "You have fewer friends than I do eyes." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.26").ToString(),
                "The ocean is a dangerous place, I wonder where Diver is?" => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.27").ToString(),
                "Do you know what an Ee-arth is?" => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.28").ToString(),
                "I can't even spell 'apotheosis', do you expect me to know what it is?" => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.29").ToString(),
                "Where do monsters get their gold from? ...I don't have pockets you know." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.30").ToString(),
                "Dogs are cool and all, but cats don't try to bite my brain." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.31").ToString(),
                "Beware the green dragon... What's that face mean?" => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.32").ToString(),
                "Where is this O-hi-o I keep hearing about." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.33").ToString(),
                "I've told you 56 times already, I'm busy... Oh wait you want to buy something, I suppose I have time." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.34").ToString(),
                "I've heard of a 'Soul of Souls' that only exists in 2015." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.35").ToString(),
                "Adding EX after everything makes it way more difficult." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.36").ToString(),
                "I think that all modern art looks great, especially the bloody stuff." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.37").ToString(),
                "How many guides does it take to change a lightbulb? ... I don't know, how about you ask him." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.38").ToString(),
                "Good thing I don't have a bed, I'd probably never leave it." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.39").ToString(),
                "What's this about an update? Sounds rare." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.40").ToString(),
                "If you need me I'll be slacking off somewhere." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.41").ToString(),
                "What do you mean who is Fargo!" => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.42").ToString(),
                "Have you seen the ech cat?" => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.43").ToString(),
                "I don't understand music nowadays, I prefer some smooth jazz... or the dying screams of monsters." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.44").ToString(),
                "Cthulhu's got nothing on me!" => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.45").ToString(),
                "Now that you've defeated the big guy, I'd say it's time to start collecting those materials!" => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.46").ToString(),
                "What's that? You want to fight me? ...sure, I guess." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.47").ToString(),
                "What's that? You want to fight me? ...maybe if I had a reason." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.48").ToString(),
                "What's that? You want to fight me? ...you're not worthy you rat." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.49").ToString(),
                "Why would you do this." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.50").ToString(),
                "I feel a great imbalance in this world." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.51").ToString(),
                "A great choice, shame about that first desert boss thing though." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.52").ToString(),
                "A bit spooky tonight, isn't it." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.53").ToString(),
                "I'd ask for a coat, but I don't think you have any my size." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.54").ToString(),
                "Weather seems odd today, wouldn't you agree?" => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.55").ToString(),
                "Lovely night, isn't it?" => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.56").ToString(),
                "I hope the constant arguing I'm hearing isn't my fault." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.57").ToString(),
                "I'd follow and help, but I'd much rather sit around right now." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.58").ToString(),
                "I don't know what everyone's so happy about, but as long as nobody mistakes me for a Pigronata, I'm happy too." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.59").ToString(),
                "Congratulations. You truly embraced eternity... at least, I think you did? So what happens next? Ascend from this plane of existence? Fight a transcendant cat-like entity? Destroy the world? All the power's in your hands now." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.74").ToString(),
                "Good work beating me, I guess. I still feel like stretching my wings... Why don't we go at it for real next time?" => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.75").ToString(),
                "I heard of a rumor of infinite use boss summons. Makes me sick.." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.76").ToString(),
                "Nice armor you have, very realistic skin. As a matter of fact, mind if I borrow it? Your skin, that is." => TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.77").ToString(),
                _ => chat
            };
            
            if (NPC.AnyNPCs(NPCID.PartyGirl))
            {
                if (chat == $"{GetNPCName(NPCID.PartyGirl)} is the one who invited me, I don't understand why though.")
                {
                    chat = TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.60").WithFormatArgs(GetNPCName(NPCID.PartyGirl)).ToString();
                }
            }

            if (NPC.AnyNPCs(NPCID.Nurse))
            {
                if (chat == $"Whenever we're alone, {GetNPCName(NPCID.Nurse)} keeps throwing syringes at me, no matter how many times I tell her to stop!")
                {
                    chat = TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.62").WithFormatArgs(GetNPCName(NPCID.Nurse)).ToString();
                }
            }

            if (NPC.AnyNPCs(NPCID.WitchDoctor))
            {
                if (chat == $"Please go tell {GetNPCName(NPCID.WitchDoctor)} to drop the 'mystical' shtick, I mean, come on! I get it, you make tainted water or something.")
                {
                    chat = TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.63").WithFormatArgs(GetNPCName(NPCID.WitchDoctor)).ToString();
                }
            }

            if (NPC.AnyNPCs(NPCID.Dryad))
            {
                if (chat == $"Why does {GetNPCName(NPCID.Dryad)}'s outfit make my wings flutter?")
                {
                    chat = TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.64").WithFormatArgs(GetNPCName(NPCID.Dryad)).ToString();
                }
            }

            if (NPC.AnyNPCs(NPCID.Stylist))
            {
                if (chat == $"{GetNPCName(NPCID.Stylist)} once gave me a wig... I look hideous with long hair.")
                {
                    chat = TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.65").WithFormatArgs(GetNPCName(NPCID.Stylist)).ToString();
                }
            }

            if (NPC.AnyNPCs(NPCID.Truffle))
            {
                if (chat == "That mutated mushroom seems like my type of fella.")
                {
                    chat = TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.66").ToString();
                }
            }

            if (NPC.AnyNPCs(NPCID.TaxCollector))
            {
                if (chat == $"{GetNPCName(NPCID.TaxCollector)} keeps asking me for money, but he won't accept my spawners!")
                {
                    chat = TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.67").WithFormatArgs(GetNPCName(NPCID.TaxCollector)).ToString();
                }
            }

            if (NPC.AnyNPCs(NPCID.Guide) && chat == $"Any idea why {GetNPCName(NPCID.Guide)} is always cowering in fear when I get near him?")
            {
                chat = TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.68")
                    .WithFormatArgs(GetNPCName(NPCID.Guide)).ToString();
            }

            if (NPC.AnyNPCs(NPCID.Truffle) && NPC.AnyNPCs(NPCID.WitchDoctor) && NPC.AnyNPCs(NPCID.Cyborg))
            {
                if (chat == $"If any of us could play instruments, I'd totally start a band with {GetNPCName(NPCID.WitchDoctor)}, {GetNPCName(NPCID.Truffle)}, and {GetNPCName(NPCID.Cyborg)}.")
                {
                    chat = TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.69").WithFormatArgs(GetNPCName(NPCID.WitchDoctor), GetNPCName(NPCID.Truffle), GetNPCName(NPCID.Cyborg)).ToString();
                }
            }

            if (NPC.AnyNPCs(NPCID.PartyGirl))
            {
                if (chat == $"Man, {GetNPCName(NPCID.PartyGirl)}'s confetti keeps getting stuck to my wings")
                {
                    chat = TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.70").WithFormatArgs(GetNPCName(NPCID.PartyGirl)).ToString();
                }
            }

            if (NPC.AnyNPCs(NPCID.Demolitionist))
            {
                if (chat == $"I'm surprised {GetNPCName(NPCID.Demolitionist)} hasn't blown a hole in the floor yet, on second thought that sounds fun.")
                {
                    chat = TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.71").WithFormatArgs(GetNPCName(NPCID.Demolitionist)).ToString();
                }
            }

            if (NPC.AnyNPCs(NPCID.DD2Bartender))
            {
                if (chat == $"{GetNPCName(NPCID.DD2Bartender)} keeps suggesting I drink some beer, something tells me he wouldn't like me when I'm drunk though.")
                {
                    chat = TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.72").WithFormatArgs(GetNPCName(NPCID.DD2Bartender)).ToString();
                }
            }

            if (NPC.AnyNPCs(NPCID.DyeTrader))
            {
                if (chat == $"{GetNPCName(NPCID.DyeTrader)} wants to see what I would look like in blue... I don't know how to feel.")
                {
                    chat = TranslationHelper.GetText("Fargowiltas.NPCs.Mutant.Dialogues.73").WithFormatArgs(GetNPCName(NPCID.DyeTrader)).ToString();
                }
            }
            CalamityRuTranslate.Instance.Logger.Info(chat);
        }

        if (npc.type == ModContent.NPCType<Squirrel>())
        {
            chat = chat switch
            {
                "[c/FF0000:You will suffer.]" => TranslationHelper.GetText("Fargowiltas.NPCs.Squirrel.Dialogues.1").ToString(),
                "*squeak*" => TranslationHelper.GetText("Fargowiltas.NPCs.Squirrel.Dialogues.2").ToString(),
                "*chitter*" => TranslationHelper.GetText("Fargowiltas.NPCs.Squirrel.Dialogues.3").ToString(),
                "*crunch crunch*" => TranslationHelper.GetText("Fargowiltas.NPCs.Squirrel.Dialogues.4").ToString(),
                _ => chat
            };
        }
        
        if (npc.type == ModContent.NPCType<LumberJack>())
        {
            chat = chat switch
            {
                "Dynasty wood? Between you and me, that stuff ain't real wood!" => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.1").ToString(),
                "Sure cactus isn't wood, but I can still chop it with me trusty axe." => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.2").ToString(),
                "You wouldn't by chance have any fantasies about me... right?" => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.3").ToString(),
                "I eat a bowl of woodchips for breakfast... without any milk." => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.4").ToString(),
                "TIIIIIIIIIMMMBEEEEEEEERRR!" => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.5").ToString(),
                "I'm a lumberjack and I'm okay, I sleep all night and I work all day!" => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.6").ToString(),
                "You won't ever need an axe again with me around." => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.7").ToString(),
                "I have heard of people cutting trees with fish, who does that?" => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.8").ToString(),
                "You wanna see me work without my shirt on? Maybe in 2030." => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.9").ToString(),
                "You ever seen the world tree?" => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.10").ToString(),
                "You want what? ...Sorry that's not the kind of wood I'm selling." => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.11").ToString(),
                "Why don't I sell acorns? ...I replant all the trees I chop, don't you?" => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.12").ToString(),
                "What's the best kind of tree? ... Any if I can chop it." => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.13").ToString(),
                "Can I axe you a question?" => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.14").ToString(),
                "Might take a nap under a tree later, care to join me?" => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.15").ToString(),
                "I'm an expert in all wood types." => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.16").ToString(),
                "I'm glad there's more trees to chop here at journey's end." => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.17").ToString(),
                "Red is one of my favourite colors, right after wood." => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.18").ToString(),
                "It's always flannel season." => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.19").ToString(),
                "I'm glad my wood put such a big smile on your face." => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.20").ToString(),
                "Lucy from that universe.. Interesting things await you." => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.36").ToString(),
                _ => chat
            };
            
            if (NPC.AnyNPCs(NPCID.Nurse))
            {
                if (chat == $"I always see {GetNPCName(NPCID.Nurse)} looking at my biceps when I'm working. Wonder if she wants some of my wood.")
                {
                    chat = TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.34").WithFormatArgs(GetNPCName(NPCID.Nurse)).ToString();
                }
            }
        }
        
        if (npc.type == ModContent.NPCType<Deviantt>())
        {
            chat = chat switch
            {
                "The blood moon's effects? I'm not human anymore, so nope!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.1").ToString(),
                "Did you know? The only real music genres are death metal and artcore." => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.2").ToString(),
                "I'll have you know I'm over a hundred Fargo years old! Don't ask me how long a Fargo year is." => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.3").ToString(),
                "I might be able to afford a taller body if you keep buying!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.4").ToString(),
                "Where's that screm cat?" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.5").ToString(),
                "You're the Terrarian? Honestly, I was expecting someone a little... taller." => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.6").ToString(),
                "Don't look at me like that! The only thing I've deviated from is my humanity." => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.7").ToString(),
                "Rip and tear and buy from me for more things to rip and tear!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.8").ToString(),
                "What's a chee-bee doe-goe?" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.9").ToString(),
                "Wait a second. Are you sure this house isn't what they call 'prison?'" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.10").ToString(),
                "Deviantt has awoken! Quick, give her all your money to defeat her!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.11").ToString(),
                "One day, I'll sell a summon for myself! ...Just kidding." => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.12").ToString(),
                "Hmm, I can tell! You've killed a lot, but you haven't killed enough!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.13").ToString(),
                "Why the extra letter, you ask? Only the strongest sibling is allowed to remove their own!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.14").ToString(),
                "The more rare things you kill, the more stuff I sell! Simple, right?" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.15").ToString(),
                "Embrace suffering... and while you're at it, embrace another purchase!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.16").ToString(),
                "This world looks tougher than usual, so you can have these on the house just this once! Talk to me if you need any tips, yeah?" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.17").ToString(),
                "Wow, you smell rancid. When's the last time you took a shower, stinky?" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.18").ToString(),
                "Oh, hi! I, uh, definitely don't have any Stink Potions on me right now! Not that I normally would!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.19").ToString(),
                "No, I'm totally not throwing Love Potions while you're not looking! Um, I mean... oh, just buy something!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.20").ToString(),
                "Shower thought. If I put you in a meat grinder and all that's left is two Dye... I'd probably be rich! Not that I would, not to you, specifically, I mean... never mind!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.21").ToString(),
                "UWAH! Please don't hurt... wait, it's just you. Don't scare me like that! And why is that THING following you?!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.74").ToString(),
                "Ooh, that's my hoodie! So how is it? Comfy and great for gaming, right? Maybe you'll even go beat a boss without taking damage!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.66").ToString(),
                "Good work getting one over on me! Hope I didn't make you sweat too much. Keep at the grind - I wanna see how far you can go!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.49").ToString(),
                _ => chat
            };
            
            if (chat == $"{Main.LocalPlayer.name}! I saw something rodent-y just now! You don't have a hamster infestation, right? Right!?")
            {
                chat = TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.34").WithFormatArgs(Main.LocalPlayer.name).ToString();
            }
            
            if (NPC.AnyNPCs(ModContent.NPCType<Mutant>()))
            {
                if (chat == $"Can you tell {GetNPCName(ModContent.NPCType<Mutant>())} to put some clothes on?")
                {
                    chat = TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.35").WithFormatArgs(GetNPCName(ModContent.NPCType<Mutant>())).ToString();
                }
                
                else if (chat == $"One day, I'll sell a summon for myself! ...Just kidding. That's {GetNPCName(ModContent.NPCType<Mutant>())}'s job.")
                {
                    chat = TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.36").WithFormatArgs(GetNPCName(ModContent.NPCType<Mutant>())).ToString();
                }
            }
            
            if (NPC.AnyNPCs(ModContent.NPCType<LumberJack>()))
            {
                if (chat == $"What's that? You want to fight {GetNPCName(ModContent.NPCType<LumberJack>())}? ...even I know better than to try.")
                {
                    chat = TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.39").WithFormatArgs(GetNPCName(ModContent.NPCType<LumberJack>())).ToString();
                }
            }
        }
    }

    public override void OnChatButtonClicked(NPC npc, bool firstButton)
    {
        if (npc.type == ModContent.NPCType<Abominationn>())
        {
            Main.npcChatText = Main.npcChatText switch
            {
                "I don't think there's an event right now." => TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.28").ToString(),
                "Hocus pocus, the event is over" => TranslationHelper.GetText("Fargowiltas.NPCs.Abominationn.Dialogues.31").ToString(),
                _ => Main.npcChatText
            };
        }
        
        if (npc.type == ModContent.NPCType<LumberJack>())
        {
            Main.npcChatText = Main.npcChatText switch
            {
                "While I was chopping down a cactus these things leaped at me, why don't you take care of them?" => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.23").ToString(),
                "These mahogany trees are full of life, but a tree only has one purpose: to be chopped. Oh yea these fell out of the last one." => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.24").ToString(),
                "This place is a bit fanciful for my tastes, but the wood's as choppable as any. Nighttime has these cool bugs though, take a few." => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.25").ToString(),
                "Whatever causes these to glow is beyond me, you're probably gonna eat them anyway so have this while you're at it." => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.26").ToString(),
                "The trees here are probably the toughest in this branch of reality.. Sorry, just tree puns. I found these for you here." => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.27").ToString(),
                "This neck of the woods is pretty eh? Here I've got some of my favorite wood for you." => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.35").ToString(),
                "Even on vacation, I always fit in a little chopping. A couple annoying birds fell out of a palm tree. Take them off my hands.. maybe cook them up?" => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.37").ToString(),
                "I looked around here for a while and eventually found some weird, ashy trees. Very fragile. I also found these little guys. Please take them, they're hot to hold." => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.38").ToString(),
                "I certainly didn't expect to find such wonderful trees down here. Check this out." => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.39").ToString(),
                "Back in the day, people used to forge butterflies into powerful gear. We try to forget those days... but here have one." => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.28").ToString(),
                "These little critters are always falling out of the trees I cut down. Maybe you can find a use for them?" => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.29").ToString(),
                "Chopping trees at night is always relaxing... well except for the flying eyeballs. Have one of these little guys to keep you company." => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.30").ToString(),
                "I'm resting after a good day of chopping, come back tomorrow and maybe I'll have something else for you." => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.32").ToString(),
                "Went for a long haul today, but there were only so many of those strange trees to go around. I did find a lot of these, why don't you give some of them a new home?" => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.31").ToString(),
                "Seems like the wind brought a bunch of these out of hiding. Some people say they're good luck. All I know is, the only luck I need is a sharp axe!" => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.33").ToString(),
                "I found this, but I'm not a sappy person. You can have it instead." => TranslationHelper.GetText("Fargowiltas.NPCs.LumberJack.Dialogues.21").ToString(),
                _ => Main.npcChatText
            };
        }
        
        if (npc.type == ModContent.NPCType<Deviantt>())
        {
            Main.npcChatText = Main.npcChatText switch
            {
                "What's that? You want to fight me for real? ...nah, I can't put up a good fight on my own." => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.41").ToString(),
                "Hey, you've almost made it to the end! Got all your Soul accessories ready? What's that? You want to fight my big brother? ...maybe if he had a reason to." => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.42").ToString(),
                "Ready to fight my big brother? Remember how you've learned to learn. Stay focused, look for patterns, and don't panic. Good luck!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.43").ToString(),
                "Wanna craft Forces, but missing Enchantments? Craft the Sigil of Champions and they'll give you what you want, so long as you earn it." => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.79").ToString(),
                "Only a specific type of weapon will work against each specific pillar. As for that moon guy, his weakness will keep changing." => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.44").ToString(),
                "Some powerful enemies like that dungeon guy can create their own arenas. You won't be able to escape, so make full use of the room you do have." => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.45").ToString(),
                "Did you beat that fish pig dragon yet? He reduces your maximum life a little on every hit. He's also strong enough to break defenses in one hit. Too bad you don't have any reinforced plating to prevent that, right?" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.46").ToString(),
                "Now's a good time to go for Betsy! Don't worry. If you reach the last wave and lose, you won't have to retry the event for more attempts at her. Careful not to slip up before then, and mind her debuffs!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.80").ToString(),
                "That temple? Reach the altar to regain wire control! The golem gets upset when you leave, so fighting in there is best. Platforms won't work, but a Lihzahrd Instactuation Bomb can help clear space!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.47").ToString(),
                "That overgrown plant inflicts a special venom that works her into an enraged frenzy if she stacks enough hits on you. She also has a ring of crystal leaves, but minions go through it." => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.48").ToString(),
                "That metal worm has a few upgrades, but its probes were downgraded to compensate. It'll start shooting homing dark stars and flying. When it coils around you, don't try to escape!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.50").ToString(),
                "I saw that metal eye spinning while firing a huge laser the other day. Also, even if you kill them, they won't die until they're both killed!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.51").ToString(),
                "Focus on taking down that metal skull, not its limbs. Don't try to outrun its spinning limbs! Keep your eyes open and learn to recognize what's doing what." => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.52").ToString(),
                "That thing's mouth is as good as immune to damage, so you'll have to aim for the eye. Only one of them is vulnerable at a time, though. What thing? You know, that thing!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.53").ToString(),
                "Next up is me! Make sure you can recognize whatever attack I'll throw at you. Blocks and turning away can nullify petrification!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.54").ToString(),
                "The master of the dungeon can use its babies to attack! Which attack it uses depends on whether or not it's spinning. It'll also take a last stand, so be ready to run when you make the kill!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.55").ToString(),
                "The queen bee will summon her progeny for backup. She's harder to hurt while they're there, so take them out first. Oh, and her swarm can't hit right above or below her!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.56").ToString(),
                "Focus on how the ichor moves and don't get overwhelmed! When the brain gets mad, it'll confuse you every few seconds. Four rings to confuse you, one ring when it wears off!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.57").ToString(),
                "The more the world eater splits, the more worms can rush you at once. The head is extra sturdy now, but don't let them pile up too much!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.58").ToString(),
                "Watch out when you break your second Crimson Heart! It might attract the goblins, so prepare before you do it." => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.59").ToString(),
                "Watch out when you break your second Shadow Orb! It might attract the goblins, so prepare before you do it." => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.60").ToString(),
                "That big eyeball has the power of the moon, but it's too flashy for its own good! Learn to notice and focus only on the bits that threaten to hurt you." => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.61").ToString(),
                "Gonna fight that slime king soon? Crafting a Mini Instabridge or two might help, and mind the spike rain. Don't stay up and out of his range or he'll get mad, though!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.62").ToString(),
                "Seems like everyone's learning to project auras these days. If you look at the particles, you can see whether it'll affect you at close range or a distance!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.63").ToString(),
                "There's probably a thousand items to protect against all these debuffs. It's a shame you don't have a thousand hands to carry them all at once!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.64").ToString(),
                "Don't forget you can turn off your soul toggles! They're all in that little wrench button right below your inventory. Those small buttons at the very bottom of the list include a recommended low-lag preset!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.65").ToString(),
                "I don't have any more Life Crystals for you, but I think my big brother left some in the fat slime king. Maybe he'll share if you beat it up!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.68").ToString(),
                "Watch out for those fish! Sharks will leave you alone if you leave them alone, but piranhas go wild when they smell blood. They can jump out of water to get you!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.70").ToString(),
                "The water is bogging you down? Never had an issue with it, personally... Have you tried breathing water instead of air?" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.71").ToString(),
                "The underworld has gotten a lot hotter since the last time I visited. I hear an obsidian skull is a good luck charm against burning alive, though!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.72").ToString(),
                "Want to have a breath-holding contest? The empty vacuum of space would be perfect. No, I won't cheat by breathing water instead of air!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.73").ToString(),
                "That's a funny face you're making... Is the underground Hallow too disorienting? Try controlling gravity on your own and maybe it can't flip you by force!" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.81").ToString(),
                "If you ask me, Plantera is really letting herself go. A diet of Chlorophyte Ore and Life Fruit isn't THAT healthy! Why don't you help her slim down?" => TranslationHelper.GetText("Fargowiltas.NPCs.Deviantt.Dialogues.77").ToString(),
                _ => Main.npcChatText
            };
        }
    }
}