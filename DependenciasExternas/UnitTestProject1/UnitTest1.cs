using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaLegado;
using UnitTestProject1.Fakes;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AoPassarUnidadeEUsuarioValidos_DeveProcessarCheckin()
        {
            //setup
            var usuario = new Usuario {Id = 1, Nome = "lalala" };
            var unidade = new Unidade{Id = 1};
            var checkin= new Fakes.CheckinFake();
            var database = new DBFake();
            var proc = new ProcessadorDeCheckin();

            //act
            var result = proc.ProcessarCheckin(unidade, usuario, checkin, database);

            //assert
            Assert.IsTrue(result);
        }
    }
}
