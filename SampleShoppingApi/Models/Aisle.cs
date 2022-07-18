namespace SampleShoppingApi.Models
{
    public class Aisle
    {
        public string Type { get; set; }
        public List<ShoppingItem> Items { get; set; } = new List<ShoppingItem>();
    }
}
