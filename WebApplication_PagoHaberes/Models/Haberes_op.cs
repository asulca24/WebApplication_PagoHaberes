using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_PagoHaberes.Models
{
    public partial class Haberes
    {

        public double Bonificacion()
        {
            return 0.25 * basico;
        }

        public double Remuneracion()
        {
        return basico + Bonificacion();
        
        }

        public double Aportacion()
        {
            return tipoaportacion == "AFP" ? 0.11* Remuneracion() : 0.13 * Remuneracion();
        }
         
        public double Neto()
        {
            return Remuneracion()- Aportacion();
        }

    }
}