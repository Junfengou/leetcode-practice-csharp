using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays_and_Hashing.String
{
    internal class _58_length_of_last_word
    {
        // Given a string s consisting of words and spaces, return the length of the last word in the string.

        // A word is a maximal substring consisting of non-space characters only.

        // Example: 
        // Input: s = "Hello World"
        // Output: 5
        // Explanation: The last word is "World" with length 5.


        public int LengthOfLastWord(string s)
        {
            var arr = s.Trim().Split(' ');
            return arr[arr.Length - 1].Length;
        }
    }
}
