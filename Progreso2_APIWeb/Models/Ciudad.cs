using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Progreso2_APIWeb.Models
{
    public class Ciudad
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public double latitud { get; set; }
        public double longitud { get; set; }
        public string pais { get; set; }
        public string region { get; set; }

    }
}