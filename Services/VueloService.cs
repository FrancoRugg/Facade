using Facade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Services
{
    public class VueloService
    {
        public string BuscarVuelos(Request request)
        {
            string titulo = "Busqueda de vuelos";
            string parrafo = $"Vuelos encontrados para la fecha: {request.fecha1} salida: {request.origen} destino: {request.destino}";
            string opcion1 = "Flybondi";
            string opcion2 = "Aerolineas Argentinas";
            string opcion3 = "Qatar";
            return titulo + "\n" + parrafo + "\n" + opcion1 + "\n" + opcion2 + "\n" + opcion3;
        }   
    }
}
