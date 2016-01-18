using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeIdentify
{
    public class Palindrome
    {
        public string getUserInput()
        {
            Console.WriteLine("Enter a number to check if it is a palindrome");
            string userWord = Console.ReadLine();
            return userWord;
        }

        public string reverseUserInput(string userWord)
        {
            char[] userInputReversed = userWord.ToCharArray();
            Array.Reverse(userInputReversed);
            return new string(userInputReversed);
        }

        public void checkIfPalindrome(string userInputReversed, string userWord)
        {
            if (userInputReversed == userWord)
            {
                Console.WriteLine("This is, in fact, a palindrome!");
            }
            else
            {
                Console.WriteLine("This is not a Palindrome");
            }
        }
    }
}
