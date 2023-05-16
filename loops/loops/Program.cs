using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++) {
                Console.WriteLine("for loop");
            }
            int j = 1;
            while (j<=5)
            {
             
                Console.WriteLine("while loop");
                j++;
            }
            int k = 1;
            do
            {
                Console.WriteLine("Do  loop");

            }
            while (k++ <= 5);
            int[] num= new int[] {3,5,6,5,9};

            foreach (int item in num)
            {
                Console.Write($"{item}");
            }
            string[] fruits1 = new string[] { "Apple", "banana", "orange", "mango", "Gauva" };
            string[] fruits2 = new string[] { "Apple", "banana", "orange", "pineaple", "cheeeku" };
            int match = 0;

            int[] alpha = new int[26];
            for (int i = 0; i < 26; i++)
            {
                alpha[i] = 0;
            }
            foreach (string f in fruits1)
            {
                string temp = f.ToUpper();
                for (int l = 0; l < temp.Length; l++)
                {
                    //if (Convert.ToInt32(f[l]) <97))
                    alpha[Convert.ToInt32(temp[l]) - 65]++;
                    //Console.Write(Convert.ToInt32(f[l]));
                }
            }
            for (int m = 0; m < alpha.Length; m++)
            {
                if (alpha[m] > 0)
                    Console.WriteLine(Convert.ToChar(m + 65) + "   " + alpha[m]);
            }
            foreach (string fr1 in fruits1)
            {
                foreach (string fr2 in fruits2)
                {
                    if (string.Compare(fr1,fr2)==0)
                    {
                        match++;
                        Console.WriteLine(match);
                    }
                }
                //if (fr.Length<=5)
                //Console.WriteLine(fr + ", ");
            }
            Console.ReadLine();
        }
    }
}
