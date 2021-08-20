using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class puerto_com
    {
        public int id { get; set; }
        public string ubicacion { get; set; }
        public string port_name { get; set; }
        public int data_bits { get; set; }
        public int baud_rate { get; set; }
        public string parity { get; set; }
        public string stop_bits { get; set; }
        public bool discard_null { get; set; }
        public int? threshold { get; set; }
    }
}
