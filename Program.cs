using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace tp09_2022_TCassas {
    class Program {
        static void Main(string[] args) {
            List<Producto> productos = new List<Producto>();
            Random random = new Random(); 

            for(int i = 0; i < 5; i++) {
                string fecha = "";

                fecha += random.Next(1, 28) + "-";
                fecha += random.Next(1, 12) + "-";
                fecha += random.Next(1999, 2032);

                Producto producto = new Producto("a", fecha, random.Next(1000, 5000), random.Next(20));
                productos.Add(producto);
            }

            string parsedProductos = JsonSerializer.Serialize(productos[1]);
            Console.WriteLine(parsedProductos);
        }
    }
}
