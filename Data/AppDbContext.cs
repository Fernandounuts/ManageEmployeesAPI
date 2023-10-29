using Microsoft.EntityFrameworkCore;
using WorkOp.Models;
using WorkOp.Models.Empresa;
using WorkOp.Models.Funcionario;

namespace WorkOp.Data; 

public class AppDbContext : DbContext {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Empresa> Empresas { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Projeto> Projetos { get; set; }
    public DbSet<Departamento> Departamentos { get; set; }
}