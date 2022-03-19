using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{

    internal class Profesor : persona
    {
        //Fecha ingreso, lvl academico. debe ser una estructura que contenga los atributos
        //profesion, universidad, año de culminación

        ArrayList profesor_listar = new ArrayList();

        enum tipo_sexo
        {
            masculino,
            femenino
        }
        enum tipo_facultad
        {
            Ingeneria,
            Medicina,
            Ciencias_sociales,
            Ciencias_adminitrativas
        }

        public void profesor()
        {

            for (int i = 0; i <= 100; i++)
            {
                Console.Clear();
                Console.WriteLine("--------------- BIENVENIDO PROFESOR ---------------\n");
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
                        eliminar();
                        break;

                    case 3:
                        modificar();
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
            Console.WriteLine("\nDigite su Nombre:\n");
            agregar_nombrePersona = Console.ReadLine();
            profesor_listar.Add(agregar_nombrePersona);

            Console.Clear();
            Console.WriteLine("\nDigite su apellido:\n");
            agregar_apellidoPersona = Console.ReadLine();
            profesor_listar.Add(agregar_apellidoPersona);

            Console.Clear();
            Console.WriteLine("\nDigite su Identificación:\n");
            agregar_identificacionPersona = Console.ReadLine();
            profesor_listar.Add(agregar_identificacionPersona);

            Console.Clear();
            Console.WriteLine("\nDigite su Sexo:\n \n 1: Masculino \n 2: Femenino\n");
            agregar_sexoPersona = Console.ReadLine();
            profesor_listar.Add(agregar_sexoPersona);

            // FechaIngreso / NivelAcademico
            Console.Clear();
            Console.WriteLine("\nDigite su Fecha de Ingreso: \n" +
                                "\nExample: 23 - 11 - 2003\n");
            agregar_fechade_ingresoPersona = Console.ReadLine();
            profesor_listar.Add(agregar_fechade_ingresoPersona);

            Console.Clear();
            Console.WriteLine("\nDigite su profesión:\n" +
                              "\n1 - Ingeneria\n \n2 - Medicina\n \n3 - Ciencias Sociales\n \n4 - Ciencias Administrativas\n");
            agregar_profesionPersona = Console.ReadLine();
            profesor_listar.Add(agregar_profesionPersona);

            Console.Clear();
            Console.WriteLine("\nDigite su  Universidad: \n");
            agregar_universidadPersona = Console.ReadLine();
            profesor_listar.Add(agregar_universidadPersona);

            Console.Clear();
            Console.WriteLine("\nDigite su Año de culiminación: \n"); //Creo que va un parse de string a int
            agregar_culminarPersona = Console.ReadLine();
            profesor_listar.Add(agregar_culminarPersona);
                        
            // sexo
            if (agregar_sexoPersona == "1")
            {
                profesor_listar.Add(tipo_sexo.masculino);
            }
            else
            {
                profesor_listar.Add(tipo_sexo.femenino);
            }

            // facultad
            if (agregar_profesionPersona == "1")
            {
                profesor_listar.Add(tipo_facultad.Ingeneria);
            }
            else if (agregar_profesionPersona == "2")
            {
                profesor_listar.Add(tipo_facultad.Medicina);
            }
            else if(agregar_profesionPersona == "3")
            {
                profesor_listar.Add(tipo_facultad.Ciencias_sociales);
            }
            else if(agregar_profesionPersona == "4")
            {
                profesor_listar.Add(tipo_facultad.Ciencias_adminitrativas);
            }
        }

        public void eliminar()
        {
            Console.Clear();
            Console.WriteLine("----------------- ELIMINAR -----------------");
            Console.WriteLine("Diga el campo que va a borrar el dato: \n1: nombre \n2: Apellido \n3: Identificación \n4: Sexo" +
                "\n5: Fecha Ingreso \n6: Profesión \n 7: Universidad \n8: Culminación ");
            identificarDato = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEscriba el dato que usted va a borrar: \n");
            eliminarDato = Console.ReadLine();

            switch (identificarDato)
            {
                case 1:
                    if (profesor_listar.Contains(eliminarDato) == true)
                    {
                        Console.Write("\nSu dato ha sido eliminado! :D\n");

                        profesor_listar.Remove(eliminarDato);
                    }
                    else
                    {
                        Console.WriteLine("No se ha encontrado los datos :(");
                    }
                    break;
                case 2:
                    if (profesor_listar.Contains(eliminarDato) == true)
                    {
                        Console.Write("\nSu dato ha sido eliminado! :D\n");

                        profesor_listar.Remove(eliminarDato);
                    }
                    else
                    {
                        Console.WriteLine("No se ha encontrado los datos :(");
                    }
                    break;
                case 3:
                    if (profesor_listar.Contains(eliminarDato) == true)
                    {
                        Console.Write("\nSu dato ha sido eliminado! :D\n");
                        profesor_listar.Remove(eliminarDato);
                    }
                    else
                    {
                        Console.WriteLine("No se ha encontrado los datos :(");
                    }
                    break;
                case 4:
                    if (profesor_listar.Contains(eliminarDato) == true)
                    {
                        Console.Write("\nSu dato ha sido eliminado! :D\n");
                        profesor_listar.Remove(eliminarDato);
                    }
                    else
                    {
                        Console.WriteLine("No se ha encontrado los datos :(");
                    }
                    break;
                case 5:
                    if (profesor_listar.Contains(eliminarDato) == true)
                    {
                        Console.Write("\nSu dato ha sido eliminado! :D\n");
                        profesor_listar.Remove(eliminarDato);
                    }
                    else
                    {
                        Console.WriteLine("No se ha encontrado los datos :(");
                    }
                    break;
                case 6:
                    if (profesor_listar.Contains(eliminarDato) == true)
                    {
                        Console.Write("\nSu dato ha sido eliminado! :D\n");
                        profesor_listar.Remove(eliminarDato);
                    }
                    else
                    {
                        Console.WriteLine("No se ha encontrado los datos :(");
                    }
                    break;
                case 7:
                    if (profesor_listar.Contains(eliminarDato) == true)
                    {
                        Console.Write("\nSu dato ha sido eliminado! :D\n");
                        profesor_listar.Remove(eliminarDato);
                    }
                    else
                    {
                        Console.WriteLine("No se ha encontrado los datos :(");
                    }
                    break;
                case 8:
                    if (profesor_listar.Contains(eliminarDato) == true)
                    {
                        Console.Write("\nSu dato ha sido eliminado! :D\n");
                        profesor_listar.Remove(eliminarDato);
                    }
                    else
                    {
                        Console.WriteLine("No se ha encontrado los datos :(");
                    }
                    break;
                default:
                    break;
            }
        }

        public void modificar()
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
                    if (profesor_listar.Contains(buscar_dato) == true)
                    {
                        Console.WriteLine("\nSus datos se han modificado! :D\n");
                        profesor_listar.Remove(buscar_dato);
                        profesor_listar.Add(modificarDato);
                    }
                    break;
                case 2:
                    if (profesor_listar.Contains(buscar_dato) == true)
                    {
                        Console.WriteLine("\nSus datos se han modificado! :D\n");
                        profesor_listar.Remove(buscar_dato);
                        profesor_listar.Add(modificarDato);
                    }
                    break;
                case 3:
                    if (profesor_listar.Contains(buscar_dato) == true)
                    {
                        Console.WriteLine("\nSus datos se han modificado! :D\n");
                        profesor_listar.Remove(buscar_dato);
                        profesor_listar.Add(modificarDato);
                    }
                    break;
                case 4:
                    if (profesor_listar.Contains(buscar_dato) == true)
                    {
                        Console.WriteLine("\nSus datos se han modificado! :D\n");
                        profesor_listar.Remove(buscar_dato);
                        profesor_listar.Add(modificarDato);
                    }
                    break;
                case 5:
                    if (profesor_listar.Contains(buscar_dato) == true)
                    {
                        Console.WriteLine("\nSus datos se han modificado! :D\n");
                        profesor_listar.Remove(buscar_dato);
                        profesor_listar.Add(modificarDato);
                    }
                    break;
                case 6:
                    if (profesor_listar.Contains(buscar_dato) == true)
                    {
                        Console.WriteLine("\nSus datos se han modificado! :D\n");
                        profesor_listar.Remove(buscar_dato);
                        profesor_listar.Add(modificarDato);
                    }
                    break;
                case 7:
                    if (profesor_listar.Contains(buscar_dato) == true)
                    {
                        Console.WriteLine("\nSus datos se han modificado! :D\n");
                        profesor_listar.Remove(buscar_dato);
                        profesor_listar.Add(modificarDato);
                    }
                    break;
                case 8:
                    if (profesor_listar.Contains(buscar_dato) == true)
                    {
                        Console.WriteLine("\nSus datos se han modificado! :D\n");
                        profesor_listar.Remove(buscar_dato);
                        profesor_listar.Add(modificarDato);
                    }
                    break;
            }
        }

        public void Imprimir()
        {
            Console.Clear();
            for (int i = 0; i < profesor_listar.Count; i++)
            {
                Console.WriteLine("{0}:{1}", i, profesor_listar[i]);
            }
            Console.WriteLine("---------------------------\n");

            Console.ReadKey();
        }
    }
}

