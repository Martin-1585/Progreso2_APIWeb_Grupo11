using Newtonsoft.Json;
using Progreso2_APIWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Progreso2_APIWeb.Services
{
    public class OpenMeteoServices
    {
        private static readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://api.open-meteo.com/v1/")
        };

        static OpenMeteoServices()
        {
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;
        }

        public async Task<ClimaResponse> GetClimaAsync()
        {
            var url = "forecast?latitude=-0.22&longitude=-78.52"
                    + "&current=temperature_2m,relative_humidity_2m,wind_speed_10m"
                    + "&daily=temperature_2m_max,temperature_2m_min"
                    + "&timezone=auto";

            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ClimaResponse>(json);
        }

    }
}