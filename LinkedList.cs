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
        public void AddLast(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
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

        public Node GetLastNode()
        {   
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
    }
}
