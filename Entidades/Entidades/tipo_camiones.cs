using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class tipo_camiones
    {
        public int id { get; set; }


        [Required(ErrorMessage = "Codigo es requerido")]
        [StringLength(maximumLength: 20, MinimumLength = 1, ErrorMessage = "Codigo máximos 20 caracteres")]
        public string codigo { get; set; }


        [StringLength(maximumLength: 45, ErrorMessage = "Descripción máximo 45 caracteres")]
        public string descripcion { get; set; }

        public Nullable<DateTime> created_at { get; set; }

        public Nullable<DateTime> updated_at { get; set; }
    }
}
