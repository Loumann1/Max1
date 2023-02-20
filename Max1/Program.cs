using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string line = Console.ReadLine();




            if ((line.Length % 2) == 0)
            {
                Console.WriteLine("Четное");

                string str1 = line.Substring(0, line.Length / 2);
                string str2 = line.Substring(line.Length / 2, line.Length / 2);


                char[] charArray1 = str1.ToCharArray();
                char[] charArray2 = str2.ToCharArray();
                Array.Reverse(charArray1);
                Array.Reverse(charArray2);


                string s1 = new string(charArray1);
                string s2 = new string(charArray2);
                Console.WriteLine(s1 + s2);
            }
            else
            {

                Console.WriteLine("Не четное");

                char[] charArray1 = line.ToCharArray();
                Array.Reverse(charArray1);
                string a1 = new string(charArray1);

                Console.WriteLine(a1 + line);

            }
            Console.ReadKey();

        }
    }
}
