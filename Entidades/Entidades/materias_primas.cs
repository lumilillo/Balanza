using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class materias_primas
    {
        public int id { get; set; }


        [Required(ErrorMessage = "Codigo es requerido")]
        [StringLength(maximumLength: 10, MinimumLength = 1, ErrorMessage = "Codigo máximo 10 caracteres")]
        public string codigo { get; set; }


        [StringLength(maximumLength: 25, ErrorMessage = "Descripción máximo 10 caracteres")]
        public string descripcion { get; set; }


        [Required(ErrorMessage = "Unidad de Medida es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Unidad de Medida es requerido")]
        public int unidades_medida_id { get; set; }

        public bool materia_prima_sn { get; set; }

        public bool material_venta { get; set; }

        public Nullable<DateTime> created_at { get; set; }

        public Nullable<DateTime> updated_at { get; set; }

        //VISTAS
        public string unidadMedida { get; set; }
    }
}
