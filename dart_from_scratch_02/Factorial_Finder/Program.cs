using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número entero: ");
        string input = Console.ReadLine();
        int numero;

        if (int.TryParse(input, out numero))
        {
            if (numero < 0)
            {
                Console.WriteLine("El factorial no está definido para números negativos.");
            }
            else
            {
                long factorial = 1;
                for (int i = 1; i <= numero; i++)
                {
                    factorial *= i;
                }

                Console.WriteLine($"El factorial de {numero} es: {factorial}");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese un número entero.");
        }
    }
}
