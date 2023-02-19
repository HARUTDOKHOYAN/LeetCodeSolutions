namespace LeetCodeSolutions
{
    internal class _1431_KidsWiththeGreatestNumberofCandies : ILeetCodeExecute
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int max = 0;
            List<bool> TEST = new List<bool>();
            for (int i = 0; i < candies.Length; i++)
            {

                if (max < candies[i])
                {
                    max = candies[i];
                }
            }
            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies > max)
                {
                    TEST.Add(true);
                }
                else
                {
                    TEST.Add(false);
                }
            }
            return TEST;
        }

        public void Execute()
        {
            KidsWithCandies(new int[2], 5);
        }
    }
}
