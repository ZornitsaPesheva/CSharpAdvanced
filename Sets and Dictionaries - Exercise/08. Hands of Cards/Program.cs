using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = new Dictionary<string, List<string>>();
            string entry = "";

            while (!entry.Equals("JOKER"))
            {
                entry = Console.ReadLine();
                string playerName = "";
                List<string> cards = new List<string>();

                if (!entry.Equals("JOKER"))
                {
                    var entryArr = entry.Split(':').ToArray();
                    playerName = entryArr[0];
                    var playerCards = entryArr[1];
                    cards = playerCards.Split(',').ToList();
                }
                if (playerName != "")
                {
                    if (!players.ContainsKey(playerName))
                    {
                        players[playerName] = cards;
                    }
                    else
                    {
                        List<string> c = players[playerName];
                        var cardList = c.Concat(cards);
                        players[playerName] = cardList.ToList();
                    }
                }
            }

            foreach (var pl in players)
            {
                var cards = pl.Value.Distinct().ToList();
                var points = SumCards(cards);
                Console.WriteLine($"{pl.Key}: {points}");
            }
        }

        private static int SumCards(List<string> cards)
        {
            int sum = 0;
            for (int i = 0; i < cards.Count; i++)
            {
                string card = cards[i];
                int p = 1;
                int t = 1;
                switch (card[1])
                {
                    case '1':
                        p = 10;
                        break;
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        p = int.Parse(card[1].ToString());
                        break;
                    case 'J':
                        p = 11;
                        break;
                    case 'Q':
                        p = 12;
                        break;
                    case 'K':
                        p = 13;
                        break;
                    case 'A':
                        p = 14;
                        break;
                }
                switch (card[card.Length - 1])
                {
                    case 'S':
                        t = 4;
                        break;
                    case 'H':
                        t = 3;
                        break;
                    case 'D':
                        t = 2;
                        break;
                    case 'C':
                        t = 1;
                        break;
                }
                sum += p * t;
            }
            return sum;
        }
    }
}
