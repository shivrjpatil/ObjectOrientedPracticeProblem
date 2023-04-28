using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoopsPracticeProlems274
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Duplicate Elements in array\n2.Unique Element in array\n3.Frequency of Elements\n4.Maximum and Minimum in array");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                   DuplicateElementinArray array = new DuplicateElementinArray();
                   array.Element();
                    break;
                case 2:
                    UniqueElementsinArray unique=new UniqueElementsinArray();
                    unique.UniqueElement();
                    break;
                case 3:
                    FrequencyofElement element=new FrequencyofElement();
                    element.Elememt();
                    break;
                case 4:
                    MaxMinInArray array1=new MaxMinInArray();
                    array1.MaxMin();
                    break;
            }
            Console.ReadLine();
        }
    }
}
