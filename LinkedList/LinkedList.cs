using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        public Node First { get; set; }

        public void InsertFirst(int data)
        {
            // Create the node
            Node newNode = new Node();

            // Put the data in the node
            newNode.Data = data;

            // Put the old node in next
            newNode.Next = First;

            //Make the first the new node
            First = newNode;
        }

        public Node DeleteFirst()
        {
            // Assign the temporary variable
            Node temp = First;

            //Assign the next dead
            First = First.Next;
            return temp;
        }

        public void InsertLast(int data)
        {
            Node current = First;
            while (current.Next != null)
            {
                current = current.Next;
            }

            Node newNode = new Node();
            newNode.Data = data;
            current.Next = newNode;
        }



        //Inserts a new element at the given position
        public void InsertAnywhere(int newElement, int position)
        {
            Node newNode = new Node();
            newNode.Data = newElement;
            newNode.Next = null;

            if (position < 1)
            {
                Console.Write("\nposition should be >= 1.");
            }
            else if (position == 1)
            {
                newNode.Next = First;
                First = newNode;
            }
            else
            {

                Node temp = new Node();
                temp = First;
                for (int i = 1; i < position - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.Next;
                    }
                }

                if (temp != null)
                {
                    newNode.Next = temp.Next;
                    temp.Next = newNode;
                }
                else
                {
                    Console.Write("\nThe previous node is null.");
                }
            }
        }

    }
}
