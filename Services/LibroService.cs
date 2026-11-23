using Biblioteca_angel.Models;

namespace Biblioteca_angel.Services;

public class LibroService
{
    private readonly List<Libro> _libros = new();

    public void AgregarLibro(Libro libro)
    {
        ArgumentNullException.ThrowIfNull(libro);

        if (_libros.Exists(actual => actual.Id == libro.Id))
        {
            throw new InvalidOperationException($"Ya existe un libro con el ID {libro.Id}.");
        }

        _libros.Add(libro);
    }

    public bool EliminarLibro(byte id)
    {
        return _libros.RemoveAll(libro => libro.Id == id) > 0;
    }

    public IReadOnlyList<Libro> ObtenerTodos()
    {
        return _libros.AsReadOnly();
    }
}
