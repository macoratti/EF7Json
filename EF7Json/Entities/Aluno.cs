using System.ComponentModel.DataAnnotations;

namespace EF7Json.Entities;

public class Aluno
{
    public int Id { get; set; }
    [MaxLength(100)]
    public string Nome { get; set; } = null!;
    public Endereco Endereco { get; set; } = null!;
}
