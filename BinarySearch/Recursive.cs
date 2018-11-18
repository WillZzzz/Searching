using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Recursive
    {
        static public int RecursiveBinarySearch(List<int> nums, int target)
        {
            if (nums.Count == 0) return -1;
            if (target < nums[0] || target > nums[nums.Count-1]) return -1;
            int pivot = nums.Count / 2;
            if (target > nums[pivot])
                return pivot + RecursiveBinarySearch(nums.GetRange(pivot, nums.Count - 1 - pivot), target);
            else if (target < nums[pivot])
                return RecursiveBinarySearch(nums.GetRange(0, pivot), target);
            else return pivot;
        }
    }
}
