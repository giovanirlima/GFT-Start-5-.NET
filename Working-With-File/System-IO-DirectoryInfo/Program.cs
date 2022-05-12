var path = @"c:\VS2022\GFT Start #5 .NET\Working-With-File\Sistem-IO-Directory\bin\Debug\net6.0\Globo";

LerDiretorios(path);


static void LerDiretorios(string path)
{
    if (Directory.Exists(path))
    {
        var diretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
        foreach (var d in diretorios)
        {
            var dirInfo = new DirectoryInfo(d);
            Console.WriteLine($"[Nome]: {dirInfo.Name}");
            Console.WriteLine($"[Nome]: {dirInfo.Root}");
            if (dirInfo.Parent != null)
                Console.WriteLine($"[Pai]: {dirInfo.Parent.Name}");

            Console.WriteLine("-------------------------------------");
        }
    }

    else
    {
        Console.WriteLine($"Diretório {path} não existe");
    }

}