namespace LojaDeGames.Services;

using LojaDeGames.Models;
using LojaDeGames.Interfaces;

public class UsuarioService : IUsuarioService
{

    private readonly IUsuarioRepository _repository;

    public UsuarioService(IUsuarioRepository repository)
    {
        _repository = repository;
    }

    public Usuario create(Usuario usuario)
    {
        return _repository.create(usuario);
    }

}