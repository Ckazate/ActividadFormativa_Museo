using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ActividadFormativa_Museo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //listado de administradores
            List<Administrador> listadoAdministrador = new List<Administrador>();
            listadoAdministrador.Add(new Administrador(1, "Ckazate", "Carlos", "Casatte", "123"));
            listadoAdministrador.Add(new Administrador(2, "Gabi", "Gabriela", "Valdebenito", "1234"));

            //listado de guias
            List<Guia> listadoGuia = new List<Guia>();
            listadoGuia.Add(new Guia(1016, "Gabo", "Gabriel", "Santander", "1016"));
            listadoGuia.Add(new Guia(2010, "Lambada", "German", "Espinoza", "2010"));

            //listado de Obras de Artes
            List<ObraArte> listadoObras = new List<ObraArte>();
            listadoObras.Add(new ObraArte(1, "La Mona Lisa", "Leonardo da Vinci", "1503 - 1506", "Retrato enigmático de una mujer"));
            listadoObras.Add(new ObraArte(2, "La noche estrellada", "Vincent van Gogh", "1889", "Cielo nocturno turbulento sobre un pueblo"));
            listadoObras.Add(new ObraArte(3, "La persistencia de la memoria", "Salvador Dalí", "1931", "Relojes derretidos en un paisaje desértico"));
            listadoObras.Add(new ObraArte(4, "La creación de Adán", "Miguel Ángel", "1512", "Representación de Dios dando vida a Adán"));

            //PrimeraExpo
            List<ObraArte> primeraObra = new List<ObraArte>();
            primeraObra.Add(listadoObras[0]);
            primeraObra.Add(listadoObras[1]);
            primeraObra.Add(listadoObras[2]);
            //SegundaExpo
            List<ObraArte> segundaObra = new List<ObraArte>();
            segundaObra.Add(listadoObras[3]);
            segundaObra.Add(listadoObras[2]);
            //Exposiciones 1 y 2
            Exposicion exposicion1 = new Exposicion(5670, "la exposicion mas Famosa", DateTime.Now, DateTime.Now, primeraObra);
            Exposicion exposicion2 = new Exposicion(8596, "Exposiciones Renacentista", DateTime.Now, DateTime.Now, segundaObra);
            //listado de exposiciones
            List<Exposicion> listadoExposicion = new List<Exposicion>();
            listadoExposicion.Add(exposicion1);
            listadoExposicion.Add(exposicion2);

            //listado de Galeria
            List<Exposicion> listadoExpoGaleria = new List<Exposicion>();
            listadoExpoGaleria.Add(exposicion1);
            //lista galeria
            Galeria galeria = new Galeria(3256, "Mi Galeria", listadoExpoGaleria);
            List<Galeria> listadoGaleria = new List<Galeria>();
            listadoGaleria.Add(galeria);

            //Agregar un boleano para validar respuesta
            bool continuar = true;

            //while por defecto viene en verdadero 
            while (continuar)
            {
                string tipoUser = LoginUser(listadoAdministrador, listadoGuia);
                if (tipoUser == "admin")
                {
                    int opcion;
                    do
                    {
                        opcion = MenuAdministrador();
                        switch (opcion)
                        {
                            case 1:
                                VerGuia(listadoGuia);
                                break;
                            case 2:
                                VerObra(listadoObras);
                                break;
                            case 3:
                                VerExpocision(listadoExposicion);
                                break;
                            case 4:
                                VerGaleria(listadoGaleria);
                                break;
                            case 5:
                                Console.WriteLine("------AGREGAR GALERIA ----------");
                                //Solicitar datos
                                Console.WriteLine("Ingrese Id:");
                                int id = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese Nombre:");
                                string nombre = Console.ReadLine();
                                Console.WriteLine("Seleccione Exposicion para Agregar");
                                VerExpocision(listadoExposicion);
                                Console.WriteLine("Ingrese Id de Exposicion ");
                                int idExpo = int.Parse(Console.ReadLine());
                                List<Exposicion> listaAgregar = new List<Exposicion>();
                                foreach (Exposicion itemExpo in listadoExposicion)
                                {
                                    if (itemExpo.Id == idExpo)
                                    {
                                        listaAgregar.Add(itemExpo);
                                    }
                                }
                                Galeria gal = new Galeria(id, nombre, listaAgregar);
                                listadoGaleria.Add(gal);
                                Console.WriteLine("Galeria Agregada Correctamente");
                                break;
                            case 6:
                                Console.WriteLine("----EDITAR GALERIA -----");
                                foreach (var gale in listadoGaleria)
                                {
                                    Console.WriteLine($"ID: {gale.Id} | Nombre: {gale.Nombre}");
                                }
                                Console.WriteLine("Seleccione Galeria");
                                int galeria_seleccionada = int.Parse(Console.ReadLine());   
                                foreach (var gale in listadoGaleria)
                                {
                                    if (gale.Id == galeria_seleccionada)
                                    {
                                        Console.WriteLine("EXPOSICIONES ACTUALES EN LA GALERIA");
                                        foreach (var expo in gale.ListadoExposiciones)
                                        {
                                            Console.WriteLine($"Id: {expo.Id} | Nombre: {expo.Nombre}");
                                        }
                                        Console.WriteLine("Motrar todas las exposiciones");
                                        foreach (var expo in listadoExposicion)
                                        {
                                            Console.WriteLine($"Id: {expo.Id} | Nombre: {expo.Nombre}");
                                        }
                                        Console.WriteLine("Selecciona exposicion a agregar");
                                        int expo_IdSeleccionada = int.Parse(Console.ReadLine());
                                        Exposicion expoBuscada = BuscarExposicion(expo_IdSeleccionada, listadoExposicion);
                                        if(expoBuscada != null)
                                        {
                                            bool existeExpo = false;
                                            foreach (var expo in gale.ListadoExposiciones)
                                            {
                                                if (expo.Id == expoBuscada.Id)
                                                {
                                                    Console.WriteLine("Ya existe la exposicion");
                                                    existeExpo = true;
                                                    break;
                                                }
                                            }
                                            if (!existeExpo)
                                            {
                                                gale.ListadoExposiciones.Add(expoBuscada);
                                                Console.WriteLine("Exposicion Agregada");
                                            }
                                        }
                                    }
                                }
                                break;
                            case 0:
                                continuar = false;
                                break;
                            default:
                                Console.WriteLine("Opción Inválida");
                                break;
                        }
                    } while (opcion != 0);
                }
                else if (tipoUser == "guia")
                {
                    int opcion;
                    do
                    {
                        opcion = MenuGuia();
                        switch (opcion)
                        {
                            case 1:
                                VerGaleria(listadoGaleria);
                                break;
                            case 0:
                                continuar = false;
                                break;
                            default:
                                Console.WriteLine("Opción Inválida");
                                break;
                        }
                    } while (opcion != 0);
                }
                else
                {
                    Console.WriteLine("No Existe");
                    continuar = false; 
                }
            }
            Console.WriteLine("Programa finalizado.");
            Console.ReadLine();
        }
        static String LoginUser(List<Administrador> listadmin, List<Guia> listguia)
        {
            Console.WriteLine("Ingrese Usuario");
            String User = Console.ReadLine();
            Console.WriteLine("Ingrese Contraseña");
            String Pass = Console.ReadLine();
            foreach (Administrador admin in listadmin)
            {
                if (admin.Usuario == User && admin.Contraseña == Pass)
                {
                    return "admin";
                }

            }
            foreach (Guia guia in listguia)
            {
                if (guia.Usuario == User && guia.Contraseña == Pass)
                {
                    return "guia";
                }

            }
            return "Invalido";
        }
        //Ver Exposicion
        static void VerExpocision(List<Exposicion> ListaExposicion)
        {
            foreach (var item in ListaExposicion)
            {

                Console.WriteLine($"-------------{item.Nombre}--------ID: {item.Id}---------");
                VerObra(item.ListadoObras);
            }
        }
        //Ver Guia
        static void VerGuia(List<Guia> listadoGuia)
        {
            foreach (var guia in listadoGuia)
            {
                Console.WriteLine($"Id: {guia.Id} Nombre: {guia.Nombre} {guia.Apellido}");
                Console.WriteLine($"Usuario: {guia.Usuario}");
            }
        }
        //Ver Obra de Arte
        static void VerObra(List<ObraArte> listadoObraArte)
        {
            foreach (var obra in listadoObraArte)
            {
                Console.WriteLine($"Id: {obra.Id} Nombre: {obra.Nombre}");
                Console.WriteLine($"Autor: {obra.Autor} Fecha: {obra.Fecha}");
                Console.WriteLine($"Descripción: {obra.Descripcion}");
            }
        }
        static void VerGaleria(List<Galeria> listaGaleria)
        {
            foreach (var item in listaGaleria)
            {
                Console.WriteLine($"Id: {item.Id} Nombre: {item.Nombre}");
                VerExpocision(item.ListadoExposiciones);
            }
        }
        static int MenuAdministrador()
        {
            Console.WriteLine("-- Menú Administrador --:");
            Console.WriteLine("[1] Ver listado de Guías");
            Console.WriteLine("[2] Ver listado de Obras de arte");
            Console.WriteLine("[3] Ver listado de Exposiciones");
            Console.WriteLine("[4] Ver listado de Galerías");
            Console.WriteLine("[5] Agregar Galería");
            Console.WriteLine("[6] Editar Galería (Agregar exposición, verificar primero que no existe ya en la galería actual)");
            Console.WriteLine("[0] Salir");
            Console.WriteLine("Selecciona una opción: ");
            int opcion = int.Parse(Console.ReadLine());
            return opcion;
        }
        static int MenuGuia()
        {
            Console.WriteLine("[1] Ver listado de Galerías");
            Console.WriteLine("[0] Salir");
            int opcion = int.Parse(Console.ReadLine());
            return opcion;
        }

        static Exposicion BuscarExposicion(int idBuscar, List<Exposicion> listadoExposiciones)
        {
            foreach (var expo in listadoExposiciones)
            {
                if (expo.Id == idBuscar)
                {
                    return expo;
                }
            }
            return null;
        }
    }
}
