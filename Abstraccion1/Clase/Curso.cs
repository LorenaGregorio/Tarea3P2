using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion1.Clase
{
    public class Curso
    {
        public int Codigo { get; set; }

        public string Nombre { get; set; }

        public bool Estado { get; set; }

        public List <Curso> PreRequisitos { get; set; }



    }
}
