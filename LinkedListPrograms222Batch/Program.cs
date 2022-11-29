using System;

namespace LinkedListPrograms222Batch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To LinkedList Progra");
            Console.WriteLine("Please choose the option\n1:UC1 create a simple linked list\n2:UC2 add 30 and 56 to 70\n3:UC3 Append 30 and 70 to 56\n4:UC4 Insert 30 between 56 and 70\n5:UC5 Delete first element in 56->30->70");
            int option=int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CustomisedLinkedlist list =new CustomisedLinkedlist();
                    list.AddLast(56);
                    list.AddLast(30);
                    list.AddLast(70);
                    list.Display();
                    break;
                case 2:
                    CustomisedLinkedlist linkedlist =new CustomisedLinkedlist();
                    linkedlist.AddLast(70);
                    linkedlist.AddFirst(30);
                    linkedlist.AddFirst(56);
                    linkedlist.Display();
                    break;
                case 3:
                    CustomisedLinkedlist linkedlist1 =new CustomisedLinkedlist();
                    linkedlist1.AddLast(56);
                    linkedlist1.Append(30);
                    linkedlist1.Append(70);
                    linkedlist1.Display();
                    break;
                case 4:
                    CustomisedLinkedlist linkedlist2=new CustomisedLinkedlist();
                    linkedlist2.AddLast(56);
                    linkedlist2.AddLast(70);
                    Console.WriteLine("Before insertion");
                    linkedlist2.Display();
                    linkedlist2.InsertInBetween(30, 56, 70);
                    Console.WriteLine("After Insertion");
                    linkedlist2.Display();
                    break;
                case 5:
                    break;
                case 6:
                    break;
            }
        }
    }
}
