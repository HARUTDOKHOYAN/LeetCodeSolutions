namespace LeetCodeSolutions
{
    internal class N1498NumberofSubsequencesThatSatisfytheGivenSumCondition : ILeetCodeExecute
    {
        public int NumSubseq(int[] nums, int target)
        {
            Array.Sort(nums);

            if(nums.Length == 1)
            {
                if (nums[0] + nums[0] <= target)
                    return 1;
                return 0;
            }
            double res = 0;
            double mod = Math.Pow(10 ,9)+7;


            int r = nums.Length -1;
            for (int i = 0; i < nums.Length; i++)
            {
                while( (nums[i] + nums[r]) > target && i <=r)
                    r--;
                if (i <= r)
                {
                    res +=Math.Pow(2 ,r-i);
                    res %= mod;
                }
            }
            return (int)res;
        }

        public void Execute()
        {
            NumSubseq(new int[] { 3 } , 3);
        }
    }
}