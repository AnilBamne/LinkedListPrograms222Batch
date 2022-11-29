using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPrograms222Batch
{
    internal class CustomisedLinkedlist
    {
        public Node head;
        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }
        public void Display()
        {
            Node temp=this.head;
            if(temp != null)
            {
                Console.WriteLine("Elements in linkedlist are");
                while(temp != null)
                {
                    Console.Write(temp.data+" ");
                    temp = temp.next;
                }
            }
            else
            {
                Console.WriteLine("LinkedList is empty");
            }
        }
    }
}
