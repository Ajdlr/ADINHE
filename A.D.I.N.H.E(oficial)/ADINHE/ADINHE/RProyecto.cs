using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADINHE
{
    public class RProyecto
    {

        public Int64 Proyectoid { get ; set; };
        public string Descripcion { get ; set; };
        public Int64 Usuariod { get ; set; };

        public RProyecto () { }

        public RProyecto (Int64 pProyectoid, string pDescripcion, Int64 pUsuariod)
        {
            this.Proyectoid = pProyectoid;
            this.Descripcion = pDescripcion;
            this.Usuariod = pUsuariod;

        }
    }
}
