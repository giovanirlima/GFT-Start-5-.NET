using ProjectTV.Interfaces;
using System;
using System.Collections.Generic;
using ProjectTV;

SerieRepositorio repositorio = new SerieRepositorio();

string opcaoUsuario = ObterOpcaoUsuario();

while (opcaoUsuario != "X")
{
    switch (opcaoUsuario)
    {
        case "1":
            ListarSerie();
            break;
        case "2":
            InserirSerie();
            break;
        case "3":
            AtualizarSerie();
            break;
        case "4":
            ExcluirSerie();
            break;
        case "5":
            VisualizarSerie();
            break;
        case "C":
            Console.Clear();
            break;
        case "c":
            Console.Clear();
            break;

        default:
            throw new Exception("Digite uma das opções válidas!");


    }
    opcaoUsuario = ObterOpcaoUsuario();

}



static string ObterOpcaoUsuario()
{
    Console.WriteLine();
    Console.WriteLine("Dio Séries a seu dispor!");
    Console.WriteLine("Informe a opção desejada");
    Console.WriteLine();
    Console.WriteLine("1 - Listar séries");
    Console.WriteLine("2 - Inserir nova série");
    Console.WriteLine("3 - Atualizar série");
    Console.WriteLine("4 - Excluir série");
    Console.WriteLine("5 - Visualizar série");
    Console.WriteLine("C - Limpar Tela");
    Console.WriteLine("X - Sair");
    Console.WriteLine("");

    string opcaoUsuario = Console.ReadLine();
    Console.WriteLine();

    return opcaoUsuario;

}

void ListarSerie()
{
    Console.WriteLine("Listar séries");

    var lista = repositorio.Lista();

    if (lista.Count == 0)
    {
        Console.WriteLine("Nenhuma série cadastrada.");
        return;
    }
    foreach (var serie in lista)
    {
        var excluido = serie.RetornaExluido();
        if(!excluido)
        Console.WriteLine($"ID: {serie.RetornaId()} - {serie.RetornaTitulo()}");
    }

}
void InserirSerie()
{
    Console.WriteLine("Inserir nova Série");

    foreach (int i in Enum.GetValues(typeof(Genero)))
    {
        Console.WriteLine($"{Enum.GetName(typeof(Genero), i)} - {i}");
    }

    Console.WriteLine();
    Console.Write("Digite o genêro entre as opções a cima: ");
    int entradaGenero = int.Parse(Console.ReadLine());

    Console.Write("Digite o Titulo da série: ");
    string entradaTitulo = Console.ReadLine();

    Console.Write("Digite o Ano da série: ");
    int entradaAno = int.Parse(Console.ReadLine());

    Console.Write("Digite a Descrição da série: ");
    string entradaDescricao = Console.ReadLine();

    Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                genero: (Genero)entradaGenero,
                                titulo: entradaTitulo,
                                ano: entradaAno,
                                descricao: entradaDescricao);
    repositorio.Insere(novaSerie);
}

void AtualizarSerie()
{
    var lista = repositorio.Lista();
    foreach (var serie in lista)
    {
        Console.WriteLine($"ID: {serie.RetornaId()} - {serie.RetornaTitulo()}");
    }
    Console.WriteLine();
    Console.Write("Digite o id da Série: ");
    int indiceSerie = int.Parse(Console.ReadLine());

    foreach (int i in Enum.GetValues(typeof(Genero)))
    {
        Console.WriteLine($"{Enum.GetName(typeof(Genero), i)} - {i}");
    }

    Console.WriteLine();
    Console.Write("Digite o genêro entre as opções a cima: ");
    int entradaGenero = int.Parse(Console.ReadLine());

    Console.Write("Digite o Titulo da série: ");
    string entradaTitulo = Console.ReadLine();

    Console.Write("Digite o Ano da série: ");
    int entradaAno = int.Parse(Console.ReadLine());

    Console.Write("Digite a Descrição da série: ");
    string entradaDescricao = Console.ReadLine();

    Serie atualizaSerie = new Serie(id: indiceSerie,
                                genero: (Genero)entradaGenero,
                                titulo: entradaTitulo,
                                ano: entradaAno,
                                descricao: entradaDescricao);
    repositorio.Atualiza(indiceSerie, atualizaSerie);
}

void ExcluirSerie()
{
    Console.WriteLine("Deseja continuar com a exclusão da série? (s/n)");
    char resp = char.Parse(Console.ReadLine());

    if (resp == 's' || resp == 'S')
    {
        var lista = repositorio.Lista();
        foreach (var serie in lista)
        {
            Console.WriteLine($"ID: {serie.RetornaId()} - {serie.RetornaTitulo()}");
        }
        Console.WriteLine();
        Console.Write("Digite o id da Série: ");
        int indiceSerie = int.Parse(Console.ReadLine());

        repositorio.Exclui(indiceSerie);
        return;
    }
    Console.WriteLine("Retornando ao menu principal!");
}

void VisualizarSerie()
{
    Console.Write("Qual o id da série que deseja visualizar: ");
    int indiceSerie = int.Parse(Console.ReadLine());

    Console.WriteLine($"{repositorio.RetornaPorId(indiceSerie)}");

}