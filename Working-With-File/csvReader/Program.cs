using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using csvReader.Model;
using System.IO;
using System;

namespace csvReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LerCsvComClasse();

        }

        static void LerCsvComClasse()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "novos-usuarios.csv");

            var fi = new FileInfo(path);

            if (!fi.Exists) 
                throw new FileNotFoundException($"O arquivo {path} não existe!");

            var sr = new StreamReader(fi.FullName);

            var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);

            var csvReader = new CsvReader(sr, csvConfig);

            var registros = csvReader.GetRecords<Usuario>();

            foreach (var registro in registros)
            {
                Console.WriteLine($"nome: {registro.Nome}");
                Console.WriteLine($"marca: {registro.Email}");
                Console.WriteLine($"preço: {registro.Telefone}");
                Console.WriteLine("--------------------");
            }
        }

        static void LerCsvComDynamic()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "Produtos.csv");


            var fi = new FileInfo(path);

            if (!fi.Exists) throw new FileNotFoundException($"O arquivo {path} não existe!");

            var sr = new StreamReader(fi.FullName);

            var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);

            var csvReader = new CsvReader(sr, csvConfig);

            var registros = csvReader.GetRecords<dynamic>();

            foreach (var registro in registros)
            {
                Console.WriteLine($"nome: {registro.Produto}");
                Console.WriteLine($"marca: {registro.Marca}");
                Console.WriteLine($"preço: {registro.Preco}");
                Console.WriteLine("--------------------");
            }
        }





    }
}
