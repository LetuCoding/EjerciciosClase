
using Geometria;

Circulo circulo = new Circulo("Circulito", 50);

Cuadrado cuadrado = new Cuadrado("Cuadrado", 50);

Rectangulo rectangulo = new Rectangulo("Rectangulo", 50, 50);


List<PadreGeometria> padreGeometrias = new List<PadreGeometria>();

padreGeometrias.Add(circulo);
padreGeometrias.Add(cuadrado);
padreGeometrias.Add(rectangulo);

padreGeometrias.ForEach(figura => Console.WriteLine(figura.ToString()));

