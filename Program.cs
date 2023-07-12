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
            var item = new _58_length_of_last_word();

            var res = item.LengthOfLastWord("Hello World");
            Console.WriteLine(res);
        }
    }
}
