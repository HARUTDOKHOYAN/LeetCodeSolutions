namespace LeetCodeSolutions
{
    partial class _70_ClimbingStairs : ILeetCodeExecute
    {

        public int ClimbStairs(int n)
        {
            if (n <= 3)
            {
                return n;
            }
            int[] dp = new int[n+1];
            dp[1] = 1;
            dp[2] = 2;
            for (int i = 3; i <= n; i++)
            {
                dp[i] = dp[i-1] + dp[i-2];
            }
            return dp[n];
        }

        public void Execute()
        {
            Console.WriteLine(ClimbStairs(45));

        }
    }
}
