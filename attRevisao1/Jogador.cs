using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao2
{
    public class Jogador
    {
        private int Id { get; set; }
        public string NomeJogaror { get; set; }

        public Jogador(int id, string nomeJogaror)
        {
            this.Id = id;
            NomeJogaror = nomeJogaror;
        }

        public int PegarId()
        {
            return Id;
        }

        public void AlterarId(int id)
        {
            id = Id;
        }
    }
}
