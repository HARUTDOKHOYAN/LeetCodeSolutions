namespace LeetCodeSolutions
{
    internal class N121BestTimetoBuyandSellStock : ILeetCodeExecute
    {
        public void Execute()
        {
            MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
        }

        public int MaxProfit(int[] prices)
        {

            int minPrice = int.MaxValue;
            int profit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                minPrice  = Math.Min(minPrice , prices[i]);
                int result = prices[i] - minPrice;
                if (result > profit) profit = result;
            }

            return profit ;

        }  
    }
}
