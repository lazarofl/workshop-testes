using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto;
using System.Collections.Generic;

namespace CodeSmells
{
    [TestClass]
    public class AlgoritmosTestes2
    {
        [TestMethod]
        public void ToUpperCaseData_DeveRetornarListaComTodosOsItensEmMaiúsculo()
        {
            var algoritmos = new ToUpperCaseData();

            var lista = new List<string> {
                "Palavra 1",
                "Palavra 2",
                "Palavra 3",
            };


            var result = algoritmos.GetChangedData(lista);

            Assert.AreEqual("PALAVRA 1", result[0]);
            Assert.AreEqual("PALAVRA 2", result[1]);
            Assert.AreEqual("PALAVRA 3", result[2]);
        }

        [TestMethod]
        public void ToLowerCaseData_ComParametroLower_DeveRetornarListaComTodosOsItensEmMinúsculo()
        {
            var algoritmos = new ToLowerCaseData();

            var lista = new List<string> {
                "Palavra 1",
                "Palavra 2",
                "Palavra 3",
            };


            var result = algoritmos.GetChangedData(lista);

            Assert.AreEqual("palavra 1", result[0]);
            Assert.AreEqual("palavra 2", result[1]);
            Assert.AreEqual("palavra 3", result[2]);
        }

        [TestMethod]
        public void ChangeDataContext_DeveConterDuasEstratégiasDeChangeData()
        {
            var contexto = new ChangeDataContext();

            Assert.AreEqual(2, contexto.changeStrategy.Count);
        }

        [TestMethod]
        public void ChangeDataContext_DeveConterEstrategiaDeUpperCaseComParametroUpper()
        {
            var contexto = new ChangeDataContext();

            Assert.IsInstanceOfType(contexto.changeStrategy["Upper"], typeof(ToUpperCaseData));
        }

        [TestMethod]
        public void ChangeDataContext_DeveConterEstrategiaDeLowerCaseComParametroLower()
        {
            var contexto = new ChangeDataContext();

            Assert.IsInstanceOfType(contexto.changeStrategy["Lower"], typeof(ToLowerCaseData));
        }

    }
}
