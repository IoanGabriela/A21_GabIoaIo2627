using A21_GabIoaIo2627;

namespace TestA21_GabIoaIo2627
{
    [TestClass]
    public sealed class FuncionesTest
    {
        //Si n < 0, devolverá -1.
        //Si n = 0, devolver 1.
        //Si n > 0, devolver el valor correspondiente.

        [TestMethod]
        [DataRow(-12, -1)]
        [DataRow(0, 1)]
        [DataRow(5, 120)]
        public void Calcular_Factorial(int n, int esperado)
        {
            int result = Funciones.CalcularFactorial(n);
            Assert.AreEqual(esperado, result);
        }
    }
}
