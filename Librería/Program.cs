/*
Ejercicio 5. Crea la estructura de clases que consideres adecuada para el siguiente supuesto:
Se quiere mantener información sobre libros. Los libros tienen ISBN que los identifica, título, año de publicación, autor, género y editorial. 
    Respecto autor queremos saber nombre, apellidos y año de nacimiento. En cuanto a la editorial, conocemos el nombre y año de creación. 
    
    
    La biblioteca ha de permitir añadir libros, eliminar libros y consultar libros por año, género y autor.
    
*/

using Librería;

public class Program
{
    public static List<Libro> Libros = new List<Libro>();
    
    public static void Main()
    {
        
        Editorial editorial1 = new Editorial("Planeta Diagostini", 1980);
        Autor autor = new Autor("Juan", "Sanchez", 1990);
                
        Libro libro = new Libro("777Fh43F582", "El cid", 1540, autor, editorial1 ); 
       
        AddBook(libro);
       
        FindBookByAuthor(autor);

       




    }



    public static void AddBook(Libro libro)
    {
        Libros.Add(libro);
    }
    
    
    public static void RemoveBook (Libro libro)
    {
        Libros.Remove(libro);
    }

    
    
    public static void FindBookByYear(int year)
    {
        var librosEncontrados = Libros.Where(libro => libro.ReleaseDate == year ).ToList();
        
        
        foreach (var libro in librosEncontrados)
        {
            Console.WriteLine(libro);
        }
        
    }
    
    public static void FindBookByAuthor(Autor autor)
    {
        var librosEncontrados = Libros.Where(libro => libro.Autor == autor ).ToList();
        
        
        foreach (var libro in librosEncontrados)
        {
            Console.WriteLine(libro);
        }
        
    }

    
    public static void FindBookByGenre(String genre)
    {
        var librosEncontrados = Libros.Where(libro => libro.genres.Contains(genre)).ToList();
        
        foreach (var libro in librosEncontrados)
        {
            Console.WriteLine(libro);
            
        }
    }
    
    
    
    
}
