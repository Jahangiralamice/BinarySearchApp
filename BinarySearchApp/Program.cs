using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements:\n");
            int elementNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter {0} integers:\n", elementNumber);
            int[] array = new int[elementNumber];
            for (int i = 0; i < elementNumber; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(array);

            Console.WriteLine("Enter the value to fine:\n");
            int search = Convert.ToInt32(Console.ReadLine());
            int first = 0;
            int last = elementNumber - 1;
            int middle = (first + last) / 2;
            while (first <= last)
            {
                if (array[middle] < search)
                {
                    first = middle + 1;
                }
                else if (array[middle] == search)
                {
                    Console.WriteLine("{0} is present at index {1}\n", search, middle + 1);
                    break;
                }
                else
                {
                    last = middle - 1;
                }
                middle = (first + last) / 2;
            }

            if (first > last)
            {
                Console.WriteLine("Not found! {0} is not present in the list.\n",search);
            }

            Console.ReadLine();
        }
    }
}
