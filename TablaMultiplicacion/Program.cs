namespace TablaMultiplicacion
{
    using System;

    class TablaMultiplicacion
    {
        static void Main(string[] args)
        {
            int numero;

            // Obtener el número del usuario en un bucle, asegurando un número válido entre 0 y 255
            do
            {
                Console.WriteLine("Ingrese un número entre 0 y 255: ");
                string entrada = Console.ReadLine();

                // Validar la entrada y manejar posibles excepciones
                if (int.TryParse(entrada, out numero) && (numero >= 0 && numero <= 255))
                {
                    break; // Salir del bucle solo si la entrada es válida
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Ingrese un número entre 0 y 255.");
                }
            } while (true);

            // Mostrar el encabezado de la tabla con un mensaje claro
            Console.WriteLine("\nEsta es la tabla del {0}:", numero);

            // Usar un bucle for para eficiencia y claridad
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, numero, i * numero);
            }
        }
    }
}
