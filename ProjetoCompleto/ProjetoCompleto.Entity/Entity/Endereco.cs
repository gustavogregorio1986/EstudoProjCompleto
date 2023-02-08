using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCompleto.Entity.Entity
{
    public class Endereco
    {
        public int Id { get; set; }

        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Uf { get; set; }

        public Aluno Aluno { get; set; }

        public int Id_Aluno { get; set; }
    }
}
