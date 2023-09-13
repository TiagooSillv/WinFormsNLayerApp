﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.comun
{
    public abstract class EntidadeBase
    {
        public int Id{ get; set;}
        public DateTime CriadaEm { get; set; }
        public string CriadoPor { get; set; }
        public DateTime AlteradoEm { get; set; }
        public string AlteradoPor { get; set; }
    }
}
