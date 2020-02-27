using System;
using Programa.Calculo;
using Programa.Diretorio;
using Programa.Funcoes;

namespace Programa.Tela
{

    public class Menu
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVO = 1;
        public const int TABUADA = 2;
        public const int CALCULA_MEDIA = 3;

        public static void Criar()
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
                    Arquivo.Ler(1);
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("===========tabuada==================");
                    Console.WriteLine("Informe um número para tabuada");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.calcular(numero);
                }
                else if (valor == CALCULA_MEDIA)
                {
                    Console.WriteLine("======================Media==================");
                    Media.Aluno();
                }
                else
                {
                    Console.WriteLine("Opção Inválida");
                }
            }
        }
    }
}
