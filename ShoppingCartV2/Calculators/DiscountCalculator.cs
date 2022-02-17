using ShoppingCartV2.Interfaces;
using static ShoppingCartV2.StaticValues.ItemPrices;
namespace ShoppingCartV2.Calculators
{
    public class DiscountCalculator
    {
        public decimal Calculate(Dictionary<char, int> shoppingCartDictionary)
        {
            decimal discountAmount = 0;

            foreach (char item in shoppingCartDictionary.Keys)
            {
                discountAmount = CalculateDiscount(item, shoppingCartDictionary, discountAmount);
            }

            return discountAmount;
        }

        public decimal CalculateDiscount(char item, Dictionary<char, int> shoppingCartDictionary, decimal discountAmount)
        {
            decimal fullPrice = 0;
            int numberOfOffers = 0;
            int modulus = 0;
            int additionalItemsAfterOfferApplied = 0;
            char itemLower = char.ToLower(item);

            if ((shoppingCartDictionary[item] >= itemAOfferTriggerNumber && itemLower == 'a') || (shoppingCartDictionary[item] >= itemBOfferTriggerNumber && itemLower == 'b'))
            {
                fullPrice = shoppingCartDictionary[item] * ((shoppingCartDictionary[item] >= itemAOfferTriggerNumber && itemLower == 'a') ? itemAPrice : itemBPrice);
                modulus = shoppingCartDictionary[item] % ((shoppingCartDictionary[item] >= itemAOfferTriggerNumber && itemLower == 'a') ? itemAOfferTriggerNumber : itemBOfferTriggerNumber);
                additionalItemsAfterOfferApplied = shoppingCartDictionary[item] - modulus;

                numberOfOffers = additionalItemsAfterOfferApplied / ((shoppingCartDictionary[item] >= itemAOfferTriggerNumber && itemLower == 'a') ? itemAOfferTriggerNumber : itemBOfferTriggerNumber);
                discountAmount += fullPrice - ((numberOfOffers * ((shoppingCartDictionary[item] >= itemAOfferTriggerNumber && itemLower == 'a') ? itemAOfferPriceFor3 : itemBOfferPriceFor2)) + (modulus * ((shoppingCartDictionary[item] >= itemAOfferTriggerNumber && itemLower == 'a') ? itemAPrice : itemBPrice)));
            }

            return discountAmount;
        }
    }
}
