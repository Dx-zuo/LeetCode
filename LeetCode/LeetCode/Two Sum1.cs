using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Two_Sum1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int x = 0; x < nums.Length; x++)
            {
                for (int y = nums.Length - 1; y >= 0; y--)
                {
                    if (nums[x] != nums[y])
                    {
                        if ((nums[x] + nums[y]) == target)
                        {
                            return new int[] { x, y };
                        }
                    }
                }
            }
            return null;
        }
    }
}
