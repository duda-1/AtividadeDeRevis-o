using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attRevisao1
{
    public class Carta
    {
        public string Nipe { get; set; }
        public int Numero { get; set; }

        public Carta(string nipe, int numero)
        {
            Nipe = nipe;
            Numero = numero;
        }


       public void ExibirDetalherCarta()
        {
            Console.WriteLine($"Nipe da Carta: {Nipe}" +
                              $"\nNúmero da Carta: {Numero}");
            Console.WriteLine("--------------------------------");
        }
    }
}
