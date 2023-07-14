using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays_and_Hashing.Array
{
    internal class _238_product_of_array_except_self
    {
        // Input: nums = [1,2,3,4]
        // Output: [24,12,8,6]
        public int[] ProductExceptSelf(int[] nums)
        {
            var list = new List<int>();

            for(var i = 0; i < nums.Length; i++)
            {
                var item1 = getProduct(nums, 0, i);
                var item2 = getProduct(nums, i + 1, nums.Length);
                list.Add(item1 * item2);
            }
            return list.ToArray();
        }

        private int getProduct(int[] arr, int startIdx, int endIdx)
        {
            var p = 1;

            for(var i = startIdx; i < endIdx; i++)
            {
                p *= arr[i];
            }
            return p;
        }
    }
}
