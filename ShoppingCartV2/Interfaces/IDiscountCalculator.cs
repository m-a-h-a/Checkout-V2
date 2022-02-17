namespace ShoppingCartV2.Interfaces
{
    public interface IDiscountCalculator
    {
        decimal GetCalculateDiscount(string shoppingCart);

    }
}
