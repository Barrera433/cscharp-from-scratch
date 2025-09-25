namespace itm.cscharp.basic
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine($"Hola, {nombre}! por favor, elija una opcion del menu:");
            Menu.MostrarMenu();
            while (true)
            {
                string entrada = Console.ReadLine().Tolower();
                if (entrada == "q" || entrada == "exist")
                {
                    Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                    break;
                }
                if (int.TryParse(entrada, out int eleccion) && eleccion >= 1 && eleccion <= Menu.Opciones.Count)
                {
                    Menu.EjecutarOpcion(opcion);
                    Console.WriteLine("Por favor, elija otra opcion del menu o 'q' para salir:");
                    Console.Readkey();
                    Console.Clear();
                    Menu.MostrarMenu();
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número de opción válido o 'q' para salir.");
                }
            }
            Console.WriteLine("Gracias por usar el programa. ¡Adiós!");
        }
    }
}