using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
        public void InsertInBetween(int data,int firstNode,int lastNode)        //UC4
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
        public void PopFirstNode()                      //UC5 deleting first node
        {
            int node = head.data;
            head = head.next;
            Console.WriteLine("\n >> {0} << is deleted",node);
        }
        public void PopLastNode()                   //UC6 deleting last node
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
        //this method is used for searching a perticular node in the linkedlist
        public void SearchElement(int data)     //UC7
        {
            Node temp = head;
            bool flag = false;
            if(temp == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            else
            {
                while(temp != null)                             //checking each node
                {
                    if(temp.data == data)
                    {
                        flag = true;
                        Console.WriteLine("\n{0} is present in the linkedlist",data);
                        break;
                    }
                    temp = temp.next;
                }
            }
            if (! flag)
            {
                Console.WriteLine("\n{0} is not present in the linkedlist", data);
            }
        }
        //inserting 40 after 30 in the linked list of 56->30->70
        public void InsertAfterSpecificNode(int data,int specificElement)       //UC8
        {
            Node node = new Node(data);
            Node temp = head;
            bool flag = false;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            else
            {
                while (temp != null)
                {
                    if (temp.data == specificElement)    //searching the nodes where to insert
                    {
                        node.next = temp.next;
                        temp.next = node;                                       //Insertion done
                        Console.WriteLine("\n{0} is inserted succesfully", node.data);
                        flag = true;
                        break;
                    }
                    temp = temp.next;
                }
                if (flag == false)                                              //node we are looking for is not present.
                {
                    Console.WriteLine("*** Insertion failed ***");
                }
            }
        }
        //Deleting 40 from LinkedList of 56->30->40->70
        public void DeletSpecificElement(int data)                      //UC9
        {
            Node temp = head;
            bool flag=false;
            if (temp.data == data)
            {
                head = null;
                Console.WriteLine("{0} is deleted",data);
            }
            else
            {
                while (temp.next != null)                                //searching from multiple elements
                {
                    if (temp.next.data == data)
                    {
                        flag = true;
                        temp.next = temp.next.next;                     //deleting element
                        Console.WriteLine("{0} is deleted", data);
                    }
                    temp = temp.next;
                }
            }
            if(!flag)
                Console.WriteLine("{0} element not present in list",data);
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
                Console.WriteLine("\nsLinkedList is empty");
            }
        }
        //computing the size of limked list
        public void SizeOfLinkedList()                  //UC9 printing size of linkedlist
        {
            int count = 0;
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("\nLinkedList is Empty");
            }
            else
            {
                while(temp != null)             //Iterating and counting elements present in list
                {
                    count++;
                    temp=temp.next;
                }
            }
            Console.WriteLine("\nLinkedList Size ="+count);
        }
    }
}
