using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    static class Class1
    {
        //static field
        public static string _Message;

        //static Properties
        public static string Message
        {
            set
            {
                _Message = value;
            }
            get
            {
                return _Message;
            }
        }

        //Static constructor
        static Class1()
        {
            Message = "Hello";
        }

        //static method
        public static void Method1()
        {
            Console.WriteLine("This is method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //get value from static property
            Console.WriteLine(Class1.Message);
            //call static method
            Class1.Method1();
            Console.ReadKey();
        }
    }
}
