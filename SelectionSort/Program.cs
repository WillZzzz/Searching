using System;
using System.Collections.Generic;
using System.Linq;

namespace SelectionSort
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			List<int> nums = new List<int>{ 6, 5, 7, 4, 3, 9, 11 };
			List<int> result = SelectionSort(nums);
			Console.WriteLine(result);
		}

		private static List<int> SelectionSort(List<int> nums)
		{
			if (nums.Count <= 1) return nums;

			int start = 0;
			int end = nums.Count - 1;
			int min_pos = 0;
			while (start != end)
			{
				min_pos = start;
				int min_val = nums[min_pos];
				for (int i = start; i <= end; i++)
				{
					if (nums[i] < min_val)
					{
						min_val = nums[i];
						min_pos = i;
					}
				}
				int tmp = nums[start];
				nums[start] = nums[min_pos];
				nums[min_pos] = tmp;
				start++;
			}

			return nums;
		}
	}
}
