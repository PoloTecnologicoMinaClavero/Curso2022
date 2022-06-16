using ConsoleApp1.Modelo;
using ConsoleApp1.Repositorio;

//Gestor de personas trabajadoras (empleados, desempleados, jubilados)
//Insertar personas en una base de datos, mostrar datos de una determinada persona o
//de todas las personas.

var repositorio = new RepositorioDePersonas();

//Le pido al usuario los datos de una persona para agregar
//El usuario debería elegir el tipo de persona a agregar
var usuarioNombre = "Ezequiel";
var usuarioApellido = "Etchecoin";

repositorio.Insertar(new Desemplado
{
    Nombre = usuarioNombre,
    Apellido = usuarioApellido
});