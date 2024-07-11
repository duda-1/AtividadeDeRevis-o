using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDeRevisão
{
    public class Automovel
    {
        public string marca { get; set; }
        public string modelo { get; set;}
        public string cor { get; set;}
        public string placa { get;}

        List<GerenciadorGeral> ger { get; set;}
        

        public Automovel(string marca, string modelo, string cor, string placa)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
            this.placa = placa;
            ger = new List<GerenciadorGeral>();
        }

        public Automovel()
        {
        }

        public void ExibirAutomovel()
        {
            Console.WriteLine($"--------------------- Automovel --------------------" +
                              $"\nMarca: {marca}" +
                              $"\nModelo: {modelo}" +
                              $"\nCor: {cor}" +
                              $"\nPlaca:{placa}");
        }


    }
}
