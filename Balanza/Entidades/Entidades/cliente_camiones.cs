using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class cliente_camiones
    {
        public int id { get; set; }


        [Required(ErrorMessage = "Camion es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "El campo Camion es requerido")]
        public int camion_id { get; set; }


        [Required(ErrorMessage = "Cliente es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Cliente es requerido")]
        public int cliente_id { get; set; }


        public Nullable<DateTime> created_at { get; set; }
        public Nullable<DateTime> updated_at { get; set; }
    }
}

