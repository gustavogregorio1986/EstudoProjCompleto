using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCompleto.Entity.Entity
{
    public class Aluno
    {
        public int Id { get; set; }

        public string NomeAluno { get; set; }

        public string EmailAluno { get; set; }

        public string Telefone { get; set; }

        public Login Login { get; set; }

        public Aluno()
        {

        }

        public Aluno(int Id, string NomeAluno, string EmailAluno, string Telefone)
        {
            this.Id´= Id;
            this.NomeAluno = NomeAluno;
            this.EmailAluno = EmailAluno;
            this.Telefone = Telefone;
        }

        public override string ToString()
        {
            return Id + "," + NomeAluno + "," + EmailAluno + "," + Telefone;
        }
    }
}
