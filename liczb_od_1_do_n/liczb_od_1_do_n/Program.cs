using System;

class Program
{
    // Funkcja do obliczania sumy liczb od 1 do n
    static int SumaOd1DoN(int n)
    {
        if (n <= 0) // Sprawdza, czy n jest większe od 0
        {
            throw new ArgumentException("n musi być większe od 0."); // Rzuca wyjątek, jeśli n <= 0
        }

        int suma = 0; // Inicjalizacja zmiennej suma
        for (int i = 1; i <= n; i++) // Iteracja od 1 do n
        {
            suma += i; // Dodaje aktualną wartość i do sumy
        }
        return suma; // Zwraca obliczoną sumę
    }

    static void Main(string[] args)
    {
        try
        {
            // Wczytuje liczbę n od użytkownika
            Console.Write("Podaj liczbę n: ");
            int n = int.Parse(Console.ReadLine());

            // Oblicza sumę liczb od 1 do n i wyświetla wynik
            int wynikSuma = SumaOd1DoN(n);
            Console.WriteLine($"Suma liczb od 1 do {n} = {wynikSuma}");
        }
        catch (Exception ex) // Obsługa wyjątków
        {
            // Wyświetla komunikat o błędzie, jeśli wystąpił wyjątek
            Console.WriteLine($"Błąd: {ex.Message}");
        }
    }
}
