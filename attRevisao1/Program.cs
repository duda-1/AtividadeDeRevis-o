using attRevisao1;
using Revisao2;

Carta c = new Carta("Espadas",6);
Carta c1 = new Carta("Rei de Espadas",  0);
c.ExibirDetalherCarta();
c1.ExibirDetalherCarta();

Gerenciador g = new Gerenciador();
g.ListarCartas();