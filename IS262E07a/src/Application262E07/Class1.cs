namespace Application262E07;

public class Figura262E07
{
    public static double CalcularPerimetro(double lado, int caras) {
        return lado * caras;
         }
    public static double CalcularArea(double lado, int caras, double altura)
    {
        return (lado * caras * altura);
    }
    public static double CalculaVolumen(double area, int profundidad)
    {
        return (area * profundidad);
    } 

}
