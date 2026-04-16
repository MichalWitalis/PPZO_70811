using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Średnia ocen");

        Console.Write("Podaj liczbę ocen: ");
        int n = int.Parse(Console.ReadLine());

        double suma = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Podaj ocenę numer {i + 1}: ");
            double ocena = double.Parse(Console.ReadLine());
            suma += ocena;
        }

        double srednia = suma / n;

        Console.WriteLine("Średnia: " + Math.Round(srednia, 2));

        if (srednia >= 3.0)
            Console.WriteLine("Uczeń zdał.");
        else
            Console.WriteLine("Uczeń nie zdał");
    }
}