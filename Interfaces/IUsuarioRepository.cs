namespace LojaDeGames.Interfaces;

using LojaDeGames.Models;

public interface IUsuarioRepository
{
    public Usuario create(Usuario usuario);
}