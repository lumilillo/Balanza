using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class users
    {
        public int id { get; set; }


        [Required(ErrorMessage = "Nombre es requerido")]
        [StringLength(maximumLength: 30, MinimumLength = 1, ErrorMessage = "Nombre máximo 30 caracteres")]
        public string name { get; set; }


        [Required(ErrorMessage = "DNI es requerido")]
        //[StringLength(maximumLength: 11, MinimumLength = 1, ErrorMessage = "DNI no puede superar los 11 caracteres")]
        public int dni { get; set; }


        [Required(ErrorMessage = "Legajo es requerido")]
        public int? legajo { get; set; }

        public string email { get; set; }

        public Nullable<DateTime> email_verified_at { get; set; }


        [Required(ErrorMessage = "Contraseña es requerido")]
        [StringLength(maximumLength: 191, MinimumLength = 1, ErrorMessage = "Contraseña máximo 191 caracteres")]
        public string password { get; set; }


        public string api_token { get; set; }

        public string remember_token { get; set; }

        public bool vendedor_sn { get; set; }

        public bool dark_mode_sn { get; set; }

        public Nullable<DateTime> created_at { get; set; }

        public Nullable<DateTime> updated_at { get; set; }
    }
}
