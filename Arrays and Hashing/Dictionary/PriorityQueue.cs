using System;
using System.Collections.Generic;

namespace Leetcode.Arrays_and_Hashing.Dictionary
{
    public class PriorityQueue<TKey, TValue>
    {
        private List<KeyValuePair<TKey, TValue>> data;
        private IComparer<TKey> comparer;

        public int Count => data.Count;

        public PriorityQueue(int capacity, IComparer<TKey> comparer)
        {
            this.data = new List<KeyValuePair<TKey, TValue>>(capacity);
            this.comparer = comparer ?? Comparer<TKey>.Default;
        }

        public void Enqueue(TKey key, TValue value)
        {
            data.Add(new KeyValuePair<TKey, TValue>(key, value));
            int childIndex = data.Count - 1;

            while (childIndex > 0)
            {
                int parentIndex = (childIndex - 1) / 2;
                if (comparer.Compare(data[childIndex].Key, data[parentIndex].Key) >= 0)
                    break;

                KeyValuePair<TKey, TValue> tmp = data[childIndex];
                data[childIndex] = data[parentIndex];
                data[parentIndex] = tmp;

                childIndex = parentIndex;
            }
        }

        public KeyValuePair<TKey, TValue> Dequeue()
        {
            if (data.Count == 0)
                throw new InvalidOperationException("PriorityQueue is empty.");

            int lastIndex = data.Count - 1;
            KeyValuePair<TKey, TValue> frontItem = data[0];
            data[0] = data[lastIndex];
            data.RemoveAt(lastIndex);

            int parentIndex = 0;
            while (true)
            {
                int leftChildIndex = parentIndex * 2 + 1;
                int rightChildIndex = parentIndex * 2 + 2;

                if (leftChildIndex >= data.Count)
                    break;

                int minChildIndex = leftChildIndex;
                if (rightChildIndex < data.Count && comparer.Compare(data[rightChildIndex].Key, data[leftChildIndex].Key) < 0)
                    minChildIndex = rightChildIndex;

                if (comparer.Compare(data[parentIndex].Key, data[minChildIndex].Key) <= 0)
                    break;

                KeyValuePair<TKey, TValue> tmp = data[parentIndex];
                data[parentIndex] = data[minChildIndex];
                data[minChildIndex] = tmp;

                parentIndex = minChildIndex;
            }

            return frontItem;
        }
    }
}