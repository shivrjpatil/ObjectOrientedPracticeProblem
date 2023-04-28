using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoopsPracticeProlems274
{
    internal class Pattern2
    {
        public void RectangulerPattern()
        {
            int length = 7, width = 7;
            for (int i = 1; i <= width; i++)
            {
                for (int j = 1; j <= length; j++)
                {
                    if (i == 1 || i == width || j == 1 || j == length)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
