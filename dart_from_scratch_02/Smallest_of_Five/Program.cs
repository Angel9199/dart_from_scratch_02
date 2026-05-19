using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese cinco números:");

        double[] numeros = new double[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Número {i + 1}: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out numeros[i]))
            {
                continue;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor ingrese un número válido.");
                return; // salir si hay error
            }
        }

        // Encontrar el menor con la función Min
        double menor = numeros[0];
        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] < menor)
            {
                menor = numeros[i];
            }
        }

        Console.WriteLine($"El número más pequeño es: {menor}");
    }
}
