using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays_and_Hashing.Dictionary
{
    internal class _1_two_sum
    {
        //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        //You may assume that each input would have exactly one solution, and you may not use the same element twice.

        //You can return the answer in any order.


        //Input: nums = [2,7,11,15], target = 9
        //Output: [0,1]
        //Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

        public int[] TwoSum(int[] nums, int target)
        {
            var hashMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int currentNum = nums[i];
                var itemToLookFor = target - currentNum;
                if (hashMap.ContainsKey(itemToLookFor))
                {
                    return new int[] { hashMap[itemToLookFor], i };
                }
                hashMap[currentNum] = i;
            }
            return new int[0];
        }
    }
}
