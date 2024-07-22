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
        public string Tipo { get; set; }
        public int Numero { get; set; }

        public Carta(string nipe, string tipo, int numero)
        {
            Nipe = nipe;
            Tipo = tipo;
            Numero = numero;
        }

       public void ExibirDetalherCarta()
        {
            Console.WriteLine($"Nipe da Carta: {Nipe}" +
                              $"\nTipo da Carta: {Tipo}" +
                              $"\nNúmero da Carta: {Numero}");
            Console.WriteLine("--------------------------------");
        }
    }
}
