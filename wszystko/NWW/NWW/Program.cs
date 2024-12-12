using System;

class Program
{
    // Funkcja do obliczania NWD (Największy Wspólny Dzielnik) przy użyciu algorytmu Euklidesa
    static int NWD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    // Funkcja do obliczania NWW (Najmniejsza Wspólna Wielokrotność)
    static int NWW(int a, int b)
    {
        return (a * b) / NWD(a, b);
    }

    static void Main(string[] args)
    {
        Console.Write("Podaj pierwszą liczbę: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Podaj drugą liczbę: ");
        int b = int.Parse(Console.ReadLine());
        
        int wynikNWW = NWW(a, b);// Oblicz NWW dla podanych liczb
        Console.WriteLine($"NWW({a}, {b}) = {wynikNWW}");
    }
}
