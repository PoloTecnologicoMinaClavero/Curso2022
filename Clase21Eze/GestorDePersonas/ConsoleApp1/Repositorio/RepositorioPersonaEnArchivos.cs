using ConsoleApp1.Interfaces;
using ConsoleApp1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Repositorio
{
    public class RepositorioPersonaEnArchivos : IRepositorioPersona
    {
        private string _pathArchivo = "c:\\persona.txt";

        public void Actualizar(Persona persona)
        {
            //Actualizo persona en un archivo
        }

        public void Actualizar(string numeroDocumento, string nombre, string apellido)
        {
            //Actualizo persona en un archivo
        }

        public void Eliminar(string numeroDocumento)
        {
            //Elimino persona en un archivo
        }

        public bool Existe(string numeroDocumento)
        {
            //Verifico si existe persona en un archivo
            return true;
        }

        public bool Existe(Persona persona)
        {
            //Verifico si existe persona en un archivo
            return true;
        }

        public void Insertar(Persona persona)
        {
            //Inserto persona en un archivo
        }
    }
}
