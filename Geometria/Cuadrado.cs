namespace Geometria;

public class Cuadrado : PadreGeometria
{
    private double Lado;

    public Cuadrado(string nombre, double lado) : base("Cuadrado")
    {
        this.Nombre = nombre;
        this.Lado = lado;
        
    }


    public override double CalcularArea() => Lado * Lado;
    
    public override double CalcularPerimetro() => Lado * 4;


    override public string ToString()
    {
        return $"Area: {CalcularArea()}, Perimetro: {CalcularPerimetro()}";
    }
}