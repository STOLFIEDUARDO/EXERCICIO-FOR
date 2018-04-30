using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVetorComFor
{
    class Exercicio06
    {
        public Exercicio06()
        {
            double[] numero = new double[10];

            for (int i = 0; i < numero.Length; i++)
            {

                Console.Write("Numeros: ");
                numero[i] = Convert.ToDouble(Console.ReadLine());

            }
            Console.Clear();
            double totalnumeros = 0;
            double media = 0;
            for (int i = 0; i < numero.Length; i++)
            {
                Console.WriteLine("Numero: " + numero[i]);

                totalnumeros = numero[i] + totalnumeros;
                media = totalnumeros / 10;

            }
            Console.WriteLine("Somatoria: " + totalnumeros);
            Console.WriteLine("Média: " + media);
        }
    }
}
