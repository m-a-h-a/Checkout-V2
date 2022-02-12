using static ShoppingCartV2.StaticValues.ItemPrices;

namespace ShoppingCartV2
{
    public class SubTotals
    {
        public decimal CalculateSubTotal(Dictionary<char, int> shoppingCartDictionary)
        {
            decimal subTotal = 0;

            foreach (char item in shoppingCartDictionary.Keys)
            {
                switch(item)
                {
                    case 'a':
                    case 'A':
                        subTotal += itemAPrice * shoppingCartDictionary[item];
                        break;
                    case 'b':
                    case 'B':
                        subTotal += itemBPrice * shoppingCartDictionary[item];
                        break;
                    case 'c':
                    case 'C':
                        subTotal += itemCPrice * shoppingCartDictionary[item];
                        break;
                    case 'd':
                    case 'D':
                        subTotal += itemDPrice * shoppingCartDictionary[item];
                        break;
                }
            }

            return subTotal;
        }
    }
}
