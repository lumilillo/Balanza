using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class model_has_permissions
    {
        public int permissions_id { get; set; }
        public string model_type { get; set; }
        public int model_id { get; set; }
    }
}
