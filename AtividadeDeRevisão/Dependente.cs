using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDeRevisão
{
    public class Dependente : Pessoa
    {
        public int parentesco { get; set; }

        public Dependente(int Parentesco)
            :base(string.Empty)
        {
            this.parentesco = Parentesco;
        }
    }
}
