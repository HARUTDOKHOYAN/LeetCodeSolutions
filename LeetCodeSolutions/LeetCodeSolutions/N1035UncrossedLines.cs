namespace LeetCodeSolutions
{
    public class N1035UncrossedLines:ILeetCodeExecute
    {
        public void Execute()
        {
            MaxUncrossedLines(new int[] { 1, 3, 7, 1, 7, 5 }, new int[] { 1, 9, 2, 5, 1 });
        }

        public int MaxUncrossedLines(int[] nums1, int[] nums2)
        {
            int count1 = 0;
            int fix = 0;
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = fix; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j] )
                    {
                        fix = j + 1;
                        count1++;
                        break;
                    }
                }
            }
            int count2 = 0;
            fix = 0;
            for (int i = 0; i < nums2.Length; i++)
            {
                for (int j = fix; j < nums1.Length; j++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        fix = j + 1;
                        count2++;
                        break;
                    }
                }
            }
            return count1 > count2 ? count1 : count2;
        }
    }
}
