using System;
using System.Collections.Generic;

namespace MergeSort
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			List<int> nums = new List<int> { 6, 5, 7, 4, 3, 9, 11 };
			List<int> result = MergeSort(nums);
			Console.WriteLine(result);
		}

		private static List<int> MergeSort(List<int> nums)
		{
			if (nums.Count <= 1) return nums;

			int l = 0;
			int r = nums.Count;
			int m = (l + r)/2;

			return Merge(MergeSort(nums.GetRange(0, m-1)), MergeSort(nums.GetRange(m, r - m - 1)));
		}

		private static List<int> Merge(List<int> nums1, List<int> nums2)
		{
			int pivot1 = 0;
			int pivot2 = 0;
			List<int> result = new List<int>{};
			while (pivot1 != nums1.Count && pivot2 != nums2.Count)
			{
				if (nums1[pivot1] <= nums2[pivot2])
				{
					result.Add(nums1[pivot1]);
					pivot1++;
				}
				else
				{
					result.Add(nums2[pivot2]);
					pivot2++;
				}
			}
			return result;
		}
	}
}
