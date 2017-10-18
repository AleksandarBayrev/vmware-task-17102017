using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMWare_Tests
{
    public static class VMWareTasks
    {
        public static int[] TenRun(int[] nums)
        {
            /*
            TenRun problem
            For each multiple of 10 in the given array, change all the values following it
            to be that multiple of 10, until encountering another multiple of 10.
            So {2, 10, 3, 4, 20, 5} yields {2, 10, 10, 10, 20, 20}.            
            */
            
            int comparison = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                if ((nums[i] % 10) == 0 && nums[i] > comparison)
                    comparison = nums[i];

                else
                    nums[i] = comparison;
            }

            return nums;
        }

        public static bool SameEnds(int[] nums, int length)
        {
            /*
            SameEnds problem
            Return true if the group of N numbers at the start and end of the array are
            the same. For example, with { 5, 6, 45, 99, 13, 5, 6 }, the ends are the same
            for n=0 and n=2, and false for n=1 and n=3. You may assume that n is in
            the range from 0 to nums.Length
            length=n
            */
            
            if (length > nums.Length || length < 0)
                throw new ArgumentException("Invalid parameter specified for length!");
            
            List<int> firstPart = new List<int>();
            List<int> secondPart = new List<int>();

            for (int i = 0, j = nums.Length - 1; i < length && j > length; i++, j--)
            {
                firstPart.Add(nums[i]);
                secondPart.Add(nums[j]);
            }

            foreach(int element in firstPart)
                if (!secondPart.Contains(element))
                    return false;

            return true;
        }
    }
}
