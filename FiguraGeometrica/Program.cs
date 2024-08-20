using Figura;

FiguraGeometrica figura = new FiguraGeometrica(10,5);
Rectangulo rectangulo = new Rectangulo(10, 5);
Cuadrado cuadrado = new Cuadrado(10,5);

Console.WriteLine("Área de la FiguraGeometrica: " + figura.CalcularArea());
Console.WriteLine("Área del Rectángulo: " + rectangulo.CalcularArea());
Console.WriteLine("Área del Cuadrado (con error): " + cuadrado.CalcularArea());

