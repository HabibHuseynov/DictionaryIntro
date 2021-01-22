namespace DictionaryIntro
{
    class MyDictionary<K, V>
    {
        K[] keys;
        V[] values;
        K[] tempKeys;
        V[] tempValues;

        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];

        }

        public void Add(K key, V value)
        {
            tempKeys = keys;
            tempValues = values;

            keys = new K[tempKeys.Length + 1];
            values = new V[tempValues.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[tempKeys.Length] = key;
            values[tempValues.Length] = value;

        }
        public int Length
        {
            get
            {
                return keys.Length;
            }
        }
        public K[] Keys
        {
            get
            {
                return keys;
            }
        }
        public V[] Values
        {
            get
            {
                return values;
            }
        }

    }
}
