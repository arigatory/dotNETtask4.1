using System;

namespace dotNETtask4._1
{
    class Queue
    {

        private Node _firstNode, _lastNode;

        public Queue()
        {
            Count = 0;
        }

        public int Count { get; private set; }


        public void Enqueue(Complex data)
        {
            Count++;
            Node temp = new Node(data);
            if (_lastNode == null)
            {
                _lastNode = temp;
                _firstNode = temp;
            }
            else
            {
                _lastNode.Next = temp;
                _lastNode = _lastNode.Next;
            }
        }

        public Complex Dequeue()
        {
            
            if (_firstNode != null)
            {
                Count--;
                Complex res = _firstNode.Data;
                _firstNode = _firstNode.Next;
                if (_firstNode == null) _lastNode = null;
                return res;
            }
            Count = 0;
            return null;
        }

        public Complex Peek()
        {
            if (_firstNode != null)
                return _firstNode.Data;
            else
                return null;
        }

        public void Print()
        {
            Node temp = _firstNode;
            while (temp != null)
            {
                Console.ForegroundColor= (ConsoleColor)((int)(Math.Abs(temp.Data.Re)+Math.Abs(temp.Data.Im))%15+1); 
                Console.Write("["+temp.Data+"]");
                Console.ResetColor();
                temp = temp.Next;
                if (temp!=null)
                    Console.Write(" << ");
            }

            Console.WriteLine();
        }

        private class Node
        {
            public Node(Complex data, Node next = null)
            {
                Data = data;
                Next = next;
            }

            public Node Next { get; set; }

            public Complex Data { get; set; }
        }
    }
}
