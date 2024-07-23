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
            cartas = new List<Carta>();
            jogador= new List<Jogador>();
            InicializarSistema();
        }

        public void InicializarSistema()
        {
            //Carta
            cartas.Add(new Carta("A de Copas",1));
            cartas.Add(new Carta("Copas", 4));
            cartas.Add(new Carta("A Espadas", 1));
            cartas.Add(new Carta("Espadas", 5));
            cartas.Add(new Carta("Espadas", 4));
            cartas.Add(new Carta("Copas", 6));
            cartas.Add(new Carta("Copas", 9));

            //Jogador
            jogador.Add(new Jogador(1, "Eduarda"));
            jogador.Add(new Jogador(2, "Júnia"));
            jogador.Add(new Jogador(3, "Janice"));
            jogador.Add(new Jogador(4, "Marisa"));
        }

        public void AdicionarJogador(Jogador j)
        {
            int novoId = jogador.Max(selector: j => j.PegarId() + 1);
            j.AlterarId(novoId);
            jogador.Add(j);
        }
        public void ListarJogadores()
        {
            foreach (Jogador j in jogador)
            {
                //j.ExibirDetalherJo();
            }
        }

        public void AdicionarCarta(Carta carta)
        {
            cartas.Add(carta);
        }

        public void ListarCartas()
        {
            foreach(Carta carta in cartas)
            {
                carta.ExibirDetalherCarta();
            }
        }

        public void ValidarPares()
        {
            foreach(Carta cartas in cartas)
            {

            }
        }
    }
}
