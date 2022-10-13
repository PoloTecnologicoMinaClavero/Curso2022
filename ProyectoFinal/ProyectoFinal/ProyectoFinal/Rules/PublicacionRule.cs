using Dapper;
using ProyectoFinal.Models;
using System.Data.SqlClient;

namespace ProyectoFinal.Rules
{
    public class PublicacionRule
    {
        public Publicacion GetOnePostRandom()
        {

            var connectionString = @"Server=.\SQL2019; Database=BlogDatabase; Trusted_Connection=True";
            using var connection = new SqlConnection(connectionString);
            {
                connection.Open();
                var posts = connection.Query<Publicacion>("SELECT TOP 1 * FROM Publicacion");

                return posts.First();
            }
        }

    }
}
