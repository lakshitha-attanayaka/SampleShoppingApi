namespace SampleShoppingApi.Models
{
    public class ShoppingCart
    {
        public double TotalPrice { get; set; }
        public int NumberOfItems { get; set; }
        public string CustomerName { get; set; }
        public List<ShoppingItem> Items { get; set; } = new List<ShoppingItem>();
    }
}
