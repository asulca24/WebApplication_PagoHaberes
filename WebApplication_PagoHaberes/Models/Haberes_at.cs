using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_PagoHaberes.Models
{
    public partial class Haberes
    {
        public string dni { get; set; }
        public string nombre { get; set; }
        public string categoria { get; set; }
        public double basico { get; set; }
        public string tipoaportacion {get; set; }
    }
}