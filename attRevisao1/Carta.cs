using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attRevisao1
{
    public class Carta
    {
        public string Naipe { get; set; }
        public string Valor { get; set; }

        public Carta(string naipe, string valor)
        {
            Naipe = naipe;
            ConverterNumeroInteiroParaValorCarta(valor);
        }

        //converter o Valor da carta
        private void ConverterNumeroInteiroParaValorCarta(string num)
        {
            switch (num)
            {
                case"1":
                    Valor = "A";
                    break;
                case "11":
                    Valor = "J";
                    break;
                case "12":
                    Valor = "Q";
                    break;
                    case"13":
                        Valor = "K";
                    break;
                default:
                    Valor = num;
                    break;
            }
        }//fim
        
        //Converter o Naipe da Carta para os simbolos
        public string ConverterNaipeParaSimbolo()
        {
            switch (Naipe)
            {
                case "Espadas":
                    return "♠";
                case "Paus":
                    return "♣";
                case "Ouros":
                    return "♦";
                case "Copas":
                    return "♥";
            }
            return Naipe;
        }//fim

        public void ExibirDetalhesDaCarta()
        {
            Console.WriteLine($"Nipe: {ConverterNaipeParaSimbolo()}" +
                              $"\nValor: {Valor}");
            Console.WriteLine("----------------------");
        }
    }
}
