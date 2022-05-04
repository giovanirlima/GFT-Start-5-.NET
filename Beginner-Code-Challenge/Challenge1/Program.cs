using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());

            double media = ((A * 2.0) + (B * 3.0) + (C * 5.0)) / 10.0;
            Console.WriteLine($"MEDIA = {media.ToString("F1")}");
            Console.ReadKey();
        }
    }
}