using System;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            foreach (var bannedWord in bannedWords)
            {
                string replacedAsteriks = new string('*', bannedWord.Length);
                text = text.Replace(bannedWord, replacedAsteriks);
            }
            Console.WriteLine(text);
        }
    }
}
