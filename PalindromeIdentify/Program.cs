using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeIdentify
{
    class Program
    {
        static void Main(string[] args)
        {
            Palindrome myPalindrome = new Palindrome();
            string userInput = myPalindrome.getUserInput();
            string reverseString = myPalindrome.reverseUserInput(userInput);
            myPalindrome.checkIfPalindrome(userInput, reverseString);
        }
    }
}
