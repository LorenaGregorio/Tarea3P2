using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion1.Clase
{
    public class Carrera
    {
        public string Nombre { get; set; }

        public bool Estado { get; set; }

        public int Codigo { get; set; }

        public List<Pensum> Pensums { get; set; }

        public List<Catedraticos> Catedraticos { get; set; }

        public List<Alumno> Alumnos { get; set; }

    }
}
