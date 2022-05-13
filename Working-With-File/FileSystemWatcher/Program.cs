var path = @"C:\VS2022\GFT Start #5 .NET\Working-With-File\Sistem-IO-Directory\bin\Debug\net6.0\Globo";

using var fsw = new FileSystemWatcher(path);

fsw.Created += OnCreated;
fsw.Renamed += OnRenamed;
fsw.Deleted += OnDeleted;


fsw.EnableRaisingEvents = true;
fsw.IncludeSubdirectories = true;

Console.WriteLine($"Monitorando eventos na pasta {path}");
Console.WriteLine("Aperte [enter] para finalizar!");
Console.ReadLine();

void OnCreated(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi criado o arquivo {e.Name}");

}

void OnDeleted(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi excluído o diretorio {e.Name}");


}

void OnRenamed(object sender, RenamedEventArgs e)
{

    Console.WriteLine($"O diretorio {e.OldName} foi renomeado para {e.Name}");
}