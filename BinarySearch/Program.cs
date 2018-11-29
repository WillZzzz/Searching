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
            List<int> nums = new List<int>{5};
            int target = 5;
			int pos = Recursive.RecursiveBinarySearch(nums, target);
			//int pos = Iterative.IterativeBinarySearch(nums, target);
            Console.WriteLine(target);
        }
    }
}
