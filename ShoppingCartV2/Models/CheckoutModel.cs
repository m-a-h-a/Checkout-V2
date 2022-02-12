namespace ShoppingCartV2.Models
{
    public class CheckoutModel
    {
        public string CartContents { get; set; }
        public decimal Subtotal { get; set; }
        public string OffersAppliedText { get; set; }
        public decimal DiscountApplied { get; set; }
        public decimal CheckoutTotal { get; set; }
    }
}
