using Facade.Models;
using Facade.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Facade
{
    public class InterfaceFacade
    {
        AlquilerService alquilerService = new AlquilerService();
        HotelService hotelService = new HotelService();
        VueloService VueloService = new VueloService();

        public string Buscar(Request request)
        {
            string response1 =alquilerService.BuscarAutos(request);
            string response2 =hotelService.BuscarHotel(request);
            string response3 =VueloService.BuscarVuelos(request);  

            return response1 + "\n" + response2 + "\n" + response3;

        }



    }
}
