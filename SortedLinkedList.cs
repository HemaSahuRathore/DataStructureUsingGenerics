using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureUsingGenerics
{
    public class SortedLinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node newNode = new Node(data);

            if (head == null || head.data >= newNode.data)
            {
                newNode.next = head;
                head = newNode;
                Console.WriteLine("{0} is added", data);
            }
            else
            {
                Node currentNode = head;
                while(currentNode.next != null && currentNode.next.data < newNode.data)
                {
                    currentNode = currentNode.next; 
                }
                newNode.next = currentNode.next;
                currentNode.next = newNode;
                Console.WriteLine("{0} is added", data);
            }
        }

        public void Display()
        {
            Console.WriteLine("Nodes Elements in Linked List : ");
            Node currentNode = this.head;
            if (currentNode == null)
            {
                Console.WriteLine("Linked List is empty!!");
                return; //control returned to main method from where it came
            }
            else
            {
                while (currentNode.next != null)
                {
                    Console.Write(currentNode.data + " ");
                    currentNode = currentNode.next;
                }
                Console.WriteLine(currentNode.data);
            }

        }
    }
}
