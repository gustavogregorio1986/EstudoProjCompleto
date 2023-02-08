using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCompleto.Entity.Entity
{
    public class Turma
    {
        public int Id { get; set; }

        public string Serie { get; set; }

        public int NumeroTurma { get; set; }

        public Avaliacao Avaliacao { get; set; }

        public int Id_Avaliacao { get; set; }
    }
}
