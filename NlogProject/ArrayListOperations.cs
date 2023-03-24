using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogProject
{
    internal class ArrayListOperations
    {
        public static void ArrayListCRUD()
        {
            ArrayList list = new ArrayList();

            // CREATE: add elements to the ArrayList
            list.Add("Raji");
            list.Add("Ammu");
            list.Add("Neethu");
            list.Add("siri");

            // READ: print the elements of the ArrayList
            Console.WriteLine("Elements of the ArrayList:");
            foreach (object element in list)
            {
                Console.WriteLine(element);
            }

            // UPDATE: update an element in the ArrayList
            int indexToUpdate = 1; // index of the element to update
            string newValue = "gaayi"; // new value for the element
            list[indexToUpdate] = newValue;

            // READ: print the elements of the List after the update
            Console.WriteLine("Elements of the List after update:");
            foreach (string element in list)
            {
                Console.WriteLine(element);
            }

            // DELETE: remove an element from the List
            int indexToDelete = 2; // index of the element to delete
            list.RemoveAt(indexToDelete);

            // READ: print the elements of the List after the deletion
            Console.WriteLine("Elements of the List after deletion:");
            foreach (string element in list)
            {
                Console.WriteLine(element);

            }

        }
    }
}

