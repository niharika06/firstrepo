using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessingInheritedFunction
{
    class GrandParent 
    {
        public int callA = 0;

       public void funcA(ref int a)
        {
            a = a * 2;
            callA++;
            Console.WriteLine("A's function called " + callA + " times");
            Console.ReadLine();
        }

    }
    class Parent : GrandParent
    {
        public int callB = 0;
       public void funcB(ref int a)
        {
            a = a * 3;
            callB++;
            Console.WriteLine("B's function called " + callB + " times");
            Console.ReadLine();
        }
    }
    class Child : Parent
    {
        public int callC = 0;

        public void funcC(ref int a)
        {
            a = a * 5;
            callC++;
            Console.WriteLine("C's function called " + callC + " times");
            Console.ReadLine();
        }
    }
    class GrandChild :Child
    {
        public void update_val(int new_val)
        {
            int v = new_val;
            if (v % 2 == 0 && v % 3 == 0 && v % 5 == 0)
            {


                Child c = new Child();
                c.funcA(ref v);
                c.funcB(ref v);
                c.funcC(ref v);

            }
            else
            {
                Console.WriteLine(" prime factors are not 2,3 and 5 ");
            }
        }
    }
    class Final
    {
        public static void Main(string[] args)
        {
            GrandChild d = new GrandChild();

            Console.WriteLine("Enter the value of new_val");
            int val = int.Parse(Console.ReadLine());
            d.update_val(val);
            Console.ReadKey();
        }
    }
}
