/*









Ejercicio 6. Crea la jerarquía que te parezca más adecuada que permita representar los conceptos de Cuadrado, Rectángulo y Círculo. De todas ellas se ha de poder obtener el área.


*/

using EjerciciosClase;


// Llamada ejercicio

Ejercicio1();

Ejercicio2Y3();










//=====================================================================================================
//       Ejercicio 1. Crea una clase llamada Punto que permita representar un punto en 2D.
//=====================================================================================================


static void Ejercicio1()
{
 
 Punto punto = new Punto(5,10);

 Console.WriteLine(punto.ToString());
 
}

//==============================================================================================================================
//     Ejercicio 2 y 3 representar recta y calcular su longitud       
//==============================================================================================================================

static void Ejercicio2Y3()
{
 Punto puntoA = new Punto(5,10);
 Punto puntoB = new Punto(7,10);
 
 
 //Representar recta
 Recta recta = new Recta(puntoA, puntoB);
 Console.WriteLine(recta.ToString());
 
 
 //Calcular longitud recta
Console.WriteLine(recta.CalcularLongitud());

}



