using SortingArray.Entities;



OperationArray op = new OperationArray();
int[] array = { 6, 3, 8, 1, 9 };


Console.WriteLine("Array original!");
op.ImprimirArray(array);

Console.WriteLine();

op.OrdenarBubbleSort(ref array);
Console.WriteLine("Array bubble!");
op.ImprimirArray(array);