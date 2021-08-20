using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class proveedor_camiones
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Camion es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Camion es requerido")]
        public int camion_id { get; set; }

        [Required(ErrorMessage = "Proveedor es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Proveedor es requerido")]
        public int proveedor_id { get; set; }

        public Nullable<DateTime> created_at { get; set; }

        public Nullable<DateTime> updated_at { get; set; }
    }
}
