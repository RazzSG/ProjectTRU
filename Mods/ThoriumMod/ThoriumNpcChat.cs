using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ThoriumMod.NPCs;

namespace CalamityRuTranslate.Mods.ThoriumMod;

public class ThoriumNpcChat : GlobalNPC
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.Thorium != null && TRuConfig.Instance.ThoriumModLocalization && TranslationHelper.IsRussianLanguage;
    }

    public override void GetChat(NPC npc, ref string chat)
    {
        string GetNPCName(int type) => Main.npc[NPC.FindFirstNPC(type)].GivenName;

        if (npc.type == ModContent.NPCType<Blacksmith>())
        {
            chat = chat switch
            {
                "Don't forget to wipe your blade if you're planning on going out there! I don't care how magical it is, those freaks' blood will rust any metal!" => "Не забудь протереть свой клинок, если собираешься выходить наружу! Мне всё равно, насколько он магический, кровь этих чудовищ заставляет ржаветь любой металл.",
                "You know all those special weapons you find scattered about the land? I've always wondered just how they were forged in the first place. I'm an old man now, but I've still got a long journey to mastery ahead of me..." => "Знаешь все эти уникальные оружия, что разбросаны по всей земле? Мне всегда было интересно, как их вообще ковали. Хотя я уже старик, мне ещё предстоит долгий путь к совершенству...",
                "Every blade's got its place in the world: a signature weapon for a hero, a beloved knife for a chef, or maybe just some gaudy piece of junk hanging from a wall." => "У каждого клинка есть своё место в этом мире: личное оружие для героя, любимый нож для шеф-повара или просто бесполезная безделушка, висящая на стене.",
                "Hey brat, corral some people into helping me out at the forge. Blacksmithing ain't a single-man task, and you'll just end up with second-rate junk if you try going solo!" => "Эй, малец, найди кого-нибудь, кто поможет мне в кузнице. Кузнечное дело - это не работа одного человека, и если ты будешь работать в одиночку, то получишь только второсортное барахло!",
                "'course I followed you here, brat. I crash-coursed you on how to forge and smith weapons for yourself before you arrived here, I'll be damned if I don't get to sit back and watch the ensuing fireworks." => "Конечно, малец, я следил за тобой с самого начала. Я научил тебя кузнечному ремеслу до того, как ты сюда пришёл. Честно говоря, я буду разочарован, если не увижу, что ты устроишь здесь.",
                "Welcome! I'm busy workin' on a commission weapon, if you touch anything, consider it sold!" => "Привет! Я сейчас работаю над заказным оружием, так что не трогай ничего, а то считай, что ты уже это купил!",
                "Heh, I told you from day one, brat: I came here to watch the fireworks, and you sure delivered." => "Хех, я же говорил тебе с самого начала, малец: я пришёл сюда смотреть на фейерверк, и ты не подкачал.",
                _ => chat
            };

            if (NPC.AnyNPCs(38))
            {
                if (chat == $"Me and {GetNPCName(38)} have a little routine going: he delivers me metal to smith, and I give him a heart attack by smoking near his explosives on purpose.")
                {
                    chat = $"У меня с {GetNPCName(38)} есть такая штука: он приносит мне металл для кузнечного дела, а я специально курю рядом с его взрывчаткой, чтобы у него случился сердечный приступ.";
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
                    chat = $"Чего этот шарлатан {GetNPCName(17)} думает, предлагая свой дешёвый хлам, который он называет «оружием»? Если хочешь что-нибудь стоящее, то ты попал по адресу!";
                }
            }
            
            if (NPC.AnyNPCs(ModContent.NPCType<Tracker>()))
            {
                if (chat == $"That brute {GetNPCName(ModContent.NPCType<Tracker>())} is more Barbarian than Tracker! Do you have any idea how many times the oaf asked me to fix that battleaxe of his?!")
                {
                    chat = $"Этот дурень {GetNPCName(ModContent.NPCType<Tracker>())} больше похож на варвара, чем на следопыта! Ты хоть представляешь, сколько раз этот болван просил меня починить свой боевой топор?!";
                }
            }
        }

        if (npc.type == ModContent.NPCType<Cobbler>())
        {
            chat = chat switch
            {
                "In my younger years, I myself was a hero. But after a bad fall, I've since retired. Perhaps if I had better boots back then I would still be a hero today..." => "В свои молодые годы я тоже был героем. Но после неудачного падения мне пришлось уйти на пенсию. Кто знает, может, если бы у меня были более надёжные ботинки, я бы и сейчас был героем...",
                "Worry not young man. While the journey may be tough, I have full confidence in your ability!" => "Не переживай, парень. Путь будет непростой, но я уверен в твоих силах!",
                "Worry not young lady. While the journey may be tough, I have full confidence in your ability!" => "Не переживай, малышка. Путь будет непростой, но я уверен в твоих силах!",
                "You can learn a lot by walking a mile in someone else's boots. If only some of these townsfolk would walk a mile in yours, then they could understand..." => "Пройдя милю в чужих сапогах, можно узнать многое. Если бы кто-нибудь из этих жителей хотя бы на минутку примерил твои ботинки, они бы поняли, каково это...",
                "I can't believe it, never in a million years... But look at you, standing so triumphantly! Ha ha hah! Congratulations, but more importantly: thank you, from the bottom of my heart, hero. Thanks to your incredible bravery, an old friend of mine can rest easy now..." => "Я не мог и представить, что такое возможно! Вот ты стоишь, весь такой победоносный! Ха-ха-ха! Поздравляю, но самое главное - спасибо тебе, герой, от всего сердца! Благодаря твоей смелости мой старый друг может наконец-то обрести покой...",
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
                    chat = $"Ты представляешь, {GetNPCName(208)} хочет устроить мне день рождения? Я так давно не праздновал!";
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
                    chat = $"А, так {GetNPCName(22)} всё это время давал тебе советы? Приятно видеть, как молодой человек ценит учёбу.";
                }
            }
        }

        if (npc.type == ModContent.NPCType<ConfusedZombie>())
        {
            chat = chat switch
            {
                "I can't remember much about my past life... Chemicals and the like were my passion I think; I only get fragments and pieces of the truth. It's saddening at times..." => "Я почти ничего не помню о своей прошлой жизни... Мне кажется, что химия была моей страстью, но сейчас я помню лишь обрывки и кусочки правды. Иногда это огорчает...",
                "Why am I not like the others...? Oh, I'm sorry, did you need something?" => "Почему я не такой, как остальные?.. Ой, извини, тебе что-то нужно?",
                "Most people don't have the stomach to handle the things I sell. The trick is to not have a stomach at all!" => "Большинство людей не могут переварить то, что я продаю. Секрет в том, чтобы вообще не иметь желудка!",
                "I gotta thank you for letting me stick around. Only coming out at night is pretty boring..." => "Спасибо, что позволил остаться. Выходить только ночью довольно скучно...",
                "I barely remember anything from before I died, but that doesn't mean I can't make new memories. I'll be sure to remember your victory for as long as this body can move!" => "Я почти ничего не помню из своей прошлой жизни, но это не значит, что я не могу создавать новые воспоминания. Я буду помнить твою победу, пока это тело способно двигаться!",
                _ => chat
            };
            
            if (NPC.AnyNPCs(22))
            {
                if (chat == $"I bet {GetNPCName(22)} has a big juicy brain... not that I would wanna... uh... did you need something?")
                {
                    chat = $"Сдаётся мне, что у {GetNPCName(22)} большой и сочный мозг... не то чтобы я хотел... э-э-э... тебе что-нибудь нужно?";
                }
            }
            
            if (NPC.AnyNPCs(208))
            {
                if (chat == $"{GetNPCName(208)}'s brain would surely taste like candy... Oh uh, hello there!")
                {
                    chat = $"М-м-м, мозг {GetNPCName(208)} наверняка будет таким сладким... Ой, привет!";
                }
            }
        }

        if (npc.type == ModContent.NPCType<Cook>())
        {
            chat = chat switch
            {
                "I've got a lot of orders from the other townsfolk right now, make it quick!" => "У меня сейчас полно заказов от других горожан, так что поторопись!",
                "How did any of you survive before I arrived? What could you have possibly been eating, dirt?" => "Как вы вообще выживали до моего прихода? Вы что, ели землю?",
                "I'm stuck with dull knives while you wield weapons of unimaginable power? Give me a break..." => "Я застрял с тупыми ножами, а ты носишь оружие невообразимой силы? Да ладно...",
                "No one should go adventuring on an empty stomach. Eat well, hero!" => "С голодным желудком в поход не пойдёшь. Наедайся, герой!",
                "Supply me with the proper ingredients, and I can make some truly powerful foods for you, hero!" => "Если ты дашь мне нужные ингредиенты, я смогу приготовить для тебя что-то по-настоящему мощное, герой!",
                "I could see the battle from here. To think you would risk your life to save us from something as overwhelming as... that. Take a seat kid, I'll cook your favorite meal - it's on me." => "Я видел битву отсюда. И подумать только, что ты рискнул жизнью, чтобы спасти нас от чего-то столь устрашающего, как... это. Садись, малец, я приготовлю тебе твоё любимое блюдо - за мой счёт.",
                _ => chat
            };
            
            if (NPC.AnyNPCs(369))
            {
                if (chat == $"{GetNPCName(369)} can be a real brat at times, but as long as he keeps providing me with fresh fish, I won't complain.")
                {
                    chat = $"{GetNPCName(369)} иногда бывает настоящим засранцем, но пока он продолжает снабжать меня свежей рыбой, я не буду жаловаться.";
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
                    chat = $"В прошлый раз, когда {GetNPCName(228)} попросил приготовить ему что-нибудь, он заказал жуков! Вот уж точно странное место...";
                }
            }
        }

        if (npc.type == ModContent.NPCType<DesertAcolyte>())
        {
            chat = chat switch
            {
                "We certainly have some strange people around this town, don't we...?" => "Да уж, в этом городе полно странных людей, не правда ли?",
                "You didn't see any giant bird shadows while you were out in the desert, did you?" => "Ты не заметил в пустыне гигантских теней, похожих на птиц?",
                "I had originally stopped just to refill my canteen, but you seem like someone who can deal with a real threat!" => "Я зашёл сюда, чтобы просто пополнить запасы, но ты выглядишь как тот, кто справится с реальной угрозой!",
                "Have you ever heard tale of the Thunder Birds? Legend says they had long protected our world from cataclysmic threats, before a disagreement between them and three individuals led to their disappearance..." => "Ты когда-нибудь слышал о Громовых птицах? Легенда гласит, что они долго защищали наш мир от катастроф, но однажды между ними и тремя людьми произошёл конфликт, который привёл к их исчезновению...",
                "If you're interested in the secrets of my people, be sure to purchase a 'Blank Technique Scroll'. They offer great power to those that utilize them well..." => "Если ты хочешь узнать секреты моего народа, обязательно купи пустой свиток техники. Он даст огромную силу тому, кто умеет им правильно пользоваться...",
                "I have seen so much evil in my travels... I only hope someone can put a stop to them!" => "Я повидал столько зла в своих странствиях... Только бы кто-нибудь смог их остановить!",
                "It seems I was right to place my trust in you, my friend. You've protected us from every threat that arose, and for that, I'm truly grateful. Maybe now I can finally relax a little." => "Похоже, я был прав, доверившись тебе, дружище. Ты защитил нас от всех угроз, и я тебе за это очень благодарен. Может, теперь я наконец смогу немного расслабиться.",
                _ => chat
            };
            
            if (NPC.AnyNPCs(207))
            {
                if (chat == $"{GetNPCName(207)} was interested in dyeing my attire, but his choice of plant dye was 'strange' to say the least.")
                {
                    chat = $"{GetNPCName(207)} хотел покрасить мне наряд, но его выбор растительного красителя был, мягко говоря, «странным».";
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
                "Visiting that sea rift again wasn't my best idea... that mutant jellyfish almost ate me whole!" => "Снова посетить тот морской разлом было не самой лучшей идеей... та мутировавшая медуза чуть не сожрала меня целиком!",
                "Yuck... that vile creature almost got away with eating me! Thank you for saving me, hero." => "Б-р-р... эта мерзкая тварь чуть не сожрала меня! Спасибо, что спас меня, герой.",
                "Have you adventured into the aquatic depths yet...? Its choking atmosphere prevents most explorers from entering, but I'm confident you'll find a way around it..." => "Ты уже погружался в акватические глубины? Многих отталкивает давящая атмосфера этих мест, но я уверен, что ты найдёшь способ преодолеть этот непроходимый барьер...",
                "I've collected many marine items in my travels, hero. Would you like to purchase one?" => "Эй, герой! В своих странствиях я собрал много морских сокровищ. Хочешь купить что-нибудь?",
                "Being at the bottom of the ocean for long periods of time has taught me one thing; Always come prepared!" => "Жизнь на дне океана научила меня одному: всегда будь готов к любым неожиданностям!",
                "You would think it gets hard to breath under this helmet, but really I'm just used to it now." => "На первый взгляд может показаться, что под этим шлемом трудно дышать, но на самом деле я уже привык.",
                "You ever try to drink a bottle of water, while drowning, to save yourself? I know I have!" => "А ты когда-нибудь пытался выпить бутылку воды, тоня, чтобы спастись? Я вот пробовал!",
                "Not bad, kid... Not bad at all. Hopefully you've had fun during all of your adventures out there. I guess you could say I've always been keeping an eye on you." => "Неплохо, малец... Даже очень неплохо. Надеюсь, ты получал удовольствие от своих приключений. Я, кстати, всё время за тобой наблюдал.",
                _ => chat
            };
        }
        
        if (npc.type == ModContent.NPCType<Druid>())
        {
            chat = chat switch
            {
                "Why don't you go fetch those seeds yourself you lazy, good for nothing-" => "Почему бы тебе не пойти и собрать эти семена самостоятельно, ни на что не годный лентяй!",
                "I bet you don't even feel guilty about destroying the natural world to better suit your needs..." => "Готов поспорить, что ты и вовсе не чувствуешь вину, разрушая природу в угоду своим прихотям...",
                "Gathering seeds is a bigger hassle than you would think. Nearly drowning, almost melting, freezing to- You get the idea." => "Собирать семена оказалось гораздо сложнее, чем я думал. Я чуть не утонул, чуть не сварился, чуть не замёрз до смер... Ну, ты понял.",
                "I often take visits to the jungle. I can understand the aversion to the place, but the creatures within don't seem to hassle me..." => "Я частенько захаживаю в джунгли. Могу понять, что это место вызывает отвращение, но местная фауна меня не трогает...",
                "My mother was a well known herbalist back in the day. She doesn't talk about my father, though. I wonder why?" => "Моя мама в своё время была знаменитой травницей. О папе она, однако, никогда не говорит. Интересно, почему?",
                "The natural world is quite a wonder. Every little place has its own charm. Some more than others!" => "Мир природы действительно чудесен. Каждый уголок имеет своё очарование. В некоторых местах оно выражено сильнее, чем в других!",
                "Normally I'd say something like, 'nature finds a way', but I'm not even sure if Mother Nature could survive if you failed to stop those spirits' carnage... Please take these lilies, in gratitude for your courage!" => "Ну, обычно я бы сказал что-нибудь вроде «природа всегда находит путь», но я даже не уверен, что сама Мать-Природа смогла бы выжить, если бы ты не остановил бойню, учинённую этими духами... Прими эти лилии в благодарность за твою храбрость!",
                _ => chat
            };
            
            if (NPC.AnyNPCs(228))
            {
                if (chat == $"Our friend there, {GetNPCName(228)}, is rather strange isn't he? He speaks in riddles...")
                {
                    chat = $"Наш друг, {GetNPCName(228)}, какой-то странный, не находишь? Он постоянно говорит загадками...";
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
                chat = $"Как дела, {Main.LocalPlayer.name}? Не забудь остановиться и понюхать цветы!";
            }
            
            if (chat == $"Even a small seed can grow into a mighty oak! Keep that in mind, {Main.LocalPlayer.name}...")
            {
                chat = $"Даже маленький росток может вырасти в могучий дуб! Помни об этом, {Main.LocalPlayer.name}...";
            }
            
            if (chat == $"Defeating powerful monsters will make it safer for me to venture into different biomes in search of seeds. Check back with me regularly, {Main.LocalPlayer.name}!")
            {
                chat = $"Побеждая сильных монстров, я смогу безопасно путешествовать по биомам в поисках семян. Заглядывай ко мне почаще, {Main.LocalPlayer.name}!";
            }
        }

        if (npc.type == ModContent.NPCType<PeculiarMirror>())
        {
            chat = chat switch
            {
                "Before you sits a rather strange mirror. Something seems to be calling out from it...?" => "Перед тобой стоит странное зеркало. Кажется, кто-то зовёт из него?..",
                _ => chat
            };
        }
        
        if (npc.type == ModContent.NPCType<Spiritualist>())
        {
            chat = chat switch
            {
                "Is- Is that my cross? How in the world did you manage to find it? It's been lost for so long..." => "Это мой крест? Да ладно, как тебе удалось его найти? Я искал его столько лет...",
                "Beware my friend... true evil walks among us this night." => "Остерегайся, дружище... этой ночью истинное зло раскроет свою личину среди нас.",
                "Ah, it's been a while friend. It is good to see you are well after so long!" => "Эх, давненько не виделись, друг. Рад видеть, что ты в порядке после столь долгого времени!",
                "Whether in body, mind, or spirit, always consider how you may grow today, my friend." => "Будь то тело, разум или дух - всегда думай, как можешь расти сегодня, мой друг.",
                "Energy, chi, spirit... it's all the same to me. There is power in all things." => "Энергия, ци, дух... для меня это всё одно и то же. Везде есть сила.",
                "I have no doubt of your physical power, hero. But sometimes hardship is fought in a battle of will, not strength." => "Не сомневаюсь в твоей физической силе, герой. Но иногда трудности преодолеваются не силой, а силой воли.",
                "From the moment we first spoke I sensed something special within you. Your spirit exudes an incredible energy, one that I'm honored to have witnessed. Stay golden my friend." => "С первой нашей встречи я почувствовал в тебе что-то особенное. Твой дух излучает невероятную энергию, и я горд, что стал свидетелем этого. Оставайся таким же, дружище.",
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
                "Many beasts have fallen to me and my axe, but new ones are always on the prowl. Keep your eyes peeled, kid." => "Множество зверей пали от моего топора, но новые всегда наготове. Будь начеку, паренёк.",
                "You'd be surprised how effective a single shoulder pad can be." => "Ты удивишься, насколько эффективен всего один наплечник.",
                "A reality-ending nightmare entity, kid? You certainly don't cut corners, there's no way I can top that!" => "Ты реально победил сущность кошмаров, способную уничтожить реальность? Ты точно не из робкого десятка, я бы так не смог!",
                _ => chat
            };
            
            if (NPC.AnyNPCs(353))
            {
                if (chat == $"Do you think {GetNPCName(353)} would give a haircut even to a brute like me...?")
                {
                    chat = $"Как думаешь, {GetNPCName(353)} постриг бы даже такого грубияна, как я?..";
                }
            }
            
            if (NPC.AnyNPCs(550) && NPC.AnyNPCs(ModContent.NPCType<WeaponMaster>()))
            {
                if (chat == $"{GetNPCName(550)}, {GetNPCName(ModContent.NPCType<WeaponMaster>())}, and I were gonna start a gym together. You want in?")
                {
                    chat = $"Слушай, {GetNPCName(550)}, {GetNPCName(ModContent.NPCType<WeaponMaster>())} и я собираемся открыть тренажёрный зал. Присоединишься?";
                }
            }
        }
        
        if (npc.type == ModContent.NPCType<WeaponMaster>())
        {
            chat = chat switch
            {
                "Long ago, when this world was first taking form, my race reigned supreme. That time has passed it seems..." => "Давным-давно, когда этот мир только начинал формироваться, мой народ властвовал над всеми. Но, похоже, это время прошло...",
                "I'm not one for idle chatter. If you have need of me, make it quick." => "Я не из тех, кто любит праздные разговоры. Если тебе что-то нужно, говори быстро.",
                "My race's obsession with voodoo dolls has only become rampant just recently. It's truly a fad gone wrong..." => "Одержимость моего народа куклами вуду появилась совсем недавно. Это по-настоящему провалившийся тренд...",
                "Should you have the coin, I would be willing to accompany you in your endeavors..." => "Если у тебя есть деньги, я готов сопровождать тебя в твоих начинаниях...",
                "A warrior without his weapon stands no chance against the ever-powering threats he must face..." => "Воин без оружия не имеет шансов против постоянно растущих угроз, с которыми ему предстоит столкнуться...",
                _ => chat
            };
            
            if (chat == $"{GetNPCName(ModContent.NPCType<WeaponMaster>())} blankly stares through you, as though he's not entirely there...")
            {
                chat = $"{GetNPCName(ModContent.NPCType<WeaponMaster>())} смотрит на тебя пустым взглядом, словно его здесь нет...";
            }
            
            if (chat == $"*So... you've gained the ability to speak in tongues, {Main.LocalPlayer.name}? Very fascinating...*")
            {
                chat = $"*Итак... ты освоил способность говорить на разных языках, {Main.LocalPlayer.name}? Очень любопытно...*";
            }
            
            if (chat == $"Ie... oep'wl vmnjld hrl mfnbnho he iwlmc nj hejvpli, {Main.LocalPlayer.name}? Wlgo zmisnjmhnjv...")
            {
                chat = $"Ыщ... нщг'му пфштув еру фишдшен ещызуфл шт ещтпгуы, {Main.LocalPlayer.name}? Мукн афысштфештп...";
            }
            
            if (chat == $"I was exiled from my people when I chose to side with your kind. They thought me foolish, placing faith in those that dwelled above. I'm sure they're feeling rather foolish themselves after what you've just accomplished. Well done, {Main.LocalPlayer.name}.")
            {
                chat = $"Я был изгнан своим народом, когда встал на твою сторону. Они считали меня глупцом за то, что я доверился тем, кто живёт наверху. Теперь, наверное, они сами чувствуют себя глупцами после того, что ты только что совершил. Отличная работа, {Main.LocalPlayer.name}.";
            }
            
            if (NPC.AnyNPCs(22))
            {
                if (chat == $"{GetNPCName(22)} keeps giving me dirty looks... It's not like I carry a doll myself.")
                {
                    chat = $"{GetNPCName(22)} постоянно косится на меня... Да я же сам не таскаю эту куклу!";
                }
            }
        }

        if (npc.type == NPCID.Merchant)
        {
            chat = chat switch
            {
                "Ah, a man of music! How well can you carry a tune?" => "Да, ты, похоже, человек музыки! А как у тебя с голосом?",
                "Ah, a woman of music! How well can you carry a tune?" => "Да, ты, похоже, человек музыки! А как у тебя с голосом?",
                "You know, people would pay good money for quality music like yours. Care to hear my business proposition...?" => "Знаешь, за такую качественную музыку, как твоя, люди готовы платить хорошие деньги. Не хочешь услышать моё деловое предложение?..",
                "In my younger years I was quite the experienced bard too! I've since left that behind me, though." => "Да, в молодости я тоже был неплохим бардом! Но это всё уже позади.",
                "Amazing work, friend! I sold off all my 'end of the world' merchandise, and now thanks to you, I can actually live long enough to kick back and enjoy the benefits!" => "Отлично сработано, друг! Я распродал все свои товары для «конца света», и теперь, благодаря тебе, смогу прожить достаточно долго, чтобы расслабиться и насладиться всеми прелестями жизни!",
                _ => chat
            };
        }
        
        if (npc.type == NPCID.Nurse)
        {
            chat = chat switch
            {
                "Are you sure you really need my help healing you and your allies? You seem to have it under control..." => "Ты уверен, что тебе действительно нужна моя помощь в исцелении тебя и твоих союзников? Похоже, ты и сам справляешься.",
                "Another healer in town? Ugh, this will be bad for business..." => "Ещё один целитель в городе? Теперь придётся конкурировать за пациентов...",
                "I assume that you won't be having too many injuries from here on out? Shame, there goes my greatest money maker." => "Думаю, серьёзных травм у тебя теперь не будет? Жаль, ведь это был мой главный источник дохода.",
                _ => chat
            };
        }
        
        if (npc.type == NPCID.Mechanic)
        {
            chat = chat switch
            {
                "Say, if you're going to explore the dungeon, keep an eye out for this bizarre mirror. I only caught a glance at it while tied up, but it gave me serious heebie-jeebies..." => "Слушай, если ты собираешься исследовать Темницу, то смотри в оба за этим странным зеркалом. Я только краем глаза его увидел, пока был связан, но оно меня до чёртиков напугало...",
                "How I got kidnapped in the first place? One of their guys had crazy illusion magic, had me convinced I was being brought in to help install some new lighting!" => "А как меня вообще похитили? Один из их парней обладал сумасшедшей иллюзорной магией, и он убедил меня, что меня привезли помочь установить новое освещение!",
                "It seems like things are gonna be a lot more peaceful from here on out. Maybe now I can finally focus on my machines... and maybe someone special to me." => "Кажется, впереди нас ждёт мирная жизнь. Наконец-то смогу спокойно заняться своими механизмами... А может быть, и чем-то более личным.",
                _ => chat
            };
        }
        
        if (npc.type == NPCID.Pirate)
        {
            chat = chat switch
            {
                "Aye, so the legends be true... A great and terrible beast lurks beneath the depths, matey. Best if you go and handle it, eh?" => "Ага, значит, легенды правдивы... Великая и ужасная тварь таится в глубинах, приятель. Лучше тебе с ней разобраться, а?",
                "Aye, I once saw a sea demon risin' from those depths. Somethin' dark, somethin' ancient, somethin'... uhh... You gonna buy somethin'?!" => "Да, однажды я видел, как из глубин моря поднялся морской демон. Что-то тёмное, что-то древнее, что-то... э-э-э... Ты что-нибудь купишь?!",
                "Best be reckonin' that travelin' the seven seas will be smoother sailin' than a newborn's behind now that the Lady High Tide has been quell'd... And prob'ly high time for this ol' swashbuckler to set voyage for a new adventure!" => "Ну и дела! Теперь, когда Леди Прилив побеждена, путешествовать по семи морям будет проще, чем скользить по гладкому заду новорождённого. И, наверное, пора этому старому корсару отправиться в новое приключение!",
                _ => chat
            };
        }
        
        if (npc.type == NPCID.SkeletonMerchant)
        {
            chat = chat switch
            {
                "Got a special deal for ya, straight from this poor lot who wandered into that old Bat's lair unprepared." => "У меня для тебя специальное предложение, прямо от бедняги, который без подготовки забрёл в логово старой летучей мыши.",
                "You see lots when you wander these caverns, y'know? Other day I stumbled upon this chamber absolutely drenched in blood! Sight shook me to my bones, I'll tell you what!" => "Вот что бывает, когда бродишь по этим пещерам. То и дело наткнёшься на что-нибудь необычное. Вот на днях я набрёл на камеру, полностью залитую кровью! Меня аж до костей проняло, скажу тебе!",
                "Take a gander at that crown above your head! Just which poor sap did you nab that from?" => "Ты только взгляни на эту корону у себя на голове! У какого бедолаги ты её стащил?",
                _ => chat
            };
        }
        
        if (npc.type == NPCID.Angler)
        {
            chat = chat switch
            {
                "Yeah, yeah, everyone's going crazy over your 'saving the world' thing. But have you saved the 200 fancy fish I've asked for? If not then it's back to work, minion!" => "Да-да, все в восторге от твоего «спасения мира». А две сотни моих золотых рыбок ты спас? Нет? Тогда назад к работе, миньон!",
                "'Ocean Essences', huh? Do you think if I have enough, I'll become the Supreme God-Emperor of all Fishkind?! I've got a new quest for you, Supreme Helper Minion! Get for me 100 MILLION of those Ocean thingies, pronto!" => "Эссенции океана, говоришь? Думаешь, если у меня их будет достаточно, я стану Верховным Богом-Императором всех рыб? А ну-ка, Верховный помощник-миньон, живо добудь мне 100 МИЛЛИОНОВ этих штуковин, и быстро!",
                _ => chat
            };
            
            if (NPC.AnyNPCs(ModContent.NPCType<Cook>()))
            {
                if (chat == $"I couldn't believe my eyes when I saw {GetNPCName(ModContent.NPCType<Cook>())} walk into town! Now I can lounge back and let HIM do all the cooking!")
                {
                    chat = $"Я не мог поверить своим глазам, когда увидел, как {GetNPCName(ModContent.NPCType<Cook>())} зашёл в город! Теперь я могу расслабиться и позволить ему готовить за меня!";
                }
            }
        }
        
        if (npc.type == NPCID.ArmsDealer)
        {
            chat = chat switch
            {
                "Peace is all fine and dandy, but what am I supposed to use as target practice now?!" => "Мир - это, конечно, хорошо и прекрасно, но что мне теперь использовать в качестве мишени?!",
                _ => chat
            };
        }
        
        if (npc.type == NPCID.Clothier)
        {
            chat = chat switch
            {
                "Ever since you freed me from my curse, I figured you were tailor-made for this whole hero business." => "С тех пор как ты спас меня от проклятия, я понял, что ты просто рождён быть героем.",
                _ => chat
            };
        }
        
        if (npc.type == NPCID.Cyborg)
        {
            chat = chat switch
            {
                "Simply incredible. I had calculated your odds of survival at less than 0.001% against those creatures and yet here you stand. Truly the will of man is a thing of wonder." => "Просто невероятно. По моим расчётам, твои шансы на выживание против этих тварей были менее 0.001%, и всё же ты здесь. Воистину, сила человеческой воли - поразительная вещь.",
                _ => chat
            };
        }
        
        if (npc.type == NPCID.Demolitionist)
        {
            chat = chat switch
            {
                "What a series of fireworks that purple guy let out! Can't help but take it as a challenge; one pyrotechnics show that'll blow your socks off, comin' right up!" => "Ого, ну и фейерверк устроил этот фиолетовый парень! Не могу не принять это как вызов. Сейчас покажу такое пиротехническое шоу, что у тебя голова закружится!",
                _ => chat
            };
        }
        
        if (npc.type == NPCID.Dryad)
        {
            if (chat == $"To think a threat even more dangerous than the Moon Lord existed out there... It makes me wonder what else lies beyond what we see. Let's not worry about that for now though, {Main.LocalPlayer.name}, we should celebrate your victory!")
            {
                chat = $"Трудно поверить, что существует угроза, ещё более опасная, чем Лунный лорд. Заставляет задуматься, что ещё скрывается за пределами нашего понимания. Но сейчас не время об этом думать, {Main.LocalPlayer.name}. Мы должны отпраздновать твою победу!";
            }
        }
        
        if (npc.type == NPCID.DyeTrader)
        {
            chat = chat switch
            {
                "Ah... must you keep that crown above your head, darling? The colors are rich, but its aesthetic is... garish." => "Ах... тебе обязательно носить эту корону, дорогуша? Цвета, конечно, шикарные, но выглядит это... безвкусно.",
                _ => chat
            };
        }
        
        if (npc.type == NPCID.GoblinTinkerer)
        {
            chat = chat switch
            {
                "I thought for sure we were all doomed when those creatures emerged so I jumped the gun on a confession of mine. It ended up working out though, so maybe I'm glad we almost all died!" => "Когда появились эти существа, я был уверен, что нам всем конец, поэтому поспешил с одним признанием. Но всё обошлось, так что, может, я даже рад, что мы едва не погибли!",
                _ => chat
            };
        }
        
        if (npc.type == NPCID.Painter)
        {
            if (chat == $"Not another word, {Main.LocalPlayer.name}! I'm already starting my newest masterpiece: a capturing of your stupendous battle!")
            {
                chat = $"Ни слова больше, {Main.LocalPlayer.name}! Я уже начал работать над своим новым шедевром: запечатлением твоего грандиозного сражения!";
            }
        }
        
        if (npc.type == NPCID.PartyGirl)
        {
            chat = chat switch
            {
                "That crown! Does that mean you're now the KING OF THE UNIVERSE?! Do you know what this calls for?! The greatest coronation party EVER!!" => "Эта корона! Ты что, теперь КОРОЛЬ ВСЕЛЕННОЙ?! Знаешь, что это значит? Самую грандиозную коронационную вечеринку в истории!!!",
                "That crown! Does that mean you're now the QUEEN OF THE UNIVERSE?! Do you know what this calls for?! The greatest coronation party EVER!!" => "Эта корона! Ты что, теперь КОРОЛЕВА ВСЕЛЕННОЙ?! Знаешь, что это значит? Самую грандиозную коронационную вечеринку в истории!!!",
                _ => chat
            };
        }
        
        if (npc.type == NPCID.Princess)
        {
            if (chat == $"Thank you, {Main.LocalPlayer.name}, from the bottom of my heart. It's thanks to you that my subjects and I can enjoy peace and prosperity once more. You're my knight in shining armor!")
            {
                chat = $"Спасибо тебе, {Main.LocalPlayer.name}, от всего сердца. Благодаря тебе мои подданные и я снова можем наслаждаться миром и процветанием. Ты мой рыцарь в сияющих доспехах!";
            }
        }
        
        if (npc.type == NPCID.SantaClaus)
        {
            chat = chat switch
            {
                "If saving the world doesn't make you a good boy, then I don't know what does. No coal for you this year!" => "Если спасение мира не делает тебя хорошим мальчиком, то я даже не знаю, что тогда. В этом году угля не будет!",
                "If saving the world doesn't make you a good girl, then I don't know what does. No coal for you this year!" => "Если спасение мира не делает тебя хорошей девочкой, то я даже не знаю, что тогда. В этом году угля не будет!",
                _ => chat
            };
        }
        
        if (npc.type == NPCID.Steampunker)
        {
            chat = chat switch
            {
                "An endless source of fire and water fell from those creatures you say? Oy, that sounds like a great way to generate some steam!" => "Бесконечный источник огня и воды от тех существ, говоришь? Оу, да это же отличный способ генерировать пар!",
                _ => chat
            };
        }
        
        if (npc.type == NPCID.Stylist)
        {
            chat = chat switch
            {
                "Wasn't aware the primordial forces of Terraria had a sense of humor. 'I saved the world and all I got was this gaudy crown' and all that, right hun?" => "И не знала, что первозданные силы Террарии обладают чувством юмора. «Спас мир, а в награду - безвкусная корона». Да уж, правда ведь?",
                _ => chat
            };
        }
        
        if (npc.type == NPCID.DD2Bartender)
        {
            chat = chat switch
            {
                "Well now. Even back in Etheria I haven't seen a hero defend their home with such bravery and tenacity before. Maybe you do measure up after all." => "Ну что ж. Даже в Этернии я не видел, чтобы герой защищал свой дом с такой отвагой и упорством. Может, ты и вправду чего-то стоишь.",
                _ => chat
            };
        }
        
        if (npc.type == NPCID.TaxCollector)
        {
            chat = chat switch
            {
                "I see that fancy crown above your head, alright. Bah! You already acted like a despot, now you have the looks to back it up. Just separate me from my lovely gold and leave!" => "Вижу эту вычурную корону над твоей головой, да-да. Ха! Ты и раньше вёл себя как деспот, а теперь ещё и выглядишь соответственно. Просто отдай моё драгоценное золото и проваливай!",
                _ => chat
            };
        }
        
        if (npc.type == NPCID.TravellingMerchant)
        {
            chat = chat switch
            {
                "Hey, I'm back in town! Did I miss anything exciting...?" => "Эй, я вернулся в город! Я что-нибудь интересное пропустил?..",
                _ => chat
            };
        }
        
        if (npc.type == NPCID.Truffle)
        {
            chat = chat switch
            {
                "I would have never seen the things I've seen recently if I had stayed underground, so thank you for that wonderful - and totally not at all terrifying - show!" => "Если бы я остался под землёй, я бы никогда не увидел того, что видел недавно. Спасибо за это удивительное и совершенно не пугающее представление!",
                _ => chat
            };
        }
        
        if (npc.type == NPCID.WitchDoctor)
        {
            chat = chat switch
            {
                "Heroism inspires legends, legends inspire heroism." => "Героизм рождает легенды, а легенды вдохновляют на подвиги.",
                _ => chat
            };
        }
        
        if (npc.type == NPCID.Wizard)
        {
            chat = chat switch
            {
                "Everyone is quite lively right now! I'm so glad all of you remembered that today was my birthday!" => "Все сегодня такие оживлённые! Я так рад, что вы не забыли, что сегодня мой день рождения!",
                _ => chat
            };
        }
        
        if (npc.type == NPCID.BestiaryGirl)
        {
            chat = chat switch
            {
                "Okay, like, wait. One more time. You say there were three of them? Okay yeah, and what did they look like exactly? Like, for real? This bestiary entry is gonna really test my drawing skills, huh?" => "Ладно, ладно, давай ещё раз. Ты говоришь, их было трое? Хорошо, и как они выглядели? Ну, по-настоящему? Эта запись в бестиарии точно станет испытанием моих художественных навыков, ага?",
                _ => chat
            };
        }
        
        if (npc.type == NPCID.Guide)
        {
            chat = chat switch
            {
                "I see you've got yourself an instrument. Instruments use ‘inspiration’ to provide helpful buffs to you and your team, as well as damage enemies. You’ll need Inspiration Fragments to increase your maximum inspiration, which can be crafted from fallen stars and a strange ore underground! Who knows, maybe later on you can increase it even more with other unique materials..." => "Вижу, ты обзавёлся инструментом! Инструменты используют «вдохновение», чтобы давать тебе и твоей команде полезные усиления, а также наносить урон врагам. Чтобы повысить максимальный запас вдохновения, тебе понадобятся осколки вдохновения. Их можно изготовить из упавших звёзд и странной руды, найденной под землёй! Кто знает, может, позже ты сможешь увеличить его ещё больше с помощью других редких материалов...",
                "Congratulations on your victory! I'm sure you've already noticed, but each of the primordial spirits left behind part of their essence over the domain they control after you defeated them. They're as powerful as they sound, and you can make some extremely potent gear with them. As always, I can help you see what you can craft with them!" => "Поздравляю с победой! Наверняка ты уже заметил, что после их поражения каждый из первородных духов оставил частицу своей сущности в подвластном ему домене. Эти сущности столь же могущественны, как это звучит, и с их помощью можно создать невероятно мощное снаряжение. Как всегда, я могу показать тебе, что можно из них изготовить!",
                _ => chat
            };
        }
        
        if (npc.type == NPCID.Golfer)
        {
            if (chat == $"I'd say that battle looked like a hole in one to me, {Main.LocalPlayer.name}. Maybe you can finally relax after all that ceaseless fighting and play some golf with me; What do you say?")
            {
                chat = $"Могу сказать, эта битва была как хоул-ин-ван для нас, {Main.LocalPlayer.name}. Как насчёт того, чтобы наконец расслабиться после всех этих непрекращающихся сражений и сыграть со мной в гольф?";
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
                Main.npcChatText = $"Ну вот, {Main.LocalPlayer.name}, ты как новенький. Это, конечно, ненадолго, но по крайней мере ты снова сможешь двигаться. Главное - быть осторожным, герой!";
            }
        }

        if (npc.type == ModContent.NPCType<Cook>())
        {
            Main.npcChatText = Main.npcChatText switch
            {
                "This crisp morel was just asking to be put in a dish. I hope it's to your liking!" => "Этот свежий сморчок так и просит стать блюдом. Надеюсь, тебе понравится!",
                "Pink pears can be problematic if prepared improperly. Good thing I'm a professional pear pickler!" => "Розовые груши могут быть проблемными, если их неправильно приготовить. Хорошо, что я профессионал по консервированию груш!",
                "Well uh... I DID cook it, though I'm not entirely sure you should eat this stuff." => "Ну... я-то его ПРИГОТОВИЛ, но не уверен, что тебе стоит это есть.",
                "With just the right amount of green, this dish gets real mean. Be careful eating it!" => "Это блюдо с достаточным количеством зелени становится реально острым. Будь осторожен, когда будешь есть!",
                "I had to visit a far away land to learn how to make this dish. Hopefully you'll appreciate it!" => "Я ездил в далёкую страну, чтобы научиться готовить это блюдо. Надеюсь, ты оценишь!",
                "When I was younger, my mother would always greet me with some mint tea after a long, hard day... I miss the simpler times." => "Когда я был моложе, мама всегда встречала меня с чашкой мятного чая после долгого, трудного дня... Я скучаю по тем временам.",
                "Yunno, it's not just called a 'Sky Blue Flower' because of its color. Some say they've fallen from the sky islands themselves long ago." => "Знаешь, это растение называется небесно-голубой цветок не только из-за цвета. Говорят, что они когда-то давно упали с небесных островов.",
                "Last time I took a bite of this stuff, I started thinking everything was out to get me... but hey, maybe that's what you're looking for?" => "В последний раз, когда я откусил кусочек этой штуки, я начал думать, что всё вокруг хочет меня схватить... но погоди, может, это именно то, что ты ищешь?",
                "Ah, just what I need to help ripen this cheese! Hopefully this'll offer a little more 'pizazz' to its taste." => "Отлично, это то, что мне нужно, чтобы сыр созрел! Надеюсь, это придаст немного «пикантности» его вкусу.",
                "I'm honored that you'd trust me with such rare commodities. Hopefully this new recipe suits your fancy!" => "Для меня большая честь, что ты доверил мне такие редкие ингредиенты. Надеюсь, этот новый рецепт тебе понравится!",
                "I myself don't know much about the Hallow, it's a rather strange place... but berries are berries, right?" => "Я сам мало что знаю об освящении, это довольно странное место... но ягоды есть ягоды, правда?",
                "So the legends are true... The kitchen scholars thought this recipe was lost to time, but it's right in front of me. I can barely contain my excitement to try it out!" => "Значит, легенды правдивы... Кухонные учёные думали, что этот рецепт утерян во времени, но он прямо передо мной. Я едва сдерживаю волнение, чтобы попробовать его!",
                "I can tell this was written by an ogre... still, the pictures give me a clear idea on how to brew this. Be careful with this stuff, it's highly potent!" => "Этот рецепт явно написан огром... тем не менее, по картинкам становится понятно, как его готовить. Будь осторожен с этим, оно очень крепкое!",
                "Leaves? You want me to cook some food... with leaves? Well, I don't think these would really work in a salad, so how about some tea instead? I'm sure it will calm you down if you're stressed." => "Листья? Ты хочешь, чтобы я приготовил еду... из листьев? Ну, я не думаю, что они подойдут для салата, так что как насчёт чая? Он поможет тебе расслабиться, если ты переживаешь.",
                "These were exactly what I was missing for my special hot chocolate recipe! If you're planning on going somewhere a little chilly, these will warm you right up for sure." => "Это именно то, чего мне так не хватало для моего фирменного горячего шоколада! Если ты собираешься в какое-нибудь прохладное место, он точно согреет тебя.",
                "Looks like you don't have any ingredients in your bag. If you can find enough of an ingredient I'm looking for, I can supply you with new purchasable foods. Some of these dishes will be far more powerful than my usual wares, so keep your eyes peeled for unique ingredients!" => "Похоже, в твоей сумке нет ингредиентов. Если найдёшь нужное количество ингредиентов, я смогу предложить тебе новые блюда. Некоторые из них будут гораздо мощнее моих обычных товаров, так что будь внимателен к уникальным ингредиентам!",
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
                "Although I'm only an acolyte, one of the first things we learn is how to create a sandstorm. Beware the creatures that lurk within however..." => "Хоть я всего лишь послушник, однако одним из первых навыков, которым нас учат, является создание песчаных бурь. Тем не менее, будь осторожен с существами, скрывающимися внутри...",
                "Creating a sandstorm is a very taxing job. I would prefer to have some compensation in the form of money, please." => "Создание песчаных бурь - довольно утомительное занятие. Мне бы хотелось получить за это какую-то компенсацию, например, деньги.",
                _ => Main.npcChatText
            };
        }
        
        if (npc.type == ModContent.NPCType<Diverman>())
        {
            Main.npcChatText = Main.npcChatText switch
            {
                "Here you go friend! This air tank will automatically activate when your breath reaches critical level. Come visit me afterwards and I'll refill it free of charge!" => "Вот, держи, дружище! Этот баллон с воздухом автоматически активируется, когда твой запас воздуха достигнет критического уровня. Потом заходи ко мне, я бесплатно его заправлю!",
                "Hmm, your air tank looks full to me... Did you just want to chat? I have all manner of tales to tell!" => "Хм, твой баллон с воздухом выглядит полным... Ты просто хочешь поболтать? У меня полно историй, которые я могу рассказать!",
                _ => Main.npcChatText
            };
        }
        
        if (npc.type == ModContent.NPCType<Spiritualist>())
        {
            Main.npcChatText = Main.npcChatText switch
            {
                "I'm afraid I can't currently protect you, friend. Give your soul some time to heal, and then come speak to me again." => "Слушай, друг, сейчас я не могу тебя защитить. Дай своей душе время залечиться, а потом вернись ко мне.",
                "With these shards, I have imbued you with an incredibly potent shield. Should you take fatal damage, you shall receive my protection for as long as I can hold it. Stay safe out there, my friend." => "С этими осколками я наделил тебя невероятно мощным щитом. Если ты получишь смертельное ранение, ты будешь под моей защитой до тех пор, пока я смогу её удерживать. Береги себя, мой друг.",
                "I require no money to watch over you my friend, but my protection is limited without some Purified Shards. Once you acquire 5, come visit me again." => "Я не беру с тебя денег за свою защиту, друг мой, но без очищенных осколков моя сила ограничена. Как только наберёшь 5 штук, возвращайся ко мне снова.",
                "No need to fear my friend, my power is already protecting you. Come back when my power has faded." => "Не бойся, друг, моя сила уже защищает тебя. Вернись, когда она угаснет.",
                _ => Main.npcChatText
            };
        }
        
        if (npc.type == ModContent.NPCType<WeaponMaster>())
        {
            Main.npcChatText = Main.npcChatText switch
            {
                "I see you're lacking in coin. Remedy that and I may just help you out..." => "Как вижу, у тебя не хватает денег. Исправь это, и я, возможно, помогу тебе...",
                _ => Main.npcChatText
            };
            
            if (Main.npcChatText == $"{GetNPCName(ModContent.NPCType<WeaponMaster>())} blankly stares through you, as though he's not entirely there...")
            {
                Main.npcChatText = $"{GetNPCName(ModContent.NPCType<WeaponMaster>())} смотрит на тебя пустым взглядом, словно он не здесь...";
            }
        }
    }
}