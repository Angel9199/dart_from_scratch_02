using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la primera fracción (ejemplo 1/2): ");
        string frac1 = Console.ReadLine();

        Console.Write("Ingrese la segunda fracción (ejemplo 1/3): ");
        string frac2 = Console.ReadLine();

        try
        {
            // Convertir las fracciones a valores numéricos
            double valor1 = ConvertirFraccion(frac1);
            double valor2 = ConvertirFraccion(frac2);

            double diferencia = valor1 - valor2;

            Console.WriteLine($"La diferencia es: {diferencia}");
        }
        catch
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese fracciones en formato a/b.");
        }
    }

    static double ConvertirFraccion(string fraccion)
    {
        string[] partes = fraccion.Split('/');
        if (partes.Length != 2)
            throw new FormatException();

        int numerador = int.Parse(partes[0]);
        int denominador = int.Parse(partes[1]);

        if (denominador == 0)
            throw new DivideByZeroException();

        return (double)numerador / denominador;
    }
}
