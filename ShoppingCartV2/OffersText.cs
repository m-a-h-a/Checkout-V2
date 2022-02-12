using static ShoppingCartV2.StaticValues.ItemPrices;

namespace ShoppingCartV2
{
    public class OffersText
    {
        private DictionaryCreator _dictionaryCreator;

        public string CreateOffersText(string receivedItems)
        {
            string offersText = string.Empty;
            _dictionaryCreator = new DictionaryCreator();
            char[] shoppingCartItems = receivedItems.ToCharArray();

            var shoppingCartDictionary = _dictionaryCreator.CreateDictionary(shoppingCartItems);

            foreach (char item in shoppingCartDictionary.Keys)
            {
                switch (item)
                {
                    case 'a':
                    case 'A':
                        if (shoppingCartDictionary[item] >= itemAOfferTriggerNumber)
                        {
                            offersText += "Item A Offer: Buy 3 for 130\n";
                        }
                        break;
                    case 'b':
                    case 'B':
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
