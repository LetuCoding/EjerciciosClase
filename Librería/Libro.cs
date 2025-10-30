/*
    
    Los libros tienen ISBN que los identifica, título, año de publicación, autor, género y editorial. 
    
*/


namespace Librería;

public class Libro
{
    public Libro(string isbn, string titulo, int releaseDate, Autor autor, Editorial editorial)
    {
        this.Isbn = isbn;
        this.Titulo = titulo;
        this.ReleaseDate = releaseDate;
        this.Autor = autor;
        this.Editorial = editorial;
        this.genres = new List<string>();
    }

    public string Isbn { get; }
    public string Titulo { get; }
    public int ReleaseDate { get; }
    public Autor Autor { get; }

    public List<String> genres { get; }
    public Editorial Editorial { get; }

    public override string ToString()
    {
        return $"{this.Isbn}\n{this.Titulo}\n{this.ReleaseDate}\n{this.Autor}";
    }

}