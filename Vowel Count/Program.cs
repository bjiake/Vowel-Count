using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_Count
{
    internal class Program
    {
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            // Your code here
            
            List<char> consider = new List<char>(5);
            consider.Add('a');
            consider.Add('e');
            consider.Add('i');
            consider.Add('o');
            consider.Add('u');

            foreach (var item in str.ToCharArray())
            {
                if(consider.Contains(item))
                {
                    vowelCount++;
                }
            }

            return vowelCount;
        }
        static void Main(string[] args)
        {
            int answer = GetVowelCount("abracadabra");
            Console.WriteLine(answer);
        }
    }
}
