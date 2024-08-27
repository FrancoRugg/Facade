// See https://aka.ms/new-console-template for more information
using Facade.Facade;
using Facade.Models;

Console.WriteLine("Patrón FACADE");

InterfaceFacade interfaceFacade = new InterfaceFacade();
Request request = new Request();

    Console.WriteLine("Ingresar origen: ");
    request.origen = Console.ReadLine();

    Console.WriteLine("Ingresar destino: ");
    request.destino = Console.ReadLine();

    Console.WriteLine("Ingresar fecha de salida: ");
    request.fecha1 = Console.ReadLine();

    Console.WriteLine("Ingresar fecha de llegada : ");
    request.fecha2 = Console.ReadLine();


interfaceFacade.Buscar(request);

Console.ReadKey();
