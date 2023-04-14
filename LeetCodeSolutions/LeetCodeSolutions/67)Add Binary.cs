namespace LeetCodeSolutions
{
    internal class _67_AddBinary : ILeetCodeExecute
    {
        public string AddBinary(string a, string b)
        {
            if (a.Length > b.Length)
            {
                int dif = a.Length - b.Length;
                for (int i = 0; i < dif; i++)
                    b = '0' + b;
            }
            else if (a.Length < b.Length)
            {
                int dif = b.Length - a.Length;
                for (int i = 0; i < dif ++;)
                    a = '0' + a;
            }
            return BinaryCalc(b, a);
        }

        private string BinaryCalc(string a, string b)
        {
            string result = "";
            bool isChash = false;
            for (int i = a.Length-1; i >= 0; i--)
                result = Add(a[i], b[i], ref isChash) + result;

            if (isChash) result = '1' + result;
            return result;
        }

        private char Add(char a, char b, ref bool isChash)
        {
            if (a == b && a == '1')
            {
                char result = '0';
                if (isChash) result = '1';
                isChash = true;
                return result;
            }
            if (a == b && a == '0')
            {
                char result = '0';
                if (isChash) result = '1';
                isChash = false;
                return result;
            }
            else
            {
                char result = '1';
                if (isChash)
                {
                    result = '0';
                    isChash = true;
                }
                else
                    isChash = false;
                return result;
            }
        }
        public void Execute()
        {
            Console.WriteLine(AddBinary("1", "111"));
        }
    }
}
