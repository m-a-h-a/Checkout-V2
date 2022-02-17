using static ShoppingCartV2.StaticValues.ItemPrices;

namespace ShoppingCartV2
{
    public class SubTotalCalculator
    {
        public decimal Calculate(Dictionary<char, int> shoppingCartDictionary)
        {
            decimal subTotal = 0;

            foreach (char item in shoppingCartDictionary.Keys)
            {
                char itemLower = char.ToLower(item);

                switch(itemLower)
                {
                    case 'a':
                        subTotal += itemAPrice * shoppingCartDictionary[item];
                        break;
                    case 'b':
                        subTotal += itemBPrice * shoppingCartDictionary[item];
                        break;
                    case 'c':
                        subTotal += itemCPrice * shoppingCartDictionary[item];
                        break;
                    case 'd':
                        subTotal += itemDPrice * shoppingCartDictionary[item];
                        break;
                }
            }

            return subTotal;
        }
    }
}
