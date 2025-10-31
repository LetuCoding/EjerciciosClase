namespace Geometria;

public class Rectangulo : PadreGeometria
{
    private double Base;
    private double Altura;

    public Rectangulo(string nombre, double Base, double Altura) : base("Rectangulo")
    {
        this.Nombre = nombre;
        this.Base = Base;
        this.Altura = Altura;
        
    }


    public override double CalcularArea() => Base * Altura;
    
    public override double CalcularPerimetro() => Base * 2 + Altura * 2;


    override public string ToString()
    {
        return $"Area: {CalcularArea()}, Perimetro: {CalcularPerimetro()}";
    }
}