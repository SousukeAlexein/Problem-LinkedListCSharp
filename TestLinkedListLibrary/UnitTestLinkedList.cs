using LinkedListLibrary;
using System;
using Xunit;

namespace TestLinkedListLibrary
{
    public class UnitTestLinkedList
    {
        [Fact]
        public void CountTest01()
        {
            var myLinkedList = new LinkedList<string>();
            Assert.Equal(0,myLinkedList.Count); 
        }
    }
}
