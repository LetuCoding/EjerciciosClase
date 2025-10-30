/*
 
    En cuanto a la editorial, conocemos el nombre y año de creación. 
    
*/


namespace Librería;

public class Editorial
{
    private string nombre { get; }
    private int foundYear {get; }

    
    
    public Editorial(string nombre, int foundYear)
    {
        this.nombre = nombre;
        this.foundYear = foundYear;
    }
    
    
    
    public override string ToString()
    {
        return $"{nombre} - {foundYear}";
    }
}