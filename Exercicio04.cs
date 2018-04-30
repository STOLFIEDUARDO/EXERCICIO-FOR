using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVetorComFor
{
    class Exercicio04
    {
        public Exercicio04()
        {
            {

                int[] TotaldeCamisas = new int[4];
                string[] tamanhoCamisas = new string[TotaldeCamisas.Length];

                for (int i = 0; i < TotaldeCamisas.Length; i++)
                {
                    Console.Write("Tamanho da camisa " + i + ": ");
                    tamanhoCamisas[i] = Console.ReadLine().ToUpper().Trim();
                }

                int quantidadeP = 0;
                int quantidadePP = 0;
                int quantidadeM = 0;
                int quantidadeG = 0;
                int quantidadeGG = 0;
                int quantidadeXG = 0;
                int quantidadeXGG = 0;

                for (int i = 0; i < TotaldeCamisas.Length; i++)
                {
                    if (tamanhoCamisas[i] == "P")
                    {
                        quantidadeP++;
                    }
                    if (tamanhoCamisas[i] == "PP")
                    {
                        quantidadePP++;
                    }
                    if (tamanhoCamisas[i] == "M")
                    {
                        quantidadeM++;
                    }
                    if (tamanhoCamisas[i] == "G")
                    {
                        quantidadeG++;
                    }
                    if (tamanhoCamisas[i] == "GG")
                    {
                        quantidadeGG++;
                    }
                    if (tamanhoCamisas[i] == "XG")
                    {
                        quantidadeXG++;
                    }
                    if (tamanhoCamisas[i] == "XGG")
                    {
                        quantidadeXGG++;
                    }
                }
                Console.Clear();
                Console.WriteLine("Quantidade de camisas PP:" + quantidadePP);
                Console.WriteLine("Quantidade de Camisas P:" + quantidadeP);
                Console.WriteLine("Quantidade de camisas M:" + quantidadeM);
                Console.WriteLine("Quantidade de camisas G:" + quantidadeG);
                Console.WriteLine("Quantidade de camisas GG:" + quantidadeGG);
                Console.WriteLine("Quantidade de camisas XG:" + quantidadeXG);
                Console.WriteLine("Quantidade de camisas XGG:" + quantidadeXGG);
            } 
        }
    }
}
