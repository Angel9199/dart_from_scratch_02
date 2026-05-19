using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine();

        if (!string.IsNullOrEmpty(palabra))
        {
            int contador = 0;
            string vocales = "aeiouAEIOU";

            foreach (char c in palabra)
            {
                if (vocales.Contains(c))
                {
                    contador++;
                }
            }

            Console.WriteLine($"La palabra tiene {contador} vocal(es).");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese una palabra.");
        }
    }
}
