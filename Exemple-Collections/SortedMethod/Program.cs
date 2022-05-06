using SortedMethod.Entities;


OperationArray op = new OperationArray();

int[] array = { 19, 3, 7, 1, 15, 25, 1, 2, 9 };
int[] copyArray = new int[10];

Console.WriteLine("Array Original!");
op.PrintOut(array);

Console.WriteLine();
op.Order(ref array);

Console.WriteLine("Array Ordenado!");
op.PrintOut(array);

op.CopyLogica(array, copyArray);
Console.WriteLine();

Console.WriteLine("Copia do Array Logica!");
op.PrintOut(copyArray);

op.Copy(array, copyArray);
Console.WriteLine();

Console.WriteLine("Copia do Array System!");
op.PrintOut(copyArray);

Console.WriteLine();

int valorProcurado = 10;
bool existe = op.Exist(array, valorProcurado);

if (existe)
{
    Console.WriteLine($"Valor encontrato {valorProcurado}");
}
else
{
    Console.WriteLine($"Valor não encontrato {valorProcurado}");
}