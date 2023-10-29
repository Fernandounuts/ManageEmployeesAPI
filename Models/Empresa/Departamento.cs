using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkOp.Models.Empresa; 

public class Departamento {
    [Key] public long? DepartamentoId { get; set; }
    [Required] public string? DeptoNome { get; set; }
    
    [MaxLength(200)]
    public string? DescricaoDepto { get; set; }
    
    public List<Funcionario.Funcionario>? FuncionariosDepto { get; set; }

    public List<Projeto>? ProjetosDepto { get; set; }
}