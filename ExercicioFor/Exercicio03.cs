using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioFor
{
    class Exercicio03
    {
        public Exercicio03()
        {
            Console.Write("Digite Quantos Produtos Quer Digitar: ");
            int produto = Convert.ToInt32(Console.ReadLine());


            double precofinal = 0;
            double[] precos = new double[produto];
            for (int i = 0; i < produto; i++)
            {
                Console.Write("Preço Do Produto Cadatrado: ");
                precos[i] = Convert.ToDouble(Console.ReadLine());
                precofinal = precofinal + precos[i];
                
            }
            for (int i = 0; i < produto; i++)
            {
                Console.WriteLine("Preços Digitados: " + precos[i]);
            }
            Console.WriteLine("Total Dos preços: " + precofinal);
        }
    }
}
