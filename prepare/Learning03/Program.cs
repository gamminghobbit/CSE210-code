using System;

class Program
{
    static void Main(string[] args)
    {
        // Test default constructor (1/1)
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString()); // Should print: 1/1
        Console.WriteLine(f1.GetDecimalValue());   // Should print: 1

        // Test top-only constructor (5/1)
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString()); // Should print: 5/1
        Console.WriteLine(f2.GetDecimalValue());   // Should print: 5

        // Test full constructor (3/4)
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString()); // Should print: 3/4
        Console.WriteLine(f3.GetDecimalValue());   // Should print: 0.75

        // Use setters and getters to change values
        f3.SetTop(1);
        f3.SetBottom(3);
        Console.WriteLine(f3.GetFractionString()); // Should print: 1/3
        Console.WriteLine(f3.GetDecimalValue());   // Should print: 0.333...
    }
}
