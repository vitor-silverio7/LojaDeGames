namespace LojaDeGames.Models;

public class VendaItens
{
    public int id { get; set; }
    public int id_venda { get; set; }
    public int id_produto { get; set; }
    public decimal valor_venda { get; set; }
    public string venda_itensco1 { get; set; }
    public DateTime criado_em { get; set; }
    public DateTime alterado_em { get; set; }
    public DateTime criado_por { get; set; }
    public DateTime alterado_por { get; set; }


}