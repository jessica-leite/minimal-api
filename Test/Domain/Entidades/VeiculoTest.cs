using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public class VeiculoTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        // Arrange
        var veiculo = new Veiculo();

        // Act
        veiculo.Id = 1;
        veiculo.Ano = 2020;
        veiculo.Marca = "Toyota";
        veiculo.Nome = "Corolla";

        // Assert
        Assert.AreEqual(1, veiculo.Id);
        Assert.AreEqual(2020, veiculo.Ano);
        Assert.AreEqual("Toyota", veiculo.Marca);
        Assert.AreEqual("Corolla", veiculo.Nome);
    }
}
