namespace Hourglass.Logic
{
    public class MyHourglass
    {
        public int[,] MatrixHourglass { get; set; }
        public int N { get; set; }
        public string MatrixPrint { get; set; } 
        public MyHourglass(int n)
        {
            MatrixHourglass = new int[n, n];
            N = n;
            GetMatrixHourglass();
            MatrixPrint = PrintMatrixHourglass();
        }

        public int[,] GetMatrixHourglass()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    MatrixHourglass[i, j] = i * 2 + j;
                }
            }
            return MatrixHourglass;
        }
        public override string ToString()
        {
            var output = String.Empty;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    output += $"{MatrixHourglass[i, j]}\t";
                }
                output += "\n";
            }
            return output;
        }

        public string PrintMatrixHourglass()
        {
            var output = String.Empty;
      
            for (int i = 0; i < N; i++)
            {
                int start = i <= N / 2 ? i : N - 1 - i;
                int finish = N - start;

                for (int j = 0; j < start; j++)
                {
                    output += "\t";
                }

                for (int j = start; j < finish; j++)
                {
                    output += $"{MatrixHourglass[i, j]}\t";
                }

                for (int j = finish; j < N; j++)
                {
                    output += "\t";
                }

                output += "\n";
            }
            return output;
        }
    }
}


