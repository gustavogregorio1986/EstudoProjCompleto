using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCompleto.Entity.Entity
{
    public class Professor
    {
        public int Id { get; set; }

        public string NomeProf { get; set; }

        public string EmailProf { get; set; }

        public string Telefone { get; set; }

        public Turma Turma { get; set; }

        public int Id_Turma { get; set; }

        public Professor()
        {

        }

        public Professor(int Id, string NomeProf, string EmailProf, string Telefone)
        {
            this.Id = Id;
            this.NomeProf = NomeProf;
            this.EmailProf = EmailProf;
            this.Telefone = Telefone;   
        }

        public override string ToString()
        {
            return Id + "," + NomeProf + "," + EmailProf + "," + Telefone;
        }
    }
}
