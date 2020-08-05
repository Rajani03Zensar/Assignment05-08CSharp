using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploringCollectionsSpecialized
{
    class StringEnumeratorExploring
    {
        static void Main()
        {
            StringCollection scol = new StringCollection();
            scol.Add("Tiger");
            scol.Add("Lion");
            scol.Add("Cheetah");
            scol.Add("Panther");
            scol.Add("Lynx");


            Console.WriteLine("Printing the Elements");
            foreach(var item in scol)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("****************************************");
            Console.WriteLine("Printing Elements using the GetEnumerator Method");

            StringEnumerator se = scol.GetEnumerator();
            

            while (se.MoveNext())
            {

                Console.WriteLine(se.Current);
            }
            se.Reset();

        }
    }
}
