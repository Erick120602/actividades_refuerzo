namespace ImpuestoVenta
{
    using System;

    class ImpuestoVenta
    {
        static void Main(string[] args)
        {
            double monto;
            string codigoPais;

            // Obtener el monto del usuario
            Console.WriteLine("Ingrese un monto: ");
            string montoStr = Console.ReadLine();
            if (!double.TryParse(montoStr, out monto))
            {
                Console.WriteLine("Error: El monto ingresado no es válido.");
                return;
            }

            // Obtener el código de país del usuario
            Console.WriteLine("Ingrese un código de país de dos letras (por ejemplo, US, MX, AR): ");
            codigoPais = Console.ReadLine().ToUpper();
            if (codigoPais.Length != 2)
            {
                Console.WriteLine("Error: El código de país debe tener dos letras.");
                return;
            }

            // Calcular el impuesto según el código de país
            double impuesto = CalcularImpuesto(monto, codigoPais);

            // Mostrar el monto total a pagar
            Console.WriteLine("Debe pagar {0:F2} en impuesto sobre las ventas.", monto + impuesto);
        }

        static double CalcularImpuesto(double monto, string codigoPais)
        {
            switch (codigoPais)
            {
                case "DO":
                    return monto * 0.18; // Impuesto en República Dominicana (18%)
                case "US": // Agregar más casos para otros países
                           // Implementar cálculo de impuesto para Estados Unidos
                    return 0; // No hay IVA en general en Estados Unidos
                default:
                    Console.WriteLine("Error: Código de país no válido.");
                    return 0; // No se calcula impuesto si el código de país no es válido
            }
        }
    }
}
