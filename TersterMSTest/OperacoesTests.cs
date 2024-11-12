using TesterCore; // Importa o namespace "TesterCore", onde provavelmente está a classe "Operacoes".

namespace Tester.MSTest
{
    [TestClass]
    public class OperacoesTests
    {
        [TestMethod]
        public void SomarDoisNumeroRetornarResultado()
        {
            //Arrange
            double primeiroNumero = 10;
            double segundoNumero = 20;
            //act
            var resultado = Operacoes.Somar(primeiroNumero, segundoNumero);
            //Assert
            Assert.AreEqual(30, resultado);


        }
    }
}