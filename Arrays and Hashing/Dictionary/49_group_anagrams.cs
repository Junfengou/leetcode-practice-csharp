using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays_and_Hashing.Dictionary
{
    internal class _49_group_anagrams
    {
        // 49 - Group Anagrams

        //Given an array of strings strs, group the anagrams together.You can return the answer in any order.

        //An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase,
        //typically using all the original letters exactly once.
        
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var hashMap = new Dictionary<string, IList<string>>();

            foreach (var word in strs)
            {
                var sortedWord = string.Concat(word.OrderBy(c => c));

                Console.WriteLine(hashMap);
                if (!hashMap.ContainsKey(sortedWord))
                    hashMap[sortedWord] = new List<string>();
                hashMap[sortedWord].Add(word);
            }
            return hashMap.Values.ToList();
        }
    }
}
