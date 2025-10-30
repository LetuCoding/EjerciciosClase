namespace EjerciciosClase;

public class Recta (Punto puntoInicial, Punto puntoFinal)
{
    
    private double RectaX = (puntoFinal.GetX()  - puntoInicial.GetX());
    private double RectaY = (puntoFinal.GetY() - puntoInicial.GetY());

    public override string ToString()
    {
        return $"rectaX:{RectaX}, rectaY:{RectaY}";
    }


    public string CalcularLongitud()
    {

        return "Longitud: " + Math.Sqrt(Math.Pow(this.RectaX, 2) + Math.Pow(this.RectaY, 2))+" unidades"  ;

    }
}