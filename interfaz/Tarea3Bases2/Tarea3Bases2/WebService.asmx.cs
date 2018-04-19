using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Tarea3Bases2
{

    [WebService(Namespace = "http://microsoft.com/webservices/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class WebService : System.Web.Services.WebService
    {
        [WebMethod]
        public void AgregarEstudianteEnCarrera(int carnetEstudiante, int id_carrera, DateTime fecha_ingreso)
        {
            //crea una instancia del linq
            LinqAzureDataContext linq = new LinqAzureDataContext();
            //ejecuta el sp AgregarEstudianteEnCarrera
            linq.AgregarEstudianteEnCarrera(carnetEstudiante, id_carrera, fecha_ingreso);
        }

        [WebMethod]
        public void BorrarCarrera(int id_carrera)
        {
            //crea una instancia del linq
            LinqAzureDataContext linq = new LinqAzureDataContext();
            //ejecuta el sp BorrarCarrera
            linq.BorrarCarrera(id_carrera);
        }

        [WebMethod]
        public void BorrarEstudiante(int carnet)
        {
            //crea una instancia del linq
            LinqAzureDataContext linq = new LinqAzureDataContext();
            //ejecuta el sp BorrarEstudiante
            linq.BorrarEstudiante(carnet);
        }

        [WebMethod]
        public int CantidadEstudiantes()
        {
            //crea una instancia del linq
            LinqAzureDataContext linq = new LinqAzureDataContext();
            //ejecuta el sp CantidadEstudiantes
            var resultado = linq.CantidadEstudiantes();
            //crea una variable para asignar la cantidad
            int cantidad = (int)resultado.FirstOrDefault().Cantidad;
            //retorna la cantidad
            return cantidad;
        }

        [WebMethod]
        public int CantidadEstudiantesAño(int año)
        {
            //crea una instancia de linq
            LinqAzureDataContext linq = new LinqAzureDataContext();
            //ejecuta el sp CantidadEstudiantesAño
            var resultado = linq.CantidadEstudiantesAño(año);
            //crea una variable para asignar la cantidad
            int cantidad = (int)resultado.FirstOrDefault().Cantidad;
            //retorna la cantidad
            return cantidad;
        }

        [WebMethod]
        public int CantidadEstudiantesCarrera(String nombreCarrera)
        {
            //crea una instancia del link
            LinqAzureDataContext linq = new LinqAzureDataContext();
            //ejecuta el sp CantidadEstudiantesCarrera
            var resultado = linq.CantidadEstudiantesCarrera(nombreCarrera);
            //crea una variable para asignar la cantidad
            int cantidad = (int)resultado.FirstOrDefault().Cantidad;
            //retorna la cantidad
            return cantidad;
        }

        [WebMethod]
        public int CantidadEstudiantesCarreraAño(String nombreCarrera, int año)
        {
            //crea una instancia del link
            LinqAzureDataContext linq = new LinqAzureDataContext();
            //ejecuta el sp CantidadEstudiantesCarreraAño
            var resultado = linq.CantidadEstudiantesCarreraAño(nombreCarrera, año);
            //crea una variable para asignar la cantidad
            int cantidad = (int)resultado.FirstOrDefault().Cantidad;
            //retorna la cantidad
            return cantidad;
        }

        [WebMethod]
        public List<Estudiante> EstudiantesCarrera(String nombreCarrera)
        {
            //define la lista que se va a devolver
            List<Estudiante> estudiantes = new List<Estudiante>();
            //crea una instancia del link
            LinqAzureDataContext linq = new LinqAzureDataContext();
            //ejecuta el sp EstudiantesCarrera
            var resultado = linq.EstudiantesCarrera(nombreCarrera);
            //recorre el resultado y lo asigna a la lista
            foreach (var estudiante in resultado)
            {
                estudiantes.Add(new Estudiante((int)estudiante.carnet, (int)estudiante.cedula, estudiante.nombre));
            }
            //devuelve la lista
            return estudiantes;
        }

        [WebMethod]
        public void InsertarCarrera(int id_carrera, String nombre, String encargado, String ubicacion)
        {
            //crea una instancia del link
            LinqAzureDataContext linq = new LinqAzureDataContext();
            //ejecuta el sp InsertarCarrera
            linq.InsertarCarrera(id_carrera, nombre, encargado, ubicacion);
        }

        [WebMethod]
        public void InsertarEstudiante(int carnet, int cedula, String nombre)
        {
            //crea una instancia del link
            LinqAzureDataContext linq = new LinqAzureDataContext();
            //ejecuta el sp InsertarEstudiante
            linq.InsertarEstudiante(carnet, cedula, nombre);
        }

        [WebMethod]
        public void ModificarCarrera(int id_carreraViejo, int id_carreraNuevo, String nombreNuevo, String encargadoNuevo, String ubicacionNueva)
        {
            //crea una instancia del link
            LinqAzureDataContext linq = new LinqAzureDataContext();
            //ejecuta el sp ModificarCarrera
            linq.ModificarCarrera(id_carreraViejo, id_carreraNuevo, nombreNuevo, encargadoNuevo, ubicacionNueva);
        }

        [WebMethod]
        public void ModificarEstudiante(int carnetViejo, int carnetNuevo, int cedulaNueva, String nombreNuevo)
        {
            //crea una instancia del link
            LinqAzureDataContext linq = new LinqAzureDataContext();
            //ejecuta el sp ModificarEstudiante
            linq.ModificarEstudiante(carnetViejo, carnetNuevo, cedulaNueva, nombreNuevo);
        }

        [WebMethod]
        public List<Carrera> MostrarCarreras()
        {
            //define la lista que va a devolver
            List<Carrera> carreras = new List<Carrera>();
            //crea una instancia del link
            LinqAzureDataContext linq = new LinqAzureDataContext();
            //ejecuta el sp MostrarCarreras
            var resultado = linq.MostrarCarreras();
            //recorre el resultado y lo asigna a la lista
            foreach (var carrera in resultado)
            {
                carreras.Add(new Carrera((int)carrera.id_carrera, carrera.nombre, carrera.encargado, carrera.ubicacion));
            }
            //devuelve la lista
            return carreras;
        }

        [WebMethod]
        public List<Estudiante> MostrarEstudiantes()
        {
            //define la lista que va a devolver
            List<Estudiante> estudiantes = new List<Estudiante>();
            //crea una instancia del link
            LinqAzureDataContext linq = new LinqAzureDataContext();
            //ejecuta el sp MostrarEstudiantes
            var resultado = linq.MostrarEstudiantes();
            //recorre el resultado y lo asigna a la lista
            foreach (var estudiante in resultado)
            {
                estudiantes.Add(new Estudiante((int)estudiante.carnet, (int)estudiante.cedula, estudiante.nombre));
            }
            //devuelve la lista
            return estudiantes;
        }

    }
}
