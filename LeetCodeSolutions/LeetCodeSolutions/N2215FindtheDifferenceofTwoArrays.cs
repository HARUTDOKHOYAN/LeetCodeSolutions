using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class N2215FindtheDifferenceofTwoArrays : ILeetCodeExecute
    {

        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {

            HashSet<int> n1 = nums1.ToHashSet();
            HashSet<int> n2 = nums2.ToHashSet();

            foreach (int item in n1)
            {
                if (n2.Contains(item))
                {
                    n1.Remove(item);
                    n2.Remove(item);
                }

            }

            return new List<IList<int>> { n1.ToList() , n2.ToList()};
        }

        public void Execute()
        {
            FindDifference(new int[] { 1, 1, 2, 3 }, new int[] { 1, 1, 2, 3 });
        }
    }
}
