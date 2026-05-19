using System;

class Program
{
    static void Main()
    {
        int suma = 0;

        for (int i = 2; i <= 50; i += 2) // solo números pares
        {
            suma += i;
        }

        Console.WriteLine($"La suma de los números pares entre 1 y 50 es: {suma}");
    }
}
