using Microsoft.AspNetCore.Mvc;
using WorkOp.Models.Funcionario;

namespace WorkOp.Interfaces; 

public interface IFuncionarioRepository {
    public Task<List<Funcionario>> GetAllFuncionarios(long? empresaId);

    public Task<IActionResult> GetFuncionarioById(long? empresaId, long? funcionarioId);

    public Task<IActionResult> GetFuncionariosInDepartametn(long? departamentoId);
    public Task<List<IActionResult>> GetFuncionariosByIdInDepartamento(long? departamentoId, long? funcionarioId);

    public Task<IActionResult> GetFuncionariosByIdInProjeto(long? funcionarioId, long? projetoId);
    public Task<List<IActionResult>> GetFuncionariosByProjeto(long? departamentoId);

    public Task<bool> FuncionarioExists(long? funcionarioId);
}