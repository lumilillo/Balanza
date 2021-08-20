using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class registros_tarjetas
    {
        public int id { get; set; }


        [Required(ErrorMessage = "Fecha")]
        public DateTime fecha { get; set; }


        [Required(ErrorMessage = "Numero Tarjeta")]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "Numero de Tarjeta")]

        public string nro_tarjeta { get; set; }

        public int? cliente_id { get; set; }

        public int? proveedor_id { get; set; }

        [Required(ErrorMessage = "Camion")]
        public int camion_id { get; set; }


        [StringLength(maximumLength: 10, ErrorMessage = "Patente")]
        public string patente_acoplado { get; set; }


        [Required(ErrorMessage = "Material")]
        [Range(1, int.MaxValue, ErrorMessage = "Material")]
        public int materias_primas_id { get; set; }

        public bool carga_sn { get; set; }

        public bool descarga_sn { get; set; }

        public bool devolucion_sn { get; set; }


        [StringLength(maximumLength: 20, ErrorMessage = "Nombre")]
        public string nombre { get; set; }


        [StringLength(maximumLength: 200, ErrorMessage = "Observaciones")]
        public string observacion_planta { get; set; }

        [StringLength(maximumLength: 200, ErrorMessage = "Observaciones")]
        public string observacion_web { get; set; }

        public bool habilitado_sn { get; set; }


        [Required(ErrorMessage = "Usuario")]
        public int user_id { get; set; }

        public Nullable<DateTime> created_at { get; set; }

        public Nullable<DateTime> updated_at { get; set; }


        //VISTAS

        public string tipo { get; set; }
        public string razon_social { get; set; }
        public bool alerta_sn { get; set; }
        public string material { get; set; }  
        public string patente { get; set; }
    }
}

