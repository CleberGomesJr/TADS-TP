using System.ComponentModel.DataAnnotations;

public class Fabricante
{
    [Key]
    public int IdFabricante { get; set; }
    public string Nome { get; set; }
    public ICollection<Veiculo> Veiculos { get; set; }
}