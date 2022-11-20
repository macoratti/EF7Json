using System.ComponentModel.DataAnnotations;

namespace EF7Json.Entities;

//owned entity
public class Endereco
{
    [MaxLength(200)]
    public string Local { get; set; } = null!;
    [MaxLength(100)]
    public string Pais { get; set; } = null!;
    [MaxLength(200)]
    public string? Telefones { get; set; }
}
