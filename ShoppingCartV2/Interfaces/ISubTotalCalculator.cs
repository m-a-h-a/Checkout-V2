namespace ShoppingCartV2.Interfaces
{
    public interface ISubTotalCalculator
    {
        decimal GatherSubTotal(string shoppingCart);
    }
}
