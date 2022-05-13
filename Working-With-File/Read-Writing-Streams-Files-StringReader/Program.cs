// String Reader 
using System.Text;

var sb = new StringBuilder();
sb.AppendLine("Caracteres na primeira linha para ler");
sb.AppendLine("segue segunda linha");
sb.AppendLine("fim");

using var sr = new StringReader(sb.ToString());
var buffer = new char[10];
var tamanho = 0;


do
{
    Console.WriteLine(sr.ReadLine());
}while(sr.Peek() >= 0);


//do
//{
//    buffer = new char[10];
//    tamanho = sr.Read(buffer);
//    Console.Write($"{string.Join("", buffer)}");
//} while (tamanho >= buffer.Length);

Console.WriteLine("Enter para finalizar");

Console.WriteLine();
