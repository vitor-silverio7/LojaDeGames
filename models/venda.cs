namespace LojaDeGames.models;

public class venda{

    public int id {get; set;}
    public decimal valor_total {get; set;}
    public string forma_pagamento {get; set;}
    public int id_usuario {get; set;}
    public int id_endereco {get; set;}
    public DateTime criado_em {get; set;}
    public DateTime alterado_em {get; set;}
    public DateTime criado_por {get; set;}
    public DateTime alterado_por {get; set;}

}