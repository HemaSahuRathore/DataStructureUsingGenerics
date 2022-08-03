namespace DataStructureUsingGenerics
{  
    internal class Program
    {   /// <summary>
        /// UC2 : Ability to create Linked List by adding 30 and 56 to 70
        ///- Node with data 70 is First Created
        ///- Next 30 is added to 70
        ///- Finally 56 is added to 30
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
                Console.Write("3.Exit  ");
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
                }
            }while (option !=3);
            

         }
    }
}