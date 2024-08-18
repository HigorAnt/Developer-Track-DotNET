using EmployeeRegistrationSystem.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeRegistrationSystem.API.Contexts;
public class FuncionarioContext : DbContext
{
    public FuncionarioContext(DbContextOptions<FuncionarioContext> options) : base(options)
    {

    }
    public DbSet<Funcionario> Funcionarios { get; set; }
}
