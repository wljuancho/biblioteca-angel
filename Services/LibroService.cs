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

    public Libro? BuscarPorIsbn(string isbn)
    {
        return _libros.Find(libro => string.Equals(libro.ISBN, isbn, StringComparison.OrdinalIgnoreCase));
    }

    public IReadOnlyList<Libro> BuscarPorTitulo(string titulo)
    {
        return _libros
            .Where(libro => libro.Titulo.Contains(titulo, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    public IReadOnlyList<Libro> BuscarPorAutor(string autor)
    {
        return _libros
            .Where(libro => libro.Autor.Contains(autor, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    public IReadOnlyList<Libro> ObtenerOrdenadosPorTitulo()
    {
        return _libros.OrderBy(libro => libro.Titulo, StringComparer.OrdinalIgnoreCase).ToList();
    }

    public IReadOnlyList<Libro> ObtenerOrdenadosPorAnio()
    {
        return _libros.OrderBy(libro => libro.AnioPublicacion).ToList();
    }
}
