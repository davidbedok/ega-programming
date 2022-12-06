using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunCard
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random generator = new Random();

            
            Console.WriteLine("----- C A R D ------");
            Card card = new Card(CardSuit.Acorns, CardRank.r9);
            Console.WriteLine(card);
            Console.WriteLine(card.GetValue());

            Console.WriteLine(card.Rank);
            card.Rank = CardRank.Ace;
            card.SetRank(CardRank.Ace);

            Console.WriteLine("----- D E C K ------");
            
            Deck deck = new Deck(generator);
            Console.WriteLine(deck);

            deck.Shuffle();
            Console.WriteLine(deck);
            Console.WriteLine(deck.GetTopCard());
            Console.WriteLine(deck.GetTopCard());
            Console.WriteLine(deck.GetTopCard());
            Console.WriteLine(deck.GetTopCard());
            

            Console.WriteLine("----- P L A Y E R ------");
            Player ply = new Player("Anakin Skywalker");
            
            ply.AddCard(new Card(CardSuit.Acorns, CardRank.r9));
            // ply[0] = new Card(CardSuit.Acorns, CardRank.r9);

            ply.AddCard(new Card(CardSuit.Bells, CardRank.Ace));
            Console.WriteLine(ply);
            Console.WriteLine(ply.GetCardsValue());



            

            Console.WriteLine("----- G A M E ------");

            Console.WriteLine("# Test Game class");
            Game game = new Game(generator, 4);
            game.AddPlayer("Terence Hill");
            game.AddPlayer(new Player("Bud Spencer"));
            game.AddPlayer("Darth Vader");
            game.AddPlayer("Anakin Skywalker");
            game.AddPlayer("No More");

            Int32 s = new Int32();
            s++;

            Console.WriteLine("------ WINNER ------");
            Console.WriteLine(game.Play());
            Console.WriteLine("------ GAME ------");
            Console.WriteLine(game);

            Console.ReadKey();
            Console.WriteLine("------ Third Player Second Card ------");
            Console.WriteLine(game[2][1]);

        }
    }
}
