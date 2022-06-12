using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(4);

            List<int> list2 = new List<int>();
            list2.Add(1);
            list2.Add(3);
            list2.Add(4);

            List<int> finalList=new List<int>(list1.Concat(list2));
            finalList.Sort();

            foreach (var x in finalList)
            {
                Console.WriteLine(x);
            }
            int ReturnNodeHead() 
            {
                int z=finalList.First();
                return z;
            }

        }
    }
}
