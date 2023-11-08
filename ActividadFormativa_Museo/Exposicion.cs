using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadFormativa_Museo
{
    class Exposicion
    {
        //Atributos: ID, nombre, fechaInicio, fechaTermino, listadoObras
        private int id;
        private String nombre;
        private DateTime fechaInicio;
        private DateTime fechaTermino;
        private List<ObraArte> listadoObras;

        //Metodo
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public DateTime FechaInicio
        {
            get { return fechaInicio;}
            set { fechaInicio = value;} 
        }
        public DateTime FechaTermino
        {
            get { return fechaTermino; }
            set { fechaTermino = value; }

        }
        public List<ObraArte> ListadoObras
        {
            get { return listadoObras; } 
            set {  listadoObras = value; }
         
        }
        public Exposicion(int id, string nombre, DateTime fechaInicio, DateTime fechaTermino, List<ObraArte> listadoObras)
        {
            Id = id;
            Nombre = nombre;
            FechaInicio= fechaInicio;
            FechaTermino = fechaTermino;
            ListadoObras = listadoObras;
        }

    }
}
