using System;
using System.Collections.Generic;
using System.Text;

namespace A21_GabIoaIo2627
{
    public class Funciones
    {
        public static int CalcularFactorial(int num)
        {
            int result = 1;

            if (num < 0)
                result = -1;

            for (int i = 1; i <= num; i++)
                result *= i;

            return result;
        }

        public static bool EsContrasenyaValida(string contrasenya)
        {
            return !string.IsNullOrEmpty(contrasenya) &&
                contrasenya.Length >= 8 &&
                contrasenya.Contains("#");
        }
    }
}
