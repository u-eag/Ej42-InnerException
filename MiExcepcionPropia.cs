using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_42
{
    class MiExcepcionPropia : Exception
    {
         string msj;

        public MiExcepcionPropia(string mensaje, Exception e) : base(mensaje, e)
        {
            this.msj = mensaje;
        }

        public MiExcepcionPropia(string mensaje) : base(mensaje)
        {
            this.msj = mensaje;
        }
    }
}
