using System;
using System.Collections.Generic;
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
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            }
        }
        private static void LerArquivo(int numeroArquivo)
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
                LerArquivo(numeroArquivo);
            }
        }

        public static void CalculoMediaAluno()
        {
            Console.WriteLine("Informa o Nome do Aluno ");
            string nome = Console.ReadLine();
            int qtdNotas = 3;
            Console.WriteLine("Informa as " + qtdNotas + " notas dos alunos");

            List<int> notas = new List<int>();
            int totalNotas = 0;

            for (int i = 1; i <= qtdNotas; i++)
            {
                Console.WriteLine("Informa a notas " + i);
                int nota = int.Parse(Console.ReadLine());
                totalNotas += nota;
                notas.Add(nota);
            }

            int media = totalNotas / notas.Count;
            Console.WriteLine("A Média do Aluno " + nome + " é " + media);
            Console.WriteLine("Suas Notas são:  ");
            foreach (int nota in notas)
            {
                Console.WriteLine("Nota: " + nota + " \n ");
            }


        }

        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVO = 1;
        public const int TABUADA = 2;
        public const int CALCULA_MEDIA = 3;

        static void Main(string[] args)
        {
            while (true)
            {
                string mensagem = "Bem vindo ao Sistema" +
                    "\n  Digite as opções abaixo " +
                    "\n  0 - Sair do Sistema" +
                    "\n  1 - Para Ler Arquivo" +
                    "\n  2 - Para Execulta a tabuada" +
                    "\n  3 - Calcular a média dos aluno";

                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == SAIDA_PROGRAMA)
                {
                    Console.WriteLine("Saindo.....");
                    break;
                }
                else if (valor == LER_ARQUIVO)
                {
                    LerArquivo(1);
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("===========tabuada==================");
                    Console.WriteLine("Informe um número para tabuada");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada(numero);
                }
                else if (valor == CALCULA_MEDIA)
                {
                    Console.WriteLine("======================Media==================");
                    CalculoMediaAluno();
                }
                else
                {
                    Console.WriteLine("Opção Inválida");
                }
            }

        }
    }
}
