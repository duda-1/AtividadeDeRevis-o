using attRevisao1;
using Revisao2;

Carta c = new Carta("Espadas","6");
Carta c1 = new Carta("Espadas", "13");
c.ExibirDetalhesDaCarta();
c1.ExibirDetalhesDaCarta();

Gerenciador g = new Gerenciador();
g.ListarCartas();
g.ListarJogadores();