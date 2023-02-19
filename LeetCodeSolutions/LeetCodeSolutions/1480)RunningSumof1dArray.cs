namespace LeetCodeSolutions
{
    internal class _1480_RunningSumof1dArray : ILeetCodeExecute
    {
        public int[] system(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                count = count + nums[i];
                nums[i] = count;
            }
            return nums;
        }
        public void work(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
        public void Execute()
        {
            work(new int[]{1,2});
        }
    }
}
