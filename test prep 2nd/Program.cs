using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_prep_2nd
{
    class Program
    {
        static void Main(string[] args)
        {
            Program a = new Program();
            Console.WriteLine("The Longest word is :");
            Console.WriteLine(a.MyFunctionA("Ada Lovelace wrote the first alogirithm designed for processing by an Analytical Engine."));
        }
        public MyFunctionA(string input)
        {
            //Write a C# program to find the longest word in a string.
            string[] words = input.Split('');

            int wordArrayLength = wordLength.Length;
            int[] wordsLength = new int[wordArrayLength];
            int x = 0;
            foreach (var word in words)
            {
                //TODO
            }
            string currentWord = words[0];
            string nextWord = currentWord;
            string longestword = currentWord;
            for ( int y=0; y<words.Length-1;y++)
            {
                currentWord = words[y];
                nextWord = words[y+1];
            }

        }

        
    }
}
