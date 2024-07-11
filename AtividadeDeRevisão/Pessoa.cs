using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDeRevisão
{
    public class Pessoa
    {
        public string nome { get; set;}

        public Pessoa(string nome)
        {
            this.nome = nome;
        }

        public Boolean contatar()
        {
            Console.WriteLine("Usuário Contratado com sucesso");
            return true;
        }

    }
}
