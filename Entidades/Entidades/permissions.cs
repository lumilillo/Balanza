using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class permissions
    {
        public int id { get; set; }
        public string name { get; set; }
        public string guard_name { get; set; }
        public string descripcion { get; set; }
        public Nullable<DateTime> created_at { get; set; }
        public Nullable<DateTime> updated_at { get; set; }

        //VISTAS
        public string rol { get; set; }
    }
}
