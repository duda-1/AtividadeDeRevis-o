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
            //Carta Espados
            cartas.Add(new Carta(" Espadas", "1"));
            cartas.Add(new Carta(" Espadas", "2"));
            cartas.Add(new Carta(" Espadas", "3"));
            cartas.Add(new Carta(" Espadas", "4"));
            cartas.Add(new Carta(" Espadas", "5"));
            cartas.Add(new Carta(" Espadas", "6"));
            cartas.Add(new Carta(" Espadas", "7"));
            cartas.Add(new Carta(" Espadas", "8"));
            cartas.Add(new Carta(" Espadas", "9"));
            cartas.Add(new Carta(" Espadas", "10"));
            cartas.Add(new Carta(" Espadas", "11"));
            cartas.Add(new Carta(" Espadas", "12"));
            cartas.Add(new Carta(" Espadas", "13"));

            // Paus
            cartas.Add(new Carta(" Paus", "1"));
            cartas.Add(new Carta(" Paus", "2"));
            cartas.Add(new Carta(" Paus", "3"));
            cartas.Add(new Carta(" Paus", "4"));
            cartas.Add(new Carta(" Paus", "5"));
            cartas.Add(new Carta(" Paus", "6"));
            cartas.Add(new Carta(" Paus", "7"));
            cartas.Add(new Carta(" Paus", "8"));
            cartas.Add(new Carta(" Paus", "9"));
            cartas.Add(new Carta(" Paus", "10"));
            cartas.Add(new Carta(" Paus", "11"));
            cartas.Add(new Carta(" Paus", "12"));
            cartas.Add(new Carta(" Paus", "13"));

            //Ouro
            cartas.Add(new Carta(" Ouros", "1"));
            cartas.Add(new Carta(" Ouros", "2"));
            cartas.Add(new Carta(" Ouros", "3"));
            cartas.Add(new Carta(" Ouros", "4"));
            cartas.Add(new Carta(" Ouros", "5"));
            cartas.Add(new Carta(" Ouros", "6"));
            cartas.Add(new Carta(" Ouros", "7"));
            cartas.Add(new Carta(" Ouros", "8"));
            cartas.Add(new Carta(" Ouros", "9"));
            cartas.Add(new Carta(" Ouros", "10"));
            cartas.Add(new Carta(" Ouros", "11"));
            cartas.Add(new Carta(" Ouros", "12"));
            cartas.Add(new Carta(" Ouros", "13"));

            //Copa
            cartas.Add(new Carta("Copas","1"));
            cartas.Add(new Carta("Copas", "2"));
            cartas.Add(new Carta("Copas", "3"));
            cartas.Add(new Carta("Copas", "4"));
            cartas.Add(new Carta("Copas", "5"));
            cartas.Add(new Carta("Copas", "6"));
            cartas.Add(new Carta("Copas", "7"));
            cartas.Add(new Carta("Copas", "8"));
            cartas.Add(new Carta("Copas", "9"));
            cartas.Add(new Carta("Copas", "10"));
            cartas.Add(new Carta("Copas", "11")); 
            cartas.Add(new Carta("Copas", "12"));
            cartas.Add(new Carta("Copas", "13"));


            //Jogador
            jogador.Add(new Jogador(1, "Eduarda"));
            jogador.Add(new Jogador(2, "Júnia"));
            jogador.Add(new Jogador(3, "Janice"));
            jogador.Add(new Jogador(4, "Marisa"));
        }

        //Caso entrar mais um jogador
        public void AdicionarJogador(Jogador j)
        {
            int novoId = jogador.Max(selector: j => j.PegarId() + 1);
            j.AlterarId(novoId);
            jogador.Add(j);
        }

        //Listar os Jogadores da partida
        public void ListarJogadores()
        {
            foreach (Jogador j in jogador)
            {
                j.ExibirDetalhedoJogador();
            }
        }
        
        //Adicionar Cartas
        public void AdicionarCarta(Carta carta)
        {
            cartas.Add(carta);
        }

        //ListarCarta
        public void ListarCartas()
        {
            foreach(Carta carta in cartas)
            {
                carta.ExibirDetalhesDaCarta();
            }
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
