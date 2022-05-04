using System;

namespace Introducao
{
    class CoxinhaDeBueno
    {
        static void Main(string[] args)
        {
            String[] line = Console.ReadLine().Split(" ");

            double A = double.Parse(line[0]);
            double B = double.Parse(line[1]);
            double total = (A / B);

            Console.WriteLine(total.ToString("F2"));
        }
    }
}