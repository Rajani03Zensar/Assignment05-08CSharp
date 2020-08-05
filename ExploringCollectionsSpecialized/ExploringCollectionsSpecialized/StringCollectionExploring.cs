using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploringCollectionsSpecialized
{
    class StringCollectionExploring
    {
        static void Main(string[] args)
        {
            StringCollection strcol = new StringCollection();
            strcol.Add("Chetan Bhagat");
            strcol.Add("Prem Chand");
            strcol.Add("Prem Chand");
            strcol.Add("Ruskin Bond");
            strcol.Add("Durjoy Dutt");
            Console.WriteLine("The Elements of the StringCollection is---------");
            foreach (var item in strcol)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Checking weather David Eagleman element is present in the StringCollection:{0}", strcol.Contains("David Eagleman"));
            string[] str = new string[strcol.Count];
            Console.WriteLine("Copying the above StringCollection list to string array--------------");
            strcol.CopyTo(str, 0);
            Console.WriteLine("Printing the copied list into the array");
            foreach(var index in str)
            {
                Console.WriteLine(index);
            }
            Console.WriteLine("Checking the index of the element : {0} ", strcol.IndexOf("Chetan Bhagat"));
            strcol.Insert(4, "David Eagleman");
            Console.WriteLine("Printing the list after inserting the new value");
            foreach(var item1 in strcol)
            {
                Console.WriteLine(item1);
            }
            strcol.Remove("Prem Chand");
            Console.WriteLine("List of the elements after removing----------");
            foreach(var item2 in strcol)
            {
                Console.WriteLine(item2);
            }
            Console.WriteLine("Removing element from the index value--------");
            strcol.RemoveAt(3);
            Console.WriteLine("Elements list after removing values from index 3");
            foreach(var item3 in strcol)
            {
                Console.WriteLine(item3);
            }
            Console.Read();
        }
    }
}
