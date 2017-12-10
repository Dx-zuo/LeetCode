using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Array_Partition_I
    {
        public int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);
            int n = 0;
            for (int i = 0; i < nums.Length; i+=2)
            {
                n += Math.Min(nums[i], nums[i+1]);
            }
            return n;
        }
    }
}