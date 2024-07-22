using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Revisao
{
    public class Cachorro : Animal
    {
        private string raca { get; set; }

        public Cachorro(string Raca, string nome, int idade, double peso, double altura)
              : base(nome, idade, peso, altura)
        {
            raca= Raca;
        }
        public void Latir()
        {
            Console.WriteLine("Latindo.............");
        }

        public override void ApresentarAnimal()
        {
            Console.WriteLine($"-------------------- Apresentando Cachorro --------------------" +
                              $"\nRaça: {raca}" +
                              $"\nNome: {VerNome}" +
                              $"\nIade: {VerIdade}" +
                              $"\nPeso: {VerPeso} " +
                              $"\n-----------------------------------------------------------");
        }
    }
}
