namespace LojaDeGames.Repository;

using LojaDeGames.Models;
using LojaDeGames.Interfaces;

public class UsuarioRepository : IUsuarioRepository {

    public Usuario create(Usuario usuario){
        return usuario;
    }
}