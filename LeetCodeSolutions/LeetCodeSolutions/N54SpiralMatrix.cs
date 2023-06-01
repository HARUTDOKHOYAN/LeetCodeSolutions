using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class N54SpiralMatrix : ILeetCodeExecute
    {

        public IList<int> SpiralOrder(int[][] matrix)
        {
            var width = matrix[0].Length;
            var height = matrix.Length;
            var lenght = width * height;

            var result = new List<int>(lenght);
            var x = 0;
            var y = 0;
            var dy = 1;
            var dx = 1;

            while (result.Count < lenght)
            {
                result.Add(matrix[y][x]);

                if (y == dy - 1 && x < width - dx)
                {
                    x++;
                }
                else if (x == width - dx && y < height - dy)
                {
                    y++;
                }
                else if (x > dx - 1)
                {
                    x--;
                }
                else if (y > dy)
                {
                    y--;
                    if (y == dy && x == dx - 1)
                    {
                        dx++;
                        dy++;
                    }
                }
            }

            return result;
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
