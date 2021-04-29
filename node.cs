using System;
using System.Collections.Generic;
using System.Text;

namespace CircularlyLinkedList
{
    class node
    {
        public string name;
        public node next;
     
        public node(string name, node next)
        {
            this.name = name;
            this.next = next;
            
        }
    }
}
