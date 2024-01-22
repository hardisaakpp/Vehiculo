using Vehiculo.Logic;

namespace Vehiculo.Logic
{
    class Program
    {
        static void Main()
        {
            // Crear instancia de Automovil
            Automovil miAutomovil = new("Toyota", "Corolla", 2022, 4);

            // Asignar valores a los atributos de Automovil
            miAutomovil.Color = "Azul";
            miAutomovil.Precio = 25000.0;

            // Realizar acción del Automovil
            Console.WriteLine("Acción del Automovil:");
            miAutomovil.RunAction(); // Conducir automóvil

            // Mostrar información del Automovil
            Console.WriteLine("Información del Automovil:");
            Console.WriteLine(miAutomovil.GetInformation());
            Console.WriteLine($"Color: {miAutomovil.Color}");
            Console.WriteLine($"Precio: ${miAutomovil.Precio}");

            // Crear instancia de Camioneta
            Camioneta miCamioneta = new("Ford", "Ranger", 2022, 1000.0)
            {
                // Asignar valores a los atributos de Camioneta
                Color = "Rojo",
                Precio = 35000.0
            };

            // Mostrar información de la Camioneta
            Console.WriteLine("\nInformación de la Camioneta:");
            Console.WriteLine(miCamioneta.GetInformation());
            Console.WriteLine($"Color: {miCamioneta.Color}");
            Console.WriteLine($"Precio: ${miCamioneta.Precio}");

            // Realizar acción de la Camioneta
            Console.WriteLine("\nAcción de la Camioneta:");
            miCamioneta.RunAction(); // Cargar camioneta
        }
    }
}
