print ("Prosty kalkulator")

l1 = float(input("Podaj pierwszą liczbę: "))
l2 = float(input("Podaj drugą liczbę: "))
znak = input("Wybierz działanie (+, -, *, /): ")

if znak == '+':
    wynik = l1 + l2
elif znak == '-':
    wynik = l1 - l2
elif znak == '*':
    wynik = l1 * l2
elif znak == '/':
    if l2 != 0:
        wynik = l1 / l2
    else:
        print("Nie można dzielić przez 0")
        exit()
else:
    print("Wybrano nieprawidłowe działanie")
    exit()
    

print("Wynik: ", wynik)
