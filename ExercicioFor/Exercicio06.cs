using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioFor
{
    class Exercicio06
    {
        public Exercicio06()
        {
            int[] totalDeNumeros = new int[10];
            for (int i = 0; i < totalDeNumeros.Length; i++)
            {
                Random numeroAleatorio = new Random();
                totalDeNumeros[i] = numeroAleatorio.Next(1, 11);
            }

            for (int i = 0; i < totalDeNumeros.Length; i++)
            {
                Console.WriteLine("Total De numeros Armazenados: " + totalDeNumeros[i]);
            }
            for (int i = 0; i < totalDeNumeros.Length; i++)
            {
               int somaTotalDenumeros = 
            }
        }
    }
}
