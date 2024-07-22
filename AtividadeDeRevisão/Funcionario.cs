using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDeRevisão
{
    public class Funcionario : Pessoa
    {
        List<Automovel> aut { get; set; }

        private string matricula { get; set; }
        private string placaVeiculo { get; set;}

        public Funcionario(string matricula, string placaVeiculo)
              : base(string.Empty)
        {
            this.matricula = matricula;
            this.placaVeiculo = placaVeiculo;
            aut= new List<Automovel>();
        }   

        public string MostrarMatricula()
        {
            return matricula;
        }

        public Boolean verificarVeiculo(Automovel automovel)
        {

            Console.WriteLine($"Deseja verificar se todas as placas tem 7 caracteres ??");


                if (placaVeiculo.Length == 7)
                {
                    Console.WriteLine("Aplaca possue 7 Caracteres");
                    return true;
                }
                else
                {
                    Console.WriteLine("Aplaca não possue 7 caracteres");
                    return false;
                }
        }
    }
}
