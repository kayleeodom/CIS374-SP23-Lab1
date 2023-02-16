using System.Collections.Generic;

namespace Lab1
{
    public interface IKeyValueMap<TKey, TValue>
    {
        public void Add(TKey key, TValue value);
        public KeyValuePair<TKey, TValue> Get(TKey key);
        public bool Remove(TKey key);
        void Clear();

        public int Height { get; }
        public int Count { get; }
    }
}