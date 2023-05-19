using HarvestingHorseback.Logic;
Console.WriteLine("36. COSECHANDO A CABALLO\n");

Console.Write("Ingrese ubicación de los frutos: ");
var fruits = Console.ReadLine();

Console.Write("Ingrese posición inicial del caballo: ");
var horsePosition = Console.ReadLine();

Console.Write("Ingrese los movimientos del caballo: ");
var horseMovements = Console.ReadLine();

var response = new MyHarvestingHorseback(fruits!, horsePosition!, horseMovements!);

Console.Write(response.FruitCollected);