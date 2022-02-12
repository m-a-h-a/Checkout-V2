namespace ShoppingCartV2
{
    public class DictionaryCreator
    {
        public Dictionary<char, int> CreateDictionary(char[] items)
        {
            Dictionary<char, int> shoppingCartDictionary = new Dictionary<char, int>();

            foreach (char item in items)
            {
                if (shoppingCartDictionary.ContainsKey(item))
                {
                    shoppingCartDictionary[item]++;
                }
                else
                {
                    shoppingCartDictionary.Add(item, 1);
                }
            }

            return shoppingCartDictionary;
        }
    }
}
