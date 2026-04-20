namespace Application.IntegrationTest;

public class UnitTest1
{
    [Theory]
        [InlineData(6, 5, 7, 454.65)] // Polígono regular de 6 lados, lado=5, altura=7
        public void CalcularVolumen_PoligonoRegular_Correcto(int lados, double lado, double altura, double expected)
        {
            // Arrange: calculamos el área del polígono regular
            double area = (lados * Math.Pow(lado, 2)) / (4 * Math.Tan(Math.PI / lados));

            // Act: calculamos el volumen como área * altura
            double volumen = area * altura;

            // Assert: verificamos que el resultado sea el esperado (con tolerancia)
            Assert.Equal(expected, volumen, 2); // tolerancia de 2 decimales
        }
}
