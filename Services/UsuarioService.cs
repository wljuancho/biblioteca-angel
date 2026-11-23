using Biblioteca_angel.Models;

namespace Biblioteca_angel.Services;

public class UsuarioService
{
    private readonly List<Usuario> _usuarios = new();

    public void AgregarUsuario(Usuario usuario)
    {
        ArgumentNullException.ThrowIfNull(usuario);

        if (_usuarios.Exists(actual => actual.Id == usuario.Id))
        {
            throw new InvalidOperationException($"Ya existe un usuario con el ID {usuario.Id}.");
        }

        _usuarios.Add(usuario);
    }

    public bool EliminarUsuario(byte id)
    {
        return _usuarios.RemoveAll(usuario => usuario.Id == id) > 0;
    }

    public IReadOnlyList<Usuario> ObtenerTodos()
    {
        return _usuarios.AsReadOnly();
    }
}
