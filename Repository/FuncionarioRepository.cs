using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkOp.Data;
using WorkOp.Interfaces;
using WorkOp.Models.Funcionario;

namespace WorkOp.Repository; 

public class FuncionarioRepository : IFuncionarioRepository{
    private readonly AppDbContext _context;

    public FuncionarioRepository(AppDbContext context) {
        _context = context;
    }
    
    public async Task<List<Funcionario>> GetAllFuncionarios(long? empresaId) {
        return await _context.Funcionarios
            .Where(f => f.EmpresaId == empresaId)
            .ToListAsync();
    }

    public async Task<List<Funcionario>> GetFuncionarioById(long? empresaId, long? funcionarioId) {
        return await _context.Funcionarios
            .Where(f => f.EmpresaId == empresaId && f.FuncionarioId == funcionarioId)
            .ToListAsync();
    }

    public async Task<List<Funcionario>> GetFuncionariosInDepartameto(long? departamentoId) {
        var depto = await _context.Departamentos
            .Where(d => d.DepartamentoId == departamentoId).Include(departamento => departamento.FuncionariosDepto)
            .FirstOrDefaultAsync();

        return depto.FuncionariosDepto;
    }

    public async Task<Funcionario> GetFuncionariosByIdInDepartamento(long? departamentoId, long? funcionarioId) {
        throw new NotImplementedException();
    }

    public Task<Funcionario> GetFuncionariosByIdInProjeto(long? funcionarioId, long? projetoId) {
        throw new NotImplementedException();
    }

    public Task<List<Funcionario>> GetFuncionariosByProjeto(long? departamentoId) {
        throw new NotImplementedException();
    }

    public async Task<bool> FuncionarioExists(long? funcionarioId) {
        return _context.Funcionarios.Any(f => f.FuncionarioId == funcionarioId);
    }
}