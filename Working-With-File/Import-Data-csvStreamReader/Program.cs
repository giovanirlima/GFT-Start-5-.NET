var path = Path.Combine(
    Environment.CurrentDirectory,
    "Usuarios.csv");

if (File.Exists(path))
{
    Console.WriteLine($"O arquivo {path} não existe.");

    using var sr = new StreamReader(path);

    var cabecalho = sr.ReadLine()?.Split(',');

    while (true)
    {
        var registro = sr.ReadLine()?.Split(',');

        if (registro == null) break;

        if (cabecalho.Length != registro.Length)
        {
            Console.WriteLine("Arquivo fora do padrão!");
            break;
        }
        for (int i = 0; i < registro.Length; i++)
        {
            Console.WriteLine($"{cabecalho?[i]} : {registro?[i]}");
        }
        Console.WriteLine("--------");

    }
    Console.WriteLine("\n\nPrecione [enter] para sair ...");
}
Console.WriteLine($"O arquivo {path} não existe.");