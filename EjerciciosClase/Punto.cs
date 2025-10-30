namespace EjerciciosClase;

public struct Punto (Double x, Double y)
{
    override public string ToString()
    {
        return $"Coordenadas:  x= {x}, y= {y}";
    }

    public Double GetX()
    {
        return x;
    }

    public Double GetY()
    {
        return y;
    }
    
}