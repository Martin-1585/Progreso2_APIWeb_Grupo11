using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;

namespace Progreso2_APIWeb.Models
{
    public class ClimaResponse
    {
        [JsonProperty("current")]
        public ClimaActual actual { get; set; }
        [JsonProperty("daily")]
        public ClimaDiario diario { get; set; }
    }
    public class ClimaActual
    {
        [JsonProperty("time")]
        public string hora { get; set; }
        [JsonProperty("temperature_2m")]
        public double temperatura { get; set; }
        [JsonProperty("relative_humidity_2m")]
        public int humedad { get; set; }
        [JsonProperty("wind_speed_10m")]
        public double viento { get; set; }
    }

    public class ClimaDiario
    {
        [JsonProperty("time")]
        public List<string> fechas { get; set; }
        [JsonProperty("temperature_2m_max")]
        public List<double> tempMax { get; set; }
        [JsonProperty("temperature_2m_min")]
        public List<double> tempMin { get; set; }
    }
}