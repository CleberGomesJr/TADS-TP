using System.ComponentModel.DataAnnotations;

public class Funcionario
{
    [Key]
    public int IdFuncionario { get; set; }
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public string Email { get; set; }
}