using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class Matricula
    {
        public int IdMatricula { get; set; }
        public string IdPersonaFk { get; set; }
        public int IdSalonFk { get; set; }

    }
}