using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion1.Clase
{
    public class Universidad
    {
        public string Nombre { get; set; }

        public string NIT { get; set; }

        public int Telefono { get; set; }

        public int FAX { get; set; }

        public string Email { get; set; }

        public List <Extension> Extensiones { get; set; }
             
    }
}
