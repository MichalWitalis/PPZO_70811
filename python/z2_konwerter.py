print("Konwerter temperatur")
print("C - Celsjusz -> Fahrenheit")
print("F - Fahrenheit -> Celsjusz")

wybor = input("Wybierz opcję (C/F): ")

if wybor == 'C':
    c = float(input("Podaj temperaturę w stopniach Celsjusza: "))
    f = c * 1.8 + 32
    print(f"{c} °C = {f} °F")

elif wybor == 'F':
    f = float(input("Podaj temperaturę w stopniach Fahrenheita: "))
    c = (f - 32) / 1.8
    print(f"{f} °F = {c} °C")

else:
    print("Błędna opcja")
