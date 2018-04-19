using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea3Bases2
{
    public class Carrera
    {
        private int id_carrera;
        private String nombre;
        private String encargado;
        private String ubicacion;

        public int Id_carrera { get => id_carrera; set => id_carrera = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Encargado { get => encargado; set => encargado = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }

        public Carrera(int id_carrera, string nombre, string encargado, string ubicacion)
        {
            this.id_carrera = id_carrera;
            this.nombre = nombre;
            this.encargado = encargado;
            this.ubicacion = ubicacion;
        }

        public Carrera()
        {
        }
    }
}