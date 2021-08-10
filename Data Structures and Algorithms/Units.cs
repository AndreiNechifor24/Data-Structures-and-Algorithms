using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms
{
    public interface IUnits
    {
        void RunUnit();
    }

    public class LinkedListsUnit : IUnits
    {
        public void RunUnit()
        {
            Console.WriteLine("######### RUNING UNIT: LinkedListsUnit #########");
            Console.WriteLine();

            // Initialize LinkedList
            LinkedList list = new LinkedList();

            // Add elements to LinkedList
            int counter = 1;
            while (counter <= 6) list.addLast(counter++);

            // Testing printList() method
            Console.WriteLine("### Our linkedList:");
            list.printList();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==============================================================================");
            Console.WriteLine();
            Console.WriteLine();

            // Testing indexOf() method
            Console.WriteLine($"\t@indexOf()\n * Value 3 is placed on position {list.indexOf(3) + 1}");
            Console.WriteLine($" * Value 123 is not included in list so it will have index {list.indexOf(123)}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==============================================================================");
            Console.WriteLine();
            Console.WriteLine();

            // Testing contains() method
            Console.WriteLine("\t@contains()");
            Console.WriteLine($" * Q: Does our LinkedList contains 1?\n * A: {list.contains(1)}");
            Console.WriteLine($" * Q: Does our LinkedList contains 123?\n * A: {list.contains(123)}");
            Console.WriteLine();
            Console.WriteLine("### Let's remove value 1 from our linkedList");
            list.removeFirst();
            Console.WriteLine($" * Q: Does our LinkedList contains 1 anymore?\n * A: {list.contains(1)}");
            Console.WriteLine("### Adding value 1 back to our linkedList");
            list.addFirst(1);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==============================================================================");
            Console.WriteLine();
            Console.WriteLine();

            // Testing size() method
            Console.WriteLine("\t@size()");
            Console.WriteLine($"### List size is: {list.size()} elements");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==============================================================================");
            Console.WriteLine();
            Console.WriteLine();

            // Testing toArray() method
            Console.WriteLine("\t@toArray()");
            var convertedList = new int[list.size()];
            convertedList = list.toArray();
            Console.WriteLine($"### Here are converted list items.");

            Console.Write("### ");
            foreach (var item in convertedList)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==============================================================================");
            Console.WriteLine();
            Console.WriteLine();

            // Testing reverseList() method
            Console.WriteLine("\t@reverseList()");
            Console.WriteLine("### Initial list");
            list.printList();
            Console.WriteLine("### Reversed list");
            list.reverseList();
            list.printList();
            Console.WriteLine("### Getting list to it's normal order");
            list.reverseList();
            Console.WriteLine("### Ordered list");
            list.printList();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==============================================================================");
            Console.WriteLine();
            Console.WriteLine();

            // Testing get_item_from_end() method
            Console.WriteLine("\t@get_item_from_end()");
            Console.WriteLine($"Last element of list is {list.get_nth_node_from_end(1)}");            
            Console.WriteLine($"2nd element from the last of list is {list.get_nth_node_from_end(2)}");
            Console.WriteLine($"3rd element from the last of list is {list.get_nth_node_from_end(3)}");
            Console.WriteLine($"4th element from the last of list is {list.get_nth_node_from_end(4)}");
            Console.WriteLine($"5hth element from the last of list is {list.get_nth_node_from_end(5)}");
            Console.WriteLine($"1st element of list is {list.get_nth_node_from_end(6)}");

        }
    }
}
