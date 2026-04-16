using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Prosty Kalkulator");

        Console.Write("Podaj pierwszą liczbę: ");
        double l1 = double.Parse(Console.ReadLine());

        Console.Write("Podaj drugą liczbę: ");
        double l2 = double.Parse(Console.ReadLine());

        Console.Write("Wybierz działanie (+, -, *, /): ");
        string znak = Console.ReadLine();

        double wynik = 0;

        if (znak == "+")
        {
            wynik = l1 + l2;
        }
        else if (znak == "-")
        {
            wynik = l1 - l2;
        }
        else if (znak == "*")
        {
            wynik = l1 * l2;
        }
        else if (znak == "/")
        {
            if (l2 != 0)
                wynik = l1 / l2;
            else
            {
                Console.WriteLine("Nie można dzielić przez 0");
                return;
            }
        }
        else
        {
            Console.WriteLine("Wybrano nieprawidłowe działanie");
            return;
        }

        Console.WriteLine("Wynik: " + wynik);
    }
}
