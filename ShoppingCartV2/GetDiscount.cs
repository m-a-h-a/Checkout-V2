using ShoppingCartV2.Calculators;

namespace ShoppingCartV2
{
    public class GetDiscount
    {
        private DictionaryCreator _dictionaryCreator;
        private Discounts _discounts;

        public decimal GetCalculateDiscount(string shoppingCart)
        {
            _dictionaryCreator = new DictionaryCreator();
            _discounts = new Discounts();
            char[] shoppingCartItems = shoppingCart.ToCharArray();

            var shoppingCartDictionary = _dictionaryCreator.CreateDictionary(shoppingCartItems);

            return _discounts.CalculateDiscount(shoppingCartDictionary);
        }
    }
}
