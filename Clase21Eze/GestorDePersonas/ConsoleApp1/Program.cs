using ConsoleApp1.Frontend;
using ConsoleApp1.Repositorio;

//Gestor de personas trabajadoras (empleados, desempleados, jubilados)
//Insertar personas en una base de datos, mostrar datos de una determinada persona o
//de todas las personas.

var menuAplicacion = new MenuAplicacion(new RepositorioPersonaEnArchivos());
menuAplicacion.Iniciar();