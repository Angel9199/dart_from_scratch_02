using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        string input = Console.ReadLine();
        int numero;

        if (int.TryParse(input, out numero))
        {
            if (numero >= 10 && numero <= 20)
            {
                Console.WriteLine("Está en el rango.");
            }
            else
            {
                Console.WriteLine("Fuera del rango.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese un número entero.");
        }
    }
}
