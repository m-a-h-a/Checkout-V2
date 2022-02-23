using ShoppingCartV2.Interfaces;
using static ShoppingCartV2.StaticValues.ItemPrices;

namespace ShoppingCartV2
{
    public class OffersText : IOffersText
    {
        public string CreateOffersText(string receivedItems)
        {
            DictionaryCreator dc = new DictionaryCreator();
            string offersText = string.Empty;
            char[] shoppingCartItems = receivedItems.ToCharArray();

            var shoppingCartDictionary = dc.CreateDictionary(shoppingCartItems);

            foreach (char item in shoppingCartDictionary.Keys)
            {
                char itemLower = char.ToLower(item);

                switch (itemLower)
                {
                    case 'a':
                        if (shoppingCartDictionary[item] >= itemAOfferTriggerNumber)
                        {
                            offersText += "Item A Offer: Buy 3 for 130\n";
                        }
                        break;
                    case 'b':
                        if (shoppingCartDictionary[item] >= itemBOfferTriggerNumber)
                        {
                            offersText += "Item B Offer: Buy 2 for 45\n";
                        }
                        break;
                }
            }

            if (offersText == string.Empty)
            {
                offersText = "No Offers Applied.";
            }
            return offersText;
        }
    }
}
