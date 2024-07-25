using attRevisao1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao2
{
    public class Baralho
    {
        List<Carta> cartas { get; set; }
        public int numeroDeCartas { get; set; } 

        public Baralho()
        {
            cartas = new List<Carta>();
            CriarBaralho();
        }

        //Criando um baralho 
        public void CriarBaralho()
        {
            string[] NipesDisponiveis = { "espadas", "Paus", "Ouros", "Copas" };
            foreach (string Naipe in NipesDisponiveis)
            {
                for (int i = 1; i <= 13; i++)
                {
                    cartas.Add(new Carta(Naipe, i.ToString()));
                }
            }
        }//fim

        public void Embaralhar()
        {
            cartas = cartas.OrderBy(x => Guid.NewGuid()).ToList();
        }

    }
}
