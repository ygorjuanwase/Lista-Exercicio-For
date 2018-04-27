using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioFor
{
    class Exercicio05
    {
        public Exercicio05()
        {
            Console.Write("Deseja Cadastrar Quantos jogos: ");
            int jogo = Convert.ToInt32(Console.ReadLine());
            string[] nome = new string[jogo];
            int[] precoJogo = new int[jogo];
            
            string[] jogos = new string[jogo];

            for (int i = 0; i < jogos.Length; i++)
            {
                Console.Write("Nome Do jogo: ");
                 nome[i] = Console.ReadLine();

                Console.Write("Quantidade Do Jogo: ");
                precoJogo[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < jogos.Length; i++)
            {
                Console.WriteLine(String.Format("O Jogo {0} Tem {1} EM Nosso Estoque: ", nome[i], precoJogo[i]));
            }
        }
    }
}
