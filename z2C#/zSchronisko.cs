using System;

public class Volunteer
{
    public string Name { get; }
    public string Phone {  get; }

    public Volunteer(string name, string phone)
    {
        Name = name;
        Phone = phone;
    }
}

public class Animal
{
    public string Name { get; }
    public string Species { get; }
    public bool IsAdopted { get; set; }
    public Volunteer Caretaker { get; set; }

    public Animal(string name, string species)
    {
        Name = name;
        Species = species;
        IsAdopted = false;
        Caretaker = null;
    }
}

public class Adoption
{
    private readonly List<Animal> animals = new List<Animal>();

    public void RegisterAnimal(Animal animal)
    {
        animals.Add(animal);
        Console.WriteLine($"Zarejestrowano: {animal.Name} (Gatunek: {animal.Species})");
    }

    public void AssignCaretaker(Animal animal, Volunteer volunteer)
    {
        animal.Caretaker = volunteer;
        Console.WriteLine($"Wolontariusz {volunteer.Name} (tel. {volunteer.Phone}) został opiekunem zwierzaka o imieniu {animal.Name}");
    }

    public void ProcessAdoption(Animal animal)
    { 
        if (!animal.IsAdopted)
        {
            animal.IsAdopted = true;
            Console.WriteLine($"SUKCES! Zwierzę {animal.Name} znalazło nowy dom!");
        }
        else
        {
            Console.WriteLine($"Zwierzę {animal.Name} zostało już wcześniej zaadoptowane");
        }
    }
}
//Testy
class Program
{
    static void Main()
    {
        var vol1 = new Volunteer("Jan Nowak", "123-456-789");
        var vol2 = new Volunteer("Adam Kowalski", "987-654-321");

        var dog = new Animal("Reksio", "Pies");
        var cat = new Animal("Kot w butach", "Kot");

        var shelter = new Adoption();

        Console.WriteLine("REJESTRACJA");
        shelter.RegisterAnimal(dog);
        shelter.RegisterAnimal(cat);

        Console.WriteLine("\nPRZYDZIAŁ OPIEKUNA");
        shelter.AssignCaretaker(dog, vol1);
        shelter.AssignCaretaker(cat, vol2);

        Console.WriteLine("\nPROCES ADOPCJI");
        shelter.ProcessAdoption(dog);

        shelter.ProcessAdoption(dog); //Test ponownej adopcji
    }
}