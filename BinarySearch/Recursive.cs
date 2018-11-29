using System.Collections.Generic;

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
                return pivot + RecursiveBinarySearch(nums.GetRange(pivot, nums.Count - 1 -pivot), target);
            else if (target < nums[pivot])
                return RecursiveBinarySearch(nums.GetRange(0, pivot-1), target);
            else return pivot;
        }
    }
}
