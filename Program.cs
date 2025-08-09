using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            List<string> modifiedWords = new List<string>();
            int numberOfWords = 5;

            Console.WriteLine("Enter a list of words");

            for (int i = 0; i < numberOfWords; i++)
            {
                Console.Write($"Word {i + 1}: ");
                string word = Console.ReadLine();
                words.Add(word);
            }
            foreach (var word in words)
            {
                string modifiedWord = ReplaceVowels(word);
                modifiedWords.Add(modifiedWord);
            }
            Console.WriteLine("\nOriginal and Modified Words:");
            Console.WriteLine("Original\tModified");
            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine($"{words[i]}\t\t{modifiedWords[i]}");
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        static string ReplaceVowels(string word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            foreach (var vowel in vowels)
            {
                word = word.Replace(vowel, '*');
            }
            return word;
        }
    }
}
    
            