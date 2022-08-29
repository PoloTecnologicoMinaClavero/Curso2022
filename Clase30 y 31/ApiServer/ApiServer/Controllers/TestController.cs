using ApiServer.Models;
using ApiServer.Rules;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("/api/products")]
        public List<Product> GetAllProducts()
        {
            var rule = new ProductRule();
            return rule.GetAllProducts();
        }

        [HttpGet("/api/products/{id}")]
        public Product GetProduct(int id)
        {
            var rule = new ProductRule();
            return rule.GetProductById(id);
        }

        [HttpGet("/api/orders/")]
        public List<Order> GetOrders()
        {
            var rule = new OrderRule();
            return rule.GetAllOrders();
        }

        [HttpDelete("/api/orders/")]
        public RespuestaDelete DeleteOrderById(int orderId)
        {
            var rule = new OrderRule();
            return rule.DeleteOrderById(orderId);
        }
        [HttpPost]
        public void PostOrder(int orderId, string nombre)
        {

        }
    }
}
