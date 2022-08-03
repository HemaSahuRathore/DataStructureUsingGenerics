namespace DataStructureUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int option;
            Console.WriteLine("Welcome to the Data Structure Problems using C# Generics");

            do {
                
                Console.WriteLine("Please select the Options from Below: ");
                Console.WriteLine("1.Create a simple Linked List of 56, 30 and 70");
                Console.Write("2.Exit  ");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        LinkedList linkedListObj = new LinkedList();
                        linkedListObj.AddLast(56);
                        linkedListObj.AddLast(30);
                        linkedListObj.AddLast(70);
                        Console.WriteLine();
                        break;
                }
            }while (option !=2);
            

         }
    }
}