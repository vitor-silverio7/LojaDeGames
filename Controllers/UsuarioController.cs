namespace LojaDeGames.Controllers;

using LojaDeGames.Models;
using Microsoft.AspNetCore.Mvc;
using LojaDeGames.Interfaces;
using LojaDeGames.Validators;

public class UsuarioController : BaseApiController<UsuarioController>
{

    private readonly IUsuarioService _service;

    public UsuarioController(IUsuarioService service)
    {
        _service = service;
    }

    [HttpPost(Name = "Criar Usuário")]
    [ProducesResponseType(typeof(Usuario), 201)]
    public IActionResult create(Usuario usuario)
    {
        List<string> mensagensErro = UsuarioValidator.validar(usuario);

        if (mensagensErro.Count() > 0)
        {
            return BadRequest(mensagensErro);
        }
        else
        {
            return Ok(_service.create(usuario));
        }
    }

}