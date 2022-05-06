

int[,] matriz = new int[2, 2];

for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {

        matriz[i, j] = int.Parse(Console.ReadLine());

    }

}

foreach (var item in matriz)
{
    Console.WriteLine($"{item}");
}

for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {

        Console.WriteLine($"{matriz[i,j]}"); ;

    }

}