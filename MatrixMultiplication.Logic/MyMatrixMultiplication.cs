namespace MatrixMultiplication.Logic
{
    public class MyMatrixMultiplication
    {
        public int[,] MyMatrixA { get; set; }
        public int[,] MyMatrixB { get; set; }
        public int[,] MyResult { get; set; }

        public int N { get; set; }
        public int M { get; set; }
        public int P { get; set; }


        public MyMatrixMultiplication(int m, int n, int p)
        {
            MyMatrixA = new int[m, n];
            MyMatrixB = new int[n, p];
            MyResult = new int[m, p];
            M = m;
            N = n;
            P = p;
            GetMatrixMultiplication();
        }

        public int[,] GetMatrixMultiplication()
        {
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    MyMatrixA[i, j] = (i + 1) * (j);
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < P; j++)
                {
                    MyMatrixB[i, j] = (j + 1) * (i);
                }
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < P; j++)
                {
                    for (int k = 0; k < N; k++)
                    {
                        MyResult[i, j] += MyMatrixA[i, k] * MyMatrixB[k, j];
                    }
                }
            }
            return MyResult;
        }

        public override string ToString()
        {
            var output = string.Empty;

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < P; j++)
                {
                    output += $"{MyResult[i, j]}  ";
                }
                output += $"\n";
            }
            return output;
        }

        public static string PrintMatrix(int[,] matrix, int param1, int param2)
        {
            var output = string.Empty;

            for (int i = 0; i < param1; i++)
            {
                for (int j = 0; j < param2; j++)
                {
                    output += $"{matrix[i, j]}  ";
                }
                output += $"\n";
            }
            return output;
        }

    }
}