namespace ShoppingCartV2
{
    public class GetSubTotal
    {
        private DictionaryCreator _dictionaryCreator;
        private SubTotals _calculateItems;

        public decimal GatherSubTotal(string shoppingCart)
        {
            _dictionaryCreator = new DictionaryCreator();
            _calculateItems = new SubTotals();
            char[] shoppingCartItems = shoppingCart.ToCharArray();

            var shoppingCartDictionary = _dictionaryCreator.CreateDictionary(shoppingCartItems);

            return _calculateItems.CalculateSubTotal(shoppingCartDictionary);
        }
    }
}
