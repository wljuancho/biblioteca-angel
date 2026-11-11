namespace Biblioteca_angel.Models;

public class Prestamo
{
    public byte Id { get; set; }
    public byte LibroId { get; set; }
    public byte UsuarioId { get; set; }
    public DateTime FechaPrestamo { get; set; }
    public DateTime? FechaDevolucion { get; set; }
    public EstadoPrestamo Estado { get; set; } = EstadoPrestamo.Activo;

    public Prestamo()
    {
        FechaPrestamo = DateTime.Now;
        FechaDevolucion = null;
        Estado = EstadoPrestamo.Activo;
    }

    public Prestamo(byte id, byte libroId, byte usuarioId, DateTime fechaPrestamo)
    {
        Id = id;
        LibroId = libroId;
        UsuarioId = usuarioId;
        FechaPrestamo = fechaPrestamo;
        FechaDevolucion = null;
        Estado = EstadoPrestamo.Activo;
    }

    public bool EstaVencido()
    {
        return Estado == EstadoPrestamo.Vencido;
    }

    public int DiasTranscurridos()
    {
        DateTime fechaFin = FechaDevolucion ?? DateTime.Now;
        return (int)(fechaFin - FechaPrestamo).TotalDays;
    }

    public string ResumenCorto()
    {
        return $"Préstamo {Id}: Libro {LibroId} - Usuario {UsuarioId} - {Estado}";
    }

    public string DetalleCompleto()
    {
        return $"Id: {Id}\nLibro Id: {LibroId}\nUsuario Id: {UsuarioId}\nFecha Préstamo: {FechaPrestamo:dd/MM/yyyy}\nFecha Devolución: {FechaDevolucion?.ToString("dd/MM/yyyy") ?? "Pendiente"}\nEstado: {Estado}";
    }

    public override string ToString()
    {
        return ResumenCorto();
    }
}
