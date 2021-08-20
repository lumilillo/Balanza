using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Servicios
{
    public class DataExport
    {
        #region PRIVADAS

        ApiService apiService;
        private string urlBase;
        private readonly string api = "/api";
        private string token;

        //PARAMETRIZABLE
        object objeto;

        #endregion

        public DataExport()
        {
            this.apiService = new ApiService();
        }

        //TAREA DE ESAMBLADO
        public async Task GenerarPaquete()
        {

        }

        //TAREA DE ENVIO
        public async Task<Resultado> SendData(string token)
        {
            return await apiService.Send<object>(urlBase, api, "/controlador", objeto, token);
        }
    }
}
