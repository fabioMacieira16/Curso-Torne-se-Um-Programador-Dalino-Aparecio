using System;
using System.IO;

namespace Programa
{
    class Program
    {
        static int CalcularSoma()
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            return c;
        }

        public static void Tabuada(int numero)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(numero + " x" + i + " = " + (numero * i));
            }
        }


        private static void LerArquivo(int numeroArquivo)
        {
            string arquivoCaminho = @"C:\Users\fabio\Documents\Documentos\Demandas\arq" + numeroArquivo +  ".txt" ;
            if (File.Exists(arquivoCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
            string arquivoCaminho2 = @"C:\Users\fabio\Documents\Documentos\arq" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(arquivoCaminho2))
            {
                Console.WriteLine("\n");
                LerArquivo(numeroArquivo);
            }

        }

        public const int SAIDA_PROGRAMA = 1;



        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite " + SAIDA_PROGRAMA + " Para sair do Programa");
                int valor = int.Parse(Console.ReadLine());

                if (SAIDA_PROGRAMA == valor)
                {
                    break;
                }

            }
            LerArquivo(1);
            
        }
    }
}
