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

        [TestMethod]
        [DataRow("", false)] //No puede estar vacía
        [DataRow(null, false)] //No tiene que ser null
        [DataRow("Termi", false)] //Longitud >= 8 caracteres
        [DataRow("terminator", false)] //Debe contener #
        [DataRow("Terminator#", true)] //Válida
        public void Validar_Contraseña(string contrasenya, bool valida)
        {
            bool result = Funciones.EsContrasenyaValida(contrasenya);
            Assert.AreEqual(valida, result);
        }
    }
}
