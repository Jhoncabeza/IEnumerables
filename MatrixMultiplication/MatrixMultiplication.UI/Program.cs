using MatrixMultiplication.Logic;

Console.WriteLine("Multiplicación de matriz");

Console.Write("Ingrese el valor de m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el valor de n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el valor de p: ");
int p = Convert.ToInt32(Console.ReadLine());

var matrix = new MyMatrixMultiplication(m, n, p);

Console.WriteLine("*** A ***");

Console.WriteLine(MyMatrixMultiplication.PrintMatrix(matrix.MyMatrixA, m, n));
Console.WriteLine("*** B ***");

Console.WriteLine(MyMatrixMultiplication.PrintMatrix(matrix.MyMatrixB, n, p));

Console.WriteLine("*** C ***");

Console.WriteLine(matrix);