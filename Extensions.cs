using System;
using System.Collections.Generic;

namespace deckofcards
{
    public static class CardGameExtensions
    {
        private static Random rng = new Random(); 
        public static void Shuffle(this IList<int> list)
        {
            int n = list.Count;  
            while (n > 1) {  
            n--;  
            int k = rng.Next(n + 1);  
            int value = list[k];  
            list[k] = list[n];  
            list[n] = value;  
            } 
        }
    }
}