

int[] arrayInteiros = new int[3];

for (int i = 0; i < arrayInteiros.Length; i++)
{
    arrayInteiros[i] = int.Parse(Console.ReadLine());

}

Console.WriteLine();        
Console.WriteLine("Percorrendo Array pelo For");

for (int i = 0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine(arrayInteiros[i]);

}
Console.WriteLine();

Console.WriteLine("Percorrendo Array pelo Foreach");

foreach (var item in arrayInteiros)
{
    Console.WriteLine(item);
}