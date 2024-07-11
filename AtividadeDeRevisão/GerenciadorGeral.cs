using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDeRevisão
{
    public class GerenciadorGeral
    {
        List<Automovel> automovel { get; set; }

        public GerenciadorGeral()
        {
            automovel= new List<Automovel>();
            InicializarSistema();
        }

        public void InicializarSistema()
        {
            automovel.Add(new Automovel("Chevrolet", "Impala", "Preto", "kaz2y5"));
            automovel.Add(new Automovel("Wills", "Rural", "Vermelha", "goz2f59"));
            automovel.Add(new Automovel("Chevrolet", "Blaze", "Prata", "abd124c"));
        }

        public void ListarAutomovel()
        {
            Console.WriteLine("------------- Automovel -------------");
            foreach (Automovel automovel in automovel)
            {
                automovel.ExibirAutomovel();
            }

            Console.WriteLine("----------------------------------------");
        }


    }
}
