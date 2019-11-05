using NUnit.Framework;
using Stack;
namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Push_PassNull_ReturnsArgumentException()
        {
            Stack<string> stack = new Stack<string>();

            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }
        [Test]
        public void Push_Pass2ValidObject_Returns2ItemsInList()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("ala");
            stack.Push("ala ala");
            Assert.AreEqual(stack.Count, 2);
        }
        [Test]
        public void Push__NotPassObject_Returns0ItemsInList()
        {
            Stack<string> stack = new Stack<string>();
            Assert.AreEqual(stack.Count, 0);
        }
        [Test]
        public void Pop_PassEmptyList_ReturnsInvalidOperationException()
        {
            Stack<string> popStack = new Stack<string>();
            Assert.That(() => popStack.Pop(), Throws.InvalidOperationException);    
        }
        [Test]
        public void Pop_PassListWith2Items_ReturnsItem2()
        {
            Stack<string> popStack = new Stack<string>();
            popStack.Push("item 1");
            popStack.Push("item 2");
           // popStack.Pop();
            Assert.AreEqual(popStack.Pop(), "item 2");
        }
        [Test]
        public void Pop_PassListWith2Items_ReturnsListWithOneItem()
        {
            Stack<string> popStack = new Stack<string>();
            popStack.Push("item 1");
            popStack.Push("item 2");
            popStack.Pop();
            Assert.AreEqual(popStack.Count, 1);
        }
        public void Peek_PassEmptyList_ReturnsInvalidOperationException()
        {
            Stack<string> peekStack = new Stack<string>();

        }

    }
}




//public T Peek()
//{
//    if (_list.Count == 0)
//        throw new InvalidOperationException();

//    return _list[_list.Count - 1];
//}
//    }