using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 ,1,0};
            Console.WriteLine(a);
            
            //int[,] b = new int[1, 2];
            //List<int> listS = new List<int>(a);
            //Array.Sort(a);
            //new List<int>(a).Add(5);
            //Console.WriteLine();
            var v = new Program();

            Console.ReadKey();
        }
        public IList<int> FindDuplicates(int[] nums)
        {
            List<int> n = nums.ToList(), ns = new List<int>();
            nums.ToList().Add(1);
            Console.WriteLine(nums.ToArray()) ;
            n.Sort();
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] == nums[i])
                {
                    ns.Add(nums[i]);
                }
            }
            Console.WriteLine(ns);
            return ns;
        }
    }
}
