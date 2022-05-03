using System;
using TemperaturaPOO2022.Entidades;

namespace TemperaturaPOO2022.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menu = new[] {"1-Celsius", "2-Fahrenheit"};
            
            Escala escala =(Escala) MostrarMenu(menu);
            double valor = PedirDouble("Ingrese el valor de la temperatura:");

            Temperatura temperatura = new Temperatura(escala, valor);

            if (temperatura.Validar())
            {
                Console.WriteLine($"{temperatura.Grados} grados {temperatura.Escala.ToString()} equivalen a {temperatura.GetConversion()}");
            }
            else
            {
                Console.WriteLine("Temperatura no válida");
            }

            Console.ReadLine();
        }

        static int MostrarMenu(string[] opciones)
        {
            for (int i = 0; i < opciones.Length; i++)
            {
                Console.WriteLine($"{opciones[i]}");
            }

            return PedirIntEnRango("Su eleccion:", 1, opciones.Length);
        }
        static int PedirIntEnRango(string m, int min, int max)
        {
            int rv = PedirInt($"{m} (Entre {min} y {max}): ");

            while (!(rv >= min && rv <= max))
            {
                Console.WriteLine("Valor fuera de rango");
                rv = PedirInt($"{m} (Entre {min} y {max}): ");
            }

            return rv;
        }

        static double PedirDouble(string m)
        {
            double rv;
            string strRv;

            strRv = PedirString(m);

            while (!double.TryParse(strRv, out rv))
            {
                strRv = PedirString(m);
            }

            return rv;
        }


        static int PedirInt(string m)
        {
            int rv;
            string strRv;

            strRv = PedirString(m);

            while (!int.TryParse(strRv, out rv))
            {
                strRv = PedirString(m);
            }

            return rv;
        }
        private static string PedirString(string m)
        {
            string strRv = string.Empty;
            while (true)
            {

                Console.Write(m);
                strRv = Console.ReadLine();
                if (strRv == string.Empty)
                {
                    Console.WriteLine("ERROR!!! El dato es requerido");

                }
                else
                {
                    break;
                }

            }
            return strRv;
        }

    }
}
