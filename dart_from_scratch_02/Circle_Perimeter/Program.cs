using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el radio del círculo: ");
        string input = Console.ReadLine();
        double radio;

        // Validar que la entrada sea un número
        if (double.TryParse(input, out radio))
        {
            if (radio >= 0)
            {
                double perimetro = 2 * Math.PI * radio;
                Console.WriteLine($"El perímetro del círculo es: {perimetro:F2}");
            }
            else
            {
                Console.WriteLine("El radio no puede ser negativo.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese un número válido.");
        }
    }
}
