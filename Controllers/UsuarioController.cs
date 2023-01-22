namespace LojaDeGames.Controllers;

using LojaDeGames.Models;
using Microsoft.AspNetCore.Mvc;
using LojaDeGames.Services;

public class UsuarioController : BaseApiController<UsuarioController>
{

    private readonly UsuarioService service;

    [HttpPost(Name = "Criar Usuário")]
    [ProducesResponseType(typeof(Usuario), 201)]
    public Usuario create(Usuario usuario)
    {
        return service.create(usuario);
    }

}