using FactorDecomposition.Logic;

Console.WriteLine("35. DESCOMPOSICION EN FACTORES");
Console.Write("Ingrese el número a descomponer:");
var number =  Convert.ToInt32(Console.ReadLine());
var factor = new MyFactorDecomposition(number);

Console.WriteLine(factor);