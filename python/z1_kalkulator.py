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
    wynik = l1 / l2
    if l2 != 0:
        wynik = l1 / l2
    else:
        print("Nie można dzielić przez 0")
else:
    print("Wybrano nieprawidłowe działanie")
    

print("Wynik: ", wynik)