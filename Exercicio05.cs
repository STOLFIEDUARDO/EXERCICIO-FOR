﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVetorComFor
{
    class Exercicio05
    {
        public Exercicio05()
        {
            Console.WriteLine("Digite a quantidade de jogos que deseja cadastrar: ");
            int quantidadedeRegistros = Convert.ToInt32(Console.ReadLine());
            string[] nomesdosjogos = new string[quantidadedeRegistros];
            int[] quantidadedejogos = new int[quantidadedeRegistros];
     
            for (int i = 0; i < quantidadedeRegistros; i++)
            {
                Console.Write("Jogo: ");
                nomesdosjogos[i] = Console.ReadLine();

                Console.Write("Quantidade de jogos: ");
                quantidadedejogos[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < quantidadedeRegistros; i++)
            {
                Console.WriteLine(string.Format("{0} --- {1}", nomesdosjogos[i], quantidadedejogos[i]));
            }








        }
    }
}
