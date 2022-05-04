using System;

class Problem
{

    static void Main(string[] args)
    {
        string[] v = Console.ReadLine().Split();
        int N = int.Parse(v[0]);
        int L = int.Parse(v[1]);

        int P = N * L;

        Console.WriteLine(P);

    }
}