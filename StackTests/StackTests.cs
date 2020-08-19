using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackNamespace;

namespace StackTests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void Create_Stack()
        {
            Stack<int> stack = new Stack<int>(3);
            Assert.AreEqual(0, stack.Size);
        }

        [TestMethod]
        public void Push_Pop()
        {
            Stack<int> stack = new Stack<int>(3);

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            int value = stack.Pop();

            Assert.AreEqual(3, value);
            Assert.AreEqual(2, stack.Size);
        }

        [TestMethod]
        public void Push_above_maxLength_should_throw_exception()
        {
            Stack<int> stack = new Stack<int>(3);

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Assert.ThrowsException<TooManyPushesException>(() => stack.Push(4));
        }

        [TestMethod]
        public void Pop_on_stack_of_size_zero_should_throw_exception()
        {
            Stack<int> stack = new Stack<int>(3);
            Assert.ThrowsException<NothingToPopOrPeekException>(() => stack.Pop());
        }

        [TestMethod]
        public void Peek()
        {
            Stack<int> stack = new Stack<int>(3);

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            int value = stack.Peek();

            Assert.AreEqual(3, value);
            Assert.AreEqual(3, stack.Size);
        }

        [TestMethod]
        public void Peek_on_stack_of_size_zero_should_throw_exception()
        {
            Stack<int> stack = new Stack<int>(3);
            Assert.ThrowsException<NothingToPopOrPeekException>(() => stack.Peek());
        }
    }
}
