using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class provincias
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Provincia es requerido")]
        [StringLength(maximumLength: 191, MinimumLength = 1, ErrorMessage = "Provincia máximo 191 caracteres")]
        public string provincia { get; set; }

        [Required(ErrorMessage = "Fav es requerido")]
        public bool fav { get; set; }

        public Nullable<DateTime> created_at { get; set; }

        public Nullable<DateTime> updated_at { get; set; }
    }
}
