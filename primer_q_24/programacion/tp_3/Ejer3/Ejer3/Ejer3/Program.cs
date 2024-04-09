using System;

namespace Ejer3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaDeNacimiento = ObtenerFechaDeNacimiento();
            var edad = CalcularEdad(fechaDeNacimiento);
            Console.WriteLine($"Edad: {edad.Item1} años, {edad.Item2} meses, {edad.Item3} días");
        }

        private static DateTime ObtenerFechaDeNacimiento()
        {
            int año = ObtenerAño();
            int mes = ObtenerMes();
            int día = ObtenerDía();

            return new DateTime(año, mes, día);
        }

        private static int ObtenerAño()
        {
            int año;

            Console.Write("Ingrese el año de nacimiento: ");
            while (!int.TryParse(Console.ReadLine(), out año))
            {
                Console.WriteLine("Año inválido, inténtelo de nuevo...");
            }

            return año;
        }

        private static int ObtenerMes()
        {
            int mes;

            Console.Write("Ingrese el número de mes: ");
            while (!int.TryParse(Console.ReadLine(), out mes) || mes <= 0 || mes > 12)
            {
                Console.WriteLine("Mes inválido, inténtelo de nuevo...");
            }

            return mes;
        }

        private static int ObtenerDía()
        {
            int día;

            Console.Write("Ingrese el día de nacimiento: ");
            while (!int.TryParse(Console.ReadLine(), out día) || día <= 0 || día > 31)
            {
                Console.WriteLine("Día inválido, inténtelo de nuevo...");
            }

            return día;
        }

        private static (int, int, int) CalcularEdad(DateTime fechaDeNacimiento)
        {
            DateTime ahora = DateTime.Now;
            TimeSpan diferencia = ahora - fechaDeNacimiento;

            int años = (int)(diferencia.TotalDays / 365.25);
            int meses = ahora.Month - fechaDeNacimiento.Month;
            int días = ahora.Day - fechaDeNacimiento.Day;

            if (días < 0)
            {
                meses--;
                días += DateTime.DaysInMonth(ahora.Year, ahora.Month);
            }

            if (meses < 0)
            {
                años--;
                meses += 12;
            }

            return (años, meses, días);
        }
    }
}
