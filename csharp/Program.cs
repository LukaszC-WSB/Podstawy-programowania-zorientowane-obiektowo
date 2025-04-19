using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1. Kalkulator");
        Console.WriteLine("2. Konwerter temperatur");
        Console.WriteLine("3. Średnia ocen");
        Console.Write("Wybierz opcję (1/2/3): ");
        string wybor = Console.ReadLine();

        switch (wybor)
        {
            case "1": Kalkulator(); break;
            case "2": KonwerterTemperatur(); break;
            case "3": SredniaOcen(); break;
            default: Console.WriteLine("Nieprawidłowy wybór."); break;
        }
    }

    static void Kalkulator()
    {
        Console.Write("Podaj pierwszą liczbę: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Podaj drugą liczbę: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Wybierz operację \n 1 - + \n 2 - -\n 3 - * \n 4 - / ");
        string op = Console.ReadLine();

        if (op == "1") Console.WriteLine("Wynik: " + (a + b));
        else if (op == "2") Console.WriteLine("Wynik: " + (a - b));
        else if (op == "3") Console.WriteLine("Wynik: " + (a * b));
        else if (op == "4")
            Console.WriteLine(b != 0 ? "Wynik: " + (a / b) : "Nie można dzielić przez zero!");
        else Console.WriteLine("Nieznana operacja.");
    }

    static void KonwerterTemperatur()
    {
        Console.Write("Podaj kierunek konwersji \n 1-Celciusz-Fahrenheit \n 2-Fahrenheit-Celciusz): ");
        string k = Console.ReadLine().ToUpper();
        Console.Write("Podaj temperaturę: ");
        double t = Convert.ToDouble(Console.ReadLine());

        if (k == "1")
        {
            if (t < -273.15)
                Console.WriteLine("Temperatura nie może być niższa niż -273.15°C");
            else
                Console.WriteLine($"{t:F2}°C = {(t * 1.8 + 32):F2}°F");
        }
        else if (k == "2")
        {
            if (t < -459.67)
                Console.WriteLine("Temperatura nie może być niższa niż -459,67°F");
            else
            {
                double c = (t - 32) / 1.8;
                Console.WriteLine($"{t:F2}°F = {c:F2}°C");
            }
        }
        else
            Console.WriteLine("Nieprawidłowy kierunek.");
    }

    static void SredniaOcen()
    {
        Console.Write("Ile ocen: ");
        int n = int.Parse(Console.ReadLine());
        double suma = 0;
        for (int i = 0; i < n; i++)
        {
            double ocena;
            while (true)
            {
                Console.Write($"Ocena {i + 1} (1–6): ");
                ocena = Convert.ToDouble(Console.ReadLine());
                if (ocena >= 1 && ocena <= 6)
                    break;
                Console.WriteLine("Nieprawidłowa ocena. Wprowadź wartość od 1 do 6.");
            }
            suma += ocena;
        }
        double s = suma / n;
        Console.WriteLine($"Średnia: {s:F2}");
        Console.WriteLine(s >= 3.0 ? "Uczeń zdał." : "Uczeń nie zdał.");
    }
}
