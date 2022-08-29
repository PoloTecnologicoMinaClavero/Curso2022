using ApiServer.Models;
using ApiServer.Data;

namespace ApiServer.Rules
{
    public class ProductRule
    {
        public List<Product> GetAllProducts()
        {
            var data = new NorthwindData();
            return data.GetAllProducts();  
        }

        public Product GetProductById(int id)
        {
            var data = new NorthwindData();
            return data.GetProductById(id);
        }


    }
}
