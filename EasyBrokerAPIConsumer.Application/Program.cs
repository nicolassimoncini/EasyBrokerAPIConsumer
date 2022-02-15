using EasyBrokerAPIConsumer.Domain.Classes;
using EasyBrokerAPIConsumer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EasyBrokerAPIConsumer.Application
{
    class Program
    {
        static async Task Main()
        {
            Console.WriteLine("-- EasyBroker API consumer --");

            try
            {
                // Creamos un CancellationTokenSource para forzar un timeout.
                using (var cts = new CancellationTokenSource())
                {
                    // Configuramos un timeout de 30 segundos para el token asincrónico.
                    cts.CancelAfter(TimeSpan.FromSeconds(30));

                    using (var consumer = new APIConsumer("https://api.stagingeb.com/v1", "l7u502p8v46ba3ppgvj5y2aad50lb9"))
                    {
                        // Obtenemos la lista de propiedades y las mostramos por salida estandar.
                        List<Content> properties = await consumer.GetPropertiesAsync(cts.Token);
                        properties.ForEach(x => Console.WriteLine(x.title));
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}

// convertir los json schemas en https://json2csharp.com
//{ Name = "HttpRequestException" FullName = "System.Net.Http.HttpRequestException"}