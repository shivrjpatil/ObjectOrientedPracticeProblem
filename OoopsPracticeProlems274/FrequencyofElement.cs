using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoopsPracticeProlems274
{
    internal class FrequencyofElement
    {
        public void Elememt()
        {
                int[] arr = { 1, 2, 3, 4, 1, 2, 1, 5, 3, 2 }; 
               
                Dictionary<int, int> freq = new Dictionary<int, int>();
              
                foreach (int element in arr)
                {
                    if (freq.ContainsKey(element))
                    {
                        freq[element]++;
                    }
                    else
                    {
                        freq[element] = 1;
                    }
                }

               
                Console.WriteLine("Element\tFrequency");
                foreach (KeyValuePair<int, int> pair in freq)
                {
                    Console.WriteLine("{0}\t{1}", pair.Key, pair.Value);
                }
        }
    }
}

