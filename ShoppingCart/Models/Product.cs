namespace ShoppingCart.Models
{
    public class Product 
    {
        public string ProductName { get; internal set; }
        public string UnitQty { get; internal set; }
        public string Quantity { get; internal set; }
        public double ItemPrice { get; internal set; }

        public string CaindId { get; internal set; }
        public string ItemCode { get; internal set; }

    }
}
