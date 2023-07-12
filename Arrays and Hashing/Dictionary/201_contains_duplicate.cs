using Leetcode.Hashmap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Hashmap
{
    internal class _201_contains_duplicate
    {
        // Leetcode question 201 - Contains Duplicate

        // Given an integer array nums,
        // return true if any value appears at least twice in the array,
        // and return false if every element is distinct.

        // Example: 
        //Input: nums = [1,2,3,1]
        //Output: true

        //Input: nums = [1,2,3,4]
        //Output: false

        public bool ContainsDuplicate(int[] nums)
        {
            var hash = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (!hash.ContainsKey(num))
                {
                    hash.Add(num, 1);
                }
                else
                    return true;
            }
            return false;
        }
    }
}


// Run in main to test
//var item = new _201_contains_duplicate();
//int[] myNum = { 1, 2, 3, 3 };
//var res = item.ContainsDuplicate(myNum);
//Console.WriteLine(res);