using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class _724_FindPivotIndex : ILeetCodeExecute
    {
        public int PivotIndex(int[] nums)
        {
            int left = 0;
            int right =  nums.Sum();
            for (int i=0; i < nums.Length ; i++) 
            {
                right -= nums[i];
                if (left == right) 
                {
                    return i;
                }
                left += nums[i];
            }
            return -1;
        }

        public void Execute()
        {
          Console.WriteLine(PivotIndex(new int[] { 1, 7, 3, 6, 5, 6 }));
        }
    }
}
