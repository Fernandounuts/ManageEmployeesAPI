using System.ComponentModel.DataAnnotations;

namespace WorkOp.Models; 

public class Endereco {
    [Key] public long EnderecoId { get; set; }
    [Required] public int Cep { get; set; }
    [Required] public string? Logradouro { get; set; }
    [MaxLength(100)] public string? Complemento { get; set; }
    [Required] [MaxLength(35)] public string? Bairro { get; set; }
    [Required] [MaxLength(40)] public string? Cidade { get; set; }
    [Required] [MaxLength(2)] public string Uf { get; set; }
}