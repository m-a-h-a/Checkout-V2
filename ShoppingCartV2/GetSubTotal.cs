using ShoppingCartV2.Interfaces;

namespace ShoppingCartV2
{
    public class GetSubTotal : ISubTotalCalculator
    {
        public decimal GatherSubTotal(string shoppingCart)
        {
            DictionaryCreator dc = new DictionaryCreator();
            SubTotalCalculator stc = new SubTotalCalculator();
            char[] shoppingCartItems = shoppingCart.ToCharArray();

            var shoppingCartDictionary = dc.CreateDictionary(shoppingCartItems);

            return stc.Calculate(shoppingCartDictionary);
        }
    }
}
