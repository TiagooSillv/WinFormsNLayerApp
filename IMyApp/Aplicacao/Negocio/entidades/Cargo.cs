using Negocio.comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.entidades
{

    public class Cargo : EntidadeBase
    {
        public string Nome { get; set; }
        public bool Status { get; set; }

        public Cargo(string nome, bool status) 
        {
            Nome = nome;
            Status = status;

            CriadoPor = nome;
            CriadoEm = DateTime.Now;

            AlteradoPor = nome;
            AlteradoEm = DateTime.Now;
        }
    }

}
