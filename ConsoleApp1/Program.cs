using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            string[] words = 
            {
                "APPLE", "HOUSE", "MOUSE", "TRAIN", "PLANE", "BEACH", "CLOUD", "DREAM",
                "EARTH", "FLAME", "GRAPE", "HEART", "IVORY", "JELLY", "KNIFE", "LEMON",
                "MUSIC", "NIGHT", "OCEAN", "PIANO", "QUEEN", "RIVER", "STORM", "TABLE",
                "VOICE", "WATER", "YOUTH", "ZEBRA", "BREAD", "CHAIR", "DANCE", "EAGLE",
                "FROGS", "GHOST", "HONEY", "JUICE", "KITES", "LIGHT", "MAGIC", "NURSE",
                "OLIVE", "PAPER", "QUIET", "RADIO", "SNAKE", "TIGER", "UNCLE", "WITCH",
                "YACHT", "ZESTY", "BLOOM", "CRISP", "DWARF", "ELBOW", "FLUTE", "GLOVE",
                "HATCH", "IGLOO", "JOKER", "KOALA", "LUNAR", "MANGO", "NOBLE", "OASIS",
                "PLUSH", "QUILT", "ROBOT", "SWIRL", "TULIP", "URBAN", "VENOM", "WALTZ",
                "YUMMY", "BLISS", "CRAVE", "DROOP", "EERIE", "FLAKY", "GIDDY", "HOARD",
                "JAZZY", "KAYAK", "LUCKY", "MOODY", "NERDY", "ONION", "PLUMP", "QUIRK",
                "ROAST", "SPICY", "TROUT", "UNZIP", "VAGUE", "WHISK", "YIELD", "ACORN",
                "BROOM", "CLOWN", "DAISY", "FROST", "GREEN", "HAPPY", "JUMBO", "MELON",
                "NORTH", "PEACH", "QUICK", "SUNNY", "THUMB", "WAGON"
            };

            string word = "QUICK";//words[random.Next(0, words.Length)];

            string newString = "";
            
            while(word.Length > 0)
            {                
                char c = word[random.Next(0, word.Length)];              
                
                newString += c;

                word = word.Replace(Convert.ToString(c), string.Empty);

                
            }
            
            Console.WriteLine($"Scrambled Word: {newString}");
            
            string userGuess = "";

            int numberOfTries = 0;
            
            while(userGuess != word)
            {
                numberOfTries++;
                Console.Write("Guess the word: ");  userGuess = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(newString);

            }

            Console.WriteLine($"You Won! It took you: {numberOfTries} tries");
            
            Console.ReadKey();
        }
    }
}
