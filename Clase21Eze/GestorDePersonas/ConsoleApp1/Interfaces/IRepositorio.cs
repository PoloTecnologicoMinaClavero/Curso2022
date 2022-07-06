using ConsoleApp1.Modelo;

namespace ConsoleApp1.Interfaces
{
    public interface IRepositorioPersona
    {
        void Insertar(Persona persona);
        void Eliminar(string numeroDocumento);

        void Actualizar(Persona persona);
        void Actualizar(string numeroDocumento, string nombre, string apellido);

        bool Existe(string numeroDocumento);
        bool Existe(Persona persona);
    }
}
