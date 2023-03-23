using NlogProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogProject
{
    class ListCRUD
    {
        public static void list()
        {
            List<string> list = new List<string>();

            // CREATE: add elements to the List
            list.Add("Raji");
            list.Add("neethu");
            list.Add("gaayi");

            // READ: print the elements of the List

            Console.WriteLine("Elements of the List:");
            foreach (string names in list)
            {
                Console.WriteLine(names);
            }

            // UPDATE: update an element in the List
            int indexToUpdate = 1; // index of the element to update
            string newValue = "ammmu"; // new value for the element
            list[indexToUpdate] = newValue;

            // READ: print the elements of the List after the update
            Console.WriteLine("Elements of the List after update:");
            foreach (string names in list)
            {
                Console.WriteLine(names);
            }

            // DELETE: remove an element from the List
            int indexToDelete = 2; // index of the element to delete
            list.RemoveAt(indexToDelete);

            // READ: print the elements of the List after the deletion
            Console.WriteLine("Elements of the List after deletion:");
            foreach (string names in list)
            {
                Console.WriteLine(names);
            }

        }
    }
}


       