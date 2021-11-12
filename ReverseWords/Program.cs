using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What word would you like to test?");
            string userInput = Console.ReadLine();

            char[] wordArray = userInput.ToCharArray();
            Array.Reverse(wordArray);
            string checkArrray = new string(wordArray);


            var reverseWord = string.Equals(userInput, checkArrray);
            Console.WriteLine($"Display user input: {userInput}");
            Console.WriteLine($"Display user input backwards: {checkArrray}");

            if (reverseWord == true)
            {
                Console.WriteLine("Your word is a palindrome");
            }
            else if (reverseWord == false)
            {
                Console.WriteLine("Your word is not a palindrome");
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
