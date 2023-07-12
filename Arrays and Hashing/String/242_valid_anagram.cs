using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Hashmap
{
    internal class _242_valid_anagram
    {
        // Given two strings s and t, return true if t is an anagram of s, and false otherwise.

        // An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase,
        // typically using all the original letters exactly once.

        // Example
        // Input: s = "anagram", t = "nagaram"
        // Output: true

        public bool IsAnagram(string s, string t)
        {
            var test = s.OrderBy(c => c);
            s = String.Concat(s.OrderBy(c => c));
            t = String.Concat(t.OrderBy(c => c));
            return s == t;
        }
    }
}

//var res = item.IsAnagram("anagram", "nagaram");
//Console.WriteLine(res);
