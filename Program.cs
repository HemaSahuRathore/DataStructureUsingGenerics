﻿namespace DataStructureUsingGenerics
{  
    internal class Program
    {   /// <summary>
        ///UC 10 : Ability to create Ordered Linked List in ascending order of data entered in following sequence 56, 30, 40, and 70
        ///- Refactor the code to create SortedLinkedList Class
        ///- Create Node that takes data that is Comparable
        ///- Perform Sorting during the add method call
        ///- Final Sequence: 30->40->56->70
        /// </summary>
        static void Main(string[] args)
        {   
            int option;
            LinkedList linkedListObj = new LinkedList();

            Console.WriteLine("Welcome to the Data Structure Problems using C# Generics");

            do {
                
                Console.WriteLine("Please select the Options from Below: ");
                Console.WriteLine("1.Create a simple Linked List of 56, 30 and 70");
                Console.WriteLine("2.Create Linked List by adding 30 and 56 to 70, LinkedList Sequence: 56->30->70");
                Console.WriteLine("3.Ability to create Linked List by appending 30 and 70 to 56, LinkedList Sequence: 56->30->70");
                Console.WriteLine("4.Ability to insert 30 between 56 and 70 Final Sequence: 56->30->70");
                Console.WriteLine("5.Ability to delete first element");
                Console.WriteLine("6.Ability to delete last element");
                Console.WriteLine("7.Ability to search LinkedList to find Node with value 30");
                Console.WriteLine("8.Ability to insert 40 after 30 to the Linked List sequence of 56->30->70");
                Console.WriteLine("9.Ability to delete 40 from the Linked List sequence of 56->30->40->70 and show the size of LinkedList is 3");
                Console.WriteLine("10.Ability to create Ordered Linked List");
                Console.Write("11.Exit  ");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        linkedListObj.AddLast(56);
                        linkedListObj.AddLast(30);
                        linkedListObj.AddLast(70);
                        linkedListObj.Display();
                        Console.WriteLine();
                        break;
                    case 2:
                        linkedListObj.AddFirst(70);
                        linkedListObj.AddFirst(30);
                        linkedListObj.AddFirst(56);
                        linkedListObj.Display();
                        Console.WriteLine();
                        break;
                    case 3:
                        linkedListObj.Append(56);
                        linkedListObj.Append(30);
                        linkedListObj.Append(70);
                        linkedListObj.Display();
                        Console.WriteLine();
                        break;
                    case 4:
                        linkedListObj.AddLast(56);
                        linkedListObj.AddLast(70);
                        linkedListObj.Display();
                        //linkedListObj.InsertElementInBetweenOrAtPosition(int position, int data)
                        linkedListObj.InsertElementInBetweenOrAtPosition(2, 30); 
                        linkedListObj.Display();
                        Console.WriteLine();
                        break;
                    case 5:
                        linkedListObj.Append(56);
                        linkedListObj.Append(30);
                        linkedListObj.Append(70);
                        linkedListObj.Display();
                        linkedListObj.DeleteFirst();
                        linkedListObj.Display();
                        Console.WriteLine();
                        break;
                    case 6:
                        linkedListObj.Append(56);
                        linkedListObj.Append(30);
                        linkedListObj.Append(70);
                        linkedListObj.Display();
                        linkedListObj.DeleteLast();
                        linkedListObj.Display();
                        Console.WriteLine();
                        break;

                    case 7:
                        linkedListObj.Append(56);
                        linkedListObj.Append(30);
                        linkedListObj.Append(70);
                        linkedListObj.Display();
                        linkedListObj.SearchElement(30);
                        Console.WriteLine();
                        break;
                    case 8:
                        linkedListObj.Append(56);
                        linkedListObj.Append(30);
                        linkedListObj.Append(70);
                        linkedListObj.Display();
                        linkedListObj.InsertDataAfterELement(40, 30);// Data:40, ELement:30
                        linkedListObj.Display();
                        Console.WriteLine();
                        break;
                    case 9:
                        linkedListObj.Append(56);
                        linkedListObj.Append(30);
                        linkedListObj.Append(40);
                        linkedListObj.Append(70);
                        linkedListObj.Display();
                        linkedListObj.Size();
                        linkedListObj.SearchElementNDelete(40);
                        linkedListObj.Display();
                        linkedListObj.Size();
                        Console.WriteLine();
                        break;
                    case 10:
                        SortedLinkedList sortedLinkedList = new SortedLinkedList();
                        sortedLinkedList.Add(56);
                        sortedLinkedList.Add(30);
                        sortedLinkedList.Add(40);
                        sortedLinkedList.Add(70);
                        sortedLinkedList.Display();
                        Console.WriteLine();
                        break;
                }
            }while (option != 11);
            

         }
    }
}