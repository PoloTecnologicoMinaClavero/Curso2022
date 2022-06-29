using ConsoleApp1.Modelo;
using ConsoleApp1.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Frontend
{
    public class MenuAplicacion
    {
        private RepositorioDePersonas _repositorio;

        public MenuAplicacion()
        {
            _repositorio = new RepositorioDePersonas();
        }

        //Mostrar menú con 3 opciones:
        //1) Agregar persona
        //2) Listar personas
        //3) Eliminar persona
        public void Iniciar()
        {
            
            
            Console.WriteLine("Bienvenido al gestor de personas!");
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1 - Agregar una persona");
            Console.WriteLine("2 - Listar personas");
            Console.WriteLine("3 - Eliminar persona");
            Console.WriteLine("4 - Salir");

            int opcionElegidaMenuPrincipal;

            do
            {
                opcionElegidaMenuPrincipal = Convert.ToInt32(Console.ReadLine());

                switch (opcionElegidaMenuPrincipal)
                {
                    case 1:
                        MostrarAgregarPersona();
                        break;

                    default:
                        break;
                }

            }
            while (opcionElegidaMenuPrincipal != 4);
        }

        public void MostrarAgregarPersona()
        {
            Console.WriteLine("Ingrese el tipo de persona a agregar:");
            Console.WriteLine("1 - Empleado");
            Console.WriteLine("2 - Desempleado");
            Console.WriteLine("3 - Jubilado");

            Persona personaAAgregar;

            var opcionTipoPersona = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese nombre:");
            var nombre = Console.ReadLine();

            Console.WriteLine("Ingrese apellido:");
            var apellido = Console.ReadLine();

            Console.WriteLine("Ingrese fecha de nacimiento (formato DD/MM/AAAA):");
            var fechaDeNacimiento = Console.ReadLine();

            switch (opcionTipoPersona)
            {
                case 1:
                    //Empleado
                    var empleado = new Empleado
                    {
                        Nombre = nombre,
                        Apellido = apellido,
                        FechaNacimiento = fechaDeNacimiento
                    };

                    Console.WriteLine("Ingrese ocupación:");
                    empleado.Ocupacion = Console.ReadLine();

                    Console.WriteLine("Ingrese empresa en la que trabaja:");
                    empleado.Empresa = Console.ReadLine();

                    Console.WriteLine("Ingrese obra social:");
                    empleado.ObraSocial = Console.ReadLine();

                    personaAAgregar = empleado;

                    break;

                case 2:
                    //Desempleado
                    var desempleado = new Desemplado
                    {
                        Nombre = nombre,
                        Apellido = apellido,
                        FechaNacimiento = fechaDeNacimiento
                    };

                    Console.WriteLine("Ingrese última ocupación:");
                    desempleado.UltimaOcupacion = Console.ReadLine();

                    Console.WriteLine("Ingrese última empresa en la que trabajó:");
                    desempleado.UltimaEmpresa = Console.ReadLine();

                    Console.WriteLine("Es discapacitado? S/N:");
                    var esDiscapacitadoOpcion = Console.ReadLine();
                    if(esDiscapacitadoOpcion.ToLower() == "s")
                    {
                        desempleado.EsDiscapacitado = true;
                    }

                    personaAAgregar = desempleado;

                    break;

                default:
                    Console.WriteLine("Opción ingresada incorrecta");
                    return;
            }

            _repositorio.Insertar(personaAAgregar);
            Console.WriteLine("Persona agregada correctamente.");
        }
    }
}
