using System;
using System.Collections.Generic;
using System.Linq;

namespace M1NETCore_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreCurso = "NET Core Web con C#";
            int edad = 30;
            double monto = 350.5;
            string salario = "Mil dolares";
            string detalleEdad = String.Empty;

            List<Persona> listado = new List<Persona>();
            Persona persona1 = new Persona();
            persona1._dni = "10102929";
            persona1._nombre = "Jose Carlos";
            persona1._telefono = 9993838;

            Persona persona2 = new Persona("70801515","Luis Quispe",662662);
            listado.Add(persona1);
            listado.Add(persona2);
            listado.Add(new Persona("66788909", "Raul Torres", 1881811));

            detalleEdad = (edad > 17) ? "Mayor de edad" : "Menor de edad";
            //if (edad >17)
            //{
            //    detalleEdad = "Mayor de edad";
            //}
            //else
            //{
            //    detalleEdad = "Menor de edad";
            //}

            foreach (var item in listado)
            {
                Console.WriteLine(item._dni + " " +
                                  item._nombre + " " +
                                  item._telefono);
            }

            var busqueda = listado.Where(x => x._dni == "70801515").FirstOrDefault();
            Console.WriteLine("La búsqueda fue: " + busqueda._nombre);
            Console.WriteLine("Hello World!");
        }
    }
}
