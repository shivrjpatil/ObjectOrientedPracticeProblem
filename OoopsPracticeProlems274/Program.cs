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
            Console.WriteLine("1.Duplicate Elements in array\n2.Unique Element in array\n3.Frequency of Elements\n4.Maximum and Minimum in array\n5.To print given pattern\n6.To print rectanguler pattern\n7.Reverse each word in given string");
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
                case 5:
                    Pattern1 pattern1=new Pattern1();
                    pattern1.StarPattern();
                    break;
                case 6:
                    Pattern2 pattern2=new Pattern2();
                    pattern2.RectangulerPattern();
                    break;
                case 7:
                    ReverseEachString reverse = new ReverseEachString();
                    reverse.Reverse();
                    break;
            }
            Console.ReadLine();
        }
    }
}
