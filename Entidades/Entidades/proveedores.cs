using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class proveedores
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Razon Social es requerido")]
        [StringLength(maximumLength: 45, MinimumLength = 1, ErrorMessage = "Razon Social máximo 45 caracteres")]
        public string razon_social { get; set; }


        [Required(ErrorMessage = "Domicilio es requerido")]
        [StringLength(maximumLength: 50, MinimumLength = 1, ErrorMessage = "Domicilio máximo 50 caracteres")]
        public string domicilio { get; set; }


        [StringLength(maximumLength: 8, ErrorMessage = "Código Postal máximo 8 caracteres")]
        public string cp { get; set; }


        public int? localidad_id { get; set; }


        [Required(ErrorMessage = "Cuit es requerido")]
        [StringLength(maximumLength: 50, MinimumLength = 1, ErrorMessage = "Cuit máximo 15 caracteres")]
        public string cuit { get; set; }


        [Required(ErrorMessage = "Usuario es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Usuario es requerido")]
        public int? user_id { get; set; }

        public Nullable<DateTime> created_at { get; set; }

        public Nullable<DateTime> updated_at { get; set; }


        //VISTAS

        public string localidad { get; set; }
    }
}
