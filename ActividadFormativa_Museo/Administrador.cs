using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadFormativa_Museo
{
   class Administrador : Empleado
    {
        //Constructor
        //Visibilidad NOMBRE_CLASES(parametros--> tipo y nombre)
        public Administrador(int id,String usuario,String nombre,String apellido,String contraseña)
        {
            Id = id;
            Usuario = usuario;
            Nombre = nombre;
            Apellido = apellido;
            Contraseña = contraseña;
        }

    }
}
