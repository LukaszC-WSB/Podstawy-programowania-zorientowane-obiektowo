def kalkulator():
    a = float(input("Podaj pierwszą liczbę: "))
    b = float(input("Podaj drugą liczbę: "))
    operacja = input("Wybierz operację \n 1 - + \n 2 - -\n 3 - * \n 4 - / ")

    if operacja == '1':
        print("Wynik:", a + b)
    elif operacja == '2':
        print("Wynik:", a - b)
    elif operacja == '3':
        print("Wynik:", a * b)
    elif operacja == '4':
        print("Wynik:", a / b if b != 0 else "Nie można dzielić przez zero!")
    else:
        print("Nieznana operacja.")

def konwerter_temperatur():
    kierunek = input("Podaj kierunek konwersji \n 1-Celciusz-Fahrenheit \n 2-Fahrenheit-Celciusz): ").upper()
    temp = float(input("Podaj temperaturę: "))

    if kierunek == '1':
        if temp < -273.15:
            print("Temperatura nie może być niższa niż -273.15°C")
        else:
            wynik = temp * 1.8 + 32
            print(f"{temp:.2f}°C = {wynik:.2f}°F")
    elif kierunek == '2':
        if temp < -459.67:
            print("Temperatura nie może być niższa niż -459.67°F")
        else:
            wynik = (temp - 32) / 1.8
            print(f"{temp:.2f}°F = {wynik:.2f}°C")
    else:
        print("Wybierz istniejące opcje..")

def srednia_ocen():
    n = int(input("Ile ocen chcesz podać? "))
    suma = 0
    for i in range(n):
        while True:
            ocena = float(input(f"Podaj ocenę {i+1} (1–6): "))
            if 1 <= ocena <= 6:
                break
            print("Nieprawidłowa ocena. Wprowadź wartość od 1 do 6.")
        suma += ocena
    srednia = suma / n
    print(f"Średnia: {srednia:.2f}")
    print("Uczeń zdał." if srednia >= 3.0 else "Uczeń nie zdał.")

def menu():
    print("1. Kalkulator")
    print("2. Konwerter temperatur")
    print("3. Średnia ocen")
    wybor = input("Wybierz opcję (1/2/3): ")
    if wybor == '1':
        kalkulator()
    elif wybor == '2':
        konwerter_temperatur()
    elif wybor == '3':
        srednia_ocen()
    else:
        print("Nieprawidłowy wybór.")

menu()
