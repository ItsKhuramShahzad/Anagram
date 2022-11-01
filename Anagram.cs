using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string s1 = "marry";
                string s2 = "army";

                string s1Copy = s1;
                string s2Copy = s2;
                char[] ch1 = s1.ToCharArray();
                char[] ch2 = s2.ToCharArray();

                if (s1.Length != s2.Length)
                {
                    Console.WriteLine("No");
                   return;
                }

                for (int i = 0; i < ch1.Length; i++)
                {
                    Console.WriteLine(ch1);
                    Console.WriteLine(ch2);

                    for (int j = 0; j < ch2.Length; j++)
                    {
                        if (ch1[i] == ch2[j] && ch1[i] != '.' && ch2[j] != '.')
                        {
                            ch1[i] = '.';
                            ch2[j] = '.';
                            break;
                        }
                    }
                }
                string a = string.Empty;
                string b = string.Empty;
                for (int i = 0; i < ch1.Length; i++)
                {
                    a += ch1[i];
                    b += ch2[i];
                }
                Console.WriteLine(a);
                Console.WriteLine(b);

                if (a.Equals(b))
                {
                    Console.WriteLine("Yes");

                }
                else
                    Console.WriteLine("No");

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();

            }

        }


     
    }
}
