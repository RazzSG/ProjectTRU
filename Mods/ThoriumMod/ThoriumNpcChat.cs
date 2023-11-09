using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ModLoader;
using ThoriumMod.NPCs;

namespace CalamityRuTranslate.Mods.ThoriumMod;

public class ThoriumNpcChat : GlobalNPC
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModsCall.Thorium != null && TranslationHelper.IsRussianLanguage;
    }

    public override void GetChat(NPC npc, ref string chat)
    {
        string GetNPCName(int type) => Main.npc[NPC.FindFirstNPC(type)].GivenName;

        if (npc.type == ModContent.NPCType<Blacksmith>())
        {
            chat = chat switch
            {
                "Don't forget to wipe your blade if you're planning on going out there! I don't care how magical it is, those freaks' blood will rust any metal!" => "Не забудь протереть свой клинок, если собираешься выходить наружу! Мне всё равно, насколько он магический, кровь этих чудищ ржавеет любой металл",
                "You know all those special weapons you find scattered about the land? I've always wondered just how they were forged in the first place. I'm an old man now, but I've still got a long journey to mastery ahead of me..." => "Знаешь, все те уникальные оружия, что разбросаны по всей этой земле? Мне всегда было интересно, как их вообще ковали. Хотя я уже старик, мной ещё предстоит долгий путь к совершенству...",
                "Every blade's got its place in the world: a signature weapon for a hero, a beloved knife for a chef, or maybe just some gaudy piece of junk hanging from a wall." => "У каждого клинка есть своё предназначение: это может быть личное оружие героя, любимый нож шеф-повара или просто бесполезная безделушка на стене.",
                "Hey brat, corral some people into helping me out at the forge. Blacksmithing ain't a single-man task, and you'll just end up with second-rate junk if you try going solo!" => "Эй, малец, найди кого-нибудь, кто поможет мне в кузнице. Кузнечное дело - это не работа одного человека, и если ты будешь работать в одиночку, то получишь только второсортное барахло!",
                "'course I followed you here, brat. I crash-coursed you on how to forge and smith weapons for yourself before you arrived here, I'll be damned if I don't get to sit back and watch the ensuing fireworks." => "Конечно, малец, я следил за твоими шагами с самого начала. Я обучил тебя кузнечному ремеслу задолго до твоего прихода сюда, Поэтому, честно говоря, я буду разочарован, если упущу тот фейерверк, который ты здесь устроишь.",
                "Welcome! I'm busy workin' on a commission weapon, if you touch anything, consider it sold!" => "Привет! Я сейчас работаю над заказом, так что не трогай ничего, а то считай, что ты это уже купил!",
                _ => chat
            };

            if (NPC.AnyNPCs(38))
            {
                if (chat == $"Me and {GetNPCName(38)} have a little routine going: he delivers me metal to smith, and I give him a heart attack by smoking near his explosives on purpose.")
                {
                    chat = $"У меня с {GetNPCName(38)} есть такая штука: он приносит мне металл для кузнеца, а я специально курю рядом с его взрывчаткой, чтобы у него случился сердечный приступ.";
                }
            }
            
            if (NPC.AnyNPCs(208))
            {
                if (chat == $"I just witnessed {GetNPCName(208)} make a knife out of chocolate that's better than half of my own blades...")
                {
                    chat = $"Я стал свидетелем того, как {GetNPCName(208)} сделал из шоколада нож, который лучше половины моих клинков...";
                }
            }
            
            if (NPC.AnyNPCs(17))
            {
                if (chat == $"What does that conman {GetNPCName(17)} think he's doing trying to offer his cheap trash he calls 'weapons'? If you want the real deal, you've come to the right place!")
                {
                    chat = $"Чего этот шарлатан {GetNPCName(17)} думает, предлагая свой дешёвый хлам, который он называет 'оружием'? Если хочешь что-нибудь стоящее, то ты попал по адресу!";
                }
            }
            
            if (NPC.AnyNPCs(ModContent.NPCType<Tracker>()))
            {
                if (chat == $"That brute {GetNPCName(ModContent.NPCType<Tracker>())} is more Barbarian than Tracker! Do you have any idea how many times the oaf asked me to fix that battleaxe of his?!")
                {
                    chat = $"Эта дубина {GetNPCName(ModContent.NPCType<Tracker>())} больше похожа на варвара, чем на следопыта! Ты хоть представляешь, сколько раз этот болван просил меня починить свой боевой топор?!";
                }
            }
        }

        if (npc.type == ModContent.NPCType<Cobbler>())
        {
            chat = chat switch
            {
                "In my younger years, I myself was a hero. But after a bad fall, I've since retired. Perhaps if I had better boots back then I would still be a hero today..." => "В свои молодые годы я тоже был героем. Но после неудачного падения пришлось уйти на пенсию. Кто знает, может, если бы у меня были более надёжные ботинки, я бы и сейчас был героем...",
                "Worry not young man. While the journey may be tough, I have full confidence in your ability!" => "Не переживай, парень. Путь будет непростой, но я уверен в твоих силах!",
                "Worry not young lady. While the journey may be tough, I have full confidence in your ability!" => "Не переживай, малышка. Путь будет непростой, но я уверен в твоих силах!",
                "You can learn a lot by walking a mile in someone else's boots. If only some of these townsfolk would walk a mile in yours, then they could understand..." => "Пройдя милю в чужих сапогах, можно узнать многое. Если бы кто-нибудь из этих жителей хотя бы на минутку примерил на себя мои ботинки, они бы поняли, каково это...",
                _ => chat
            };
            
            if (chat == $"Having proper footwear is no joke, {Main.LocalPlayer.name}. Always make sure your shoes are polished and ready for adventure!")
            {
                chat = $"Выбор правильной обуви - это не шутка, {Main.LocalPlayer.name}. Всегда следи, чтобы твои ботинки были начищены и готовы к приключениям!";
            }
            
            if (chat == $"How are you doing, {Main.LocalPlayer.name}? Are you staying safe out there in the wilds?")
            {
                chat = $"Как поживаешь, {Main.LocalPlayer.name}? Не вляпался в неприятности в этих дебрях?";
            }
            
            if (NPC.AnyNPCs(208))
            {
                if (chat == $"Can you believe that {GetNPCName(208)} wanted to throw me a birthday party? I haven't had one in so long!")
                {
                    chat = $"Ты представляешь,{GetNPCName(208)} хочет устроить мне день рождения? Я так давно не праздновал!";
                }
            }
            
            if (NPC.AnyNPCs(108))
            {
                if (chat == $"Oh my... I think {GetNPCName(108)} might be even older than I am!")
                {
                    chat = $"Вот это да... Думаю, {GetNPCName(108)} может быть даже старше меня!";
                }
            }
            
            if (NPC.AnyNPCs(22))
            {
                if (chat == $"Ah, so {GetNPCName(22)} has been giving you advice this whole time? It's always nice to see a young man appreciate his studies.")
                {
                    chat = $"А, так {GetNPCName(22)} всё это время давал тебе советы? Всегда рад видеть, как молодые люди ценят обучение.";
                }
            }
        }

        if (npc.type == ModContent.NPCType<ConfusedZombie>())
        {
            chat = chat switch
            {
                "I can't remember much about my past life... Chemicals and the like were my passion I think; I only get fragments and pieces of the truth. It's saddening at times..." => "Я почти ничего не помню о своей прошлой жизни... Мне кажется, что химия была моей страстью, но сейчас я помню лишь обрывки и кусочки воспоминаний. Иногда это бывает настолько грустно...",
                "Why am I not like the others...? Oh, I'm sorry, did you need something?" => "Почему я не такой, как остальные?.. Ой, извини, тебе что-то нужно?",
                "Most people don't have the stomach to handle the things I sell. The trick is to not have a stomach at all!" => "Большинство людей не могут переварить то, что я продаю. А секрет в том, чтобы вообще не иметь желудка!",
                "I gotta thank you for letting me stick around. Only coming out at night is pretty boring..." => "Спасибо, что разрешил мне остаться. Просто выходить только ночью довольно скучно...",
                _ => chat
            };
            
            if (NPC.AnyNPCs(22))
            {
                if (chat == $"I bet {GetNPCName(22)} has a big juicy brain... not that I would wanna... uh... did you need something?")
                {
                    chat = $"Сдаётся мне, {GetNPCName(22)} имеет большой и сочный мозг... не то чтобы я хотел... э-э-э... тебе что-нибудь нужно?";
                }
            }
            
            if (NPC.AnyNPCs(208))
            {
                if (chat == $"{GetNPCName(208)}'s brain would surely taste like candy... Oh uh, hello there!")
                {
                    chat = $"М-м-м, мозг {GetNPCName(208)} наверняка такой сладкий... Ой, привет!";
                }
            }
        }

        if (npc.type == ModContent.NPCType<Cook>())
        {
            chat = chat switch
            {
                "I've got a lot of orders from the other townsfolk right now, make it quick!" => "У меня сейчас полно заказов от других горожан, так что поторопись!",
                "How did any of you survive before I arrived? What could you have possibly been eating, dirt?" => "Ну, и как вы вообще выживали до моего прихода? Вы что, ели землю?",
                "I'm stuck with dull knives while you wield weapons of unimaginable power? Give me a break..." => "Я сижу тут с тупыми ножами, а ты носишь оружие невообразимой силы? Дай мне перерыв...",
                "No one should go adventuring on an empty stomach. Eat well, hero!" => "С голодным желудком в поход не пойдёшь. Наедайся, герой!",
                "Supply me with the proper ingredients, and I can make some truly powerful foods for you, hero!" => "Если ты дашь мне нужные ингредиенты, я смогу приготовить для тебя что-нибудь по-настоящему крутое, герой!",
                _ => chat
            };
            
            if (NPC.AnyNPCs(369))
            {
                if (chat == $"{GetNPCName(369)} can be a real brat at times, but as long as he keeps providing me with fresh fish, I won't complain.")
                {
                    chat = $"{GetNPCName(369)} иногда настоящий засранец, но пока он продолжает снабжать меня свежей рыбой, я не буду жаловаться.";
                }
            }
            
            if (NPC.AnyNPCs(20))
            {
                if (chat == $"Cooking for {GetNPCName(20)} is no easy task. She simply refuses to eat any form of meat!")
                {
                    chat = $"Приготовить что-нибудь для {GetNPCName(20)} - это нелёгкая задача. Она просто отказывается есть мясо!";
                }
            }
            
            if (NPC.AnyNPCs(228))
            {
                if (chat == $"The last time {GetNPCName(228)} asked me to cook for him, he requested bugs! This truly is a strange place...")
                {
                    chat = $"В прошлый раз когда {GetNPCName(228)} попросил приготовить ему что-нибудь, он попросил жуков! Вот уж точно странное место...";
                }
            }
        }

        if (npc.type == ModContent.NPCType<DesertAcolyte>())
        {
            chat = chat switch
            {
                "We certainly have some strange people around this town, don't we...?" => "Да уж, в этом городе полно странных людей, не правда ли?",
                "You didn't see any giant bird shadows while you were out in the desert, did you?" => "Ты не заметил в пустыне гигантские тени, похожие на птиц, а?",
                "I had originally stopped just to refill my canteen, but you seem like someone who can deal with a real threat!" => "Я зашёл сюда просто пополнить запасы, но ты выглядишь как тот, кто справится с реальной угрозой!",
                "Have you ever heard tale of the Thunder Birds? Legend says they had long protected our world from cataclysmic threats, before a disagreement between them and three individuals led to their disappearance..." => "Слышал ли ты когда-нибудь о Громовых птицах? Легенда гласит, что они долгое время защищали наш мир от катастроф, но однажды между ними и тремя личностями произошёл конфликт, который привёл к их исчезновению...",
                "If you're interested in the secrets of my people, be sure to purchase a 'Blank Technique Scroll'. They offer great power to those that utilize them well..." => "Если ты хочешь узнать секреты моего народа, обязательно купи 'Пустой свиток техники'. Он даст тебе огромную силу, если ты умеешь им пользоваться...",
                "I have seen so much evil in my travels... I only hope someone can put a stop to them!" => "Я столько зла повидал в своих странствиях... Только бы кто-нибудь смог их остановить!",
                _ => chat
            };
            
            if (NPC.AnyNPCs(207))
            {
                if (chat == $"{GetNPCName(207)} was interested in dyeing my attire, but his choice of plant dye was 'strange' to say the least.")
                {
                    chat = $"{GetNPCName(207)} хотел покрасить мне наряд, но его выбор растительного красителя был, мягко говоря, 'странным'.";
                }
            }
            
            if (NPC.AnyNPCs(19))
            {
                if (chat == $"Look at {GetNPCName(19)} over there! He's got an entire arsenal of guns, is that really safe?")
                {
                    chat = $"Ты только посмотри на {GetNPCName(19)}! У него целый арсенал оружия, это вообще безопасно?";
                }
            }
        }
        
        if (npc.type == ModContent.NPCType<Diverman>())
        {
            chat = chat switch
            {
                "Visiting that sea rift again wasn't my best idea... that mutant jellyfish almost ate me whole!" => "Посетить снова тот морской разлом было не самой лучшей идеей... та мутировавшая медуза чуть не сожрала меня целиком!",
                "Yuck... that vile creature almost got away with eating me! Thank you for saving me, hero." => "Б-р-р... эта мерзкая тварь чуть не сожрала меня! Спасибо, что спас меня, герой.",
                "Have you adventured into the aquatic depths yet...? Its choking atmosphere prevents most explorers from entering, but I'm confident you'll find a way around it..." => "Ты уже погружался в акватические глубины? Многих отталкивает давящая атмосфера этих мест, но я убеждён, что ты найдёшь способ преодолеть этот непроходимый барьер...",
                "I've collected many marine items in my travels, hero. Would you like to purchase one?" => "Эй, герой! В своих странствиях я собрал много морских сокровищ. Хочешь купить что-нибудь?",
                "Being at the bottom of the ocean for long periods of time has taught me one thing; Always come prepared!" => "Жизнь на дне океана научила меня одному: всегда будь готов к любым неожиданностям!",
                "You would think it gets hard to breath under this helmet, but really I'm just used to it now." => "На первый взгляд, может показаться, что под этим шлемом трудно дышать, но я уже привык",
                "You ever try to drink a bottle of water, while drowning, to save yourself? I know I have!" => "А ты когда-нибудь, когда тонул, пробовал выпить бутылку воды, чтобы спастись? Я вот да!",
                _ => chat
            };
        }
        
        if (npc.type == ModContent.NPCType<Druid>())
        {
            chat = chat switch
            {
                "Why don't you go fetch those seeds yourself you lazy, good for nothing-" => "Почему бы тебе не пойти и собрать эти семена самостоятельно, ни на что не годный лентяй!",
                "I bet you don't even feel guilty about destroying the natural world to better suit your needs..." => "Готов поспорить, что ты и вовсе не чувствуешь вину, разрушая природу в угоду своим прихотям...",
                "Getting these seeds is a bigger hassle than you would think. Nearly drowning, almost melting, freezing to- You get the idea." => "Достать эти семена оказалось гораздо сложнее, чем я думал. Я чуть не утонул, чуть не сварился, чуть не замёрз до смер... Ну, ты понял.",
                "I often take visits to the jungle. I can understand the aversion to the place, but the creatures within don't seem to hassle me..." => "Я частенько захаживаю в джунгли. Могу понять, что это место вызывает отвращение, но местная фауна меня не трогают...",
                "My mother was a well known herbalist back in the day. She doesn't talk about my father, though. I wonder why?" => "Моя мама в своё время была знаменитой травницей. А вот о папе она никогда не говорит. Интересно, почему?",
                "The natural world is quite a wonder. Every little place has its own charm. Some more than others!" => "Мир природы действительно чудесен. Каждый уголок имеет своё очарование. В некоторых местах оно проявляется сильнее, чем в других!",
                _ => chat
            };
            
            if (NPC.AnyNPCs(228))
            {
                if (chat == $"Our friend there, {GetNPCName(228)}, is rather strange isn't he? He speaks in riddles...")
                {
                    chat = $"Наш друг, {GetNPCName(228)}, какой-то странный, не находишь?. Он постоянно говорит этими загадками...";
                }
            }
            
            if (NPC.AnyNPCs(ModContent.NPCType<Cook>()))
            {
                if (chat == $"I wonder if I can convince {GetNPCName(ModContent.NPCType<Cook>())} to whip me up a salad.")
                {
                    chat = $"Интересно, смогу ли я уговорить {GetNPCName(ModContent.NPCType<Cook>())} приготовить мне салат.";
                }
            }
            
            if (chat == $"How does today find you, {Main.LocalPlayer.name}? Make sure to stop and smell the roses!")
            {
                chat = $"Как дела, {Main.LocalPlayer.name}? Не забудь остановиться и полюбоваться цветами!";
            }
            
            if (chat == $"Even a small seed can grow into a mighty oak! Keep that in mind, {Main.LocalPlayer.name}...")
            {
                chat = $"Даже маленький росток может вырасти в могучий дуб! Помни это, {Main.LocalPlayer.name}...";
            }
        }

        if (npc.type == ModContent.NPCType<PeculiarMirror>())
        {
            chat = chat switch
            {
                "Before you sits a rather strange mirror. Something seems to be calling out from it...?" => "Перед тобой стоит странное зеркало. Кажется, из него кто-то зовёт?..",
                _ => chat
            };
        }
        
        if (npc.type == ModContent.NPCType<Spiritualist>())
        {
            chat = chat switch
            {
                "Is- Is that my cross? How in the world did you manage to find it? It's been lost for so long..." => "Это мой крест? Да ладно, откуда он у тебя? Я его уже столько лет ищу...",
                "Beware my friend... true evil walks among us this night." => "Остерегайся, дружище... этой ночью истинное зло раскроет личину среди нас.",
                "Ah, it's been a while friend. It is good to see you are well after so long!" => "Эх, давненько мы не виделись, друг. Рад видеть, что ты в порядке!",
                "Whether in body, mind, or spirit, always consider how you may grow today, my friend." => "Эх, давненько мы не виделись, друг. Рад видеть тебя в полном здравии спустя столь долгое время!",
                "Energy, chi, spirit... it's all the same to me. There is power in all things." => "Энергия, ци, дух... для меня это всё одно и то же. Везде есть сила.",
                "I have no doubt of your physical power, hero. But sometimes hardship is fought in a battle of will, not strength." => "Не сомневаюсь в твоей силе, герой. Но иногда трудности преодолевают силой воли, а не грубой силой.",
                _ => chat
            };
            
            if (NPC.AnyNPCs(369))
            {
                if (chat == $"{GetNPCName(369)} often comes to me in private to discuss things that are bothering him. Such a young age to be in his position...")
                {
                    chat = $"{GetNPCName(369)} частенько приходит ко мне поговорить по душам. В таком молодом возрасте столько ответственности...";
                }
            }
        }
        
        if (npc.type == ModContent.NPCType<Tracker>())
        {
            chat = chat switch
            {
                "Seen any interesting beasts lurking around lately? Minotaurs? Beholders? Gorgons?" => "Не видел ли ты каких-нибудь интересных монстров, которые бродят тут в последнее время? Минотавров? Созерцателей? Горгон?",
                "Bear your scars with pride, as each one has a tale to tell... What do your scars say about you, hero?" => "Не стыдись своих шрамов, ведь каждый из них рассказывает свою историю... Что говорят твои шрамы о тебе, герой?",
                "Many beasts have fallen to me and my axe, but new ones are always on the prowl. Keep your eyes peeled, kid." => "Множество зверей уже пало от меня и моего топора, но эти новые всегда нападают неожиданно. Будь начеку, паренёк.",
                "You'd be surprised how effective a single shoulder pad can be." => "Ты удивишься, насколько эффективен всего один наплечник.",
                _ => chat
            };
            
            if (NPC.AnyNPCs(353))
            {
                if (chat == $"Do you think {GetNPCName(353)} would give a haircut even to a brute like me...?")
                {
                    chat = $"Думаешь, {GetNPCName(353)} пострижёт даже такого грубияна, как я?..";
                }
            }
            
            if (NPC.AnyNPCs(550) && NPC.AnyNPCs(ModContent.NPCType<WeaponMaster>()))
            {
                if (chat == $"{GetNPCName(550)}, {GetNPCName(ModContent.NPCType<WeaponMaster>())}, and I were gonna start a gym together. You want in?")
                {
                    chat = $"Слушай, {GetNPCName(550)}, {GetNPCName(ModContent.NPCType<WeaponMaster>())} и я собираемся открыть тренажёрный зал. Хочешь присоединиться?";
                }
            }
        }
        
        if (npc.type == ModContent.NPCType<WeaponMaster>())
        {
            chat = chat switch
            {
                "Long ago, when this world was first taking form, my race reigned supreme. That time has passed it seems..." => "Давным-давно, когда этот мир только начинал формироваться, мой народ был самым могущественным. Но, похоже, это время прошло...",
                "I'm not one for idle chatter. If you have need of me, make it quick." => "Я не из тех, кто любит болтать. Если тебе что-то от меня нужно, говори по делу.",
                "My race's obsession with voodoo dolls has only become rampant just recently. It's truly a fad gone wrong..." => "У моей расы недавно появилась странная одержимость куклами вуду. Это просто дурной тренд, который вышел из-под контроля...",
                "Should you have the coin, I would be willing to accompany you in your endeavors..." => "Если у тебя есть деньги, я готов сопровождать тебя в твоих начинаниях...",
                "A warrior without his weapon stands no chance against the ever-powering threats he must face..." => "Воин без оружия не имеет шансов против постоянно усиливающихся угроз, которые ему приходится встречать...",
                _ => chat
            };
            
            if (chat == $"{GetNPCName(ModContent.NPCType<WeaponMaster>())} blankly stares through you, as though he's not entirely there...")
            {
                chat = $"{GetNPCName(ModContent.NPCType<WeaponMaster>())} смотрит на тебя пустым взглядом, словно он не здесь...";
            }
            
            if (chat == $"*So... you've gained the ability to speak in tongues, {Main.LocalPlayer.name}? Very fascinating...*")
            {
                chat = $"*Так значит, ты научился говорить на разных языках, {Main.LocalPlayer.name}? Очень интересно...*";
            }
            
            if (chat == $"Ie... oep'wl vmnjld hrl mfnbnho he iwlmc nj hejvpli, {Main.LocalPlayer.name}? Wlgo zmisnjmhnjv...")
            {
                chat = $"Ыщ... нщг'му пфштув еру фишдшен ещызуфл шт ещтпгуы, {Main.LocalPlayer.name}? Мукн афысштфештп...";
            }
            
            if (NPC.AnyNPCs(22))
            {
                if (chat == $"{GetNPCName(22)} keeps giving me dirty looks... It's not like I carry a doll myself.")
                {
                    chat = $"{GetNPCName(22)} постоянно пялится на меня... Да я же сам не хожу с куклой!";
                }
            }
        }
    }

    public override void OnChatButtonClicked(NPC npc, bool firstButton)
    {
        string GetNPCName(int type) => Main.npc[NPC.FindFirstNPC(type)].GivenName;
        if (npc.type == ModContent.NPCType<Cobbler>())
        {
            if (Main.npcChatText == $"There we go, {Main.LocalPlayer.name}, good as new. It won't last long, but maybe you'll notice some more spring in your step. Make sure to stay safe out there, hero!")
            {
                Main.npcChatText = $"Ну вот, {Main.LocalPlayer.name}, ты как новенький. Это, конечно, ненадолго, но по крайней мере ты снова можешь двигаться. Главное быть осторожным, герой!";
            }
        }

        if (npc.type == ModContent.NPCType<ConfusedZombie>())
        {
            Main.npcChatText = Main.npcChatText switch
            {
                "I just whipped up the perfect recipe to deter bats from bothering you; no more tiny nibbles!" => "Я только что придумал идеальный рецепт для отпугивания летучих мышей; скажем нет маленьким укусам!",
                "If this turned out correctly, you'll smell just like a zombie. Hopefully your nights will be a tad more calm!" => "Если всё получится, ты будешь пахнуть как зомби. Надеюсь, твои ночи станут чуточку спокойнее!",
                "Getting this stuff to work underwater was a huge hassle... Either way, hungry fish shouldn't attempt to eat you with this." => "Наладить работу этой штуки под водой было непросто... Но зато теперь голодные рыбы не будут пытаться тебя сожрать.",
                "I'll be honest, this is just a bottle of pure liquid calcium. Don't question it, the skeletons surely won't." => "Скажу честно, это просто бутылка жидкого кальция. Не задавай вопросов, скелеты же не задают",
                "With this nasty concoction, insects will associate your scent with their queen! Neat, huh?" => "С помощью этой мерзкой смеси насекомые будут считать тебя своей королевой! Круто, да?",
                "Looks like you're a bit short on funds. Come back to me when you have a little more coin in your pocket!" => "Слушай, у тебя видать денег мало. Приходи ко мне, когда у тебя будет побольше монет в кармане!",
                "I'm afraid you'll have to give me some more time to prepare the next repellent. This stuff can get pretty complicated..." => "К сожалению, мне нужно немного больше времени, чтобы приготовить следующий репеллент. Это штука может быть весьма сложной...",
                _ => Main.npcChatText
            };
        }
        
        if (npc.type == ModContent.NPCType<Cook>())
        {
            Main.npcChatText = Main.npcChatText switch
            {
                "This crisp morel was just asking to be put in a dish. I hope it's to your liking!" => "Этот свежий сморчок так и просит стать блюдом. Надеюсь, ты оценишь!",
                "Pink pears can be problematic if prepared improperly. Good thing I'm a professional pear pickler!" => "Розовые груши могут быть проблемными, если их неправильно приготовить. Хорошо, что я профессионал по консервированию груш!",
                "Well uh... I DID cook it, though I'm not entirely sure you should eat this stuff." => "Ну... я-то его ПРИГОТОВИЛ, но я не уверен, что тебе стоит это есть.",
                "With just the right amount of green, this dish gets real mean. Be careful eating it!" => "Это блюдо с достаточным количеством зелени становится реально ядрёным. Будь осторожен, когда будешь есть его!",
                "I had to visit a far away land to learn how to make this dish. Hopefully you'll appreciate it!" => "Я специально ездил в другую страну, чтобы научиться готовить это блюдо. Надеюсь, ты оценишь!",
                "When I was younger, my mother would always greet me with some mint tea after a long, hard day... I miss the simpler times." => "Когда я был моложе, мама всегда встречала меня с чашкой мятного чая после долгого, трудного дня... Я скучаю по тем временам.",
                "Yunno, it's not just called a 'Sky Blue Flower' because of its color. Some say they've fallen from the sky islands themselves long ago." => "Знаешь, эти цветы не просто так называются 'голубыми'. Говорят, что они когда-то давно упали с небесных островов.",
                "Last time I took a bite of this stuff, I started thinking everything was out to get me... but hey, maybe that's what you're looking for?" => "В последний раз, когда я откусил кусочек этой штуки, я начал думать, что всё вокруг хочет схватить меня... но погоди, может это именно то, что ты ищешь?",
                "Ah, just what I need to help ripen this cheese! Hopefully this'll offer a little more 'pizazz' to its taste." => "Отлично, это то, что мне нужно, чтобы сыр стал вкуснее! Надеюсь, это добавит немного 'пикантности' в его вкус.",
                "I'm honored that you'd trust me with such rare commodities. Hopefully this new recipe suits your fancy!" => "Для меня большая честь, что ты доверил мне такие редкие ингридиенты. Надеюсь, тебе понравится этот новый рецепт!",
                "I myself don't know much about the Hallow, it's a rather strange place... but berries are berries, right?" => "Сам по себе я мало что знаю об освящении, это довольно странное место... ну, а ягоды есть ягоды, в конце концов.",
                "So the legends are true... The kitchen scholars thought this recipe was lost to time, but it's right in front of me. I can barely contain my excitement to try it out!" => "Значит, легенды не врали... Кухонные учёные думали, что этот рецепт утерян во времени, но он прямо передо мной. Я едва сдерживаю волнение, чтобы не попробовать его!",
                "I can tell this was written by an ogre... still, the pictures give me a clear idea on how to brew this. Be careful with this stuff, it's highly potent!" => "Этот рецепт определённо написан огром... тем не менее, по картинкам становится понятен способ готовки. Будь осторожен с этой штукой, больно она крепкая!",
                "Leaves? You want me to cook some food... with leaves? Well, I don't think these would really work in a salad, so how about some tea instead? I'm sure it will calm you down if you're stressed." => "Листья? Ты хочешь, чтобы я приготовил тебе еду... из листьев? Ну, я не думаю, что они подойдут для салата, так что как насчёт чая? Он обладает успокаивающим эффектом.",
                "These were exactly what I was missing for my special hot chocolate recipe! If you're planning on going somewhere a little chilly, these will warm you right up for sure." => "Это именно то, чего мне так не хватало для моего фирменного горячего шоколада! Если ты собираешься в какое-нибудь прохладное место, он точно согреет тебя.",
                "Looks like you don't have any ingredients in your bag. If you can find enough of an ingredient I'm looking for, I can supply you with new purchasable foods. Some of these dishes will be far more powerful than my usual wares, so keep your eyes peeled for unique ingredients!" => "Похоже, в твоей сумке нет ингредиентов. Если наберёшь нужное количество ингредиентов, я смогу предложить тебе новые блюда. Они будут гораздо вкуснее, чем обычные, так что не пропусти уникальные ингредиенты!",
                _ => Main.npcChatText
            };
            
            if (Main.npcChatText == $"Lovely, just enough blueberries for the job! Thanks, and please enjoy, {Main.LocalPlayer.name}!")
            {
                Main.npcChatText = $"Отлично, как раз столько черники, сколько нужно! Спасибо, и приятного аппетита, {Main.LocalPlayer.name}!";
            }
        }

        if (npc.type == ModContent.NPCType<DesertAcolyte>())
        {
            Main.npcChatText = Main.npcChatText switch
            {
                "Although I'm only an acolyte, one of the first things we learn is how to create a sandstorm. Beware the creatures that lurk within however..." => "Хоть я всего лишь послушник, однако одним из первых навыков, которым нас учат, - создание песчаных бурь. Тем не менее, будь осторожен с существами, скрывающимися внутри...",
                "Creating a sandstorm is a very taxing job. I would prefer to have some compensation in the form of money, please." => "Создание песчаных бурь довольно утомительное занятие. Мне бы хотелось получить за это какую-то компенсацию, например, деньги.",
                _ => Main.npcChatText
            };
        }
        
        if (npc.type == ModContent.NPCType<Diverman>())
        {
            Main.npcChatText = Main.npcChatText switch
            {
                "Here you go friend! This air tank will automatically activate when your breath reaches critical level. Come visit me afterwards and I'll refill it free of charge!" => "Вот, держи, дружище! Этот баллон с воздухом автоматически активируется, когда твой запас воздуха достигнет критического уровня. Потом заходи ко мне, я бесплатно его заправлю!",
                "Hmm, your air tank looks full to me... Did you just want to chat? I have all manner of tales to tell!" => "Хм, твой баллон с воздухом выглядит полным... Ты просто хочешь поболтать? У полно историй, которые я могу рассказать!",
                _ => Main.npcChatText
            };
        }
        
        if (npc.type == ModContent.NPCType<Spiritualist>())
        {
            Main.npcChatText = Main.npcChatText switch
            {
                "I'm afraid I can't currently protect you, friend. Give your soul some time to heal, and then come speak to me again." => "Слушай, друг, сейчас я не могу тебя защитить. Дай своей душе время залечиться, а затем возвращайся ко мне.",
                "With these shards, I have imbued you with an incredibly potent shield. Should you take fatal damage, you shall receive my protection for as long as I can hold it. Stay safe out there, my friend." => "С этими осколками я наделил тебя невероятно мощным щитом. Если ты получишь смертельное ранение, то будешь под моей защитой до тех пор, пока я смогу её удерживать. Будь осторожен, мой друг.",
                "I require no money to watch over you my friend, but my protection is limited without some Purified Shards. Once you acquire 5, come visit me again." => "Я тебе бесплатно помогаю, друг мой, но без очищенных осколков моя сила сильно ограничена. Как только наберёшь 5 штук, возвращайся ко мне снова.",
                "No need to fear my friend, my power is already protecting you. Come back when my power has faded." => "Не бойся, друг, моя сила уже защищает тебя. Возвращайся, когда данная мной сила угаснет.",
                _ => Main.npcChatText
            };
        }
        
        if (npc.type == ModContent.NPCType<WeaponMaster>())
        {
            Main.npcChatText = Main.npcChatText switch
            {
                "I see you're lacking in coin. Remedy that and I may just help you out..." => "Как погляжу, у тебя мало денег. Исправь эту досадную оплошность и я помогу тебе...",
                _ => Main.npcChatText
            };
            
            if (Main.npcChatText == $"{GetNPCName(ModContent.NPCType<WeaponMaster>())} blankly stares through you, as though he's not entirely there...")
            {
                Main.npcChatText = $"{GetNPCName(ModContent.NPCType<WeaponMaster>())} смотрит на тебя пустым взглядом, словно он не здесь...";
            }
        }
    }
}