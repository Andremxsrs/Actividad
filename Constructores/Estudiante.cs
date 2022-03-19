using System;
using System.Collections; // Usar para colocar ArrayList / Add  IMPORTANTE
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    internal class Estudiante : persona // Herencia
    {
        ArrayList lista_estudiante = new ArrayList();
        enum tipo_sexo
        {
            masculino,
            femenino
        }

        enum tipo_facultad
        {
            Ingenería,
            Medicina,
            Ciencias_sociales,
            Ciencias_adminitrativas
        }
        public void estudiante()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Clear();
                Console.WriteLine("--------------- BIENVENIDO ESTUDIANTE ---------------\n");
                Console.WriteLine("¿Qué desea realizar?:\n " +
                "\n1 - Insertar\n" +
                "\n2 - Eliminar\n" +
                "\n3 - Modificar\n " +
                "\n4 - Listar Todos\n" +
                "\n5 - Regresar menú principal\n");
                continuar_formulario = int.Parse(Console.ReadLine());

                switch (continuar_formulario)
                {
                    case 1:
                        Insertar();
                        break;

                    case 2:
                        Eliminar();
                        break;

                    case 3:
                        Modificar();
                        break;

                    case 4:
                        Imprimir();
                        break;

                    case 5:
                        Console.Clear();
                        persona volver = new persona();
                        volver.menuPrincipal();
                        break;
                }
            }    
        }

        public void Insertar()
        {
            Console.Clear();
            Console.WriteLine("----------------- INSERTAR -----------------");
            Console.WriteLine("\nDigite su Nombre: \n ");
            agregar_nombrePersona = Console.ReadLine();
            lista_estudiante.Add(agregar_nombrePersona);

            Console.Clear();
            Console.WriteLine("\nDigite su Apellido: \n ");
            agregar_apellidoPersona = Console.ReadLine();
            lista_estudiante.Add(agregar_apellidoPersona);

            Console.Clear();
            Console.WriteLine("\nDigite su Identificacion: \n ");
            agregar_identificacionPersona = Console.ReadLine();
            lista_estudiante.Add(agregar_identificacionPersona);

            Console.Clear();
            Console.WriteLine("\nDigite su tipo de Sexo:\n  \n1: Masculino \n2: Femenino\n");
            agregar_sexoPersona = Console.ReadLine();
            
            // Edad and Facultad

            Console.Clear();
            Console.WriteLine("\nDigite su Edad: \n");
            agregar_edadPersona = Console.ReadLine();
            lista_estudiante.Add(agregar_edadPersona);

            Console.Clear();
            Console.WriteLine("\nIngrese la facultad a la que usted Pertenece:\n" +
                "\n1 - Ingenería\n2 - Medicina\n3 - Ciencias Sociales\n4 - Ciencias Administrativas\n");
            agregar_facultadPersona = Console.ReadLine();
            

            // sexo 

            if (agregar_sexoPersona == "1")
            {
                lista_estudiante.Add(tipo_sexo.masculino);
            }
            else
            {
                lista_estudiante.Add(tipo_sexo.femenino);
            }

            // facultad
            if (agregar_facultadPersona == "1")
            {
                lista_estudiante.Add(tipo_facultad.Ingenería);
            }
            else if (agregar_facultadPersona == "2")
            {
                lista_estudiante.Add(tipo_facultad.Medicina);
            }
            else if (agregar_facultadPersona == "3")
            {
                lista_estudiante.Add(tipo_facultad.Ciencias_sociales);
            }
            else if (agregar_facultadPersona == "4")
            {
                lista_estudiante.Add(tipo_facultad.Ciencias_adminitrativas);
            }
        }

        public void Eliminar()
        {
            Console.Clear();
            Console.WriteLine("----------------- ELIMINAR -----------------");
            Console.WriteLine("\nDigite el campo que usted quiera eliminar:\n \n1 - Nombre\n" +
                "\n2 - Apellido\n \n3 - Identificacion\n \n4 - Sexo\n \n5 - Edad\n" +
                "\n6 - Facultad\n" +
                "\nRecuerde que tiene que hacerlo colocando el número!\n");
            identificarDato = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEscriba el dato que usted va a borrar: \n");
            eliminarDato = Console.ReadLine();

            switch (identificarDato)
            {
                case 1:
                    if (lista_estudiante.Contains(eliminarDato) == true)
                    {
                        Console.Write("\nSu dato ha sido eliminado! :D\n");
                        lista_estudiante.Remove(eliminarDato);
                    }
                    else
                    {
                        Console.WriteLine("\nNo se han encontrado los datos!\n");
                    }
                    break;
                case 2:
                    if (lista_estudiante.Contains(eliminarDato) == true)
                    {
                        Console.Write("\nSu dato ha sido eliminado! :D\n");
                        lista_estudiante.Remove(eliminarDato);
                    }
                    else
                    {
                        Console.WriteLine("\nNo se han encontrado los datos!\n");
                    }
                    break;
                case 3:
                    if (lista_estudiante.Contains(eliminarDato) == true)
                    {
                        Console.Write("\nSu dato ha sido eliminado! :D\n");
                        lista_estudiante.Remove(eliminarDato);
                    }
                    else
                    {
                        Console.WriteLine("\nNo se han encontrado los datos!\n");
                    }
                    break;
                case 4:
                    if (lista_estudiante.Contains(eliminarDato) == true)
                    {
                        Console.Write("\nSu dato ha sido eliminado! :D\n");
                        lista_estudiante.Remove(eliminarDato);
                    }
                    else
                    {
                        Console.WriteLine("\nNo se han encontrado los datos!\n");
                    }
                    break;
                case 5:
                    if (lista_estudiante.Contains(eliminarDato) == true)
                    {
                        Console.Write("\nSu dato ha sido eliminado! :D\n");
                        lista_estudiante.Remove(eliminarDato);
                    }
                    else
                    {
                        Console.WriteLine("\nNo se han encontrado los datos!\n");
                    }
                    break;
                case 6:
                    if (lista_estudiante.Contains(eliminarDato) == true)
                    {
                        Console.Write("\nSu dato ha sido eliminado! :D\n");
                        lista_estudiante.Remove(eliminarDato);
                    }
                    else
                    {
                        Console.WriteLine("\nNo se han encontrado los datos!\n");
                    }
                    break;
            }
        }

        public void Modificar()
        {
            Console.Clear();
            Console.WriteLine("----------------- MODIFICAR -----------------");
            Console.WriteLine("\nDigite el campo que usted quiera Modificar:\n \n1 - Nombre\n" +
            "\n2 - Apellido\n \n3 - Identificacion\n \n4 - Sexo\n \n5 - Edad\n" +
            "\n6 - Facultad\n" +
            "\nRecuerde que tiene que hacerlo colocando el número!\n");
            identificar_dato = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite la palabra que quiere cambiar:\n ");
            buscar_dato = Console.ReadLine();

            Console.WriteLine("\nDigite el qué cambiara el otro!:\n ");
            modificarDato = Console.ReadLine();

            switch (identificar_dato)
            {
                case 1:
                    if (lista_estudiante.Contains(buscar_dato) == true)
                    {
                        Console.WriteLine("\nSus datos se han modificado! :D\n");
                        lista_estudiante.Remove(buscar_dato);
                        lista_estudiante.Add(modificarDato);
                    }
                    break;
                case 2:
                    if (lista_estudiante.Contains(buscar_dato) == true)
                    {
                        Console.WriteLine("\nSus datos se han modificado! :D\n");
                        lista_estudiante.Remove(buscar_dato);
                        lista_estudiante.Add(modificarDato);
                    }
                    break;
                case 3:
                    if (lista_estudiante.Contains(buscar_dato) == true)
                    {
                        Console.WriteLine("\nSus datos se han modificado! :D\n");
                        lista_estudiante.Remove(buscar_dato);
                        lista_estudiante.Add(modificarDato);
                    }
                    break;
                case 4:
                    if (lista_estudiante.Contains(buscar_dato) == true)
                    {
                        Console.WriteLine("\nSus datos se han modificado! :D\n");
                        lista_estudiante.Remove(buscar_dato);
                        lista_estudiante.Add(modificarDato);
                    }
                    break;
                case 5:
                    if (lista_estudiante.Contains(buscar_dato) == true)
                    {
                        Console.WriteLine("\nSus datos se han modificado! :D\n");
                        lista_estudiante.Remove(buscar_dato);
                        lista_estudiante.Add(modificarDato);
                    }
                    break;
                case 6:
                    if (lista_estudiante.Contains(buscar_dato) == true)
                    {
                        Console.WriteLine("\nSus datos se han modificado! :D\n");
                        lista_estudiante.Remove(buscar_dato);
                        lista_estudiante.Add(modificarDato);
                    }
                    break;

            }

        }

        public void Imprimir()
        {
            Console.Clear();
            for (int i = 0; i < lista_estudiante.Count; i++)
            {
                Console.WriteLine("{0}: {1}", i, lista_estudiante[i]);
            }
            Console.WriteLine("---------------------------\n");

            Console.ReadKey();
        }
    }
}
