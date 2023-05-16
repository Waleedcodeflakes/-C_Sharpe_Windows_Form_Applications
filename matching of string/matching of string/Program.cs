using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matching_of_string

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputstring = "This is an example paragraph in which some words are repeating.For example the word 'word' is repeating and the word example is not repeating";
            string[] words = inputstring.Split(' ', '.');
            /*for(int i=0;i<words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }*/
            //string[] temp= 
           
            for(int i = 0; i < words.Length; i++)
            {

            int count=1;
                for (int j = i+1; j < words.Length; j++)
                {
                    if (words[i] == words[j])
                    {
                        count++;
                        words[j] = "0";
                    }
                }
                if (words[i] != "0")
                {
                    Console.WriteLine(words[i] + " appears " + count + " times.");
                }
            }
           Console.ReadKey();
        }
    }
}
