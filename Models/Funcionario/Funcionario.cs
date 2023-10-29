using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkOp.Models.Funcionario; 

public class Funcionario {
    [Key] public int FuncionarioId { get; set; }
    [ForeignKey("Endereco")] public long EnderecoId { get; set; }
    [Required] public Endereco? Endereco { get; set; }
    
    [ForeignKey("Empresa")] public long? EmpresaId { get; set; }
    public Empresa.Empresa Empresa { get; set; }
    
    [Required] 
    [MaxLength(70)] 
    public string? FuncionarioNome { get; set; }

    [Required] public DateOnly DiaContratacao { get; set; }
    public DateOnly? DiaTerminacao { get; set; } 
}