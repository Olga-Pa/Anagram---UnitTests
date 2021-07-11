using System;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Type the string you would to reverse.");
            var tryMe = Console.ReadLine();
            Anagram anagram = new Anagram();
            Console.WriteLine("This is the result: " + anagram.Reverse(tryMe));
        }
    }
}
