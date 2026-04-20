class Volunteer:
    def __init__(self, name: str, phone: str):
        self.name = name
        self.phone = phone

class Animal: 
    def __init__(self, name: str, species: str):
        self.name = name
        self.species = species
        self.caretaker = None
        self.is_adopted = False 

class Adoption:
    def __init__(self):
        self.animals = []

    def register_animal(self, animal):
        self.animals.append(animal)
        print(f"Zarejestrowano: {animal.name} (Gatunek: {animal.species})")

    def assign_caretaker(self, animal, volunteer):
        animal.caretaker = volunteer
        print(f"Wolontariusz {volunteer.name} (tel. {volunteer.phone}) został opiekunem zwierzaka o imieniu {animal.name}.")

    def process_adoption(self, animal):
        if not animal.is_adopted:
            animal.is_adopted = True
            print(f"SUKCES! Zwierzę {animal.name} znalazło nowy dom!")
        else:
            print(f"Zwierzę {animal.name} zostało już wcześniej zaadoptowane.")

# Testy
if __name__ == "__main__":
    vol1 = Volunteer("Jan Nowak", "123-456-789")
    vol2 = Volunteer("Adam Kowalski", "987-654-321")

    dog = Animal("Reksio", "Pies")
    cat = Animal("Kot w butach", "Kot")

    shelter = Adoption()

    print("REJESTRACJA")
    shelter.register_animal(dog)
    shelter.register_animal(cat)

    print("\nPRZYDZIAŁ OPIEKUNA")
    shelter.assign_caretaker(dog, vol1)
    shelter.assign_caretaker(cat, vol2)

    print("\nPROCES ADOPCJI")
    shelter.process_adoption(dog)

    shelter.process_adoption(dog) #Test ponownej adopcji 
