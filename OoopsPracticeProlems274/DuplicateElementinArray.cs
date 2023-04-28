using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoopsPracticeProlems274
{
    internal class DuplicateElementinArray
    {
        public void Element()
        {
            int[] arr = { 1, 2, 2, 3, 4, 4, 5, 5 };
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            Console.WriteLine("Total number of duplicate elements in the array: {0}", count);
        }
    }
}
