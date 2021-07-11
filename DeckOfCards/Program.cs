using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------Deck Of Cards---------------------------------");
            Box box = new Box();

            Console.WriteLine(" No. of Cards : " + box.cards.Count);

            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");
            Player player3 = new Player("Player 3");
            Player player4 = new Player("Player 4");
            for (int i = 1; i < 10; i++)
            {
                player1.draw(box);
                player2.draw(box);
                player3.draw(box);
                player4.draw(box);
            }
            Console.WriteLine("\n------------------- Player 1 Number of Cards : " + player1.hand.Count + " ----------------------");
            ShowCards(player1);
            Console.WriteLine("\n------------------- Player 2 Number of Cards : " + player2.hand.Count + " ----------------------");
            ShowCards(player2);
            Console.WriteLine("\n------------------- Player 3 Number of Cards : " + player3.hand.Count + " ----------------------");
            ShowCards(player3);
            Console.WriteLine("\n------------------- Player 4 Number of Cards : " + player4.hand.Count + " ----------------------");
            ShowCards(player4);
        }

        public static void ShowCards(Player player)
        {
            foreach (Card list in player.hand)
            {
                Console.WriteLine("\nCard Value : " + list.cardValue);
                Console.WriteLine("Symbol : " + list.symbol);
                Console.WriteLine("Card : " + list.value);
            }
        }


    }
    
}
