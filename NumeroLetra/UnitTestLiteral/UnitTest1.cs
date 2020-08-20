using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumeroLetra.Controllers;

namespace UnitTestLiteral
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int a = 5;
            string expected = "CINCO PESOS 00 /100";
            //Act
            LiteralController literalController = new LiteralController();
            string resultado = literalController.LiteralGet(a);
            //Assert
            Assert.AreEqual(expected,resultado);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int a = 2;
            string expected = "DOS PESOS 00 /100";
            //Act
            LiteralController literalController = new LiteralController();
            string resultado = literalController.LiteralGet(a);
            //Assert
            Assert.AreEqual(expected, resultado);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            int a = 10;
            string expected = "DIEZ PESOS 00 /100";
            //Act
            LiteralController literalController = new LiteralController();
            string resultado = literalController.LiteralGet(a);
            //Assert
            Assert.AreEqual(expected, resultado);
        }
    }
}
