using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardville.Cards;

namespace Cardville.Engine
{
    public class GameData
    {
        public Dictionary<GameObjectType, List<CardTemplate>> CardTemplatesOfType
            = new Dictionary<GameObjectType, List<CardTemplate>>()
            {
                {
                    GameObjectType.Monster,
                    new List<CardTemplate>()
                    {
                        new CardTemplate()
                        {
                            ID = 11,
                            Name = "Болтающаяся голова",
                            Description = "",
                            CardType = GameObjectType.Monster,
                            Rarity = Rarity.Common
                        },
                        new CardTemplate()
                        {
                            ID = 12,
                            Name = "Слизь",
                            Description = "",
                            CardType = GameObjectType.Monster,
                            Rarity = Rarity.Common
                        },
                        new CardTemplate()
                        {
                            ID = 13,
                            Name = "Газебо",
                            Description = "Никто тебе не поможет. \n" +
                            "Настоящий Манчкин должен разбираться с Газебо один на один",
                            CardType = GameObjectType.Monster,
                            Rarity = Rarity.Rare
                        },
                        new CardTemplate()
                        {
                            ID = 14,
                            Name = "Белые братья",
                            Description = "Андеды",
                            CardType = GameObjectType.Monster,
                            Rarity = Rarity.Transcendent
                        },
                        new CardTemplate()
                        {
                            ID = 15,
                            Name = "Гидра",
                            Description = "",
                            CardType = GameObjectType.Monster,
                            Rarity = Rarity.Epic
                        },
                        new CardTemplate()
                        {
                            ID = 16,
                            Name = "Г-н Костин",
                            Description = "Андед",
                            CardType = GameObjectType.Monster,
                            Rarity = Rarity.Common
                        },
                        new CardTemplate()
                        {
                            ID = 17,
                            Name = "Гиппогриф",
                            Description = "",
                            CardType = GameObjectType.Monster,
                            Rarity = Rarity.Legendary
                        },
                        new CardTemplate()
                        {
                            ID = 19,
                            Name = "Глазастый Гриб",
                            Description = "Если гриб станет Амбалом, он получит не +10, а +25! \n" +
                            "Не связывайтесь с грибным Амбалом.",
                            CardType = GameObjectType.Monster,
                            Rarity = Rarity.Uncommon
                        },
                        new CardTemplate()
                        {
                            ID = 18,
                            Name = "Плутониевый Дракон",
                            Description = "",
                            CardType = GameObjectType.Monster,
                            Rarity = Rarity.Mythical
                        },
                        new CardTemplate()
                        {
                            ID = 20,
                            Name = "Король Тут",
                            Description = "Андед",
                            CardType = GameObjectType.Monster,
                            Rarity = Rarity.Relict
                        },
                        new CardTemplate()
                        {
                            ID = 21,
                            Name = "Кровожадина",
                            Description = "",
                            CardType = GameObjectType.Monster,
                            Rarity = Rarity.Rare
                        },
                        new CardTemplate()
                        {
                            ID = 22,
                            Name = "Калли",
                            Description = "",
                            CardType = GameObjectType.Monster,
                            Rarity = Rarity.Godly
                        },
                    }
                },

                {
                    GameObjectType.Equipment,
                    new List<CardTemplate>()
                    {
                        new CardTemplate()
                        {
                            ID = 01,
                            Name = "Вездешний щит",
                            Description = "",
                            CardType = GameObjectType.Equipment,
                            Rarity = Rarity.Legendary
                        },
                        new CardTemplate()
                        {
                            ID = 02,
                            Name = "Бензопила кровавого расчленения",
                            Description = "",
                            CardType = GameObjectType.Equipment,
                            Rarity = Rarity.Epic
                        },
                        new CardTemplate()
                        {
                            ID = 03,
                            Name = "Крыса на палочке",
                            Description = "",
                            CardType = GameObjectType.Equipment,
                            Rarity = Rarity.Common
                        },
                        new CardTemplate()
                        {
                            ID = 04,
                            Name = "Башмаки могучего пенделя",
                            Description = "",
                            CardType = GameObjectType.Equipment,
                            Rarity = Rarity.Rare
                        },
                        new CardTemplate()
                        {
                            ID = 05,
                            Name = "Бюджетная броня",
                            Description = "",
                            CardType = GameObjectType.Equipment,
                            Rarity = Rarity.Common
                        },
                        new CardTemplate()
                        {
                            ID = 07,
                            Name = "Одиннадцатифунтовый шест",
                            Description = "",
                            CardType = GameObjectType.Equipment,
                            Rarity = Rarity.Uncommon
                        },
                        new CardTemplate()
                        {
                            ID = 06,
                            Name = "Боевая стремянка",
                            Description = "",
                            CardType = GameObjectType.Equipment,
                            Rarity = Rarity.Uncommon
                        },
                        new CardTemplate()
                        {
                            ID = 08,
                            Name = "Меч Рубящий Что Угодно Кроме Кальмаров",
                            Description = "",
                            CardType = GameObjectType.Equipment,
                            Rarity = Rarity.Mythical
                        },
                        new CardTemplate()
                        {
                            ID = 09,
                            Name = "Мифрильная броня",
                            Description = "",
                            CardType = GameObjectType.Equipment,
                            Rarity = Rarity.Transcendent
                        },
                        new CardTemplate()
                        {
                            ID = 010,
                            Name = "Колготы великанской силы",
                            Description = "",
                            CardType = GameObjectType.Equipment,
                            Rarity = Rarity.Relict
                        },
                        new CardTemplate()
                        {
                            ID = 011,
                            Name = "Очень святая книга",
                            Description = "",
                            CardType = GameObjectType.Equipment,
                            Rarity = Rarity.Godly
                        },
                    }
                }
            };
    }
}
