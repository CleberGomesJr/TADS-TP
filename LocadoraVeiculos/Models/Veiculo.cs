using System.ComponentModel.DataAnnotations;

public class Veiculo
{
    [Key]
    public int IdVeiculo { get; set; }
    public string Modelo { get; set; }
    public int AnoFabricacao { get; set; }
    public int Quilometragem { get; set; }

    public int IdFabricante { get; set; }
    public Fabricante Fabricante { get; set; }

    public ICollection<Aluguel> Alugueis { get; set; }
}