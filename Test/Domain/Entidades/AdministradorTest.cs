using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public class AdministradorTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        // Arrange
        var administrador = new Administrador();

        // Act
        administrador.Id = 1;
        administrador.Email = "admin@test.com";
        administrador.Senha = "123456";
        administrador.Perfil = "Adm";

        // Assert
        Assert.AreEqual(1, administrador.Id);
        Assert.AreEqual("admin@test.com", administrador.Email);
        Assert.AreEqual("123456", administrador.Senha);
        Assert.AreEqual("Adm", administrador.Perfil);
    }
}
