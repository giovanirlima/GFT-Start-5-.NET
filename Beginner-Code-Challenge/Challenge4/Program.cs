using System;

class TESTE
{

    static void Main(string[] args)
    {

        int maior = 0, posicao = 0, j = 1;

        for (int i = 0; i < 100; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (maior < num)
            {
                maior = num;
                posicao = j;
                j++;
            }
            else j++;
        }
        Console.WriteLine(maior);
        Console.WriteLine(posicao);
    }
}
