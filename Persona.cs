using System;
using System.Collections.Generic;
using System.Text;

namespace M1NETCore_Consola
{
    public class Persona
    {
        public string _dni { get; set; }
        public string _nombre { get; set; }
        public int _telefono { get; set; }

        public Persona()
        {

        }

        public Persona(string dni, string nombre, int telefono)
        {
            this._dni = dni;
            this._nombre = nombre;
            this._telefono = telefono;
        }





    }
}
