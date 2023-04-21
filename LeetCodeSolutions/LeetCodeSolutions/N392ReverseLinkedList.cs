namespace LeetCodeSolutions
{
    partial class N392ReverseLinkedList : ILeetCodeExecute
    {

        bool IsSubsequence(string s, string t)
        {

            if (s == string.Empty) return false;

            string result = string.Empty;
            int index = 0;
            for (int i = 0; i < t.Length; i++)
            {

                if (s == result) return true;
                if (t[i] == s[index])
                {
                    result += s[index];
                    index++;
                }
            }

            return s == result;
        }

        public void Execute()
        {
            IsSubsequence("aa" , "bb");
        }
    }
}
