using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace OoopsPracticeProlems274
{
    internal class UniqueElementsinArray
    {
        public void UniqueElement()
        {
            int[] arr = { 1, 2, 2, 3, 4, 4, 4, 5, 5 };
            int n = arr.Length;

            Console.Write("Unique elements in the array: ");

            for (int i = 0; i < n; i++)
            {
                bool isUnique = true;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    Console.Write("{0} ", arr[i]);
                }
            }
        }
    }
   




   
}
