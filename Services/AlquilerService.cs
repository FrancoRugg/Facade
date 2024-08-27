using Facade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Services
{
    public class AlquilerService
    {

        public string BuscarAutos(Request request)
        {

            string titulo = "Alquiler de Autos";
            string parrafo = $"Empresas disponibles para la fecha de llegada: {request.fecha1} fecha de salida: {request.fecha2} ";
            string opcion1 = "Empresa 1";
            string opcion2 = "Empresa 2";
            string opcion3 = "Empresa 3";
            return titulo + "\n" + parrafo + "\n" + opcion1 + "\n" + opcion2 + "\n" +opcion3;
        }

    }
}
