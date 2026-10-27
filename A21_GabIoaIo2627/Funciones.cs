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
            if (string.IsNullOrEmpty(contrasenya)) //null o vacío
            {
                return false;
            }

            if (contrasenya.Length < 8) //contiene menos de 8 caracteres
            {
                return false;
            }

            if (!contrasenya.Contains("#")) //si no contiene #
            {
                return false;
            }

            return true;
        }
    }
}
