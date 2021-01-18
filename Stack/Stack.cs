using System;
using System.Net.Http.Headers;

namespace StackNamespace
{
    public class Stack<T>
    {
        private readonly int maximumLength;
        private readonly T[] stackArray;

        public int Size { get; private set; }

        public Stack(int length)
        {
            maximumLength = length;
            stackArray = new T[maximumLength];
        }

        public void Push(T v)
        {
            if (Size == maximumLength)
                throw new TooManyPushesException();

            stackArray[Size++] = v;
        }

        public T Pop()
        {
            if (Size == 0)
                throw new NothingToPopOrPeekException();

            return stackArray[--Size];
        }

        public T Peek()
        {
            if (Size == 0)
                throw new NothingToPopOrPeekException();

            return stackArray[Size - 1];
        }
    }
}
