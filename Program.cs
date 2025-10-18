// jakis uproszczony kod
// Console.WriteLine("Hello, World!");

// klasyczna wersja kodu

internal class Program
{
    // nic nie zwracająca funkcja Main, która jako argument przyjmuje tablicę args. W środku tej funkcji jest funkcja pisząca Hello World na konsolę
    private static void Main(string[] args)
    {
        // Console.WriteLine("Hello, Paulina!");
        // stare, nieeleganckie
        // Console.WriteLine(args[0] + args[1]);
        // Console.WriteLine($"{args[0]} {args[1]}");
        // Console.WriteLine($"Sumą 2+2 jest {2 + 2}");

        // Definiowanie zmiennych
        // Int32 a = 5;
        // Int32 b = 10;
        // Int32 suma = a + b;
        // Console.WriteLine($"Suma {a} + {b} = {suma}");

        // Definiowanie stałych
        // const Double PI = 3.14;
        // Console.WriteLine($"Wartość liczby PI to {PI}");

        // Pobieranie wartości od użytkownika i parsowanie na liczbę całkowitą
        Int32 a = Int32.Parse(args[0]);
        Int32 b = Int32.Parse(args[1]);
        Console.WriteLine($"Suma {a} + {b} = {a + b}");

        

    }
}