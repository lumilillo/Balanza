using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Modelos
{
    public class Resultado
    {
        public bool isOk { get; set; }
        public string error { get; set; }
        public int id { get; set; }
        public object result { get; set; }
    }
}
