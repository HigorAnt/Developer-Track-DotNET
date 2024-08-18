namespace EmployeeRegistrationSystem.API.Models;
public class Funcionario
{
    public Funcionario()
    {
        
    }
    public Funcionario(int id, string nome, string endereco, string ramal, string emailProfisisonal, string departamento, decimal salario, DateTimeOffset dataAdmissao)
    {
        Id = id;
        Nome = nome;
        Endereco = endereco;
        Ramal = ramal;
        EmailProfissional = emailProfisisonal;
        Departamento = departamento;    
        Salario = salario;
        DataAdmissao = dataAdmissao;
    }
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Ramal { get; set; }
    public string EmailProfissional { get; set; }
    public string Departamento { get; set; }
    public decimal Salario { get; set; }
    public DateTimeOffset? DataAdmissao { get; set; }
}
