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

    public Usuario? BuscarPorDocumento(string documento)
    {
        return _usuarios.Find(usuario => string.Equals(usuario.Documento, documento, StringComparison.OrdinalIgnoreCase));
    }

    public IReadOnlyList<Usuario> BuscarPorNombre(string nombre)
    {
        return _usuarios
            .Where(usuario => usuario.Nombre.Contains(nombre, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    public IReadOnlyList<Usuario> ObtenerOrdenadosPorNombre()
    {
        return _usuarios.OrderBy(usuario => usuario.Nombre, StringComparer.OrdinalIgnoreCase).ToList();
    }

    public int ObtenerTotalUsuarios()
    {
        return _usuarios.Count;
    }

    public int ObtenerTotalActivos()
    {
        return _usuarios.Count(usuario => usuario.Activo);
    }

    public int ObtenerTotalInactivos()
    {
        return _usuarios.Count(usuario => !usuario.Activo);
    }
}
