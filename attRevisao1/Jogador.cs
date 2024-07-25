using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao2
{
    public class Jogador
    {
        public int Id { get; set; }
        public string NomeJogaror { get; set; }

        public Jogador()
        {

        }



        //CadasTrar Jogador
        public Jogador CadastrarJogador(int id)
        {
            id = Id;
            Console.WriteLine("Digite o Nome");
            NomeJogaror = Console.ReadLine();
            return this;

        }
        
        public void ExibirDetalhedoJogador()
        {
            Console.WriteLine($"-------------- Jogador {Id} --------------" +
                              $"\nNome do Jogador: {NomeJogaror}" +
                              $"\n-----------------------------------------");
        }
    }
}
