using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays_and_Hashing.String
{
    internal class _293_is_sequence
    {
        // 293 - Is Sequence
        // Given two strings s and t, return true if s is a subsequence of t, or false otherwise.

        // A subsequence of a string is a new string that is formed from the original string
        // by deleting some(can be none) of the characters without disturbing the relative positions of
        // the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).


        // Example:
        // Input: s = "abc", t = "ahbgdc"
        // Output: true

        //Input: s = "axc", t = "ahbgdc"
        //Output: false


        public bool IsSubsequence(string s, string t)
        {
            if (s == "")
                return true;
            var counter = 0;
            for (var i = 0; i < t.Length && counter < s.Length; i++)
            {
                if (s[counter] == t[i])
                    counter++;
            }
            return counter == s.Length;
        }
    }
}
