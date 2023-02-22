namespace LeetCodeSolutions
{
    internal class _66_PlusOne : ILeetCodeExecute
    {

        public int[] PlusOne(int[] digits)
        {
            
            for (int i = digits.Length - 1; i >= 0; i-- )
            {
                digits[i]++;
                if (digits[i] > 9)
                {
                    digits[i] = 0;
                    continue;
                }
                break;
            }

            if (digits[0] == 0) 
            {
                digits = new int[digits.Length + 1];
                digits[0] = 1;
                return digits;
            } 
            return digits;
        }

        public void Execute()
        {
            var numbers = new int[]{9};
            PlusOne(numbers);
        }
    }
}
