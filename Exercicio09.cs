using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVetorComFor
{
    class Exercicio09
    {
        public Exercicio09()
     {

        
        double[] notas = new double[4];
        string[] disciplina = new string[1];

        Console.WriteLine("disciplina: ");
        disciplina[0] = Console.ReadLine();

            for (int i = 0; i < notas.Length; i++)
            {
               
                Console.WriteLine("Digite a nota: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }
            double media = 0;
            double total = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("notas: " + notas[i]);
                total = notas[i] + total;
                media = total / 4;
                
            }
            Console.WriteLine("Media: " + media);

                }
            }
    

    }
   
 
    

