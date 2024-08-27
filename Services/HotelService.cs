using Facade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Services
{
    public class HotelService
    {

      public string BuscarHotel(Request request)
        {
            string titulo = "Busqueda de Hotel";
            string parrafo = $"Hoteles encontrados para la decha de llegada: {request.fecha1} y fecha de salida: {request.fecha2}";
            string opcion1 = "Hotel 1";
            string opcion2 = "Hotel 2";
            string opcion3 = "Hotel 3";
            return titulo +"\n"+ parrafo + "\n" + opcion1 + "\n" + opcion2 + "\n" + opcion3;
        }
    }
}
