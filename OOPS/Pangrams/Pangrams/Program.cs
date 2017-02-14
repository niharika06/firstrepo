using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangrams
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            string s = Console.ReadLine();
            s = s.ToUpper();
            if (s.Length < 26)
            {
                Console.WriteLine("not a pangram");
            }
            else
            {
                for (int j = 65; j < 91; j++)
                {
                    for (int i = 0; i < s.Length; i++)
                    {

                        {
                            if (s[i] == j)
                            {
                                flag++;
                                break;
                            }
                        }
                    }
                }
                if (flag == 26)
                {
                    Console.WriteLine("it is a pangram");
                }
                else
                {
                    Console.WriteLine("not a Pangram");
                }
            }
            Console.ReadKey();
        }
    }
}
    

