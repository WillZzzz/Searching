using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>{1,2,3,4,5,6,7,8};
            int target = 5;
            int pos = Recursive.RecursiveBinarySearch(nums, target);
            Console.WriteLine(target);
        }
    }
}
