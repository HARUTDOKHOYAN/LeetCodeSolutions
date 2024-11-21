using System;

namespace LeetCodeSolutions.ArraysProblems;

public class N189_Rotate_Array : ILeetCodeRun
{
    public void Run()
    {
       Rotate([1,2,3,5,6,7,8,9] , 4);
    }
    public void Rotate(int[] nums, int k) 
    {    
		if (k == 0 || nums.Length == 1 || nums.Length == k)
			return;

		int loopProtectionPointer = 0;
		int currentPointer = 0;
		int e = nums[currentPointer];

		for (int c = 1; c <= nums.Length; c++)
		{
			currentPointer = (currentPointer + k) % nums.Length;
			(e, nums[currentPointer]) = (nums[currentPointer], e);

            //protecting for loop
			if (currentPointer == loopProtectionPointer)
			{
				loopProtectionPointer++;
				currentPointer++;
				e = nums[currentPointer];
			}
     }
    }
}

