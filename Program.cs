using System;
using System.Collections.Generic;

namespace deckofcards
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            string userInput = string.Empty;
            CardDeck game = new CardDeck();

            Console.WriteLine("Welcome to the game - Deck of Cards");
            do{          
            //User can only restart or exit when he has run out of cards     
            if(game.CanContinue())
            {    
                Console.WriteLine("Press 1 to Play a card");
                Console.WriteLine("Press 2 to Shuffle the deck");
            }
            Console.WriteLine("Press 3 to Restart the game");
            Console.WriteLine("Press any other key to EXIT");
            userInput = Console.ReadLine();
            int selectedOption = 0;
            Int32.TryParse(userInput, out selectedOption);
            //User can only restart or exit when he has run out of cards  
            selectedOption = !game.CanContinue() && selectedOption != 3 ? 0 : selectedOption;
            switch(selectedOption)
            {
                case 1: Console.WriteLine(game.Play());break;
                case 2: game.Shuffle();Console.WriteLine("Card shuffle successful\n"); break;
                case 3: game = new CardDeck(); Console.WriteLine("Card deck has been reset successfully\n"); break;
                default: return;
            }
            if(!game.CanContinue())
                Console.WriteLine("You have run out of cards");
            Console.WriteLine("");
            }while (true);
             
        }
       

}
}
