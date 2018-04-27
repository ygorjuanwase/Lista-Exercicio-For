using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioFor
{
    class Exercicio01
    {
        public Exercicio01()
        {

            string[] nomes = new string[25];
            for (int i = 0; i < 25; i++)
            {
                Console.Write("Digite Seu Nome: ");
                nomes[i] = Console.ReadLine();


            }
        }
        
    }
}
