using Biblioteca_angel.Models;

namespace Biblioteca_angel.Services;

public class PrestamoService
{
    // La guía no fija el plazo; se toma un período de 14 días para calcular la fecha límite.
    private const int DiasMaximosPrestamo = 14;
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

    public Prestamo? BuscarPorId(byte id)
    {
        return _prestamos.Find(prestamo => prestamo.Id == id);
    }

    public IReadOnlyList<Prestamo> BuscarPorEstado(EstadoPrestamo estado)
    {
        return _prestamos.Where(prestamo => prestamo.Estado == estado).ToList();
    }

    public IReadOnlyList<Prestamo> ObtenerOrdenadosPorFechaLimite()
    {
        return _prestamos
            .OrderBy(prestamo => prestamo.FechaPrestamo.AddDays(DiasMaximosPrestamo))
            .ToList();
    }

    public int ObtenerTotalPrestamos()
    {
        return _prestamos.Count;
    }

    public int ObtenerTotalActivos()
    {
        return _prestamos.Count(prestamo => prestamo.Estado == EstadoPrestamo.Activo);
    }

    public int ObtenerTotalVencidos()
    {
        return _prestamos.Count(prestamo => prestamo.Estado == EstadoPrestamo.Vencido);
    }

    public int ObtenerTotalDevueltos()
    {
        return _prestamos.Count(prestamo => prestamo.Estado == EstadoPrestamo.Devuelto);
    }

    public double ObtenerPromedioDiasPrestamo()
    {
        List<Prestamo> prestamosDevueltos = _prestamos
            .Where(prestamo => prestamo.Estado == EstadoPrestamo.Devuelto)
            .ToList();

        return prestamosDevueltos.Count == 0
            ? 0
            : prestamosDevueltos.Average(prestamo => prestamo.DiasTranscurridos());
    }
}
