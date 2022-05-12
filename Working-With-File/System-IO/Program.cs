using static System.Console;

Console.WriteLine("Digite o nome d oarquivo: ");
var nome = ReadLine();
nome = LimparNome(nome);


var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");
CriarArquivo(path);

Console.WriteLine("Digite enter para finalizar");
ReadLine();



static string LimparNome(string nome)
{
    foreach (var @char in Path.GetInvalidFileNameChars())
    {
        nome = nome.Replace(@char, '-');
    }
    return nome;
}

static void CriarArquivo(string path)
{
    try
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("Está é a linha 1");
        sw.WriteLine("Esta é a linha 2");
        sw.WriteLine("Está é a linha 3");
    }
    catch
    {
        Console.WriteLine("O nome do arquivo está invalido");
    }
}
