using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadFormativa_Museo
{
   class Galeria
    {
        //Atributos: ID, nombre, listadoExposiciones
        private int id;
        private String nombre;
        private List<Exposicion> listadoExposiciones;

        //metodo
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
        public List<Exposicion> ListadoExposiciones
        {
            get { return listadoExposiciones; }
            set { listadoExposiciones = value; }
        }

        //Constructor 
        public Galeria(int id,String nombre,List<Exposicion> listadoExposiciones)
        {
            Id = id;
            Nombre = nombre;
            ListadoExposiciones = listadoExposiciones;
        }
    }
}
