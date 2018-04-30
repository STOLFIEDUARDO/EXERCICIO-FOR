using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVetorComFor
{
    class Exercicio10
    {
        public Exercicio10()
        {
           string[] nomes = new string[10];
            int quantidadeletras = 0,quantidadeletraa =0, quantidadesobrenomesilva = 0, maiorNome = 0, menorNome = 999999,quantidadenomemenor = 0, quantidadenomemaior = 0;
            
            
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Nome " + i + ": ");
                nomes[i] = Console.ReadLine().ToUpper().Trim();

                if (nomes[i] == "S")
                {
                    quantidadeletras++;
                }
                if (nomes[i] == "A")
                {
                    quantidadeletraa++;
                }
                
                if (nomes[i] == "SILVA")
                {
                     quantidadesobrenomesilva++;
                }
                if (nomes[i].Length > maiorNome)
                {
                   quantidadenomemaior++;
                }
                if (nomes[i].Length < menorNome)
                {
                    quantidadenomemenor++;
                }
            }
            Console.WriteLine("a " + quantidadeletraa);
            Console.WriteLine("s " + quantidadeletras);
            Console.WriteLine("Silva " + quantidadesobrenomesilva);
            Console.WriteLine("Menor " + quantidadenomemaior);
            Console.WriteLine("Maior " + quantidadenomemenor);

        }
    }
}
