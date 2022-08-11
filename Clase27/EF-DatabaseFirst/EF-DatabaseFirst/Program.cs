
using EF_DatabaseFirst.Models;
using EFDatabaseFirs.Namespace;
using Microsoft.EntityFrameworkCore;

var ctx = new NorthwindContext();

////Creamos customer
//var newCustomer = new Customer()
//{
//    CustomerId = "RUBEN",
//    CompanyName = "Ruben Benegas",
//    Orders = new List<Order>()
//};

//newCustomer.Orders.Add(new Order()
//{
//    CustomerId = "RUBEN",
//    OrderDate = DateTime.Now,
//});

////Agregamos el customer
//ctx.Add(newCustomer);
//ctx.SaveChanges();


////EDITAR
//var reg = ctx.Customers.FirstOrDefault(r => r.CustomerId == "RUBEN");
//if (reg != null)
//{
//    reg.CompanyName = "Ruben Benegas Editado";
//    ctx.SaveChanges();
//}

////ELIMINAR
//var regOrders = ctx.Orders.Where(r => r.CustomerId == "RUBEN");
//ctx.RemoveRange(regOrders);
//var regCustomer = ctx.Customers.FirstOrDefault(r => r.CustomerId == "RUBEN");
//ctx.Remove(regCustomer);
//ctx.SaveChanges();

Console.WriteLine("Lista de Customers");
Console.WriteLine();
Console.WriteLine("===================================");

//var customers = ctx.Customers.Select(selector => 
//                                    new { IdCustomer = selector.CustomerId, 
//                                    NameCustomer = selector.CompanyName });



//var sqlRaw = ctx.Customers.FromSqlRaw("SELECT * FROM Customers");


//SELECT
var customers = ctx.Customers;

foreach (var customer in customers)
{
    Console.WriteLine($"{customer.CustomerId} - {customer.CompanyName}");
}

Console.WriteLine("===================================");
Console.WriteLine();
Console.Write("Ingrese el IDCustomer que desea consultar: ");
string idCustomer = Console.ReadLine();

//Consulta si existe en la base de datos (Any)
bool anyCustomer = ctx.Customers.Any(x => x.CustomerId == idCustomer.ToUpper());

if (anyCustomer)
{
    Console.WriteLine("Existe. Todo OK!");

    //SELECT TOP (1) 
    var customer = ctx.Customers.Include(i => i.Orders)
                                .FirstOrDefault(c=> c.CustomerId == idCustomer);

    Console.WriteLine();
    Console.WriteLine($"IdCustomer: {customer.CustomerId} - CompanyName: {customer.CompanyName}");
    Console.WriteLine();
    Console.WriteLine("Orders");
    foreach (var item in customer.Orders)
    {
        Console.WriteLine($"OrderId: {item.OrderId} - OrderDate: {item.OrderDate}");
    }
    Console.WriteLine("===========================================");
    Console.WriteLine();
}
else
{
    Console.WriteLine("El IdCustomer ingresado no existe en la BD.");
}



Console.ReadKey();
