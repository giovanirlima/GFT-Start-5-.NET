CriarDiretoriosGlobal();
CriarArquivoBr();
CriarArquivoArg();

var origemBr = Path.Combine(Environment.CurrentDirectory, "Brasil.txt");
var destinoBr = Path.Combine(Environment.CurrentDirectory, "Globo", "América do Sul", "Brasil", "Brasil.txt");

var origemArg = Path.Combine(Environment.CurrentDirectory, "Argentina.txt");
var destinoArg = Path.Combine(Environment.CurrentDirectory, "Globo", "América do Sul", "Argentina", "Argentina.txt");

//MoverArquivo(origemBr, destinoBr);
//MoverArquivo(origemArg, destinoArg);
  
CopiarArquivo(origemBr, destinoBr);
CopiarArquivo(origemArg, destinoArg);


static void CriarArquivoArg()
{
    var path = Path.Combine(Environment.CurrentDirectory, $"Argentina.txt");
    if (!File.Exists(path))
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("Oíd mortales, el grito sagrado");
        sw.WriteLine("Libertad, libertad, libertad");
        sw.WriteLine("Oíd el ruido de rotas cadenas");
        sw.WriteLine("Ved el trono a la noble igualdad");
    }
}

static void CriarArquivoBr()
{
    var path = Path.Combine(Environment.CurrentDirectory, $"Brasil.txt");
    if (!File.Exists(path))
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("Ouviram do Ipiranga as margens placidas,");
        sw.WriteLine("De um povo Heróico, bravo e retumbante.");
        sw.WriteLine("E o sol da liberdade raios Fúlgidos,");
        sw.WriteLine("Brilhou no céu da patria nesse instante.");
    }
}

static void MoverArquivo(string pathOrigem, string pathDestino)
{
    if (!File.Exists(pathOrigem))
    {
        Console.WriteLine("Arquivo de origem não existe!");
        return;
    }
    if (File.Exists(pathDestino))
    { 
        Console.WriteLine("Arquivo ja existe na pasta de destino!");
        return;
    }

    File.Move(pathOrigem, pathDestino);

}

static void CopiarArquivo(string pathOrigem, string pathDestino)
{
    if (!File.Exists(pathOrigem))
    {
        Console.WriteLine("Arquivo não existe no diretorio!");
        return;
    }
    if (File.Exists(pathDestino))
    {
        Console.WriteLine("Arquivo ja existe na pasta destino!");
        return;
    }

    File.Copy(pathOrigem, pathDestino);
}

static void CriarDiretoriosGlobal()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Globo");
    if (!Directory.Exists(path))
    {
        var dirGlobal = Directory.CreateDirectory(path);
        var dirAmNorte = dirGlobal.CreateSubdirectory("América do Norte");
        var dirAmCentral = dirGlobal.CreateSubdirectory("América Central");
        var dirAmSul = dirGlobal.CreateSubdirectory("América do Sul");

        dirAmNorte.CreateSubdirectory("USA");
        dirAmNorte.CreateSubdirectory("Mexico");
        dirAmNorte.CreateSubdirectory("Canada");

        dirAmCentral.CreateSubdirectory("Costa Rica");
        dirAmCentral.CreateSubdirectory("Panama");

        dirAmSul.CreateSubdirectory("Brasil");
        dirAmSul.CreateSubdirectory("Argentina");
        dirAmSul.CreateSubdirectory("Paraguai");
    }
}