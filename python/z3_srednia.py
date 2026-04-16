print("Średnia ocen")

n = int(input("Podaj liczbę ocen: "))

suma = 0

for i in range(n):
    ocena = float(input(f"Podaj ocenę {i + 1}: "))
    suma += ocena

srednia = suma / n

print(f"Średnia: {round(srednia, 2)}")

if srednia >= 3.0:
    print("Uczeń zdał.")
else:
    print("Uczeń nie zdał.")
