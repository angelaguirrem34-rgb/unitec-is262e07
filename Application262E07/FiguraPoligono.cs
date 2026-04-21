using Xunit;
using Application; // referencia al proyecto principal

public class FiguraPoligonoTests
{
    // 🔹 Pruebas de Perímetro
    [Theory]
    [InlineData(5, 3, 15)]
    [InlineData(6, 4, 24)]
    [InlineData(8, 2, 16)]
    [InlineData(3, 10, 30)]
    [InlineData(4, 5, 20)]
    [InlineData(10, 1, 10)]
    [InlineData(5, 10, 50)]
    [InlineData(12, 3, 36)]
    [InlineData(20, 2, 40)]
    [InlineData(6, 0.5, 3)]
    [InlineData(8, 5, 40)]
    [InlineData(7, 7, 49)]
    [InlineData(5, 1.2, 6)]
    [InlineData(100, 1, 100)]
    [InlineData(9, 3, 27)]
    [InlineData(3, 33.3333, 100)]
    [InlineData(4, 25, 100)]
    [InlineData(5, 20, 100)]
    [InlineData(6, 10, 60)]
    [InlineData(10, 10, 100)]
    public void UnitTestPoligonoPerimetro(double n, double b, double esperado)
    {
        var figura = new FiguraPoligono();
        double resultado = figura.CalcularPerimetro(n, b);
        Assert.Equal(esperado, resultado);
    }

    // 🔹 Pruebas de Área
    [Theory]
    [InlineData(5, 3, 2, 15)]
    [InlineData(6, 4, 3.464, 41.568)]
    [InlineData(8, 2, 2.414, 19.312)]
    [InlineData(3, 10, 2.887, 43.305)]
    [InlineData(4, 5, 2.5, 25)]
    [InlineData(10, 1, 1.5, 7.5)]
    [InlineData(5, 10, 6.882, 172.050)]
    [InlineData(12, 3, 4, 72)]
    [InlineData(20, 2, 6, 120)]
    [InlineData(6, 10, 8.66, 259.8)]
    [InlineData(8, 5, 6, 120)]
    [InlineData(7, 7, 7.2, 176.4)]
    [InlineData(5, 2, 1.376, 6.880)]
    [InlineData(100, 1.15, 750)]
    [InlineData(9, 3, 4, 54)]
    [InlineData(3, 4, 1.155, 6.930)]
    [InlineData(4, 2, 1, 4)]
    [InlineData(5, 4, 2.753, 27.530)]
    [InlineData(6, 2, 1.732, 10.392)]
    [InlineData(10, 2, 3, 30)]
    public void UnitTestPoligonoArea(double n, double b, double a, double esperado)
    {
        var figura = new FiguraPoligono();
        double resultado = figura.CalcularArea(n, b, a);
        Assert.Equal(esperado, Math.Round(resultado, 3));
    }

    // 🔹 Pruebas de Volumen
    [Theory]
    [InlineData(15, 10, 150)]
    [InlineData(41.568, 2, 83.136)]
    [InlineData(19.312, 10, 193.120)]
    [InlineData(43.305, 2, 86.610)]
    [InlineData(25, 4, 100)]
    [InlineData(7.5, 10, 75)]
    [InlineData(172.050, 1, 172.050)]
    [InlineData(72, 2, 144)]
    [InlineData(120, 0.5, 60)]
    [InlineData(259.8, 2, 519.6)]
    [InlineData(120, 2, 240)]
    [InlineData(176.4, 1, 176.4)]
    [InlineData(6.880, 10, 68.800)]
    [InlineData(750, 0.1, 75)]
    [InlineData(54, 2, 108)]
    [InlineData(6.930, 10, 69.300)]
    [InlineData(4, 5, 20)]
    [InlineData(27.530, 2, 55.060)]
    [InlineData(10.392, 10, 103.920)]
    [InlineData(30, 5, 150)]
    public void UnitTestPoligonoVolumen(double area, double hPrisma, double esperado)
    {
        var figura = new FiguraPoligono();
        double resultado = figura.CalcularVolumen(area, hPrisma);
        Assert.Equal(esperado, Math.Round(resultado, 3));
    }
}
