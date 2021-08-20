using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Servicios
{
    public class ApiService
    {
        //POST CON TOKEN + OBJETO
        public async Task<Resultado> Send<T>(
                       string urlBase,
                       string servicePrefix,
                       string controller, T objeto, string apiToken)
        {
            try
            {
                //OBJETO A JSON
                var json = JsonConvert.SerializeObject(objeto, Formatting.Indented);
                //FORMATO DE DATA PARA EVITAR ERRORES DE COMUNICACION
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                //CLIENTE HTTP
                var client = new HttpClient();
                //HEADERS DE LA CONSULTA
                //TOKEN
                client.DefaultRequestHeaders.Add("authorization", "Bearer " + apiToken);
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                client.BaseAddress = new Uri(urlBase);
                //ARMADO DE LA URL: API/CONTROLADOR
                var url = $"{servicePrefix}{controller}";
                //ENVIO PETICION DE POST URL + DATA (JSON) 
                var response = await client.PostAsync(url, data);
                //RESULTADO DE LA CONSULTA
                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Resultado
                    {
                        isOk = false,
                        error = result,
                    };
                }
                return new Resultado
                {
                    isOk = true,
                    result = result
                };

            }
            catch (Exception ex)
            {
                return new Resultado
                {
                    isOk = false,
                    error = ex.Message,
                };
            }
        }

        //POST CON TOKEN + LISTA
        public async Task<Resultado> Send<T>(
                       string urlBase,
                       string servicePrefix,
                       string controller, List<T> objeto, string apiToken)
        {
            try
            {
                //OBJETO A JSON
                var json = JsonConvert.SerializeObject(objeto, Formatting.Indented);
                //FORMATO DE DATA PARA EVITAR ERRORES DE COMUNICACION
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                //CLIENTE HTTP
                var client = new HttpClient();
                //HEADERS DE LA CONSULTA
                //TOKEN
                client.DefaultRequestHeaders.Add("authorization", "Bearer " + apiToken);
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                client.BaseAddress = new Uri(urlBase);
                //ARMADO DE LA URL: API/CONTROLADOR
                var url = $"{servicePrefix}{controller}";
                //ENVIO PETICION DE POST URL + DATA (JSON) 
                var response = await client.PostAsync(url, data);
                //RESULTADO DE LA CONSULTA
                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Resultado
                    {
                        isOk = false,
                        error = result,
                    };
                }
                return new Resultado
                {
                    isOk = true,
                    result = result
                };

            }
            catch (Exception ex)
            {
                return new Resultado
                {
                    isOk = false,
                    error = ex.Message,
                };
            }
        }

        //GET CON TOKEN
        public async Task<Resultado> GetList<T>(
                      string urlBase,
                      string servicePrefix,
                      string controller,
                      string apiToken)
        {

            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);
                client.DefaultRequestHeaders.Add("authorization", "Bearer " + apiToken);
                var url = $"{servicePrefix}{controller}";
                var response = await client.GetAsync(url);
                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Resultado
                    {
                        isOk = false,
                        error = result,
                    };
                }

                List<T> list = JsonConvert.DeserializeObject<List<T>>(result);

                return new Resultado
                {
                    isOk = true,
                    error = "Ok",
                    result = list,
                };
            }
            catch (Exception ex)
            {
                return new Resultado
                {
                    isOk = false,
                    error = ex.Message,
                };
            }

        }

        //GET TABLA CON TOKEN Y FECHA
        public async Task<Resultado> GetLastUpdatedList<T>(
                    string urlBase,
                    string servicePrefix,
                    string controller,
                    string tableName,
                    string datecreated,
                    string apiToken)
        {

            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);
                client.DefaultRequestHeaders.Add("authorization", "Bearer " + apiToken);
                client.DefaultRequestHeaders.Add("dateupdated", datecreated);
                client.DefaultRequestHeaders.Add("tablename", tableName);
                var url = $"{servicePrefix}{controller}";
                var response = await client.GetAsync(url);
                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Resultado
                    {
                        isOk = false,
                        error = result,
                    };
                }

                List<T> list = JsonConvert.DeserializeObject<List<T>>(result);

                return new Resultado
                {
                    isOk = true,
                    error = "Ok",
                    result = list,
                };
            }
            catch (Exception ex)
            {
                return new Resultado
                {
                    isOk = false,
                    error = ex.Message,
                };
            }

        }

        //AUTENTICACION, GET TOKEN
        public async Task<Resultado> Auth<T>(
                                string urlBase,
                                string servicePrefix,
                                string controller, T datosUser)
        {
            try
            {
                var json = JsonConvert.SerializeObject(datosUser);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);
                var url = $"{servicePrefix}{controller}";
                var response = await client.PostAsync(url, data);
                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Resultado
                    {
                        isOk = false,
                        error = result,
                    };
                }

                return new Resultado
                {
                    isOk = true,
                    result = result
                };

            }
            catch (Exception ex)
            {
                return new Resultado
                {
                    isOk = false,
                    error = ex.Message,
                };
            }
        }

    }
}
