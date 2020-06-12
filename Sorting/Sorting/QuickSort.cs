using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    class QuickSort
    {
        public void qs (int[] nums, int left, int right)
        {
            int mid = partition(nums, left, right);
            if (left < mid - 1)
            {
                qs(nums, left, mid - 1);
            }
            if (mid < right)
            {

                qs(nums, mid, right);
            }

        }

        public int partition (int[] nums, int left, int right)
        {
            int pivot = nums[((left + right) / 2)];

            while (left <= right)
            {
                while (nums[left] < pivot)
                {
                    left++;
                }
                while (nums[right] > pivot)
                {
                    right--;
                }
                if (left <= right)
                {
                    int temp = nums[left];
                    nums[left] = nums[right];
                    nums[right] = temp;
                    left++;
                    right--;
                }
            }

            return left;
        }
    }
}
