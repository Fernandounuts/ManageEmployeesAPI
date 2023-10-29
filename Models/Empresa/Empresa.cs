using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkOp.Models.Empresa; 

public class Empresa {
    [Key] public long EmpresaId { get; set; }
    [ForeignKey("Endereco")] public long EnderecoId { get; set; }
    [Required] public Endereco Endereco { get; set; }
    
    [Required] 
    [MaxLength(100)] 
    public string? Nome { get; set; }

    public List<Funcionario.Funcionario> FuncionariosEmpresa { get; set; }
}