using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona
    {
        public string IdPersona {get; set;}
        public string NombrePersona {get; set;}
        public int IdGeneroFk {get; set;}
        public int IdCiudadFk {get; set;}
        public int IdTipoPersonaFk {get; set;}



    }
}