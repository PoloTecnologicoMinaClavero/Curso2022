using ApiServer.Models;
using Dapper;
using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ApiServer.Data
{
    
    public class NorthwindData
    {
        public string _cnnStr = "Server=localhost\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;";
       
        public int DeleteOrderById(int orderId)
        {
            using var cnn = new SqlConnection(_cnnStr);
            cnn.Open();
            var tran = cnn.BeginTransaction();
            try
            {
                var sql = "DELETE FROM [Order Details] WHERE OrderID = @orderId";
                var cant = cnn.Execute(sql, new { orderId }, tran);

                sql = "DELETE FROM Orders WHERE OrderId = @orderId";
                cant += cnn.Execute(sql, new { orderId }, tran);

                tran.Commit();
                return cant;
            }
            catch
            {
                tran.Rollback();
                throw;
            }
            finally
            {
                cnn.Close();
            }

        }

        public List<Product> GetAllProducts()
        {
            using var cnn = new SqlConnection(_cnnStr);
            cnn.Open();
            var query = "SELECT * FROM Products";
            var listProduct = cnn.Query<Product>(query).ToList();
            return listProduct;
        }

        public Product GetProductById(int id)
        {
            using var cnn = new SqlConnection(_cnnStr);
            cnn.Open();
            var q = "SELECT * FROM Products WHERE ProductId = @IdProducto";
            var product = cnn.QueryFirstOrDefault<Product>(q, new { IdProducto = id });
            return product;
        }

        public Product GetProductById(Product p)
        {
            using var cnn = new SqlConnection(_cnnStr);
            cnn.Open();
            var q = "SELECT * FROM Products WHERE ProductId = @ProducId";
            var product = cnn.QueryFirstOrDefault<Product>(q, p);
            return product;
        }

        public List<Order> GetAllOrders2()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            using var cnn = new SqlConnection(_cnnStr);
            cnn.Open();
            var q = "SELECT OrderId, CustomerID FROM Orders";

            var ordenes = cnn.Query<Order>(q).ToList();

            if (ordenes != null)
            {
                foreach (var o in ordenes)
                {
                    var query = "SELECT * FROM [Order Details] WHERE OrderId = @OrderId ";
                    o.Details = new List<OrderDetail>();
                    o.Details.AddRange(cnn.Query<OrderDetail>(query, o).ToList());
                }
            }
            stopWatch.Stop();
            var tiempo = stopWatch.ElapsedMilliseconds;
            return ordenes;
        }


        public List<Order> GetAllOrders()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            using var cnn = new SqlConnection(_cnnStr);
            cnn.Open();
            var q = "SELECT o.OrderId, o.CustomerID, od.* FROM Orders o " +
                "INNER JOIN [Order Details] od ON o.OrderID = od.OrderID";

            var dicc = new Dictionary<int, Order>();

            cnn.Query<Order, OrderDetail, Order>(q,
            (o, d) =>
            {
                if (!dicc.TryGetValue(o.OrderId, out Order order))
                {
                    dicc.Add(o.OrderId, order = o);
                }
                if (order.Details == null)
                {
                    order.Details = new List<OrderDetail>();
                }
                order.Details.Add(d);
                return order;
            },
            splitOn: "OrderId").AsQueryable();

            var orders = dicc.Values.ToList();

            stopWatch.Stop();
            var tiempo = stopWatch.ElapsedMilliseconds;
            return orders;

        }
    }
}
