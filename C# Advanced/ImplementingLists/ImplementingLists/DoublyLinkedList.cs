using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList

{
   public class DoublyLinkedList
    {
         

        private class Node
        {
            public Node(int value)
            {
                Value = value;
            }
            public int Value { get; set; }

            public Node NextNode { get; set; }

            public Node PreviosNode { get; set; }
        }
        private Node head;
        private Node tail;

        public int Count { get; private set; }


        public void AddFirst(int element)
        {
            if (this.Count == 0)
            {
                head = tail = new Node(element);
            }
            else
            {
                var newHead = new Node(element);
                newHead.NextNode = this.head;
                head.PreviosNode = newHead;
                head = newHead;
            }
            this.Count++;
        }

        public void AddLast(int element)
        {
            if (this.Count == 0)
            {
                head = tail = new Node(element);
            }
            else
            {
                var newTail = new Node(element);

                newTail.PreviosNode = this.tail;
                tail.NextNode = newTail;
                tail = newTail;
            }

            this.Count++;
        }

        public int RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("This list is empty");
            }
            int removed = head.Value;
            this.head = this.head.NextNode;
            if (this.head != null)
            {
                this.head.PreviosNode = null;
            }
            else
            {
                tail = null;
            }
            this.Count--;

            return removed;
        }

        public int RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("This list is empty");
            }
            int result = this.tail.Value;
            this.tail.PreviosNode = this.tail;

            if (this.tail != null)
            {
                this.tail.NextNode = null;
                
            }
            else
            {
                head = null;
            }
            this.Count--;
            return result;
        }

        public void ForEach(Action<int> action)
        {
            var currNode = this.head;

            while (currNode != null)
            {
                action(currNode.Value);
                currNode = currNode.NextNode;
            }

        }
        
    }
}
