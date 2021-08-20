using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class movimientos_camiones
    {
        public int id { get; set; }


        [Required(ErrorMessage = "Tarjeta es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Tarjeta es requerido")]
        public int registros_tarjeta_id { get; set; }


        [Required(ErrorMessage = "Fecha Entrada es requerido")]
        public DateTime fecha_entrada { get; set; }
        public Nullable<DateTime> fecha_salida { get; set; }


        [Required(ErrorMessage = "Peso Entrada es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Peso Entrada es requerido")]
        public int peso_entrada { get; set; }
        public int? peso_salida { get; set; }
        public bool balanza_entrada_sn { get; set; }
        public bool? balanza_salida_sn { get; set; }
        public Nullable<DateTime> created_at { get; set; }
        public Nullable<DateTime> updated_at { get; set; }
        public int? user_id { get; set; }
        public string observacion_planta { get; set; }
        public string observacion_web { get; set; }
        public int estado_id { get; set; }
        public bool editado_sn { get; set; }

        //VISTAS
        public Boolean correcto { get; set; }
        public string razon_social { get; set; }
        public string material { get; set; }
        public string patente { get; set; }
        public string tarjeta { get; set; }
        public decimal peso_entrada_tn { get; set; }
        public decimal peso_salida_tn { get; set; }
        public decimal? pesoFinal { get; set; }
        public string entrada { get => fecha_entrada.ToString("HH:mm:ss"); }
        public string salida { get => salidaDt(); }
        public int? total { get; set; }

        //AUXILIARES

        string salidaDt()
        {
            if(fecha_salida != null)
            {
                return Convert.ToDateTime(fecha_salida).ToString("HH:mm:ss");
            }
            return "Sin Salida.";
        }
    }
}

