using System;

namespace CircularlyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            circularlyLinkedList mylist = new circularlyLinkedList();

            mylist.add("Intouch");
            mylist.add("Prem");
            mylist.add("Toy");
            mylist.printList();
          
        }
    }
}
