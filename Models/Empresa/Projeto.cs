using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkOp.Models.Empresa; 

public class Projeto {
    [Key]
    public long? ProjetoId { get; set; }
    
    [ForeignKey("Departamento")] public long DepartamentoId { get; set; }
    public Departamento? Departamento { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string? ProjetoNome { get; set; }

    public List<Funcionario.Funcionario>? FuncionariosProjeto { get; set; }

    [Required]
    public DateTime DataInicio { get; set; }
    
    public DateTime? DataEntrega { get; set; }
}