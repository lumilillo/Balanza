using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class camiones
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Tipo de Camion es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Tipo de es requerido")]
        public int tipo_camion_id { get; set; }

        [Required(ErrorMessage = "Patente Chasis es requerido")]
        [StringLength(maximumLength: 10, MinimumLength = 1, ErrorMessage = "Patente Chasis máximo los 10 caracteres")]
        public string patente_chasis { get; set; }

        public Nullable<DateTime> created_at { get; set; }
        public Nullable<DateTime> updated_at { get; set; }

        //VISTAS
        public string tipoCamion { get; set;}
    }
}
