using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedListPrograms222Batch
{
    internal class CustomisedLinkedlist
    {
        //globally defining a head of Node class/type
        public Node head;
        //this method is used to work like AddLast Method of linkedlist
        public void AddLast(int data)       //UC1
        {
            //created a new node 
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;           //defined a temp node 
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }
        //this method is used to work like AddLast Method of linkedlist,adds the node at first position
        public void AddFirst(int data)      //UC2
        {
            Node newNode=new Node(data);
            newNode.next= head;             //now the new node will have the address of previous head,and the head is initialised with new node.
            head= newNode;
            Console.WriteLine("{0} is added succesfully",newNode.data);
        }
        public void Append(int data)        //UC3 appending 30 and 70 to 56 ,appending means adding after/last
        {
            AddLast(data);
            Console.WriteLine("{0} is appended succesfully",data);
        }
        //InsertInBetween is used to insert a node between two existing nodes
        public void InsertInBetween(int data,int firstNode,int lastNode)
        {
            Node node=new Node(data);
            Node temp = head;
            bool flag = false;
            if(temp == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            else
            {
                while(temp != null)
                {
                    if(temp.data == firstNode && temp.next.data == lastNode)    //searching the nodes where to insert
                    {
                        node.next = temp.next;
                        temp.next = node;                                       //Insertion done
                        Console.WriteLine("\n{0} is inserted succesfully",node.data);
                        flag = true;
                        break;
                    }
                    temp=temp.next;
                }
                if (flag == false)                                              //nodes we are looking for are not present.
                {
                    Console.WriteLine("*** Insertion failed ***");
                }
            }
        }
        //pop method is used for deleting nodes
        //where the address of first element(node) is removed from head and the address of second element(node) is stored in head.next
        public void PopFirstNode()
        {
            int node = head.data;
            head = head.next;
            Console.WriteLine("\n >> {0} << is deleted",node);
        }
        public void PopLastNode()                   //deleting last node
        {
            Node temp = head;
            if (temp.next == null)                  //if lilkedlist has only one element
            {
                int element = temp.data;
                head = null;
                Console.WriteLine("\n >> {0} << is deleted", element);
            }
            else
            {
                while( temp.next.next != null)      //if linkedlist has multiple element
                {
                    temp=temp.next;
                }
                int element = temp.next.data;
                temp.next = null;
                Console.WriteLine("\n >> {0} << is deleted", element);
            }
        }
        public void Display()       //this method displayes the elements in linked list
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
