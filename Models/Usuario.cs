namespace Biblioteca_angel.Models;

public class Usuario
{
    public byte Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Documento { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
    public bool Activo { get; set; } = true;

    public Usuario()
    {
    }

    public Usuario(byte id, string nombre, string documento, string email, string telefono)
    {
        Id = id;
        Nombre = nombre;
        Documento = documento;
        Email = email;
        Telefono = telefono;
        Activo = true;
    }

    public string ResumenCorto()
    {
        return $"Usuario {Id}: {Nombre} - {(Activo ? "Activo" : "Inactivo")}";
    }

    public string DetalleCompleto()
    {
        return $"Id: {Id}\nNombre: {Nombre}\nDocumento: {Documento}\nEmail: {Email}\nTeléfono: {Telefono}\nActivo: {Activo}";
    }

    public override string ToString()
    {
        return ResumenCorto();
    }
}
