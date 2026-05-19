using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su salario anual: ");
        string input = Console.ReadLine();
        double salario;

        // Validar que la entrada sea un número
        if (double.TryParse(input, out salario))
        {
            if (salario > 12000)
            {
                double excedente = salario - 12000;
                double impuesto = excedente * 0.15;
                Console.WriteLine($"Impuesto a pagar: {impuesto:F2}");
            }
            else
            {
                Console.WriteLine("No debe impuestos.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese un número válido.");
        }
    }
}
