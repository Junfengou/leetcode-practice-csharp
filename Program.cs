using Leetcode.Arrays_and_Hashing.Array;
using Leetcode.Arrays_and_Hashing.Dictionary;
using Leetcode.Arrays_and_Hashing.List;
using Leetcode.Arrays_and_Hashing.String;
using Leetcode.Hashmap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var item = new _238_product_of_array_except_self();
            int[] nums = {1, 2, 3, 4};
            //string[] wordList = { "eat", "tea", "tan", "ate", "nat", "bat" };
            var res = item.ProductExceptSelf(nums);

            Console.WriteLine(res);
        }
    }
}

// Good strategy
// _347_top_k_frequent_element