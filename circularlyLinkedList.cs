using System;
using System.Collections.Generic;
using System.Text;

namespace CircularlyLinkedList
{
    class circularlyLinkedList
    {
        node head = null;
        
        public circularlyLinkedList()
        {

        }
        public void add(string name)
        {
            if (head == null)
            {
                head = new node(name, null);
                head.next = head;
            }
            else
            {
                node current = head;
                while (current.next != head)
                {
                    current = current.next;
                }
                node newNode = new node(name, head);
                current.next = newNode;
            }
        }
        public void printList()
        {
            if (head != null)
            {


                node current = head;
                while (current.next != head)
                {
                    Console.WriteLine(current.name);
                    current = current.next;
                }
                Console.WriteLine(current.name);
            }
        }
       
    }
}
