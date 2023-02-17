using System;
using System.Collections.Generic;
using System.Diagnostics;
using DSA.DataStructures.Trees;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int MAX = 1_000_000;
            int ITERATIONS = 11;

            double totalOrderedCreate = 0;
            double totalUnorderedCreate = 0;

            double totalOrderedGet = 0;
            double totalUnorderedGet = 0;

            double totalOrderdRemoval = 0;
            double totalUnorderedRemoval = 0;

            double totalHeightOrdered = 0;
            double totalHeightUnordered = 0;

            IKeyValueMap<int, int> keyValueMap = null ;

            var dictionaryKeyValueMap = new DictionaryKeyValueMap<int, int>();
            var bstKeyValueMap = new BinarySearchTreeKeyValueMap<int, int>();
            var avlKeyValueMap = new AVLTreeKeyValueMap<int, int>();
            var redblackKeyValueMap = new RedBlackTreeKeyValueMap<int, int>();

            keyValueMap = bstKeyValueMap;

            for (int c = 0; c < ITERATIONS; c++)
            {
                var intKeyValuePairs = new List<KeyValuePair<int, int>>();

                for (int i = 0; i < MAX; i++)
                {
                    intKeyValuePairs.Add(new KeyValuePair<int, int>(i, i + 42));
                }

                keyValueMap.Clear();
                // Ordered
                    // Create
                totalOrderedCreate += CreateKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);
                    // Height
                //totalHeightOrdered += keyValueMap.Height;
                    // Get
                totalOrderedGet += QueryKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);
                    // Removal
                totalOrderdRemoval += RemoveKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);


                //Console.WriteLine("Unordered");
                intKeyValuePairs.Shuffle();
                keyValueMap.Clear();
                // Unordered
                    // Create
                //totalUnorderedCreate += CreateKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);
                    // Height
                //totalHeightUnordered += keyValueMap.Height;
                    // Get
                //totalUnorderedGet += QueryKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);
                    // Removal
                //totalUnorderedRemoval += RemoveKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);

            }

            Console.WriteLine(keyValueMap.GetType());

            Console.WriteLine("Ordered");
            Console.WriteLine("Create");
            Console.WriteLine(totalOrderedCreate / ITERATIONS);
            Console.WriteLine("Get");
            Console.WriteLine(totalOrderedGet / ITERATIONS);
            Console.WriteLine("Removal");
            Console.WriteLine(totalOrderdRemoval / ITERATIONS);
            Console.WriteLine("Height");
            Console.WriteLine(totalHeightOrdered/ ITERATIONS);

            Console.WriteLine("Unordered");
            Console.WriteLine("Create");
            Console.WriteLine(totalUnorderedCreate / ITERATIONS);
            Console.WriteLine("Get");
            Console.WriteLine(totalUnorderedGet / ITERATIONS);
            Console.WriteLine("Removal");
            Console.WriteLine(totalUnorderedRemoval / ITERATIONS);
            Console.WriteLine("Height");
            Console.WriteLine(totalHeightUnordered / ITERATIONS);

            

        }


        public static double CreateKeyValueMap<TKey, TValue>(
                IKeyValueMap<TKey,TValue> keyValueMap,
                List<KeyValuePair<TKey, TValue>> keyValuePairs )
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            // do the work

            foreach (var kvp in keyValuePairs)
            {
                keyValueMap.Add(kvp.Key, kvp.Value);
            }

            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed.TotalSeconds);
            return stopwatch.Elapsed.TotalSeconds;

        }


        //Done?
        // call get (time it takes to get every key)
        public static double QueryKeyValueMap<TKey, TValue>(
                IKeyValueMap<TKey, TValue> keyValueMap,
                List<KeyValuePair<TKey, TValue>> keyValuePairs)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            // do the work

            foreach (var kvp in keyValuePairs)
            {
                keyValueMap.Get(kvp.Key);
            }

            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed.TotalSeconds);
            return stopwatch.Elapsed.TotalSeconds;
        }

        //Done?
        public static double RemoveKeyValueMap<TKey, TValue>(
                IKeyValueMap<TKey, TValue> keyValueMap,
                List<KeyValuePair<TKey, TValue>> keyValuePairs)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            // do the work

            foreach (var kvp in keyValuePairs)
            {
                keyValueMap.Remove(kvp.Key);
            }

            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed.TotalSeconds);
            return stopwatch.Elapsed.TotalSeconds;
        }
    }
}
