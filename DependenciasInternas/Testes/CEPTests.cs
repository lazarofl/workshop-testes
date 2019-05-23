using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ParaCEP12345678_DeveRetornarLogradouro()
        {
            //setup
            var consultaCep = new ConsultaCEPFake();

            //act
            var result = consultaCep.ObterEndere�o("12345678");

            Assert.AreEqual("Alameda Vicente Pinzon", result);

        }

        [TestMethod]
        [ExpectedException(typeof(Microsoft.CSharp.RuntimeBinder.RuntimeBinderException))]
        public void ParaCEP11111111_DeveGerarExcess�o()
        {
            //setup
            var consultaCep = new ConsultaCEPFake();

            //act
            var result = consultaCep.ObterEndere�o("11111111");
        }

    }
}
