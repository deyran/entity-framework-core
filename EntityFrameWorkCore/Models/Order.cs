namespace EntityFrameWorkCore.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderFulfilled { get; set; }
        public int Customer { get; set; }

        public Customer Customers { get; set; } = null!;
        public ICollection<OrderDetail> OrderDetails { get; set; }

    }
}