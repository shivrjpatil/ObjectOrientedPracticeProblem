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
            Console.WriteLine("1.Duplicate Elements in array\n2.Unique Element in array");
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
            }
            Console.ReadLine();
        }
    }
}
