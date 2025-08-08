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

    [TestMethod]
    public void TestarConstrutor()
    {
        // Arrange
        //Act
        var administrador = new Administrador("editor@test.com", "1234567", "Editor");

        // Assert
        Assert.AreEqual("editor@test.com", administrador.Email);
        Assert.AreEqual("1234567", administrador.Senha);
        Assert.AreEqual("Editor", administrador.Perfil);
    }
}
