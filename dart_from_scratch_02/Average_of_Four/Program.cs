using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese cuatro números:");

        double[] numeros = new double[4];
        double suma = 0;

        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Número {i + 1}: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out numeros[i]))
            {
                suma += numeros[i];
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor ingrese un número válido.");
                return; // salir si hay error
            }
        }

        double promedio = suma / 4;
        Console.WriteLine($"El promedio de los cuatro números es: {promedio}");
    }
}
