using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioFor
{
    class Exercicio04
    {
        public Exercicio04()
        {
            
            int[] quantidadeCamisas = new int[40];
            int quantidadeCamisasPP = 0;
            int quantidadeCamisasP = 0;
            int quantidadeCamisasM = 0;
            int quantidadeCamisasG = 0;
            int quantidadeCamisasGG = 0;
            int quantidadeCamisasXG = 0;
            int quantidadeCamisasXXG = 0;
            string[] tamanhoCamisetas = new string[40];
            for (int i = 0; i < quantidadeCamisas.Length; i++)
            {
                Console.Write("Digite O Tamanho De Camisetas: ");
                 tamanhoCamisetas[i] = Console.ReadLine().ToLower();
                
            }
            for (int i = 0; i < quantidadeCamisas.Length; i++)
            {
                if (tamanhoCamisetas[i] == "pp")
                {
                    quantidadeCamisasPP = quantidadeCamisasPP + 1;
                }
                    }
            for ( int i = 0; i < quantidadeCamisas.Length; i++)
            {
                if (tamanhoCamisetas[i] == "p")
                {
                    quantidadeCamisasP = quantidadeCamisasP +1;
                }
            }
            for (int i = 0; i < quantidadeCamisas.Length; i++)
            {
                if (tamanhoCamisetas[i] == "m")
                {
                    quantidadeCamisasM = quantidadeCamisasM +1;
                }
            }
            for(int i = 0; i < quantidadeCamisas.Length; i++) 
            {
                if (tamanhoCamisetas[i] == "g"){
                    quantidadeCamisasG = quantidadeCamisasG +1;
                }
            }
            for (int i = 0; i < quantidadeCamisas.Length; i++){
                if (tamanhoCamisetas[i] == "gg"){
                    quantidadeCamisasGG = quantidadeCamisasGG + 1;
                }
            }
            for(int i = 0; i < quantidadeCamisas.Length; i++)
            {
                if(tamanhoCamisetas[i] == "xg")
                {
                    quantidadeCamisasXG = quantidadeCamisasXG + 1;
                }
            }
            for (int i = 0; i < quantidadeCamisas.Length; i++)
            {
                if (tamanhoCamisetas[i] == "xgg")
                {
                    quantidadeCamisasXXG = quantidadeCamisasXXG +1;
                }
            }
            Console.WriteLine("Quantidades De Camisetas: " + quantidadeCamisas.Length);
            Console.WriteLine("Quantidade De Camisas PP: " + quantidadeCamisasPP);
            Console.WriteLine("Quantidade De Camisas P: " + quantidadeCamisasP);
            Console.WriteLine("Quantidade De Camisas M: " + quantidadeCamisasM);
            Console.WriteLine("Quantidade De Camisas G: " + quantidadeCamisasG);
            Console.WriteLine("Quantidade De Camisas GG: " + quantidadeCamisasGG);
            Console.WriteLine("Quantidade De Camisas XG:" + quantidadeCamisasXG);
            Console.WriteLine("Quantidade De Camisas XGG: " + quantidadeCamisasXXG);





                }
            }
        }
   

