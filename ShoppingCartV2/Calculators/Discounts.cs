using static ShoppingCartV2.StaticValues.ItemPrices;
namespace ShoppingCartV2.Calculators
{
    public class Discounts
    {
        public decimal CalculateDiscount(Dictionary<char, int> shoppingCartDictionary)
        {
            decimal discountAmount = 0;
            decimal fullPrice = 0;
            int numberOfOffers = 0;
            int modulus = 0;
            int additionalItemsAfterOfferApplied = 0;

            foreach (char item in shoppingCartDictionary.Keys)
            {
                switch (item)
                {
                    case 'a':
                    case 'A':
                        if (shoppingCartDictionary[item] >= itemAOfferTriggerNumber)
                        {
                            fullPrice = shoppingCartDictionary[item] * itemAPrice;
                            modulus = shoppingCartDictionary[item] % itemAOfferTriggerNumber;
                            additionalItemsAfterOfferApplied = shoppingCartDictionary[item] - modulus;

                            numberOfOffers = additionalItemsAfterOfferApplied / itemAOfferTriggerNumber;
                            discountAmount += fullPrice - ((numberOfOffers * itemAOfferPriceFor3) + (modulus * itemAPrice));
                        }
                        break;
                    case 'b':
                    case 'B':
                        if (shoppingCartDictionary[item] >= itemBOfferTriggerNumber)
                        {
                            fullPrice = shoppingCartDictionary[item] * itemBPrice;
                            modulus = shoppingCartDictionary[item] % itemBOfferTriggerNumber;
                            additionalItemsAfterOfferApplied = shoppingCartDictionary[item] - modulus;

                            numberOfOffers = additionalItemsAfterOfferApplied / itemBOfferTriggerNumber;
                            discountAmount += fullPrice - ((numberOfOffers * itemBOfferPriceFor2) + (modulus * itemBPrice));
                        }
                        break;
                }
            }

            return discountAmount;
        }
    }
}
