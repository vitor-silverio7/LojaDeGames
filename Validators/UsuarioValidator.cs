namespace LojaDeGames.Validators;

using LojaDeGames.Models;
using System.Text.RegularExpressions;

public class UsuarioValidator {

    public static List<string> validar(Usuario usuario){
        List<string> mensagensErro = new List<string>(); 
        Match match;

        // validação de nome
        if (usuario.nome == null || usuario.nome.Trim() == "")
        {
            mensagensErro.Add("O Nome não pode ser Vazio!"); 
        }

        // validação do cpf
        match = Regex.Match(usuario.cpf, @"^\d{3}\.\d{3}\.\d{3}-\d{2}$");
        if (match.Success == false)
        {
            mensagensErro.Add("O CPF é Inválido!"); 
        }

        // validações de idade
        int idade = DateTime.Now.Year - usuario.data_nascimento.Year;
        if (idade >= 100)
        {
            mensagensErro.Add("O usuário é muito velho!"); 
        }

        if (idade <= 17)
        {
            mensagensErro.Add("O usuário é muito novo!"); 
        }

        return mensagensErro;
    }

}