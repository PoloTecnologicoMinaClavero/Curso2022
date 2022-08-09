using System.Data.SqlClient;

//var connectionString = "Provider=MSOLEDBSQL;Server=myServerName\theInstanceName;Database=myDataBase;Trusted_Connection=yes;";
var connectionString = @"Server=.\SQL2019;Database=Northwind;Trusted_Connection=yes;";

using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();

    var command = new SqlCommand("SELECT * FROM Customers", connection);
    var reader = command.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine($"{reader["CustomerID"]} | {reader["CompanyName"]} | {reader["ContactName"]}");
    }

    command = new SqlCommand("SELECT * FROM Suppliers", connection);
    var reader2 = command.ExecuteReader();
    while (reader2.Read())
    {
        Console.WriteLine($"{reader2["SupplierID"]} | {reader2["CompanyName"]} | {reader["ContactName"]}");
    }

}
