Console.Write("Ingrese número: ");
var numberString = Console.ReadLine(); // "45"
var numberInt = int.Parse (numberString!); // 45 
if (numberInt % 2 == 0)
{
    Console.WriteLine("El numero es par.");
}
else 
{
    Console.WriteLine("El numero es inpar.");
}