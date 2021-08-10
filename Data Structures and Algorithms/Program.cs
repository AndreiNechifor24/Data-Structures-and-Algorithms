using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data_Structures_and_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            var units_list = new List<IUnits>
            {
                new LinkedListsUnit(),
                new StacksUnit()
        };

            Console.WriteLine("Hello world !");
            Console.WriteLine("Press any key to see available options");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("#### Available options ####");

            var index = 1;
            foreach(var unit in units_list)
            {
                Console.WriteLine($"  {index}.{unit.name()}");
                Console.WriteLine();
                index++;
            }

            

            var initial_option = int.Parse(Console.ReadLine());

            while(initial_option<0 || initial_option > units_list.Count())
            {
                Console.WriteLine("Option not valid. Please try again");
                initial_option = int.Parse(Console.ReadLine());
            }
            
            units_list[initial_option-1].RunUnit();           
            
            

            
        }
    }
}
