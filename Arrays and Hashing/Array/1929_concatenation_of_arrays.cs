using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays_and_Hashing.List
{
    internal class _1929_concatenation_of_arrays
    {
        // 1929 - Concatenation of arrays
        // Given an integer array nums of length n, you want to create an array
        // ans of length 2n where ans[i] == nums[i] and ans[i + n] == nums[i] for 0 <= i<n (0-indexed).
        // Specifically, ans is the concatenation of two nums arrays.
        // Return the array ans.

        // Example:
        //Input: nums = [1,2,1]
        //Output: [1,2,1,1,2,1]


        public int[] GetConcatenation(int[] nums)
        {
            // increase the size of the array
            var result = new int[nums.Length * 2];
            for (var i = 0; i < nums.Length; i++)
            {
                result[i] = nums[i];
                result[i + nums.Length] = nums[i];
            }
            return result;
        }
    }
}


//int[] myNum = { 1, 2, 1 };
//var res = item.GetConcatenation(myNum);