namespace Geometria;

public abstract class PadreGeometria
{
    protected PadreGeometria(string nombre)
    {
        Nombre = nombre;
    }

    public string Nombre { get; set; }

    
    
    public abstract double CalcularPerimetro();
    public abstract double CalcularArea();
    
 
    

}