namespace LeetCodeSolutions
{
    public class N1572MatrixDiagonalSum : ILeetCodeExecute
    {

        public int DiagonalSum(int[][] mat)
        {
            int count = 0;
            for (int i = 0; i < mat.Length; i++)
            {
                count += mat[i][i];
                if (i == mat[i].Length - 1 - i) continue;
                count   += mat[i][mat[i].Length - 1 - i];
            }
            return count;

        }


        public void Execute()
        {
            DiagonalSum(new int[][] {
                                      new int[] { 1, 2, 3},
                                      new int[] { 4, 5, 6 },
                                      new int[] { 7,8,9, },
            });
        }
    }
}
