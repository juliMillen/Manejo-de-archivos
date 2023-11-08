using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace archivos3._3
{
    class MiExcepcion:ApplicationException
    {
        public MiExcepcion() : base("Se ha producido un error") { }
        public MiExcepcion(string msg) : base(msg)
        {

        }
        public MiExcepcion(string msg, Exception e) : base(msg, e) { }
    }
}
