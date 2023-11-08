using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActividadFormativa_Museo
{
    public class ObraArte
    {
        //Atributos: ID, nombre, autor, fecha, descripción
        private int id;
        private String nombre;
        private String autor;
        private String fecha;
        private String descripcion;

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
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        //Constructor
        public ObraArte(int id, String nombre, string autor, string fecha, String descripcion)
        {
            Id = id;
            Nombre = nombre;
            Autor = autor;
            Fecha = fecha;
            Descripcion = descripcion;
        }

    }

}