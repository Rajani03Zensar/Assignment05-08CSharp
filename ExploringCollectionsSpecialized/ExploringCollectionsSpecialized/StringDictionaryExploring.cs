using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploringCollectionsSpecialized
{
    class StringDictionaryExploring
    {
        static void Main()
        {
            StringDictionary strdic = new StringDictionary();
            strdic.Add("one",  "EmpId=101");
            strdic.Add("two",  "EmpId=102");
            strdic.Add("three","EmpId=103");
            strdic.Add("four", "EmpId=104");
            strdic.Add("five", "EmpId=105");

            Console.WriteLine("Printing the Key Vakue pair");
            foreach(DictionaryEntry item in strdic)
            {
                Console.WriteLine("{0} : {1}",item.Key,item.Value);
            }

            Console.WriteLine("Checking weather the key six is present in the String dictionary or not");
            bool ck=strdic.ContainsKey("six");
            Console.WriteLine("Contains or not:{0}",ck);

            Console.WriteLine("Checking weather the value Empid=104 exist in the String Dictionary or not");
            bool cv=strdic.ContainsValue("EmpId=104");
            Console.WriteLine("Value present or not:{0}", cv);

            DictionaryEntry[] str1 = new DictionaryEntry[strdic.Count];
            strdic.CopyTo(str1, 0);
            Console.WriteLine("Printing the Copied array");
            foreach(var ar in str1)
            {
                Console.WriteLine("{0}:{1}",ar.Key,ar.Value);
            }

            Console.WriteLine("Printing the elements of the String Dictionary using GetEnumerator method");
            IEnumerator ie=strdic.GetEnumerator();
            DictionaryEntry de;
            while (ie.MoveNext())
            {
                de = (DictionaryEntry)ie.Current;
                Console.WriteLine("{0}:{1}",de.Key,de.Value);
            }
            strdic.Remove("five");
            Console.WriteLine("Printing the String Dictionary after removing the key-----");
            foreach(DictionaryEntry item1 in strdic)
            {
                Console.WriteLine("{0} : {1}",item1.Key,item1.Value);
            }

            
            //strdic.Clear();

            Console.Read();
        }
    }
}
