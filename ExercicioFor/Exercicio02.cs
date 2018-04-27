using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioFor
{
    class Exercicio02
    {
        public Exercicio02()
        {
            int[] idades = new int[7];
            for (int i = 0; i < 7; i++)
            {
                Console.Write("Digite Sua Idade: ");
                idades[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Idades Digitadas: " + idades[i]);
            }
        }
    }
}
