
using EFDatabaseFirs.Namespace;

var ctx = new NorthwindContext();

var customers = ctx.Customers;

foreach (var item in customers)
{
}
