using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms
{
    class LinkedList
    {
        /*
         * PURPOSE: 
                * This class is meant to solve exercises from Code With Mosh Data Structures and Algorithms Course         
                * It will implement LinkedLists logic from scratch and some basic methods to operate with them.
            
         * METHODS:
                * printList()
                * addFirst()
                * addLast()
                * deleteFirst()
                * deleteLast()
                * contains()
                * indexOf()
                * toArray()
                * reverseList()
                
         * AUTHOR: Andrei Nechifor
         
         * LAST UPDATED: August 5, 2021
         
       */


        internal class Node
        {
            internal int value; // current Node value
            internal Node next; // reference of the next Node

            public Node(int value)
            {
                this.value = value;
            }
        }

        private Node first { get; set; }
        private Node last { get; set; }
        private int listSize { get; set; }

        /*
            * SECTION: ADD METHODS
             
            * AUTHOR: Andrei Nechifor
            
            * LAST UPDATE: August 5, 2021
         */

        public void addLast(int item)
        {
            Node node = new Node(item);
            
            if(first == null)            
                last = first = node;
            else
            {
                last.next = node;
                last = node;
            }

            listSize++;

        }

        public void addFirst(int item)
        {
            var node = new Node(item);

            if(isEmpty(node))
            {
                first = last = node;
            }
            else
            {
                node.next = first;
                first = node;
            }

            this.listSize++;
        }


        /*
            * SECTION: VERIFICATION METHODS
             
            * AUTHOR: Andrei Nechifor
            
            * LAST UPDATE: August 5, 2021
         */

        public int indexOf(int item)
        {
            int index = 0;
            var current = first;
            while(current != null)
            {
                if(current.value == item)
                {
                    return index;
                }

                current = current.next;
                index++;
            }

            return -1;
        }

        public bool contains(int item)
        {
            return indexOf(item) != -1;
        }

        private bool isEmpty(Node node)
        {
            return node == null;
        }


        /*
            * SECTION: REMOVE METHODS
             
            * AUTHOR: Andrei Nechifor
            
            * LAST UPDATE: August 5, 2021
         */

        public void removeFirst()
        {

            if (!isEmpty(first) || !isEmpty(last))
            {
                var second = first.next; // make second node the first one
                first.next = null;
                first = second;
                this.listSize--;
            }


            
        }

        public void removeLast()
        {

            // Empty list scenario
            if (isEmpty(first))
            {
                throw new Exception(message: "List should contain at least one element");
            }

            // List contains only one element
            if(first == last)
            {
                first = last = null;
                this.listSize--;
                return;
            }

            // Default use case
            var previous = getPrevious(last);
            last = previous;
            last.next = null;
            this.listSize--;
        }

        public int size()
        {
            return this.listSize;
        }


        /*
            * SECTION: SORT METHODS

            * AUTHOR: Andrei Nechifor

            * LAST UPDATE: August 5, 2021
        */

        public void revertList()
        {
            // To do            
        }

        /*
    * SECTION: UTILS

    * AUTHOR: Andrei Nechifor

    * LAST UPDATE: August 5, 2021
        */

        private Node getPrevious(Node node)
        {
            var current = first;
            while (current != null)
            {
                if (current.next == node)
                {
                    return current;
                }
                current = current.next;
            }

            return null;
        }

        public void printList()
        {
            int index = 0;
            var current = first;

            while (current != null)
            {
                /*Console.Write($" {index} \n {current.value} ");*/
                Console.Write(current.value + " ");
                index++;
                current = current.next;
            }

            Console.WriteLine();
        }

        public int[] toArray()
        {
            /* Converts a linkedList into integers array */

            var result = new int[listSize];
            int index = 0;
            var current = first;

            while (current != null)
            {
                result[index++] = current.value;
                current = current.next;
            }

            return result;

        }

        public void reverseList()
        {
            // [1 -> 2 -> 3 -> 4] => [4 -> 3 -> 2 -> 1]

            // Intialize pointers
            var previous = first;
            var current = first.next;

            // Set last element to first
            last = first;

            // Set last node, next node reference to null since it's the final one
            last.next = null;

            // Perform switching
            while(current != null)
            {
                // Keep track of the current next value, before switching
                var next = current.next;

                // Setting current element next node to previous one - switching positions
                current.next = previous;

                // Shift values
                
                // Previous shifts to current 
                previous = current;

                // Current shits to next
                current = next;
            }

            // Set first element to last known previous variable value
            first = previous;
        }
        
    }
}
