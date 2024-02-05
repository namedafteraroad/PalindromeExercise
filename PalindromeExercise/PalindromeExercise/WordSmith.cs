using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {

        public bool IsAPalindrome(string wString)
        {
            return wString.SequenceEqual(wString.Reverse());

            
        }
    }
}
////In your WordSmith class, you will create a method (IsAPalindrome) that will take a parameter of type string and return a value of type bool.
//If the given input is a palindrome – return true, else return false. You will finish this method after you write your tests.