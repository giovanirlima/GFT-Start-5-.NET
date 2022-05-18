using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;

var path = Path.Combine(Environment.CurrentDirectory, "Entrada","Produtos.csv");

var fi = new FileInfo(path);

if (!fi.Exists) 
    throw new FileNotFoundException($"O arquivo {path} não existe!");

using var sr = new StringReader(fi.FullName);

var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);

using var csvReader = new CsvReader(sr, csvConfig);

var registros = csvReader.GetRecords<dynamic>();

foreach (var registro in registros)
{
    Console.WriteLine($"nome: {registro.Produto}");
    Console.WriteLine($"nome: {registro.Marca}");
    Console.WriteLine($"nome: {registro.Preco}");
    Console.WriteLine("------------");
    
}