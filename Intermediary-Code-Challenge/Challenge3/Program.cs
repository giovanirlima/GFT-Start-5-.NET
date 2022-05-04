using System;
using System.Linq;
class Media
{
    static void Main()
    {
        double a, b, c, d, avg = 0, e;
        string[] values = Console.ReadLine().Split();
        string[] resultado = { "Aluno aprovado", "Aluno reprovado" };
        int[] pesos = { 2, 3, 4, 1 };

        for (int i = 0; i < 4; i++)
        { avg += (double.Parse(values[i]) * pesos[i]); }
        avg /= pesos.Sum();

        Console.WriteLine($"Media: {avg.ToString("0.0")}");

        if (avg >= 7) { Console.WriteLine(resultado[0] + "."); }
        else if (avg < 5) { Console.WriteLine(resultado[1] + "."); }
        else if (avg <= 6.9)
        {
            e = double.Parse(Console.ReadLine());
            Console.WriteLine("Aluno em exame.");
            Console.WriteLine($"Nota do exame: {e.ToString("0.0")}");
            avg = (avg + e) / 2;

            if (avg >= 5) { Console.WriteLine(resultado[0] + "."); }
            else { Console.WriteLine(resultado[1]); }

            Console.WriteLine($"Media final: {avg.ToString("0.0")}");
        }
    }
}