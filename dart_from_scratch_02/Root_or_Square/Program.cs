using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        string input = Console.ReadLine();
        int numero;

        // Validar que la entrada sea un número entero
        if (int.TryParse(input, out numero))
        {
            if (numero > 0)
            {
                double resultado = Math.Sqrt(numero);
                Console.WriteLine($"Resultado: {resultado}");
            }
            else if (numero < 0)
            {
                int resultado = numero * numero;
                Console.WriteLine($"Resultado: {resultado}");
            }
            else
            {
                Console.WriteLine("Resultado: 0");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese un número entero.");
        }
    }
}
