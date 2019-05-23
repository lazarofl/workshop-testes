using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto;
using System.Collections.Generic;

namespace CodeSmells
{
    [TestClass]
    public class AlgoritmosTestes
    {
        [TestMethod]
        public void AoChamarFuncaoChangedData_ComParametroUpper_DeveRetornarListaComTodosOsItensEmMaiúsculo()
        {
            var algoritmos = new Algoritmos();

            var lista = new List<string> {
                "Palavra 1",
                "Palavra 2",
                "Palavra 3",
            };


            var result = algoritmos.GetChangedData(lista, "Upper");

            Assert.AreEqual("PALAVRA 1", result[0]);
            Assert.AreEqual("PALAVRA 2", result[1]);
            Assert.AreEqual("PALAVRA 3", result[2]);
        }

        [TestMethod]
        public void AoChamarFuncaoChangedData_ComParametroLower_DeveRetornarListaComTodosOsItensEmMinúsculo()
        {
            var algoritmos = new Algoritmos();

            var lista = new List<string> {
                "Palavra 1",
                "Palavra 2",
                "Palavra 3",
            };


            var result = algoritmos.GetChangedData(lista, "Lower");

            Assert.AreEqual("palavra 1", result[0]);
            Assert.AreEqual("palavra 2", result[1]);
            Assert.AreEqual("palavra 3", result[2]);
        }
    }
}
