using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Break.Datos;

namespace OnBreak.Negocios
{
    internal class Conexion
    {
        private static OnBreakEntities _break;
        public static OnBreakEntities Break
        {
            get
            {
                if (_break == null)
                {
                    _break = new OnBreakEntities();
                }
                return _break;
            }
            set
            {
                _break =value;
            }
        }
    }
}
