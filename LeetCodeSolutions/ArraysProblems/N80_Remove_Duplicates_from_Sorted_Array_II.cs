using System;

namespace LeetCodeSolutions.ArraysProblems;

public class N80_Remove_Duplicates_from_Sorted_Array_II : ILeetCodeRun
{
    public int RemoveDuplicates(int[] nums) {
        var deletCount = 0;
        var numPointer = 0;
        var currentUnicItem = nums[0];
        var dubCount = 0;
        while(numPointer < nums.Length - deletCount){
            if(currentUnicItem == nums[numPointer] 
            && dubCount != 2){
                dubCount++;
            }
            else if(currentUnicItem != nums[numPointer])
            {
                dubCount = 0;
                currentUnicItem = nums[numPointer] ;
                dubCount++;
            }
            else if(dubCount == 2){
                deletCount++;
                SifhtArray(nums , numPointer);
                continue;
            }
            
        numPointer++;
        }
        return nums.Length - deletCount;
    }

    public void Run()
    {
        RemoveDuplicates(new int[]{0,0,1,1,1,1,2,3,3});
    }

    public void SifhtArray(int[] nums , int startPosition){
        for(int i = startPosition ; i < nums.Length - 1; i++){
            nums[i] = nums[i+1];
        }
    }

}