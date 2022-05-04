using System;
class Program
{
    static void Main(string[] args)
    {
        int a, b;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        int PROD = a * b;
        Console.WriteLine($"PROD = {PROD}");
        Console.ReadLine();
    }
}