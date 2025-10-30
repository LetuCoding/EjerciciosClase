/*
    Respecto autor queremos saber nombre, apellidos y año de nacimiento. 
*/



namespace Librería;

public class Autor
{
    private string nombre { get; }
    private string apellido { get; }
    private int birthYear { get; }

    public Autor(string nombre, string apellido, int birthYear)
    {
        this.nombre = nombre;   
        this.apellido = apellido;
        this.birthYear = birthYear;
        
    }

    public override string ToString()
    {
        return $"Nombre: {nombre}, Apellido: {apellido},Año de nacimiento: {birthYear}";
    }
    
}