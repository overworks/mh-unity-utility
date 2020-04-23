using System;
using System.Collections.Generic;

namespace Mh
{
    public class ObjectPool<T>
    {
        private Queue<T> queue;
        private Func<T> factory;
        private Action<T> onPush;
        private Action<T> onPop;

        public int Count
        {
            get { return queue.Count; }
        }

        public ObjectPool(Func<T> factory, int capacity = 8, Action<T> onPush = null, Action<T> onPop = null)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory), $"{nameof(factory)} should be not null.");
            }
            this.queue = new Queue<T>(capacity);
            this.factory = factory;
            this.onPush = onPush;
            this.onPop = onPop;
        }

        public void Push(T elem)
        {
            if (elem == null)
            {
                throw new ArgumentNullException(nameof(elem), $"{nameof(elem)} should be not null.");
            }
            queue.Enqueue(elem);
        }

        public T Pop()
        {
            return queue.Count > 0 ? queue.Dequeue() : factory();
        }
    }
}
