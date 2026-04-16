using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Konwerter temperatur");
        Console.WriteLine("C - Celsjusz -> Fahrenheit");
        Console.WriteLine("F - Fahrenheit -> Celsjusz");

        Console.Write("Wybierz opcję (C/F): ");
        string wybor = Console.ReadLine();

        if (wybor == "C")
        {
            Console.Write("Podaj temperaturę w stopniach Celsjusza: ");
            double c = double.Parse(Console.ReadLine());

            double f = c * 1.8 + 32;

            Console.WriteLine(c + "°C = " + f + "°F");
        }
        else if (wybor == "F")
        {
            Console.Write("Podaj temperaturę w stopniach Fahrenheita: ");
            double f = double.Parse(Console.ReadLine());

            double c = (f - 32) / 1.8;

            Console.WriteLine(f + "°F = " + c + "°C");
        }
        else
        {
            Console.WriteLine("Blędna opcja");
        }
    }
}
