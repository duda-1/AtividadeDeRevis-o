using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Revisao
{
    public class Gato : Animal
    {
        public Gato(string nome, int idade, double peso, double altura)
            : base(nome, idade, peso, altura)
        {

        }

        public void Miar()
        {
            Console.WriteLine("Miau.............");
        }

        public override void ApresentarAnimal()
        {
            Console.WriteLine($"-------------------- Apresentando Gato --------------------" +
                              //  $"\nNome: {nome}" +
                              //$"\nIade: {Idade}" +
                              //$"\nPeso: {Peso}" +
                              //$"\nAltura: {Altura}" +
                              $"\n-----------------------------------------------------------");
        }
    }
}
