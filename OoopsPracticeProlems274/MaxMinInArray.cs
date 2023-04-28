using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OoopsPracticeProlems274
{
    internal class MaxMinInArray
    {
        public void MaxMin()
        {
            int[] numbers = { 5, 7, 2, 8, 4, 6 };

            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine("Maximum element in the array is: " + max);

            int min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine("Minimum element in the array is: " + min);
        }
    }   
}
