using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prova.Apresentacao;
using System;

namespace Prova.Testes
{
    [TestClass]
    public class ClienteTestes
    {
        private const string _owner = "Juliano";
        private const string _category = "Cliente";

        [TestMethod]
        [Owner(_owner)]
        [TestCategory(_category)]
        public void Cliente_Construtor_NomeExpectedException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => new Cliente("11111111111", string.Empty),
                "Não foi gerada exception esperada para a propriedade Nome.");
        }

        [TestMethod]
        [Owner(_owner)]
        [TestCategory(_category)]
        public void Cliente_Construtor_DocumentoExpectedException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => new Cliente(string.Empty, "Teste"),
                "Não foi gerada exception esperada para a propriedade Documento.");
        }

        [TestMethod]
        [Owner(_owner)]
        [TestCategory(_category)]
        public void Cliente_ToString_ExpectedSucesso()
        {
            var cliente = new Cliente("11111111111", "Teste");

            Assert.AreEqual("11111111111 - Teste", cliente.ToString(),
                "Não foi gerado corretamente a string.");
        }
    }
}