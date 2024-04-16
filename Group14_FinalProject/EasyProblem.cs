using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Group14_FinalProject
{
    public class EasyProblem
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                if (!map.ContainsKey(nums[i]))
                {
                    map[nums[i]] = i;
                }
            }
            throw new ArgumentException("No two sum solution");
        }

        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] result = TwoSum(nums, target);

            Console.WriteLine("Indices: " + result[0] + ", " + result[1]);
        }
    }
}
    