using System;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly input your sentence below :");
            string sentence = Console.ReadLine();
            int count = WordCountProcessor(sentence);
            Console.WriteLine($"The sentence you entered has {count} words in it");
        }

        static int WordCountProcessor(string input)
        {
            int result = 0;

            // Remove all whitespace
            string newSenctence = input.Trim();

            // Check if entry is null and return a defaut value
            if (newSenctence == "")
                return 0;

            

            foreach (string word in newSenctence.Split(' '))
            {
                result++;
            }
            return result;
        }
    }
}
