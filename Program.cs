namespace DataStructureUsingGenerics
{  
    internal class Program
    {   /// <summary>
        /// UC3 : Ability to create Linked List by appending 30 and 70 to 56
        ///- Node with data 56 is First Created
        ///- Next Append 30 to 56
        ///- Finally Append 70 to 30
        ///- LinkedList Sequence: 56->30->70
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
                Console.Write("4.Exit  ");
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
                }
            }while (option !=4);
            

         }
    }
}