namespace LojaDeGames.Models;

public class Endereco
{
    public int id { get; set; }
    public string rua { get; set; }
    public string cep { get; set; }
    public string bairro { get; set; }
    public string numero { get; set; }
    public string complemento { get; set; }
    public string estado { get; set; }
    public string cidade { get; set; }
    public DateTime criado_em { get; set; }
    public DateTime alterado_por { get; set; }
    public DateTime criado_por { get; set; }


}