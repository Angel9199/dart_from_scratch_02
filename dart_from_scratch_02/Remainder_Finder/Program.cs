using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        string input1 = Console.ReadLine();

        Console.Write("Ingrese el segundo número: ");
        string input2 = Console.ReadLine();

        int numero1, numero2;

        // Validar que ambos sean números enteros
        if (int.TryParse(input1, out numero1) && int.TryParse(input2, out numero2))
        {
            if (numero2 != 0)
            {
                int residuo = numero1 % numero2;
                Console.WriteLine($"El residuo de la división es: {residuo}");
            }
            else
            {
                Console.WriteLine("Error: no se puede dividir entre cero.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese números enteros.");
        }
    }
}
