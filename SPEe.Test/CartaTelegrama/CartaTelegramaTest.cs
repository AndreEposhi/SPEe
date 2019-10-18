using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SPEe.Test.CartaTelegrama
{
    [TestClass]
    public class CartaTelegramaTest
    {
        [TestMethod]
        public void TelegramaTest()
        {
            var telegrama = new Models.CartaTelegrama();
            var identificador = Models.IdentificacaoRegistro.Create(new Models.IdentificacaoRegistro
            {
                VersaoLayout = 1
            });

            telegrama.IdentificacaoRegistro = identificador;
        }
    }
}
