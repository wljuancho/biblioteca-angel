namespace Biblioteca_angel.Models;

public class Libro
{
    public byte Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Autor { get; set; } = string.Empty;
    public string ISBN { get; set; } = string.Empty;
    public int AnioPublicacion { get; set; }
    public string Categoria { get; set; } = string.Empty;
    public bool Disponible { get; set; } = true;

    public Libro()
    {
    }

    public Libro(byte id, string titulo, string autor, string isbn, int anioPublicacion, string categoria)
    {
        Id = id;
        Titulo = titulo;
        Autor = autor;
        ISBN = isbn;
        AnioPublicacion = anioPublicacion;
        Categoria = categoria;
        Disponible = true;
    }

    public string ResumenCorto()
    {
        return $"Libro {Id}: {Titulo} - {(Disponible ? "Disponible" : "Prestado")}";
    }

    public string DetalleCompleto()
    {
        return $"Id: {Id}\nTítulo: {Titulo}\nAutor: {Autor}\nISBN: {ISBN}\nAño: {AnioPublicacion}\nCategoría: {Categoria}\nDisponible: {Disponible}";
    }

    public override string ToString()
    {
        return ResumenCorto();
    }
}
