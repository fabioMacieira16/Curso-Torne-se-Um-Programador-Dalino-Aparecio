using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Programa.Diretorio
{
    public class Arquivo
    {
        public static void Ler(int numeroArquivo)
        {
            string arquivoCaminho = @"C:\Users\fabio\Documents\Documentos\Demandas\arq" + numeroArquivo + ".txt";
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
                Ler(numeroArquivo);
            }
        }
    }
}
