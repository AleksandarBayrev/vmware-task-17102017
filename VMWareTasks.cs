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
