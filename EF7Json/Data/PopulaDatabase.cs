using EF7Json.Entities;

namespace EF7Json.Data;

public class PopulaDatabase
{
    public static void PopularTabela()
    {
        using (var context = new AppDbContext())
        {
            var maria = new Aluno()
            {
                Nome = "Maria",
                Endereco = new Endereco()
                {
                    Pais = "Brasil",
                    Local = "Rua Projetada 100",
                    Telefones = "12-9857-44, 13-9854-8877"
                }
            };
            var amanda = new Aluno()
            {
                Nome = "Amanda",
                Endereco = new()
                {
                    Local = "Pça XV de Novembro 20",
                    Pais = "Brasil",
                    Telefones = "11-8875-1234"
                }
            };
            var manoel = new Aluno()
            {
                Nome = "Manoel",
                Endereco = new()
                {
                    Local = "Rua Camões 34",
                    Pais = "Portugal",
                    Telefones = "55 7605-1234"
                }
            };

            var cristina = new Aluno()
            {
                Nome = "Cristina",
                Endereco = new()
                {
                    Local = "Calle Felipe Vallese 10",
                    Pais = "Argentina",
                    Telefones = "55 213-215-200"
                }
            };

            context.Add(maria);
            context.Add(amanda);
            context.Add(manoel);
            context.Add(cristina);

            context.SaveChanges();
        }
    }
}
