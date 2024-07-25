using attRevisao1;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao2
{
    public class Gerenciador
    {
        List<Carta> cartas { get; set; } 
        List<Jogador> jogador { get; set; } 


        public Gerenciador()
        {
            cartas = new List<Carta>(9);
            jogador= new List<Jogador>();

            Console.WriteLine("Quantos Jogadores vão Jogar ??");
            int QuantidadeJogador = int.Parse(Console.ReadLine());
            int id = jogador.Count == 0 ? 1 : jogador.Max(x => x.Id) +1 ;

            for (int i = 0; i < QuantidadeJogador; i++)
            {
                Jogador j = new Jogador();
                j.CadastrarJogador(id);
                jogador.Add(j);
            }
            Console.WriteLine("Jogadores Cadastrados com sucesso");
        }



        //Listar os Jogadores da partida
        public void ListarJogadores()
        {
            foreach (Jogador j in jogador)
            {
                j.ExibirDetalhedoJogador();
            }
        }
        

        public void ListarCartas()
        {
            foreach(Carta carta in cartas)
            {
                carta.ExibirDetalhesDaCarta();
            }
        }

        //Adicionar Cartas
        public void AdicionarCarta(Carta carta)
        {
            cartas.Add(carta);
        }

        // Ver Pares Validos
        public void ValidarPares()
        {
            foreach(Carta cartas in cartas)
            {

            }
        }
    }
}
