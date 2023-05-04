using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    //Class
    class Aadhar
    {
        public string AadharNo { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public string Address { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Object
            Aadhar PrudviAadhar = new Aadhar(); 
            PrudviAadhar.AadharNo = "123456789";
            PrudviAadhar.Name = "Prudvi";
            PrudviAadhar.DOB = "26-09-1998";
            PrudviAadhar.Address = "Visakha Patnam";
            Console.WriteLine(PrudviAadhar.AadharNo + " " + PrudviAadhar.Name + " " + PrudviAadhar.DOB + " " + PrudviAadhar.Address);
            Console.ReadKey();
        }
    }
}
