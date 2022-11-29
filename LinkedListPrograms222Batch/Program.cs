using System;

namespace LinkedListPrograms222Batch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To LinkedList Progra");
            Console.WriteLine("Please choose the option\n1:UC1 create a simple linked list\n2:UC2 add 30 and 56 to 70\n");
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
                    break;
                case 3:
                    break;
            }
        }
    }
}
