using System;
using System.Net;

namespace WordConjugation
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Név: ");
            string name = Console.ReadLine();

            string modifiedWord = AddConjuctionForWord(name);

            Console.WriteLine("Ragozva: " + modifiedWord);

            Console.WriteLine("Amikor " + AddConjuctionForWord(name) + " szüksége volt egy eszközre.");
        }

        private static string AddConjuctionForWord( string word )
        {
            string result;
            int numberOfDeepVowels = GetNumberOfDeepVowels(word);
            int numberOfHighVowels = GetNumberOfHighVowels(word);

            Console.WriteLine("Deep: " + numberOfDeepVowels);
            Console.WriteLine("High: " + numberOfHighVowels);

            if (numberOfDeepVowels >= numberOfHighVowels)
            {
                result = "nak";
            } else
            {
                result = "nek";
            }
            return word + result;
        }

        private static int GetNumberOfDeepVowels(string word) {
            int result = 0;
            char[] letters = word.ToLower().ToCharArray();
            for ( int i = 0; i < letters.Length; i++ )
            {
                char current = letters[i];
                if ( current == 'a' || current == 'á' || current == 'o' || current == 'ó' || current == 'u' || current == 'ú' )
                {
                    result++;
                }
            }
            return result;
        }

        private static int GetNumberOfHighVowels(string word)
        {
            int result = 0;
            char[] letters = word.ToLower().ToCharArray();
            for (int i = 0; i < letters.Length; i++)
            {
                char current = letters[i];
                if (current == 'e' || current == 'é' || current == 'i' || current == 'í' || current == 'ö' || current == 'ő' || current == 'ü' || current == 'ű')
                {
                    result++;
                }
            }
            return result;
        }

    }
}
