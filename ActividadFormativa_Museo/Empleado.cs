using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadFormativa_Museo
{
   public abstract class Empleado
    {
        //Atributos
        private int id;
        private String usuario;
        private String nombre;
        private String apellido;
        private String contraseña;

        //Metodos
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        //Metodo de Iniciar Sesion
      
    }
}
