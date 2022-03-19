using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    internal class persona 
    {
        // Estudiante

        //Variables - agregar
        public string agregar_nombrePersona;
        public string agregar_apellidoPersona;
        public string agregar_identificacionPersona;
        public string agregar_sexoPersona;
        public int continuar_formulario; 
        public string agregar_edadPersona;
        public string agregar_facultadPersona;

        // Profesor
        public string agregar_profesionPersona;
        public string agregar_universidadPersona;
        public string agregar_culminarPersona;
        public string agregar_fechade_ingresoPersona;

        //variables eliminar
        public int identificarDato; //
        public string eliminarDato; //

        //variables modificar
        public int identificar_dato; // 
        public string buscar_dato; //
        public string modificarDato; //

        public void menuPrincipal() 
        {
            int opcion_clase; //Crear clase para usar switch

            Console.WriteLine("--------------- BIENVENIDO --------------- \n");
            Console.WriteLine("¿Quién es usted?\n" +
                "\n Seleccione por Favor:\n \n 1: Profesor \n 2: Estudiante \n 3: Cerrar\n");
            opcion_clase = int.Parse(Console.ReadLine()); //Parse es para convertir de strin a int o contrario

            switch (opcion_clase)
            {
                case 1:
                    Profesor profesor_switch = new Profesor();
                    profesor_switch.profesor();
                    break;
                case 2:
                    Estudiante estudiante_switch = new Estudiante();
                    estudiante_switch.estudiante();
                    break;
                case 3:
                    Environment.Exit(-1);
                    break;
                default:
                    Console.WriteLine("Seleccione una opción valida :)");
                    break;
            }
        }
        
}
}
