using System;
using System.Collections.Generic;
using System.Text;

namespace Programa.Funcoes
{
    public class Tabuada
    {
        public static void calcular(int numero)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            }
        }

    }
}
