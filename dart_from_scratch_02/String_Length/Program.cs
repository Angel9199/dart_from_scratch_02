using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine();

        if (!string.IsNullOrEmpty(palabra))
        {
            int longitud = palabra.Length;
            Console.WriteLine($"La longitud de la palabra es: {longitud}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese una palabra.");
        }
    }
}
