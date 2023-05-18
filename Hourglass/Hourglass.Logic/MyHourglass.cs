namespace Hourglass.Logic
{
    public class MyHourglass
    {
        public int[,] MatrixHourglass { get; set; }
        public int N { get; set; } 

        public MyHourglass(int n)
        {
            MatrixHourglass = new int[n, n];
            N = n;
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
    }
}