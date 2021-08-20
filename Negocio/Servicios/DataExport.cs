using Datos.Servicios;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Servicios
{
    public class DataExport
    {
        #region PRIVADAS

        private string urlBase;
        private readonly string api = "/api";
        private string CurrentDirectory;
        private string tipoInforme = "none";
        private string apiToken;

        ApiService apiService = new ApiService();

        #endregion

        #region ENTIDADES

        users usuario;

        #endregion

        public DataExport(object objeto, string directorio, string apitoken, string url)
        {
            CurrentDirectory = directorio;
            apiToken = apitoken;
            urlBase = url;

            SetObject(objeto);
        }

        void SetObject(object objeto)
        {
            if(objeto is users)
            {
                usuario = objeto as users;
            }
        }

        private async Task<Resultado> SendUser(string apiToken)
        {
            return await apiService.Send<users>(urlBase, api, "/informes_lp", usuario, apiToken);
        }
    }
}
