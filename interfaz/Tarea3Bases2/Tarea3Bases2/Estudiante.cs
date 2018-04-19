using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea3Bases2
{
    public class Estudiante
    {
        private int carnet;
        private int cedula;
        private String nombre;

        public int Carnet { get => carnet; set => carnet = value; }
        public int Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        //foto
        //video


        public Estudiante(int carnet, int cedula, string nombre)
        {
            this.carnet = carnet;
            this.cedula = cedula;
            this.nombre = nombre;
        }

        public Estudiante()
        {
        }
    }
}