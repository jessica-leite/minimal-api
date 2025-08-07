using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Servicos;
using MinimalApi.Infraestrutura.Db;

namespace Test.Domain.Entidades;

[TestClass]
public class AdministradorServicoTest
{
    private DbContexto CriarContextoDeTeste()
    {
        var assemblyPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        var path = Path.GetFullPath(Path.Combine(assemblyPath ?? "", "..", "..", ".."));

        var builder = new ConfigurationBuilder()
            .SetBasePath(path ?? Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables();

        return new DbContexto(builder.Build());
    }

    [TestMethod]
    public void TestandoSalvarAdministrador()
    {
        // Arrange
        var context = CriarContextoDeTeste();
        context.Database.ExecuteSqlRaw("TRUNCATE TABLE Administradores");

        var administrador = new Administrador
        {
            Email = "admin@test.com",
            Senha = "123456",
            Perfil = "Adm"
        };

        var administradorServico = new AdministradorServico(context);

        // Act
        administradorServico.Incluir(administrador);

        // Assert
        Assert.AreEqual(1, administradorServico.Todos(1).Count);
    }

    [TestMethod]
    public void TestandoBuscaPorId()
    {
        // Arrange
        var context = CriarContextoDeTeste();
        context.Database.ExecuteSqlRaw("TRUNCATE TABLE Administradores");

        var administrador = new Administrador
        {
            Email = "admin@test.com",
            Senha = "123456",
            Perfil = "Adm"
        };

        var administradorServico = new AdministradorServico(context);

        // Act
        administradorServico.Incluir(administrador);
        var adminBuscado = administradorServico.BuscaPorId(administrador.Id);

        // Assert
        Assert.AreEqual(1, adminBuscado?.Id);
    }
}
