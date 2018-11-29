using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Iterative
    {
        static public int IterativeBinarySearch(List<int> nums, int target)
        {
            if (nums.Count == 0) return -1;
            if (target < nums[0] || target > nums[nums.Count - 1]) return -1;
            int start = 0;
            int end = nums.Count;
            int pivot = (start + end) / 2;

            while (true)
            {
                if (target < nums[pivot])
                {
                    end = pivot;
                    pivot = (start + end) / 2;
                }
                else if (target > nums[pivot])
                {
                    start = pivot;
                    pivot = (start + end) / 2;
                }

                if (target == nums[pivot])
                {
                    return pivot;
                }

                if (pivot == start || pivot == end)
                {
                    return -1;
                }
            }
        }
    }
}
