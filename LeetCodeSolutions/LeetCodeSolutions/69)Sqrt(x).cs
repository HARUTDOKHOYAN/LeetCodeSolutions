namespace LeetCodeSolutions
{
    internal class _69_Sqrt_x_ : ILeetCodeExecute
    {

        public int MySqrt(int x)
        {
            if (x == 0) return 0;
            double guess = 1;

            while (true)
            {
                if (guess == (guess + x/guess)/2) break;
                else guess = (guess + x/guess)/2;
            }
            return (int)guess;
        }

        public void Execute()
        {
            Console.WriteLine(MySqrt(8));
        }
    }
}
