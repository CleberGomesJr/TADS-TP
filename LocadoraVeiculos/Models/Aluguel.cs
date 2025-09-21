using System.ComponentModel.DataAnnotations;

public class Aluguel
{
    [Key]
    public int IdAluguel { get; set; }
    public int IdCliente { get; set; }
    public Cliente Cliente { get; set; }

    public int IdVeiculo { get; set; }
    public Veiculo Veiculo { get; set; }

    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public DateTime? DataDevolucao { get; set; }
    public int QuilometragemInicial { get; set; }
    public int QuilometragemFinal { get; set; }
    public decimal ValorDiaria { get; set; }
    public decimal ValorTotal { get; set; }
}