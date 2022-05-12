var path = @"c:\VS2022\GFT Start #5 .NET\Working-With-File\Sistem-IO-Directory\bin\Debug\net6.0\Globo";

LerArquivos(path);



static void LerArquivos(string path)
{
    if (!File.Exists(path))
    {
        var arquivos = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
        foreach (var arquivo in arquivos)
        {
            var fileInfo = new FileInfo(arquivo);
            Console.WriteLine($"[Nome]: {fileInfo.Name}");
            Console.WriteLine($"[Tamanho]: {fileInfo.Length}");
            Console.WriteLine($"[Último acesso]: {fileInfo.LastAccessTime}");
            Console.WriteLine($"[Pasta]: {fileInfo.DirectoryName}");
            Console.WriteLine("-----------------------------------------");
        }
    }

    if (File.Exists(path))
    {
        Console.WriteLine($"{path} não existe!");
    }

}

