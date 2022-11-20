
using EF7Json.Data;

//PopulaDatabase.PopularTabela();

//ExibirDados();
//ConsultarDados();
//AtualizarDados();

static void ExibirDados()
{
    using (var context = new AppDbContext())
    {
        var agenda = context.Alunos.ToList();

        Console.WriteLine();

        foreach (var a in agenda)
        {
            Console.WriteLine($"{a.Nome} - {a.Endereco.Pais} - " +
                              $"{a.Endereco.Local} : {a.Endereco.Telefones}");
        }
    }
}

static void ConsultarDados()
{
    using (var context = new AppDbContext())
    {
        var agenda = context.Alunos
            .Where(p => p.Endereco.Pais == "Brasil")
            .OrderBy(p => p.Endereco.Local)
            .ToList();
       
        Console.WriteLine();

        foreach (var a in agenda)
        {
            Console.WriteLine($"{a.Nome} - {a.Endereco.Pais} - " +
                              $"{a.Endereco.Local} : {a.Endereco.Telefones}");
        }
    }
}

static void AtualizarDados()
{
    using (var context = new AppDbContext())
    {
        var aluno = context.Alunos
                           .FirstOrDefault(a => a.Endereco.Pais == "Argentina");

        aluno.Endereco.Local = "Calle Corrientes 999";

        context.SaveChanges();
    }
}