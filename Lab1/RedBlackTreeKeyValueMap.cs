using DSA.DataStructures.Trees;
using System.Collections.Generic;

namespace Lab1
{
    //Done?
    public class RedBlackTreeKeyValueMap<TKey, TValue> : IKeyValueMap<TKey, TValue>
    {
        public RedBlackTreeMap<TKey, TValue> redBlackTreeMap = new RedBlackTreeMap<TKey, TValue>();

        public int Height => redBlackTreeMap.Height;

        public int Count => redBlackTreeMap.Count;

        public void Add(TKey key, TValue value)
        {
            redBlackTreeMap.Add(key, value);
        }

        public void Clear()
        {
            redBlackTreeMap.Clear();
        }

        public KeyValuePair<TKey, TValue> Get(TKey key)
        {
            TValue value;
            redBlackTreeMap.TryGetValue(key, out value);
            return new KeyValuePair<TKey, TValue>(key, value);
        }

        public bool Remove(TKey key)
        {
            if (redBlackTreeMap.ContainsKey(key))
            {
                redBlackTreeMap.Remove(key);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}