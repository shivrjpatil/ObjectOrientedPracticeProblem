using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoopsPracticeProlems274
{
    internal class ReverseEachString
    {
        public void Reverse()
        {
            string input = "Hello world, how are you?";
            string[] words = input.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                char[] charArray = words[i].ToCharArray();
                Array.Reverse(charArray);
                words[i] = new string(charArray);
            }

            string output = string.Join(" ", words);
            Console.WriteLine(output);
        }
    }
}
