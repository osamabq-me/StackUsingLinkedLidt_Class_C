using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingLinkedLidt_CSharp
{

    class Node
    {
        public int info;
        public Node next;
        public Node(int i, Node n)
        {
            info = i;
            next = n;
        }
    }

    class Stacks
    {
        Node top;
        public Stacks()
        {
            top = null;
        }
        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }
        public void push(int element)
        {
            Node fresh;
            fresh = new Node(element,null);
            fresh.next = top;
            top = fresh;
            Console.WriteLine("\n"+ element + "Pushed.");
        }
        public void pop()
        {
            Console.WriteLine("\n The poped element is: "+ top.info);
            top = top.next;
        }
        public void Display()
        {
            Node tmp;
            if (empty())//if Stack is empty
                Console.WriteLine("\n Stack Empty");
            else
            {
                //traverse the List from beginning till end
                for(tmp = top; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.info);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Stacks s = new Stacks();


        }
    }
}
