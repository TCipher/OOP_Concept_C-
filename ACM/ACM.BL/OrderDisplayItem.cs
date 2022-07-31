namespace ACM.BL
{
    public class OrderDisplayItem
    {
        public int OrderItemId { get; private set; }
        public int orderQuantity { get; set; }
        public string productName { get; set; }
        public decimal? PurchasePrice { get; set; }
    }
}