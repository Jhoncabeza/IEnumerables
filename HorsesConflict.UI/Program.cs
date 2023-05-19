using HorsesConflict.Logic;

Console.WriteLine("37. CABALLOS EN CONFLICTO");

Console.Write("Ingrese ubicación de los caballos: ");
var coordinatesInput = Console.ReadLine();

var response = new MyHorsesConflict(coordinatesInput!);
Console.WriteLine(response);
