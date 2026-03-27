// See https://aka.ms/new-console-template for more information

using Application262E07;

double lado = 5;
int caras = 6;
double altura = 7;
int profundidad = 8;
double perimetro = Figura262E07.CalcularPerimetro(lado, caras);
double area = Figura262E07.CalcularArea(lado, caras, altura)/2;
double volumen = Figura262E07.CalculaVolumen(area, profundidad);

Console.WriteLine($"El perimetro de un poligono regular de {lado}cm por lado y {caras} caras es {perimetro}cm");
Console.WriteLine($"El area de un poligono regular de {lado}cm por lado, {caras} caras y {altura}cm de altura es {area}cm2");
Console.WriteLine($"El volumen de un poligono regular con area de la base de {area} cm2 y profundidad de {profundidad} cm es {volumen} cm3");