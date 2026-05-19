using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        
        // Leer entrada y convertir a entero
        string input = Console.ReadLine();
        int numero;

        // Validar que la entrada sea un número
        if (int.TryParse(input, out numero))
        {
            if (numero > 0)
            {
                int resultado = numero * numero;
                Console.WriteLine($"Resultado: {resultado}");
            }
            else if (numero == 0)
            {
                Console.WriteLine("Resultado: 0");
            }
            else
            {
                Console.WriteLine("Número negativo.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese un número entero.");
        }
    }
}
