namespace LojaDeGames.models;

public class Usuario{

    public int id {get; set;}
    public string nome {get; set;}
    public string cpf {get; set;}
    public DateOnly data_nascimento {get; set;}
    public DateTime alterado_em {get; set;}
    public DateTime criado_em {get; set;}
    public string alterado_por {get; set;}
    public string criado_por {get; set;}
    
}




