namespace ApiServer.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerID { get; set; }
        public List<OrderDetail> Details { get; set; }
    }
}
