
CriarCsv();



static void CriarCsv()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Saida");

    var pessoas = new List<Pessoa>()
    {
        new Pessoa()
        {
            Nome = "José da Silva",
            Email = "js@gmail.com",
            Telefone = 123456,
            Nascimento = new DateOnly(year: 1970, month: 2, day: 14)
        },
        new Pessoa()
        {
            Nome = "Pedro Jose Neto",
            Email = "pjn@gmail.com",
            Telefone = 1234568,
            Nascimento = new DateOnly(year: 1971, month: 3, day: 15)
        },
        new Pessoa()
        {
            Nome = "Maria Maria",
            Email = "mm@gmail.com",
            Telefone = 1234567,
            Nascimento = new DateOnly(year: 1973, month: 5, day: 25)
        },
        new Pessoa()
        {
            Nome = "Giovani Rocha Lima",
            Email = "grl@gmail.com",
            Telefone = 992804976,
            Nascimento = new DateOnly(year: 1994, month: 3, day: 24)
        },
     };

    var di = new DirectoryInfo(path);
    if (!di.Exists)
    {
        di.Create();
        path = Path.Combine(path, "usuarios.csv");
    }
    
    using var sw = new StreamWriter(path);

    sw.WriteLine("nome,email,telefone,nascimento");

    foreach (var pessoa in pessoas)
    {
        var linha = $"{pessoa.Nome}, {pessoa.Email}, {pessoa.Telefone}, {pessoa.Nascimento}";
        sw.WriteLine(linha);
    }
}

class Pessoa
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public int Telefone { get; set; }
    public DateOnly Nascimento { get; set; }
}