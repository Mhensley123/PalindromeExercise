using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq;


namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            var reversedWord = word.Reverse();

            return word.ToLower().SequenceEqual(reversedWord);
        }
    }
}
