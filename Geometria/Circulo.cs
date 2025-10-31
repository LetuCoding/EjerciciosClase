namespace Geometria;

public class Circulo : PadreGeometria
{
    private double radio;

    public Circulo(string nombre, double radio) : base("Círculo")
    {
        this.Nombre = nombre;
        this.radio = radio;
    }

    public override double CalcularArea() => Math.PI * Math.Pow(radio, 2);
    public override double CalcularPerimetro() => 2 * Math.PI * radio;

    override public string ToString()
    {
        return $"Nombre: {Nombre}, radio: {radio}, perimetro: {CalcularPerimetro():F2}, area: {CalcularArea():F2}";
    }
}
