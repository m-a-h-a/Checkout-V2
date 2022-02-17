using ShoppingCartV2.Calculators;
using ShoppingCartV2.Interfaces;

namespace ShoppingCartV2
{
    public class GetDiscount : IDiscountCalculator
    {
        public decimal GetCalculateDiscount(string shoppingCart)
        {
            DictionaryCreator dc = new DictionaryCreator();
            DiscountCalculator discountCalculator = new DiscountCalculator();

            char[] shoppingCartItems = shoppingCart.ToCharArray();

            var shoppingCartDictionary = dc.CreateDictionary(shoppingCartItems);

            return discountCalculator.Calculate(shoppingCartDictionary);
        }
    }
}
