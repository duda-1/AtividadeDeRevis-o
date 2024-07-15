using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    public class Animal
    {
        private string Nome { get; set; }   
        private int Idade { get; set; } 
        private double Peso { get; set; }
        private double Altura { get; set; }

        public Animal(string nome, int idade, double peso, double altura)
        {
            Nome= nome;
            Idade= idade;
            Peso= peso;
            Altura= altura;
        }
        public string VerNome()
        {
            return Nome;
        }
        public int VerIdade()
        {
            return Idade;
        }
        public double VerPeso()
        {
            return Peso;
        }
        public double VerAltura()
        {
            return Altura;  
        }
      
        public void Comer()
        {
            Console.WriteLine("Comendo...........");
        }

        public void Dormir()
        {
            Console.WriteLine("Latindo.............");
        }
        public virtual void ApresentarAnimal()
        {
            Console.WriteLine($"-------------------- Apresentando Animal --------------------" +
                              $"\nNome: {Nome}" +
                              $"\nIade: {Idade}" +
                              $"\nPeso: {Peso}" +
                              $"\nAltura: {Altura}" +
                              $"\n-----------------------------------------------------------");
        }

        public void RegistrarInformacoesAnimal()
        {
            Console.WriteLine("Qual o Peso do animal?");
            Peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a Altura do seu animal??");
            Altura = double.Parse( Console.ReadLine() );

        }
        
    }
}
