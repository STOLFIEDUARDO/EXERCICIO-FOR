using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVetorComFor
{
    class Exercicio11
    {
        public Exercicio11()
        {
              
           string[] nomes = new string[5];
            var nomes2 = "";
            string ex = "";
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Nomes: ");
                nomes[i] = Console.ReadLine();

                nomes2 += nomes[i];
                ex = string.Join(",", nomes);
            }
            Console.WriteLine(ex);
        }
    }
}
