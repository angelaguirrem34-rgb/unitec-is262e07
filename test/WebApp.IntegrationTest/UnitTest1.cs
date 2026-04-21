namespace WebApp.IntegrationTest;

using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

public class UnitTest1 : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public IntegrationTestPages(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    // Prueba de integración para la figura: polígono regular de 6 lados, lado=5, altura=7
    [Fact]
    public async Task Get_FiguraVolumen_RetornaResultadoCorrecto()
    {
        // Arrange: cliente HTTP virtual
        var client = _factory.CreateClient();

        // Act: simulamos que el usuario consulta la ruta /Figura/Volumen
        var response = await client.GetAsync("/Figura/Volumen?lados=6&lado=5&altura=7");

        // Assert 1: el servidor responde correctamente
        response.EnsureSuccessStatusCode();
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        // Assert 2: verificamos que el contenido devuelto sea el volumen esperado
        string contenido = await response.Content.ReadAsStringAsync();
        double volumen = double.Parse(contenido);

        // Volumen esperado ≈ 454.65 cm³
        Assert.Equal(454.65, volumen, 2); // tolerancia de 2 decimales
    }
}