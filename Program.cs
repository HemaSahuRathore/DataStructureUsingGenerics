namespace DataStructureUsingGenerics
{  
    internal class Program
    {   /// <summary>
        ///UC6 : Ability to delete the last element in the LinkedList of sequence 56->30->70
        ///- Final Sequence: 56->30
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
                Console.Write("6.Exit  ");
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

                }
            }while (option !=6);
            

         }
    }
}