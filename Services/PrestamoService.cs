using Biblioteca_angel.Models;

namespace Biblioteca_angel.Services;

public class PrestamoService
{
    private readonly List<Prestamo> _prestamos = new();

    public void AgregarPrestamo(Prestamo prestamo)
    {
        ArgumentNullException.ThrowIfNull(prestamo);

        if (_prestamos.Exists(actual => actual.Id == prestamo.Id))
        {
            throw new InvalidOperationException($"Ya existe un préstamo con el ID {prestamo.Id}.");
        }

        _prestamos.Add(prestamo);
    }

    public bool EliminarPrestamo(byte id)
    {
        return _prestamos.RemoveAll(prestamo => prestamo.Id == id) > 0;
    }

    public IReadOnlyList<Prestamo> ObtenerTodos()
    {
        return _prestamos.AsReadOnly();
    }
}
