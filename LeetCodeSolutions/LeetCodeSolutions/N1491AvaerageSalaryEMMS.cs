namespace LeetCodeSolutions
{
    public class N1491AvaerageSalaryEMMS : ILeetCodeExecute
    {
        public double Average(int[] salary)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            double avareg = 0; 


            for (int i = 0; i < salary.Length; i++)
            {
                if (salary[i] > max) max = salary[i];
                if (salary[i] < min) min = salary[i];
                avareg += salary[i];
            }

            return (avareg - min -max) /( salary.Length -2);
        }

        public void Execute()
        {
            Average(new int[] { 4000, 3000, 1000, 2000 });
        }
    }
}
