using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Tarea3Bases2
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://microsoft.com/webservices/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public int CantidadEstudiantes()
        {
            //crea una instancia del linq
            LinqAzureDataContext linq = new LinqAzureDataContext();
            //ejecuta el sp CantidadEstudiantes
            var resultado = linq.CantidadEstudiantes();
            //crea una variable para asignar la cantidad
            int cantidad = (int) resultado.FirstOrDefault().Cantidad;
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
            foreach(var estudiante in resultado)
            {
                estudiantes.Add(new Estudiante((int)estudiante.carnet, (int)estudiante.cedula, estudiante.nombre));
            }
            //devuelve la lista
            return estudiantes;
        }

    }
}
