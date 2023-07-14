using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Leetcode.Arrays_and_Hashing.Dictionary
{
    internal class _347_top_k_frequent_element
    {
        // Given an integer array nums and an integer k, return the k most
        // frequent elements.You may return the answer in any order.

        // Example: 
        // Input: nums = [1,1,1,2,2,3], k = 2
        // Output: [1,2]

        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                dic[num] = dic.ContainsKey(num) ? dic[num] + 1 : 0; // one liner to check if the item is in Dictionary
            }
            var test = dic.OrderByDescending(x => x.Value); // order desc by the value in the dictionary
            var test2 = test.Select(x => x.Value); // select all of the values and ignore the keys
            var test3 = test2.Take(k); // take only 'k' number of items
            var test4 = test3.ToArray(); // turn the result into an array
            return dic.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToArray();

        }
    }
}
