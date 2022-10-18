using Dapper;
using ProyectoFinal.Models;
using System.Data.SqlClient;

namespace ProyectoFinal.Rules
{
    public class PublicacionRule
    {
        private readonly IConfiguration _configuration;
        public PublicacionRule(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public Publicacion GetOnePostRandom()
        {
            var connectionString = _configuration.GetConnectionString("BlogDatabase");
            using var connection = new SqlConnection(connectionString);
            {
                connection.Open();
                var posts = connection.Query<Publicacion>("SELECT TOP 1 * FROM Publicacion");

                return posts.First();
            }
        }

        public List<Publicacion> GetPostsHome()
        {
            var connectionString = _configuration.GetConnectionString("BlogDatabase");
            using var connection = new SqlConnection(connectionString);
            {
                connection.Open();
                var posts = connection.Query<Publicacion>("SELECT TOP 4 * FROM Publicacion ORDER BY Creacion DESC");

                return posts.ToList();
            }
        }

    }
}
