using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    //generic class with two generic-type parameters called "T1" and "T2"
    class Class1<T1, T2>
    {
        //generic Field of generic-type called "T1"
        public T1 x;
        //generic Field of generic-type called "T2"
        public T2 y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //creating first generic object.
            Class1<int, bool> c1;
            c1 = new Class1<int, bool>();
            c1.x = 100;
            c1.y = true;
            Console.WriteLine(c1.x); ; //Output: 100
            Console.WriteLine(c1.y); ; //Output: true
            Console.WriteLine();

            //creating second generic object.
            Class1<string, double> c2;
            c2 = new Class1<string, double>();
            c2.x = "hello";
            c2.y = 100.438;
            Console.WriteLine(c2.x); //Output: hello
            Console.WriteLine(c2.y); //Output: 100.438

            Console.ReadKey();
        }
    }
}
