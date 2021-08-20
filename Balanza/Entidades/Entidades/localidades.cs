using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class localidades
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Localidad es requerido")]
        [StringLength(maximumLength: 191, MinimumLength = 1, ErrorMessage = "Localidad máximo 191 caracteres")]
        public string localidad { get; set; }

        [Required(ErrorMessage = "Provincia es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Provincia es requerido")]
        public int provincia_id { get; set; }

        public string lat { get; set; }

        public string lon { get; set; }

        [Required(ErrorMessage = "Fav es requerido")]
        public bool fav { get; set; }

        public Nullable<DateTime> created_at { get; set; }

        public Nullable<DateTime> updated_at { get; set; }
    }
}
