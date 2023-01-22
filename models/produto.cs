namespace LojaDeGames.Models;

public class Produto
{

    public int id { get; set; }
    public string nome { get; set; }
    public int estoque { get; set; }
    public decimal valor { get; set; }
    public Boolean ativo { get; set; }
    public string categoria { get; set; }
    public string descricao { get; set; }

}

