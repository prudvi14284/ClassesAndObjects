using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{
    //sealed class Sealed classes can’t be inheritable.
    sealed class Class1
    {
    }
    class Class2 : Class1
    {
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
