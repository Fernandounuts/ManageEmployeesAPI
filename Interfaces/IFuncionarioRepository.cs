using Microsoft.AspNetCore.Mvc;
using WorkOp.Models.Funcionario;

namespace WorkOp.Interfaces; 

public interface IFuncionarioRepository {
    public Task<List<Funcionario>> GetAllFuncionarios(long? empresaId);

    public Task<List<Funcionario>> GetFuncionarioById(long? empresaId, long? funcionarioId);

    public Task<List<Funcionario>> GetFuncionariosInDepartameto(long? departamentoId);
    public Task<Funcionario> GetFuncionariosByIdInDepartamento(long? departamentoId, long? funcionarioId);

    public Task<Funcionario> GetFuncionariosByIdInProjeto(long? funcionarioId, long? projetoId);
    public Task<List<Funcionario>> GetFuncionariosByProjeto(long? departamentoId);

    public Task<bool> FuncionarioExists(long? funcionarioId);
}