using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogProject
{
    internal class DictionaryCRUDOperation
    {
        public static void DictionaryCRUD()
        {
            // Create a new dictionary to store key-value pairs
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            // Add some data to the dictionary
            myDictionary.Add(1, "Raji");
            myDictionary.Add(2, "Ammu");
            myDictionary.Add(3, "Neethu");

            // Read data from the dictionary
            Console.WriteLine("Reading data from the dictionary:");
            foreach (KeyValuePair<int, string> kvp in myDictionary)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            // Update data in the dictionary
            myDictionary[2] = "Pragna";
            Console.WriteLine("\nUpdated dictionary:");
            foreach (KeyValuePair<int, string> kvp in myDictionary)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            // Delete data from the dictionary
            myDictionary.Remove(3);
            Console.WriteLine("\nDictionary after removing data:");
            foreach (KeyValuePair<int, string> kvp in myDictionary)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            // Check if dictionary contains a specific key
            if (myDictionary.ContainsKey(1))
            {
                Console.WriteLine("\nDictionary contains key 1.");
            }
            else
            {
                Console.WriteLine("\nDictionary does not contain key 1.");
            }

            // Check if dictionary contains a specific value
            if (myDictionary.ContainsValue("Raji"))
            {
                Console.WriteLine("Dictionary contains value Raji.");
            }
            else
            {
                Console.WriteLine("Dictionary does not contain value Raji.");
            }
            Console.ReadLine();
        }
    }
}