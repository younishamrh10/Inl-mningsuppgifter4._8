using System;

namespace Inlämningsuppgifter4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in en sträng: ");
            string inputStr = Console.ReadLine();

            if (inputStr.Length < 2)
            {
                Console.WriteLine("Strängen måste vara minst två tecken lång.");
                return;
            }

            Console.Write("Skriv in de två tecknen (exempel: ac): ");
            string charsToFind = Console.ReadLine();

            if (charsToFind.Length != 2)
            {
                Console.WriteLine("Du måste skriva exakt två tecken.");
                return;
            }

            char char1 = charsToFind[0];
            char char2 = charsToFind[1];

            if (inputStr.Contains(char1.ToString()) && inputStr.Contains(char2.ToString()))
            {
                Console.WriteLine($"Båda tecknen '{char1}' och '{char2}' finns i strängen.");
            }
            else
            {
                Console.WriteLine($"Minst ett av tecknen '{char1}' eller '{char2}' saknas i strängen.");
            }
        }
    }
}