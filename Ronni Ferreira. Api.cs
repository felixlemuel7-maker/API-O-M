using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net.Http.Json;

namespace Modelo_de_registro
{
    public class Api
    {
        private readonly HttpClient httpClient;

        public Api()
        {
            httpClient = new HttpClient();
        }
        public async Task<List<string>> ObtenerCarrerasAsync()
        {
            string url = "";

            return await httpClient.GetFromJsonAsync<List<string>>(url)
                   ?? new List<string>();
        }

        public async Task<List<string>> ObtenerPeriodosAsync()
        {
            string url = "";

            return await httpClient.GetFromJsonAsync<List<string>>(url)
                   ?? new List<string>();
        }
        public async Task<bool> RegistrarEstudianteAsync(Estudiante estudiante)
        {
            string url = "";

            HttpResponseMessage respuesta =
                await httpClient.PostAsJsonAsync(url, estudiante);

            return respuesta.IsSuccessStatusCode;
        }
    }
}
