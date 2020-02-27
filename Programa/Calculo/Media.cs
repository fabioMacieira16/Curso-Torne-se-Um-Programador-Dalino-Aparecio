using System;
using System.Collections.Generic;
using System.Text;

namespace Programa.Calculo
{
    public class Media
    {
        public static void Aluno()
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
    }
}
