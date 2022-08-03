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

        //Method to add element at first place
        public void AddFirst(int data)
        {
            Node newNode = new Node(data); //created new node to add
            newNode.next = head; //stored address of head node to the new node
            head = newNode; //assiging new node to head
            Console.WriteLine("{0} is added as a first element", data);
        }

        //Method to display elements in LinkedList
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

        //Method to append element
        public void Append(int data)
        {
            AddLast(data); //functionality is same as AddLast so calling the method here
        }



    }
}
