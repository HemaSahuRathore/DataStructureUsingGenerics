using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureUsingGenerics
{
    public class LinkedList
    {
        public Node head;
       

        //Method to add element to the last
        public void AddLast(int data)
        {
            Node newNode = new Node(data); 

            if (head == null) //if linked list is empty
            {
                head = newNode; 
                Console.WriteLine("{0} is added", data);
            }
            else 
            {
                Node lastNode = GetLastNode(); 
                lastNode.next = newNode; 
                Console.WriteLine("{0} is added", data);
            }
        }

        //Method to get the Last Node
        public Node GetLastNode()
        {   
            Node temp = head; 
            while (temp.next != null) 
            {
                temp = temp.next;
            }
            return temp; //returning last node
        }

        //add element at first place
        public void AddFirst(int data)
        {
            Node newNode = new Node(data); //created new node to add
            newNode.next = head; //stored address of head node to the new node
            head = newNode; //assiging new node to head
            Console.WriteLine("{0} is added as a first element", data);
        }

        //display elements in LinkedList
        public void Display()
        {
            Console.WriteLine("Nodes Elements in Linked List : ");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty!!");
                return; //control returned to main method from where it came
            }
            else
            {
                while (temp.next != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine(temp.data);
            }

        }

        //append element
        public void Append(int data)
        {
            AddLast(data); //functionality is same as AddLast so calling the method here
        }

        //insert in between or at position
        public void InsertElementInBetweenOrAtPosition(int position, int data)
        {
            
            if(position < 1)
                Console.WriteLine("Invalid Position");
            if(position == 1)
            {
                Node newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {       Node temp = head; 
                    for(int i = 1; i <  position - 1; i++)
                    {
                        temp = temp.next;
                    }
                    if (temp!=null)
                    {
                        Node newNode = new Node(data);
                        newNode.next = temp.next;
                        temp.next = newNode;              
                    }                
            }
            Console.WriteLine("{0} is inserted at {1} position", data, position);
        }

        //delete first
        public void DeleteFirst()
        {
            if (head == null)
                Console.WriteLine("LinkedList is Empty!!");
            else
            {
                int elementRemoved = head.data;
                head = head.next;
                Console.WriteLine("First node element {0} is deleted from the Linked List", +elementRemoved);
            }
        }


    }
}
