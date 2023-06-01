using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class N1964FindtheLongestValidObstacleCourseatEachPosition : ILeetCodeExecute
    {
        public int[] LongestObstacleCourseAtEachPosition(int[] obstacles)
        {
            int n = obstacles.Length;
            int[] Lis = new int[n];  
            int[] res = new int[n];
            int lengthOfLis = 0;

            for (int i = 0; i<n; i++)
            {
                int nextGreaterInList = FindNextGreater(Lis, obstacles[i], lengthOfLis);
                res[i] = nextGreaterInList+1;
                Lis[nextGreaterInList] = obstacles[i];

                if (nextGreaterInList == lengthOfLis)
                {
                    lengthOfLis++;
                 }
            }

            return res;
        }

        private int FindNextGreater(int[] Lis, int obstacle, int last)
        {
            int start = 0;

            while (start < last)
            {
                int mid = (start+last)/2;

                if (Lis[mid] <= obstacle)
                {
                    start = mid+1;
                }
                else
                {
                    last = mid;
                }
            }

            return start;
        }
        public void Execute()
        {
            LongestObstacleCourseAtEachPosition(new int[] { 3, 1, 5, 6, 4, 2 ,7 });
        }
    }
}
