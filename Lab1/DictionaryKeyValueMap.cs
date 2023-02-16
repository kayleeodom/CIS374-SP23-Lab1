using System;
using System.Collections.Generic;

namespace Lab1
{
    public class DictionaryKeyValueMap<TKey, TValue> : IKeyValueMap<TKey, TValue>
    {
        private Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();

        public int Height => 1;

        public int Count => dictionary.Count;

        public void Add(TKey key, TValue value)
        {
            dictionary.Add(key, value);
        }

        public KeyValuePair<TKey, TValue> Get(TKey key)
        {
            return new KeyValuePair<TKey, TValue>(key, dictionary[key]);
        }

        public bool Remove(TKey key)
        {
            if (dictionary.ContainsKey(key))
            {
                dictionary.Remove(key);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Clear()
        {
            dictionary.Clear();
        }

    }
}
