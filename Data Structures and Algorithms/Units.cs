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
            while (counter <= 4) list.addLast(counter++);

            // Testing printList() method
            Console.WriteLine("### Our linkedList:");
            list.printList();
            Console.WriteLine();

            // Testing indexOf() method
            Console.WriteLine($"\t@indexOf()\n * Value 3 is placed on position {list.indexOf(3) + 1}");
            Console.WriteLine($" * Value 123 is not included in list so it will have index {list.indexOf(123)}");
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

            // Testing size() method
            Console.WriteLine("\t@size()");
            Console.WriteLine($"### List size is: {list.size()} elements");
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
        }
    }
}
