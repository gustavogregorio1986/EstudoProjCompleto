using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCompleto.Entity.Entity
{
    public class Administrador
    {
        public int Id { get; set; }

        public string NomeAdm { get; set; }

        public string EmailAdm { get; set; }

        public Login Login { get; set; }

        public int Id_Login { get; set; }

        public Administrador()
        {

        }

        public Administrador(int Id, string NomeAdm, string EmailAdm)
        {
            this.Id = Id;
            this.NomeAdm = NomeAdm;
            this.EmailAdm = EmailAdm;
        }

        public override string ToString()
        {
            return Id + "," + NomeAdm + "," + EmailAdm;
        }
    }
}
