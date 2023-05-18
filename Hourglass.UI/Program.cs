using Hourglass.Logic;

Console.Write("Ingrese orden de la matriz: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("MATRIZ COMPLETA");
var matrix = new MyHourglass(m);
Console.Write(matrix);
Console.WriteLine("RELOJ DE ARENA");
Console.WriteLine(matrix.MatrixPrint);
